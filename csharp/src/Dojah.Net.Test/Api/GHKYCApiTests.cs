/*
 * DOJAH APIs
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
    ///  Class for testing GHKYCApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Konfig (https://konfigthis.com).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GHKYCApiTests : IDisposable
    {
        private GHKYCApi instance;

        public GHKYCApiTests()
        {
            instance = new GHKYCApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GHKYCApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GHKYCApi
            //Assert.IsType<GHKYCApi>(instance);
        }

        /// <summary>
        /// Test GetDriversLicense
        /// </summary>
        [Fact]
        public void GetDriversLicenseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fullName = null;
            //string dateOfBirth = null;
            //var response = instance.GetDriversLicense(id, fullName, dateOfBirth);
            //Assert.IsType<GetDriversLicenseResponse>(response);
        }

        /// <summary>
        /// Test GetPassport
        /// </summary>
        [Fact]
        public void GetPassportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string firstName = null;
            //string lastName = null;
            //string middleName = null;
            //string dateOfBirth = null;
            //var response = instance.GetPassport(id, firstName, lastName, middleName, dateOfBirth);
            //Assert.IsType<GetPassportResponse>(response);
        }

        /// <summary>
        /// Test GetSsnit
        /// </summary>
        [Fact]
        public void GetSsnitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fullName = null;
            //string dateOfBirth = null;
            //var response = instance.GetSsnit(id, fullName, dateOfBirth);
            //Assert.IsType<GetSsnitResponse>(response);
        }
    }
}
