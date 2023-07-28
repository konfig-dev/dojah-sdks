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

namespace Dojah.Net.Test.Api
{
    /// <summary>
    ///  Class for testing GlobalKYCApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Konfig (https://konfigthis.com).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GlobalKYCApiTests : IDisposable
    {
        private GlobalKYCApi instance;

        public GlobalKYCApiTests()
        {
            instance = new GlobalKYCApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GlobalKYCApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GlobalKYCApi
            //Assert.IsType<GlobalKYCApi>(instance);
        }

        /// <summary>
        /// Test CaEkyc
        /// </summary>
        [Fact]
        public void CaEkycTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string firstName = null;
            //string lastName = null;
            //string streetName = null;
            //string dateOfBirth = null;
            //int? houseNumber = null;
            //int? postCode = null;
            //var response = instance.CaEkyc(country, firstName, lastName, streetName, dateOfBirth, houseNumber, postCode);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetUsSsn
        /// </summary>
        [Fact]
        public void GetUsSsnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string firstName = null;
            //string lastName = null;
            //string streetName = null;
            //string dateOfBirth = null;
            //int? houseNumber = null;
            //int? postCode = null;
            //var response = instance.GetUsSsn(country, firstName, lastName, streetName, dateOfBirth, houseNumber, postCode);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UkTwoPlusTwo
        /// </summary>
        [Fact]
        public void UkTwoPlusTwoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string firstName = null;
            //string lastName = null;
            //string streetName = null;
            //string dateOfBirth = null;
            //int? houseNumber = null;
            //int? postCode = null;
            //var response = instance.UkTwoPlusTwo(country, firstName, lastName, streetName, dateOfBirth, houseNumber, postCode);
            //Assert.IsType<Object>(response);
        }
    }
}
