﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;


using System.Threading;
using System.Threading.Tasks;
using static CocApiLibrary.Enums;
using CocApiLibrary.Models;
using System.Text.Json.Serialization;
using System.Diagnostics;
using CocApiLibrary.Exceptions;
using System.Text.Json;
using System.Collections.Concurrent;

namespace CocApiLibrary
{
    internal static class WebResponse
    {
        public static ConcurrentBag<WebResponseTimer> Timers = new ConcurrentBag<CocApiLibrary.WebResponseTimer>();


        private static readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);
        private static readonly IList<TokenObject> _tokenObjects = new List<TokenObject>();
        private static readonly HttpClient ApiClient = new HttpClient();
        private static int _timeToWaitForWebRequest;
        private static VerbosityType _verbosityType;
        private static int counter = 0;


        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public static void Initialize(int timeToWaitForWebRequests, VerbosityType verbosityType, IEnumerable<string> tokens, int tokenTimeOutInMilliseconds)
        {
            _timeToWaitForWebRequest = timeToWaitForWebRequests;

            _verbosityType = verbosityType;

            _verbosityType = verbosityType;

            ApiClient.DefaultRequestHeaders.Accept.Clear();

            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (string token in tokens)
            {
                TokenObject tokenObject = new TokenObject(token, tokenTimeOutInMilliseconds, verbosityType);

                _tokenObjects.Add(tokenObject);
            }

            options.Converters.Add(new JsonStringEnumConverter());
        }


        public static string GetTokenStatus()
        {
            return $"{_tokenObjects.Count(x => x.IsRateLimited)} Rate Limited\n{_tokenObjects.Count(x => !x.IsRateLimited)} not rate limited";
        }









        private static async Task<TokenObject> GetToken(string url)
        {
            await _semaphoreSlim.WaitAsync();
            try
            {
                if (_verbosityType == VerbosityType.Verbose)
                {
                    Console.WriteLine($"counter: {counter};  {url}");
                }

                counter++;

                while (_tokenObjects.All(x => x.IsRateLimited))
                {
                    await Task.Delay(100);
                }

                return await _tokenObjects.Where(x => !x.IsRateLimited).OrderBy(x => x.LastUsedUTC).FirstOrDefault().GetToken(url);
            }
            finally
            {
                _semaphoreSlim.Release();
            }
        }


        internal static async Task<T> GetWebResponse<T>(CocApi cocApi, string encodedUrl) where T : new()
        {
            TokenObject token = await GetToken(encodedUrl);

            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);

            using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(_timeToWaitForWebRequest);

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            using HttpResponseMessage response = await ApiClient.GetAsync(encodedUrl, cancellationTokenSource.Token);

            stopwatch.Stop();

            string responseText = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                cocApi.IsAvailable = true;

                T result = JsonSerializer.Deserialize<T>(responseText, options);

                if (result != null)
                {
                    WebResponseTimer webResponseTimer = new WebResponseTimer(result, stopwatch.Elapsed);

                    Timers.Add(webResponseTimer);

                    return result;

                    //return new Tuple<Stopwatch, T>(stopwatch, result);
                }
                else
                {
                    throw new CocApiException("The response could not be parsed.");
                }

            }
            else
            {
                ResponseMessageAPIModel ex = JsonSerializer.Deserialize<ResponseMessageAPIModel>(responseText, options);

                if (response.StatusCode == System.Net.HttpStatusCode.BadRequest) //400
                {
                    throw new BadRequestException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) //403
                {
                    throw new ForbiddenException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound) //404
                {
                    throw new NotFoundException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests) //429
                {
                    token.IsRateLimited = true;

                    throw new TooManyRequestsException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError) //500
                {
                    throw new ServerUnavailableException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.BadGateway) //502
                {
                    throw new BadGateWayException(ex, response.StatusCode);
                }

                else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError) //503
                {
                    cocApi.IsAvailable = false;

                    throw new ServerUnavailableException(ex, response.StatusCode);
                }
                               
                throw new ServerResponseException(ex, response.StatusCode);
            }
        }
    }
}


