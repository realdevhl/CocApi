/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using CocApi.Rest.Client;
using CocApi.Rest.IApis;
using CocApi.Rest.Extensions;
using Xunit;

namespace CocApi.Rest.Test.BaseApis
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient = 
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureCocApi((context, options) =>
            {
                ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken);
                
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureCocApi((context, options) =>
            {
                ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken);
                
                options.AddCocApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddCocApi(options =>
                {
                    ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken);
                    
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddCocApi(options =>
                {
                    ApiKeyToken apiKeyToken = new ApiKeyToken($"<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken);
                    
                    options.AddCocApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var clansApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.IClansApi>();
            Assert.True(clansApi.HttpClient.BaseAddress != null);
            
            var goldpassApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.IGoldpassApi>();
            Assert.True(goldpassApi.HttpClient.BaseAddress != null);
            
            var labelsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.ILabelsApi>();
            Assert.True(labelsApi.HttpClient.BaseAddress != null);
            
            var leaguesApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.ILeaguesApi>();
            Assert.True(leaguesApi.HttpClient.BaseAddress != null);
            
            var locationsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.ILocationsApi>();
            Assert.True(locationsApi.HttpClient.BaseAddress != null);
            
            var playersApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IApis.IPlayersApi>();
            Assert.True(playersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var clansApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.IClansApi>();
            Assert.True(clansApi.HttpClient.BaseAddress != null);
            
            var goldpassApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.IGoldpassApi>();
            Assert.True(goldpassApi.HttpClient.BaseAddress != null);
            
            var labelsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.ILabelsApi>();
            Assert.True(labelsApi.HttpClient.BaseAddress != null);
            
            var leaguesApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.ILeaguesApi>();
            Assert.True(leaguesApi.HttpClient.BaseAddress != null);
            
            var locationsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.ILocationsApi>();
            Assert.True(locationsApi.HttpClient.BaseAddress != null);
            
            var playersApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IApis.IPlayersApi>();
            Assert.True(playersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var clansApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.IClansApi>();
            Assert.True(clansApi.HttpClient.BaseAddress != null);
            
            var goldpassApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.IGoldpassApi>();
            Assert.True(goldpassApi.HttpClient.BaseAddress != null);
            
            var labelsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.ILabelsApi>();
            Assert.True(labelsApi.HttpClient.BaseAddress != null);
            
            var leaguesApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.ILeaguesApi>();
            Assert.True(leaguesApi.HttpClient.BaseAddress != null);
            
            var locationsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.ILocationsApi>();
            Assert.True(locationsApi.HttpClient.BaseAddress != null);
            
            var playersApi = _hostUsingAddWithAClient.Services.GetRequiredService<IApis.IPlayersApi>();
            Assert.True(playersApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var clansApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.IClansApi>();
            Assert.True(clansApi.HttpClient.BaseAddress != null);
            
            var goldpassApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.IGoldpassApi>();
            Assert.True(goldpassApi.HttpClient.BaseAddress != null);
            
            var labelsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.ILabelsApi>();
            Assert.True(labelsApi.HttpClient.BaseAddress != null);
            
            var leaguesApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.ILeaguesApi>();
            Assert.True(leaguesApi.HttpClient.BaseAddress != null);
            
            var locationsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.ILocationsApi>();
            Assert.True(locationsApi.HttpClient.BaseAddress != null);
            
            var playersApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IApis.IPlayersApi>();
            Assert.True(playersApi.HttpClient.BaseAddress != null);
        }
    }
}

