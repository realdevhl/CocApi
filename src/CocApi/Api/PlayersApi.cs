/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CocApi.Client;
using CocApi.Model;
using Microsoft.Extensions.Logging;

namespace CocApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlayersApi
    {
        /// <summary>
        /// Get player information
        /// </summary>
        /// <remarks>
        /// Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Player)</returns>
        System.Threading.Tasks.Task<ApiResponse<Player>> FetchPlayerResponseAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Get player information
        /// </summary>
        /// <remarks>
        /// Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Player)</returns>
        System.Threading.Tasks.Task<Player> FetchPlayerAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Get player information
        /// </summary>
        /// <remarks>
        /// Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </remarks>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Player?)</returns>
        System.Threading.Tasks.Task<Player?> FetchPlayerOrDefaultAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null);
        /// <summary>
        /// Verify player API token that can be found from the game settings.
        /// </summary>
        /// <remarks>
        /// Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VerifyTokenResponse>> VerifyTokenResponseAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Verify player API token that can be found from the game settings.
        /// </summary>
        /// <remarks>
        /// Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse)</returns>
        System.Threading.Tasks.Task<VerifyTokenResponse> VerifyTokenAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Verify player API token that can be found from the game settings.
        /// </summary>
        /// <remarks>
        /// Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </remarks>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse?)</returns>
        System.Threading.Tasks.Task<VerifyTokenResponse?> VerifyTokenOrDefaultAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PlayersApi : IPlayersApi
    {
        private readonly ILogger<PlayersApi> _logger;
        private readonly System.Net.Http.HttpClient _httpClient;

        //private void OnHttpRequestResult(HttpRequestResultEventArgs log) => CocApi.Library.OnHttpRequestResult(this, log);

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayersApi(ILogger<PlayersApi> logger, System.Net.Http.HttpClient httpClient, TokenProvider tokenProvider)
        {
            _logger = logger;
            _httpClient = httpClient;
            GetTokenAsync = tokenProvider.GetAsync;
        }

        /// <summary>
        /// Returns the token to be used in the api query
        /// </summary>
        public Func<System.Threading.CancellationToken?, System.Threading.Tasks.ValueTask<string>>? GetTokenAsync { get; set; }  


        /// <summary>
        /// Get player information Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Player</returns>
        public async System.Threading.Tasks.Task<Player> FetchPlayerAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null)
        {
            CocApi.Client.ApiResponse<Player> result = await FetchPlayerResponseAsync(playerTag, cancellationToken).ConfigureAwait(false);
            return result.Content ?? throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);
        }

        /// <summary>
        /// Get player information Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Player</returns>
        public async System.Threading.Tasks.Task<Player?> FetchPlayerOrDefaultAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                CocApi.Client.ApiResponse<Player> result = await FetchPlayerResponseAsync(playerTag, cancellationToken).ConfigureAwait(false);
                
                return result.IsSuccessStatusCode
                    ? result.Content
                    : null;
            }
            catch(Exception)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                return null;
            }
        } 

        /// <summary>
        /// Get player information Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists. Note that player tags start with hash character &#39;#&#39; and that needs to be URL-encoded properly to work in URL, so for example player tag &#39;#2ABC&#39; would become &#39;%232ABC&#39; in the URL. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Player)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<Player>> FetchPlayerResponseAsync(string playerTag, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (playerTag == null)
                throw new ArgumentNullException(nameof(playerTag)); 

            playerTag = Clash.FormatTag(playerTag);
            
            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/players/{playerTag}";
            path = path.Replace("{playerTag}", Uri.EscapeDataString(playerTag));



            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");




            // authentication (JWT) required
            //isKeyInHeader
            string? token = GetTokenAsync != null
                ? await GetTokenAsync(cancellationToken).ConfigureAwait(false)
                : null;

            if (token != null)
                request.Headers.Add("authorization", $"Bearer {token}");            


            request.Method = new System.Net.Http.HttpMethod("GET");

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            DateTime start = DateTime.UtcNow;

            DateTime end;

            HttpStatusCode httpStatusCode = HttpStatusCode.OK;

            string? reasonPhrase;

            string responseContent = string.Empty;

            ApiResponse<Player> apiResponse;

            try
            {
                using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                httpStatusCode = responseMessage.StatusCode;

                reasonPhrase = responseMessage.ReasonPhrase;

                responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                end = DateTime.UtcNow;

                apiResponse = new(responseMessage, responseContent);
            }
            catch (Exception e)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                end = DateTime.UtcNow;

                HttpRequestException httpRequestException = new("/players/{playerTag}", path, end - start, e);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestException));

                Library.LogRequestException(_logger, e, start, end, path);

                throw httpRequestException;
            }

            if (apiResponse.IsSuccessStatusCode)
            {
                apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(apiResponse.RawContent, CocApi.Clash.JsonSerializerSettings);
                
                //HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/players/{playerTag}", path, end - start, httpStatusCode);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

                Library.LogRequestSuccess(_logger, httpStatusCode, start, end, path);
            }
            else
            {
                //HttpRequestNonSuccess httpRequestNonSuccess = new("/players/{playerTag}", path, end - start, httpStatusCode, reasonPhrase);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestNonSuccess));

                Library.LogRequestFailure(_logger, httpStatusCode, start, end, path, reasonPhrase);
            }

            return apiResponse;
        }

        /// <summary>
        /// Verify player API token that can be found from the game settings. Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyTokenResponse</returns>
        public async System.Threading.Tasks.Task<VerifyTokenResponse> VerifyTokenAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null)
        {
            CocApi.Client.ApiResponse<VerifyTokenResponse> result = await VerifyTokenResponseAsync(playerTag, body, cancellationToken).ConfigureAwait(false);
            return result.Content ?? throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);
        }

        /// <summary>
        /// Verify player API token that can be found from the game settings. Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyTokenResponse</returns>
        public async System.Threading.Tasks.Task<VerifyTokenResponse?> VerifyTokenOrDefaultAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                CocApi.Client.ApiResponse<VerifyTokenResponse> result = await VerifyTokenResponseAsync(playerTag, body, cancellationToken).ConfigureAwait(false);
                
                return result.IsSuccessStatusCode
                    ? result.Content
                    : null;
            }
            catch(Exception)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                return null;
            }
        } 

        /// <summary>
        /// Verify player API token that can be found from the game settings. Verify player API token that can be found from the game settings. This API call can be used to check that players own the game accounts they claim to own as they need to provide the one-time use API token that exists inside the game. 
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="playerTag">Tag of the player.</param>
        /// <param name="body">Request body</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<VerifyTokenResponse>> VerifyTokenResponseAsync(string playerTag, VerifyTokenRequest body, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (playerTag == null)
                throw new ArgumentNullException(nameof(playerTag)); 
            if (body == null)
                throw new ArgumentNullException(nameof(body)); 

            playerTag = Clash.FormatTag(playerTag);
            
            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/players/{playerTag}/verifytoken";
            path = path.Replace("{playerTag}", Uri.EscapeDataString(playerTag));



            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            request.Content = new System.Net.Http.StringContent(body.ToJson(), System.Text.Encoding.UTF8, "application/json");

            // authentication (JWT) required
            //isKeyInHeader
            string? token = GetTokenAsync != null
                ? await GetTokenAsync(cancellationToken).ConfigureAwait(false)
                : null;

            if (token != null)
                request.Headers.Add("authorization", $"Bearer {token}");            

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            request.Method = new System.Net.Http.HttpMethod("POST");

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            DateTime start = DateTime.UtcNow;

            DateTime end;

            HttpStatusCode httpStatusCode = HttpStatusCode.OK;

            string? reasonPhrase;

            string responseContent = string.Empty;

            ApiResponse<VerifyTokenResponse> apiResponse;

            try
            {
                using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                httpStatusCode = responseMessage.StatusCode;

                reasonPhrase = responseMessage.ReasonPhrase;

                responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                end = DateTime.UtcNow;

                apiResponse = new(responseMessage, responseContent);
            }
            catch (Exception e)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                end = DateTime.UtcNow;

                HttpRequestException httpRequestException = new("/players/{playerTag}/verifytoken", path, end - start, e);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestException));

                Library.LogRequestException(_logger, e, start, end, path);

                throw httpRequestException;
            }

            if (apiResponse.IsSuccessStatusCode)
            {
                apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<VerifyTokenResponse>(apiResponse.RawContent, CocApi.Clash.JsonSerializerSettings);

                //HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/players/{playerTag}/verifytoken", path, end - start, httpStatusCode);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

                Library.LogRequestSuccess(_logger, httpStatusCode, start, end, path);
            }
            else
            {
                //HttpRequestNonSuccess httpRequestNonSuccess = new("/players/{playerTag}/verifytoken", path, end - start, httpStatusCode, reasonPhrase);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestNonSuccess));

                Library.LogRequestFailure(_logger, httpStatusCode, start, end, path, reasonPhrase);
            }

            return apiResponse;
        }
    }
}

