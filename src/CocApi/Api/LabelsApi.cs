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
    public interface ILabelsApi
    {
        /// <summary>
        /// List clan labels
        /// </summary>
        /// <remarks>
        /// List clan labels
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<LabelsObject>> FetchClanLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// List clan labels
        /// </summary>
        /// <remarks>
        /// List clan labels
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        System.Threading.Tasks.Task<LabelsObject> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// List clan labels
        /// </summary>
        /// <remarks>
        /// List clan labels
        /// </remarks>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject?)</returns>
        System.Threading.Tasks.Task<LabelsObject?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
        /// <summary>
        /// List player labels
        /// </summary>
        /// <remarks>
        /// List player labels
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<LabelsObject>> FetchPlayerLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// List player labels
        /// </summary>
        /// <remarks>
        /// List player labels
        /// </remarks>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        System.Threading.Tasks.Task<LabelsObject> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// List player labels
        /// </summary>
        /// <remarks>
        /// List player labels
        /// </remarks>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject?)</returns>
        System.Threading.Tasks.Task<LabelsObject?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LabelsApi : ILabelsApi
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        //private void OnHttpRequestResult(HttpRequestResultEventArgs log) => CocApi.Library.OnHttpRequestResult(this, log);

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi(ILogger<LabelsApi> logger, System.Net.Http.HttpClient httpClient, TokenProvider tokenProvider)
        {
            _logger = logger;
            _httpClient = httpClient;
            GetTokenAsync = tokenProvider.GetAsync;
        }

        /// <summary>
        /// Returns the token to be used in the api query
        /// </summary>
        public Func<System.Threading.CancellationToken?, System.Threading.Tasks.ValueTask<string>>? GetTokenAsync { get; set; }
        private ILogger<LabelsApi> _logger;


        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            CocApi.Client.ApiResponse<LabelsObject> result = await FetchClanLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            return result.Content ?? throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                CocApi.Client.ApiResponse<LabelsObject> result = await FetchClanLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
                
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
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>> FetchClanLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            
            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/labels/clans";


            path = $"{path}?";
            
            if (limit != null)
                path = $"{path}limit={Uri.EscapeDataString(limit.ToString()!)}&";  

            if (after != null)
                path = $"{path}after={Uri.EscapeDataString(after.ToString()!)}&";  

            if (before != null)
                path = $"{path}before={Uri.EscapeDataString(before.ToString()!)}&";  


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

            ApiResponse<LabelsObject> apiResponse;

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

                HttpRequestException httpRequestException = new("/labels/clans", path, end - start, e);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestException));

                Library.LogRequestException(_logger, e, start, end, path);

                throw httpRequestException;
            }

            if (apiResponse.IsSuccessStatusCode)
            {
                apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<LabelsObject>(apiResponse.RawContent, CocApi.Clash.JsonSerializerSettings);

                //HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/labels/clans", path, end - start, httpStatusCode);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

                Library.LogRequestSuccess(_logger, httpStatusCode, start, end, path);
            }
            else
            {
                //HttpRequestNonSuccess httpRequestNonSuccess = new("/labels/clans", path, end - start, httpStatusCode, reasonPhrase);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestNonSuccess));

                Library.LogRequestFailure(_logger, httpStatusCode, start, end, path, reasonPhrase);
            }

            return apiResponse;
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            CocApi.Client.ApiResponse<LabelsObject> result = await FetchPlayerLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            return result.Content ?? throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                CocApi.Client.ApiResponse<LabelsObject> result = await FetchPlayerLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
                
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
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>> FetchPlayerLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            
            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/labels/players";


            path = $"{path}?";
            
            if (limit != null)
                path = $"{path}limit={Uri.EscapeDataString(limit.ToString()!)}&";  

            if (after != null)
                path = $"{path}after={Uri.EscapeDataString(after.ToString()!)}&";  

            if (before != null)
                path = $"{path}before={Uri.EscapeDataString(before.ToString()!)}&";  


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

            ApiResponse<LabelsObject> apiResponse;

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

                HttpRequestException httpRequestException = new("/labels/players", path, end - start, e);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestException));

                Library.LogRequestException(_logger, e, start, end, path);

                throw httpRequestException;
            }

            if (apiResponse.IsSuccessStatusCode)
            {
                apiResponse.Content = Newtonsoft.Json.JsonConvert.DeserializeObject<LabelsObject>(apiResponse.RawContent, CocApi.Clash.JsonSerializerSettings);

                //HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/labels/players", path, end - start, httpStatusCode);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

                Library.LogRequestSuccess(_logger, httpStatusCode, start, end, path);
            }
            else
            {
                //HttpRequestNonSuccess httpRequestNonSuccess = new("/labels/players", path, end - start, httpStatusCode, reasonPhrase);

                //OnHttpRequestResult(new HttpRequestResultEventArgs(httpRequestNonSuccess));

                Library.LogRequestFailure(_logger, httpStatusCode, start, end, path, reasonPhrase);
            }

            return apiResponse;
        }
    }
}

