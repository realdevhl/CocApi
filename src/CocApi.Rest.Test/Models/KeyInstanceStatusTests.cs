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
using CocApi.Rest.Models;
using CocApi.Rest.Client;
using System.Reflection;

namespace CocApi.Rest.Test.Model
{
    /// <summary>
    ///  Class for testing KeyInstanceStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KeyInstanceStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KeyInstanceStatus
        //private KeyInstanceStatus instance;

        public KeyInstanceStatusTests()
        {
            // TODO uncomment below to create an instance of KeyInstanceStatus
            //instance = new KeyInstanceStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KeyInstanceStatus
        /// </summary>
        [Fact]
        public void KeyInstanceStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" KeyInstanceStatus
            //Assert.IsType<KeyInstanceStatus>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'Detail'
        /// </summary>
        [Fact]
        public void DetailTest()
        {
            // TODO unit test for the property 'Detail'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
    }
}
