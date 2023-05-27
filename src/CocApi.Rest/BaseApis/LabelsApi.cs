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

namespace CocApi.Rest.IBaseApis
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
        /// <returns>Task&lt;ApiResponse&lt;LabelsObject&gt;&gt;</returns>
        Task<ApiResponse<LabelsObject>> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task&lt;ApiResponse&gt;LabelsObject&gt;?&gt;</returns>
        Task<ApiResponse<LabelsObject>?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task&lt;ApiResponse&lt;LabelsObject&gt;&gt;</returns>
        Task<ApiResponse<LabelsObject>> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task&lt;ApiResponse&gt;LabelsObject&gt;?&gt;</returns>
        Task<ApiResponse<LabelsObject>?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default);
    }
}

namespace CocApi.Rest.BaseApis
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LabelsApi : IBaseApis.ILabelsApi
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
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void AfterFetchClanLabels(ApiResponse<LabelsObject> apiResponseLocalVar, int? limit, string? after, string? before)
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
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="LabelsObject"/></returns>
        public async Task<ApiResponse<LabelsObject>?> FetchClanLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await FetchClanLabelsAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
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
        public async Task<ApiResponse<LabelsObject>> FetchClanLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                var validatedParameterLocalVars = OnFetchClanLabels(limit, after, before);
                limit = validatedParameterLocalVars.Item1;
                after = validatedParameterLocalVars.Item2;
                before = validatedParameterLocalVars.Item3;

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/labels/clans";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    if (limit != null)
                        parseQueryStringLocalVar["limit"] = limit.ToString();

                    if (after != null)
                        parseQueryStringLocalVar["after"] = after.ToString();

                    if (before != null)
                        parseQueryStringLocalVar["before"] = before.ToString();

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();

                    ApiKeyToken apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);

                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "authorization");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] { 
                        "application/json" 
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAtLocalVar, DateTime.UtcNow, httpResponseMessageLocalVar.StatusCode, "/labels/clans", uriBuilderLocalVar.Path));

                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ApiResponse<LabelsObject> apiResponseLocalVar = new ApiResponse<LabelsObject>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, _jsonSerializerOptions);

                        AfterFetchClanLabels(apiResponseLocalVar, limit, after, before);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFetchClanLabels(e, "/labels/clans", uriBuilderLocalVar.Path, limit, after, before);
                throw;
            }
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
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        protected virtual void AfterFetchPlayerLabels(ApiResponse<LabelsObject> apiResponseLocalVar, int? limit, string? after, string? before)
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
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="LabelsObject"/></returns>
        public async Task<ApiResponse<LabelsObject>?> FetchPlayerLabelsOrDefaultAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await FetchPlayerLabelsAsync(limit, after, before, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
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
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="LabelsObject"/></returns>
        public async Task<ApiResponse<LabelsObject>> FetchPlayerLabelsAsync(int? limit = null, string? after = null, string? before = null, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                var validatedParameterLocalVars = OnFetchPlayerLabels(limit, after, before);
                limit = validatedParameterLocalVars.Item1;
                after = validatedParameterLocalVars.Item2;
                before = validatedParameterLocalVars.Item3;

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/labels/players";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    if (limit != null)
                        parseQueryStringLocalVar["limit"] = limit.ToString();

                    if (after != null)
                        parseQueryStringLocalVar["after"] = after.ToString();

                    if (before != null)
                        parseQueryStringLocalVar["before"] = before.ToString();

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();

                    ApiKeyToken apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);

                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "authorization");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] { 
                        "application/json" 
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAtLocalVar, DateTime.UtcNow, httpResponseMessageLocalVar.StatusCode, "/labels/players", uriBuilderLocalVar.Path));

                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ApiResponse<LabelsObject> apiResponseLocalVar = new ApiResponse<LabelsObject>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, _jsonSerializerOptions);

                        AfterFetchPlayerLabels(apiResponseLocalVar, limit, after, before);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFetchPlayerLabels(e, "/labels/players", uriBuilderLocalVar.Path, limit, after, before);
                throw;
            }
        }
    }
}
