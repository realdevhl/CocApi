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
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using CocApi.Rest.IApis;
using CocApi.Rest.Models;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace CocApi.Rest.Test.Apis
{
    /// <summary>
    ///  Class for testing PlayersApi
    /// </summary>
    public sealed class PlayersApiTests : ApiTestsBase
    {
        private readonly IPlayersApi _instance;

        public PlayersApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IPlayersApi>();
        }


        /// <summary>
        /// Test GetPlayer
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlayerAsyncTest()
        {
            string playerTag = default;
            var response = await _instance.FetchPlayerAsync(playerTag);
            Assert.IsType<Player>(response);
        }

        /// <summary>
        /// Test VerifyToken
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task VerifyTokenAsyncTest()
        {
            VerifyTokenRequest body = default;
            string playerTag = default;
            var response = await _instance.VerifyTokenAsync(body, playerTag);
            Assert.IsType<VerifyTokenResponse>(response);
        }
    }
}


