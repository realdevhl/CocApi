// <auto-generated>
/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using CocApi.Rest.Client;
using CocApi.Rest.Models;

namespace CocApi.Rest.IApis
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface ILabelsApi : IApi
    {
        /// <summary>
        /// List clan labels
        /// </summary>
        /// <remarks>
        /// List clan labels
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;LabelsObject?&gt;&gt;</returns>
        Task<ApiResponse<LabelsObject?>> FetchClanLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// List clan labels
        /// </summary>
        /// <remarks>
        /// List clan labels
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;LabelsObject&gt;</returns>
        Task<LabelsObject> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);

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
        /// <returns>Task of ApiResponse&lt;LabelsObject?&gt;</returns>
        Task<LabelsObject?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// List player labels
        /// </summary>
        /// <remarks>
        /// List player labels
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;LabelsObject?&gt;&gt;</returns>
        Task<ApiResponse<LabelsObject?>> FetchPlayerLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// List player labels
        /// </summary>
        /// <remarks>
        /// List player labels
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;LabelsObject&gt;</returns>
        Task<LabelsObject> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);

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
        /// <returns>Task of ApiResponse&lt;LabelsObject?&gt;</returns>
        Task<LabelsObject?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null);
    }
}

namespace CocApi.Rest.BaseApis
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LabelsApi : IApis.ILabelsApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<LabelsApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi(ILogger<LabelsApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Logs the api response
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (args.ReceivedAt - args.RequestedAt).TotalSeconds, args.HttpStatus, args.Path);
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="LabelsObject"/>&gt;</returns>
        public async Task<LabelsObject> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<LabelsObject?> result = await FetchClanLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="LabelsObject"/>&gt;</returns>
        public async Task<LabelsObject?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<LabelsObject?>? result = null;
            try 
            {
                result = await FetchClanLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <returns></returns>
        protected virtual (int?, string?, string?) OnFetchClanLabels(int? limit, string? after, string? before)
        {
            return (limit, after, before);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void AfterFetchClanLabels(ApiResponse<LabelsObject?> apiResponse, int? limit, string? after, string? before)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void OnErrorFetchClanLabels(Exception exception, string pathFormat, string path, int? limit, string? after, string? before)
        {
            Logger.LogError(exception, "An error occured while sending the request to the server.");
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="LabelsObject"/></returns>
        public async Task<ApiResponse<LabelsObject?>> FetchClanLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                var validatedParameters = OnFetchClanLabels(limit, after, before);
                limit = validatedParameters.Item1;
                after = validatedParameters.Item2;
                before = validatedParameters.Item3;

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/labels/clans";

                    System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    if (limit != null)
                        parseQueryString["limit"] = Uri.EscapeDataString(limit.ToString()!);

                    if (after != null)
                        parseQueryString["after"] = Uri.EscapeDataString(after.ToString()!);

                    if (before != null)
                        parseQueryString["before"] = Uri.EscapeDataString(before.ToString()!);

                    uriBuilder.Query = parseQueryString.ToString();

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "authorization");

                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = HttpMethod.Get;

                    DateTime requestedAt = DateTime.UtcNow;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/labels/clans", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        ApiResponse<LabelsObject?> apiResponse = new ApiResponse<LabelsObject?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<LabelsObject>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterFetchClanLabels(apiResponse, limit, after, before);
                        }
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFetchClanLabels(e, "/labels/clans", uriBuilder.Path, limit, after, before);
                throw;
            }
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="LabelsObject"/>&gt;</returns>
        public async Task<LabelsObject> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<LabelsObject?> result = await FetchPlayerLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="LabelsObject"/>&gt;</returns>
        public async Task<LabelsObject?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<LabelsObject?>? result = null;
            try 
            {
                result = await FetchPlayerLabelsResponseAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <returns></returns>
        protected virtual (int?, string?, string?) OnFetchPlayerLabels(int? limit, string? after, string? before)
        {
            return (limit, after, before);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void AfterFetchPlayerLabels(ApiResponse<LabelsObject?> apiResponse, int? limit, string? after, string? before)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void OnErrorFetchPlayerLabels(Exception exception, string pathFormat, string path, int? limit, string? after, string? before)
        {
            Logger.LogError(exception, "An error occured while sending the request to the server.");
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="LabelsObject"/></returns>
        public async Task<ApiResponse<LabelsObject?>> FetchPlayerLabelsResponseAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                var validatedParameters = OnFetchPlayerLabels(limit, after, before);
                limit = validatedParameters.Item1;
                after = validatedParameters.Item2;
                before = validatedParameters.Item3;

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/labels/players";

                    System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    if (limit != null)
                        parseQueryString["limit"] = Uri.EscapeDataString(limit.ToString()!);

                    if (after != null)
                        parseQueryString["after"] = Uri.EscapeDataString(after.ToString()!);

                    if (before != null)
                        parseQueryString["before"] = Uri.EscapeDataString(before.ToString()!);

                    uriBuilder.Query = parseQueryString.ToString();

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "authorization");

                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = HttpMethod.Get;

                    DateTime requestedAt = DateTime.UtcNow;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/labels/players", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        ApiResponse<LabelsObject?> apiResponse = new ApiResponse<LabelsObject?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<LabelsObject>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterFetchPlayerLabels(apiResponse, limit, after, before);
                        }
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFetchPlayerLabels(e, "/labels/players", uriBuilder.Path, limit, after, before);
                throw;
            }
        }
    }
}
