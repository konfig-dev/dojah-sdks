/*
 * DOJAH Publilc APIs
 *
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://konfigthis.com
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Dojah.Net.Client;
using Dojah.Net.Api;
// uncomment below to import models
//using Dojah.Net.Model;

namespace Dojah.Net.Test.Api
{
    /// <summary>
    ///  Class for testing AMLApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Konfig (https://konfigthis.com).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AMLApiTests : IDisposable
    {
        private AMLApi instance;

        public AMLApiTests()
        {
            instance = new AMLApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AMLApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AMLApi
            //Assert.IsType<AMLApi>(instance);
        }

        /// <summary>
        /// Test GetScreeningInfo
        /// </summary>
        [Fact]
        public void GetScreeningInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //var response = instance.GetScreeningInfo(profileId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ScreenAml
        /// </summary>
        [Fact]
        public void ScreenAmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AmlScreenAmlRequest amlScreenAmlRequest = null;
            //var response = instance.ScreenAml(amlScreenAmlRequest);
            //Assert.IsType<AmlScreenAmlResponse>(response);
        }
    }
}
