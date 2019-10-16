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
using Microsoft.Extensions.Logging;

namespace CocApiLibrary
{
    internal static class WebResponse
    {
        public static SemaphoreSlim SemaphoreSlim { get; } = new SemaphoreSlim(1, 1);
        public static HttpClient ApiClient { get; } = new HttpClient();

        private const string _source = nameof(WebResponse);
        private static readonly IList<TokenObject> _tokenObjects = new List<TokenObject>();        
        private static CocApi _cocApi = new CocApi();
        private static CocApiConfiguration _cfg = new CocApiConfiguration();
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };





        public static List<WebResponseTimer> WebResponseTimers { get; } = new List<WebResponseTimer>();

        public static void Initialize(CocApi cocApi, CocApiConfiguration cfg, IEnumerable<string> tokens)
        {
            _cocApi = cocApi;

            _cfg = cfg;

            ApiClient.DefaultRequestHeaders.Accept.Clear();

            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (string token in tokens)
            {
                TokenObject tokenObject = new TokenObject(cocApi, token, _cfg.TokenTimeOut);

                _tokenObjects.Add(tokenObject);
            }

            _jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        }


        public static string GetTokenStatus()
        {
            return $"{_tokenObjects.Count(x => x.IsRateLimited)} Rate Limited\n{_tokenObjects.Count(x => !x.IsRateLimited)} not rate limited";
        }









        private static async Task<TokenObject> GetTokenAsync(EndPoint endPoint, string url)
        {
            await SemaphoreSlim.WaitAsync();

            try
            {
                while (_tokenObjects.All(x => x.IsRateLimited))
                {
                    await Task.Delay(50);
                }

                return await _tokenObjects.Where(x => !x.IsRateLimited).OrderBy(x => x.LastUsedUTC).FirstOrDefault().GetTokenAsync(endPoint, url);
            }
            finally
            {
                SemaphoreSlim.Release();
            }
        }


        internal static List<WebResponseTimer> GetTimers() => WebResponseTimers;

        internal static async Task<T> GetWebResponse<T>(EndPoint endPoint, string encodedUrl, CancellationTokenSource? cancellationTokenSource = null) where T : class, IDownloadable, new()
        {
            Stopwatch stopwatch = new Stopwatch();

            try
            {
                _cocApi.Logger?.LogDebug("{source}: Getting web response from {encodedUrl}", _source, encodedUrl);

                TokenObject token = await GetTokenAsync(endPoint, encodedUrl);

                using CancellationTokenSource cts = new CancellationTokenSource(_cfg.TimeToWaitForWebRequests);

                cancellationTokenSource?.Token.Register(() => cts?.Cancel());

                ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);

                stopwatch.Start();

                using HttpResponseMessage response = await ApiClient.GetAsync(encodedUrl, cts.Token);
                
                stopwatch.Stop();

                string responseText = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    _cocApi.IsAvailable = true;

                    T result = JsonSerializer.Deserialize<T>(responseText, _jsonSerializerOptions);

                    if (result != null)
                    {
                        WebResponseTimers.Add(new WebResponseTimer(endPoint, stopwatch.Elapsed, response.StatusCode));

                        if (result is IInitialize process)
                        {
                            process.Initialize();
                        }

                        SetIDownloadableProperties(result, encodedUrl);

                        return result;
                    }
                    else
                    {
                        throw new CocApiException("The response could not be parsed.");
                    }

                }
                else
                {
                    ResponseMessageAPIModel ex = JsonSerializer.Deserialize<ResponseMessageAPIModel>(responseText, _jsonSerializerOptions);

                    WebResponseTimers.Add(new WebResponseTimer(endPoint, stopwatch.Elapsed, response.StatusCode));

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
                        throw new InternalServerErrorException(ex, response.StatusCode);
                    }

                    else if (response.StatusCode == System.Net.HttpStatusCode.BadGateway) //502
                    {
                        _cocApi.IsAvailable = false;

                        throw new BadGateWayException(ex, response.StatusCode);
                    }

                    else if (response.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable) //503
                    {
                        _cocApi.IsAvailable = false;

                        throw new ServiceUnavailableException(ex, response.StatusCode);
                    }

                    else if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout)  //504
                    {
                        _cocApi.IsAvailable = false;

                        throw new GatewayTimeoutException(ex, response.StatusCode);
                    }

                    throw new ServerResponseException(ex, response.StatusCode);
                }
            }
            catch (Exception e)
            {
                stopwatch.Stop();

                WebResponseTimers.Add(new WebResponseTimer(endPoint, stopwatch.Elapsed));

                _cocApi.Logger?.LogWarning("{source}: {message} {encodedUrl}", _source, e.Message, encodedUrl);

                if (e is TaskCanceledException taskCanceledException)
                {
                    throw new ServerTookTooLongToRespondException(e.Message, e);
                }

                throw _cocApi.GetException(e);
            }
        }

        private static void SetIDownloadableProperties<T>(T result, string encodedURL) where T : class, IDownloadable, new()
        {
            switch (result)
            {
                case LeagueWarAPIModel leagueWarAPIModel:
                    if (leagueWarAPIModel.State == WarState.WarEnded)
                    {
                        leagueWarAPIModel.Expires = DateTime.UtcNow.AddYears(1);
                    }
                    else
                    {
                        leagueWarAPIModel.Expires = DateTime.UtcNow.Add(_cfg.LeagueWarAPIModelTimeToLive);
                    }

                    leagueWarAPIModel.EncodedUrl = encodedURL;
                    break;

                case CurrentWarAPIModel currentWar:
                    if (currentWar.State == WarState.WarEnded)
                    {
                        currentWar.Expires = DateTime.UtcNow.AddYears(1);
                    }
                    else
                    {
                        currentWar.Expires = DateTime.UtcNow.Add(_cfg.CurrentWarAPIModelTimeToLive);
                    }
                    
                    currentWar.EncodedUrl = encodedURL;
                    break;

                case LeagueGroupAPIModel leagueGroupAPIModel:
                    if (leagueGroupAPIModel.State == LeagueState.WarsEnded)
                    {
                        leagueGroupAPIModel.Expires = DateTime.UtcNow.AddHours(6);
                    }
                    else
                    {
                        leagueGroupAPIModel.Expires = DateTime.UtcNow.Add(_cfg.LeagueGroupAPIModelTimeToLive);
                    }
                    
                    leagueGroupAPIModel.EncodedUrl = encodedURL;
                    break;

                case ClanAPIModel clanAPIModel:
                    clanAPIModel.Expires = DateTime.UtcNow.Add(_cfg.ClanAPIModelTimeToLive);
                    clanAPIModel.EncodedUrl = encodedURL;
                    break;

                case VillageAPIModel villageAPIModel:
                    villageAPIModel.Expires = DateTime.UtcNow.Add(_cfg.VillageAPIModelTimeToLive);
                    villageAPIModel.EncodedUrl = encodedURL;
                    break;

                case WarLogAPIModel warLogAPIModel:
                    warLogAPIModel.Expires = DateTime.UtcNow.Add(_cfg.WarLogAPIModelTimeToLive);
                    warLogAPIModel.EncodedUrl = encodedURL;
                    break;

                default:
                    throw new CocApiException($"Unhandled Type");
            }
        }
    }
}


