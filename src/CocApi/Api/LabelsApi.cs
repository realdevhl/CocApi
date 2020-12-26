/* 
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Collections.Immutable;
using CocApi.Client;
using CocApi.Model;

namespace CocApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class LabelsApi
    {
        //private readonly CocApi.TokenQueue _tokenProvider;
        private CocApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
        public delegate System.Threading.Tasks.Task HttpRequestResultEventHandler(object sender, HttpRequestResultEventArgs log);        
        public event HttpRequestResultEventHandler HttpRequestResult;
        //private readonly System.Collections.Concurrent.ConcurrentBag<IHttpRequestResult> // _httpRequestResults = new System.Collections.Concurrent.ConcurrentBag<IHttpRequestResult>();
        internal void OnHttpRequestResult(HttpRequestResultEventArgs log) => HttpRequestResult?.Invoke(this, log);
        //public ImmutableArray<IHttpRequestResult> HttpRequestResults => // _httpRequestResults.ToImmutableArray();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi(/*CocApi.TokenQueue tokenProvider,*/ TimeSpan? httpRequestTimeOut = null, string basePath = "https://api.clashofclans.com/v1")
        {
            this.Configuration = CocApi.Client.Configuration.MergeConfigurations(
                CocApi.Client.GlobalConfiguration.Instance,
                new CocApi.Client.Configuration { BasePath = basePath, Timeout = ((int?)httpRequestTimeOut?.TotalMilliseconds) ?? 100000  }
            );
            this.Client = new CocApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CocApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CocApi.Client.Configuration.DefaultExceptionFactory;
            //this._tokenProvider = tokenProvider;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CocApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CocApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CocApi.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CocApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }



        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject> GetClanLabelsAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
             CocApi.Client.ApiResponse<LabelsObject> localVarResponse = await GetClanLabelsResponseAsync(token, limit, after, before,  cancellationToken.GetValueOrDefault());
             return localVarResponse.Data;
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>> GetClanLabelsResponseAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
            CocApi.Client.RequestOptions localVarRequestOptions = new CocApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = CocApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CocApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }

            // authentication (JWT) required
            //localVarRequestOptions.HeaderParameters.Add("authorization", "Bearer " + await _tokenProvider.GetTokenAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false));
            localVarRequestOptions.HeaderParameters.Add("authorization", "Bearer " + token);
            

            // make the HTTP request
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();

            ApiResponse<LabelsObject>? localVarResponse = null;

            try
            {
                localVarResponse = await this.AsynchronousClient.GetAsync<LabelsObject>("/labels/clans", localVarRequestOptions, this.Configuration, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                stopwatch.Stop();

                HttpRequestException requestException = new HttpRequestException("/labels/clans", localVarRequestOptions, stopwatch.Elapsed, e);

                // _httpRequestResults.Add(requestException);

                OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                throw;
            }

            stopwatch.Stop();

            if (localVarResponse.ErrorText == "The request timed-out." || localVarResponse.ErrorText == "The operation has timed out.")
            {
                TimeoutException timeoutException = new TimeoutException(localVarResponse.ErrorText);

                HttpRequestException requestException = new HttpRequestException("/labels/clans", localVarRequestOptions, stopwatch.Elapsed, timeoutException);

                // _httpRequestResults.Add(requestException);

                OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                throw timeoutException;
            }

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClanLabels", localVarResponse);
                if (_exception != null) 
                {
                    HttpRequestException requestException = new HttpRequestException("/labels/clans", localVarRequestOptions, stopwatch.Elapsed, _exception);

                    // _httpRequestResults.Add(requestException);

                    OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                    throw _exception;
                }
            }

            HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/labels/clans", localVarRequestOptions, stopwatch.Elapsed, localVarResponse.StatusCode);

            // _httpRequestResults.Add(requestSuccess);

            OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

            return localVarResponse;
        }

        /// <summary>
        /// List clan labels List clan labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>?> GetClanLabelsResponseOrDefaultAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
            try
            {
                return await GetClanLabelsResponseAsync (token, limit, after, before, cancellationToken.GetValueOrDefault());
            }
            catch(ApiException)
            {
                return null;
            }
            catch (TimeoutException)
            {
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
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject?> GetClanLabelsOrDefaultAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
             CocApi.Client.ApiResponse<LabelsObject>? localVarResponse = await GetClanLabelsResponseOrDefaultAsync(token, limit, after, before, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);
             if (localVarResponse == null)
                return null;

             return localVarResponse.Data;
        }



        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject> GetPlayerLabelsAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
             CocApi.Client.ApiResponse<LabelsObject> localVarResponse = await GetPlayerLabelsResponseAsync(token, limit, after, before,  cancellationToken.GetValueOrDefault());
             return localVarResponse.Data;
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>> GetPlayerLabelsResponseAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
            CocApi.Client.RequestOptions localVarRequestOptions = new CocApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = CocApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CocApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(CocApi.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }

            // authentication (JWT) required
            //localVarRequestOptions.HeaderParameters.Add("authorization", "Bearer " + await _tokenProvider.GetTokenAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false));
            localVarRequestOptions.HeaderParameters.Add("authorization", "Bearer " + token);
            

            // make the HTTP request
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();

            ApiResponse<LabelsObject>? localVarResponse = null;

            try
            {
                localVarResponse = await this.AsynchronousClient.GetAsync<LabelsObject>("/labels/players", localVarRequestOptions, this.Configuration, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                stopwatch.Stop();

                HttpRequestException requestException = new HttpRequestException("/labels/players", localVarRequestOptions, stopwatch.Elapsed, e);

                // _httpRequestResults.Add(requestException);

                OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                throw;
            }

            stopwatch.Stop();

            if (localVarResponse.ErrorText == "The request timed-out." || localVarResponse.ErrorText == "The operation has timed out.")
            {
                TimeoutException timeoutException = new TimeoutException(localVarResponse.ErrorText);

                HttpRequestException requestException = new HttpRequestException("/labels/players", localVarRequestOptions, stopwatch.Elapsed, timeoutException);

                // _httpRequestResults.Add(requestException);

                OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                throw timeoutException;
            }

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPlayerLabels", localVarResponse);
                if (_exception != null) 
                {
                    HttpRequestException requestException = new HttpRequestException("/labels/players", localVarRequestOptions, stopwatch.Elapsed, _exception);

                    // _httpRequestResults.Add(requestException);

                    OnHttpRequestResult(new HttpRequestResultEventArgs(requestException));

                    throw _exception;
                }
            }

            HttpRequestSuccess requestSuccess = new HttpRequestSuccess("/labels/players", localVarRequestOptions, stopwatch.Elapsed, localVarResponse.StatusCode);

            // _httpRequestResults.Add(requestSuccess);

            OnHttpRequestResult(new HttpRequestResultEventArgs(requestSuccess));

            return localVarResponse;
        }

        /// <summary>
        /// List player labels List player labels
        /// </summary>
        /// <exception cref="CocApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit the number of items returned in the response. (optional)</param>
        /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the &#39;paging&#39; property. Note that only after or before can be specified for a request, not both.  (optional)</param>
        /// <returns>Task of ApiResponse (LabelsObject)</returns>
        public async System.Threading.Tasks.Task<CocApi.Client.ApiResponse<LabelsObject>?> GetPlayerLabelsResponseOrDefaultAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
            try
            {
                return await GetPlayerLabelsResponseAsync (token, limit, after, before, cancellationToken.GetValueOrDefault());
            }
            catch(ApiException)
            {
                return null;
            }
            catch (TimeoutException)
            {
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
        /// <returns>Task of LabelsObject</returns>
        public async System.Threading.Tasks.Task<LabelsObject?> GetPlayerLabelsOrDefaultAsync (string token, int? limit = default(int?), string after = default(string), string before = default(string), System.Threading.CancellationToken? cancellationToken = default)
        {
             CocApi.Client.ApiResponse<LabelsObject>? localVarResponse = await GetPlayerLabelsResponseOrDefaultAsync(token, limit, after, before, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);
             if (localVarResponse == null)
                return null;

             return localVarResponse.Data;
        }

    }
}