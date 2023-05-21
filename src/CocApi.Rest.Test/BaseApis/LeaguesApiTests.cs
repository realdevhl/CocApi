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
using CocApi.Rest.IBaseApis;
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


namespace CocApi.Rest.Test.BaseApis
{
    /// <summary>
    ///  Class for testing LeaguesApi
    /// </summary>
    public sealed class LeaguesApiTests : ApiTestsBase
    {
        private readonly IBaseApis.ILeaguesApi _instance;

        public LeaguesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IBaseApis.ILeaguesApi>();
        }


        /// <summary>
        /// Test GetBuilderBaseLeague
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetBuilderBaseLeagueAsyncTest()
        {
            string leagueId = default;
            var response = await _instance.GetBuilderBaseLeagueAsync(leagueId);
            var model = response.ToModel();
            Assert.IsType<BuilderBaseLeague>(model);
        }

        /// <summary>
        /// Test GetBuilderBaseLeagues
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetBuilderBaseLeaguesAsyncTest()
        {
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.GetBuilderBaseLeaguesAsync(limit, after, before);
            var model = response.ToModel();
            Assert.IsType<BuilderBaseLeagueList>(model);
        }

        /// <summary>
        /// Test GetCapitalLeague
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCapitalLeagueAsyncTest()
        {
            string leagueId = default;
            var response = await _instance.GetCapitalLeagueAsync(leagueId);
            var model = response.ToModel();
            Assert.IsType<CapitalLeague>(model);
        }

        /// <summary>
        /// Test GetCapitalLeagues
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCapitalLeaguesAsyncTest()
        {
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.GetCapitalLeaguesAsync(limit, after, before);
            var model = response.ToModel();
            Assert.IsType<CapitalLeagueObject>(model);
        }

        /// <summary>
        /// Test GetLeague
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLeagueAsyncTest()
        {
            string leagueId = default;
            var response = await _instance.FetchLeagueAsync(leagueId);
            var model = response.ToModel();
            Assert.IsType<League>(model);
        }

        /// <summary>
        /// Test GetLeagueSeasonRankings
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLeagueSeasonRankingsAsyncTest()
        {
            string leagueId = default;
            string seasonId = default;
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.FetchLeagueSeasonRankingsAsync(leagueId, seasonId, limit, after, before);
            var model = response.ToModel();
            Assert.IsType<PlayerRankingList>(model);
        }

        /// <summary>
        /// Test GetLeagueSeasons
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLeagueSeasonsAsyncTest()
        {
            string leagueId = default;
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.FetchLeagueSeasonsAsync(leagueId, limit, after, before);
            var model = response.ToModel();
            Assert.IsType<LeagueSeasonList>(model);
        }

        /// <summary>
        /// Test GetLeagues
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLeaguesAsyncTest()
        {
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.FetchLeaguesAsync(limit, after, before);
            var model = response.ToModel();
            Assert.IsType<LeagueList>(model);
        }

        /// <summary>
        /// Test GetWarLeague
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetWarLeagueAsyncTest()
        {
            string leagueId = default;
            var response = await _instance.FetchWarLeagueAsync(leagueId);
            var model = response.ToModel();
            Assert.IsType<WarLeague>(model);
        }

        /// <summary>
        /// Test GetWarLeagues
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetWarLeaguesAsyncTest()
        {
            int? limit = default;
            string? after = default;
            string? before = default;
            var response = await _instance.FetchWarLeaguesAsync(limit, after, before);
            var model = response.ToModel();
            Assert.IsType<WarLeagueList>(model);
        }
    }
}
