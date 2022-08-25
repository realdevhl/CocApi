﻿// this file was initially auto generated
// it will not be overwritten

/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Microsoft.Extensions.Logging;
using System.Net.Http;
using CocApi.Rest.Client;

namespace CocApi.Rest.Apis
{
    /// <summary>
    /// Validate requests and process server responses
    /// </summary>
    public class GoldpassApi : BaseApis.GoldpassApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldpassApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GoldpassApi(ILogger<GoldpassApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        : base(logger, httpClient, jsonSerializerOptionsProvider,
            apiKeyProvider)
        {
        }
    }
}

