/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CocApi.Rest.BaseApis;
using CocApi.Rest.Models;
using CocApi.Rest.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace CocApi.Rest.Test.Model
{
    /// <summary>
    ///  Class for testing PlayerClan
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PlayerClanTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PlayerClan
        //private PlayerClan instance;

        public PlayerClanTests()
        {
            // TODO uncomment below to create an instance of PlayerClan
            //instance = new PlayerClan();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PlayerClan
        /// </summary>
        [Fact]
        public void PlayerClanInstanceTest()
        {
            // TODO uncomment below to test "IsType" PlayerClan
            //Assert.IsType<PlayerClan>(instance);
        }


        /// <summary>
        /// Test the property 'BadgeUrls'
        /// </summary>
        [Fact]
        public void BadgeUrlsTest()
        {
            // TODO unit test for the property 'BadgeUrls'
        }
        /// <summary>
        /// Test the property 'ClanLevel'
        /// </summary>
        [Fact]
        public void ClanLevelTest()
        {
            // TODO unit test for the property 'ClanLevel'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }

    }

}

