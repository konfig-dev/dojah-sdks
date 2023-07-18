/*
 * DOJAH Publilc APIs
 *
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Dojah.Net.Client;
using Dojah.Net.Model;

namespace Dojah.Net.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZWKYCApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Credit Check
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ZwKycCheckCreditResponse</returns>
        ZwKycCheckCreditResponse CheckCredit(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0);

        /// <summary>
        /// Credit Check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ZwKycCheckCreditResponse</returns>
        ApiResponse<ZwKycCheckCreditResponse> CheckCreditWithHttpInfo(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0);
        /// <summary>
        /// National ID Verification
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ZwKycVerifyIdResponse</returns>
        ZwKycVerifyIdResponse VerifyId(string appId = default(string), string id = default(string), int operationIndex = 0);

        /// <summary>
        /// National ID Verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ZwKycVerifyIdResponse</returns>
        ApiResponse<ZwKycVerifyIdResponse> VerifyIdWithHttpInfo(string appId = default(string), string id = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZWKYCApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Credit Check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ZwKycCheckCreditResponse</returns>
        System.Threading.Tasks.Task<ZwKycCheckCreditResponse> CheckCreditAsync(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Credit Check
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ZwKycCheckCreditResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZwKycCheckCreditResponse>> CheckCreditWithHttpInfoAsync(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// National ID Verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ZwKycVerifyIdResponse</returns>
        System.Threading.Tasks.Task<ZwKycVerifyIdResponse> VerifyIdAsync(string appId = default(string), string id = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// National ID Verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ZwKycVerifyIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZwKycVerifyIdResponse>> VerifyIdWithHttpInfoAsync(string appId = default(string), string id = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZWKYCApi : IZWKYCApiSync, IZWKYCApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZWKYCApi : IZWKYCApi
    {
        private Dojah.Net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZWKYCApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZWKYCApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZWKYCApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZWKYCApi(string basePath)
        {
            this.Configuration = Dojah.Net.Client.Configuration.MergeConfigurations(
                Dojah.Net.Client.GlobalConfiguration.Instance,
                new Dojah.Net.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Dojah.Net.Client.ApiClient(this.Configuration);
            this.AsynchronousClient = new Dojah.Net.Client.ApiClient(this.Configuration);
            this.ExceptionFactory = Dojah.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZWKYCApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZWKYCApi(Dojah.Net.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Dojah.Net.Client.Configuration.MergeConfigurations(
                Dojah.Net.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Dojah.Net.Client.ApiClient(this.Configuration);
            this.AsynchronousClient = new Dojah.Net.Client.ApiClient(this.Configuration);
            this.ExceptionFactory = Dojah.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZWKYCApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZWKYCApi(Dojah.Net.Client.ISynchronousClient client, Dojah.Net.Client.IAsynchronousClient asyncClient, Dojah.Net.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Dojah.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Dojah.Net.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Dojah.Net.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Dojah.Net.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dojah.Net.Client.ExceptionFactory ExceptionFactory
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
        /// Credit Check 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ZwKycCheckCreditResponse</returns>
        public ZwKycCheckCreditResponse CheckCredit(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0)
        {
            Dojah.Net.Client.ApiResponse<ZwKycCheckCreditResponse> localVarResponse = CheckCreditWithHttpInfo(appId, idNumber, name, surname, gender, dob, maritalStatus, mobileNumber);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Credit Check 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ZwKycCheckCreditResponse</returns>
        public Dojah.Net.Client.ApiResponse<ZwKycCheckCreditResponse> CheckCreditWithHttpInfo(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0)
        {
            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Dojah.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Dojah.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (idNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "id_number", idNumber, ""));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "name", name, ""));
            }
            if (surname != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "surname", surname, ""));
            }
            if (gender != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "gender", gender, ""));
            }
            if (dob != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "dob", dob, ""));
            }
            if (maritalStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "marital_status", maritalStatus, ""));
            }
            if (mobileNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "mobile_number", mobileNumber, ""));
            }
            if (appId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", Dojah.Net.Client.ClientUtils.ParameterToString(appId)); // header parameter
            }

            localVarRequestOptions.Operation = "ZWKYCApi.CheckCredit";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ZwKycCheckCreditResponse>("/api/v1/zw/kyc/fcb", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckCredit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Credit Check 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ZwKycCheckCreditResponse</returns>
        public async System.Threading.Tasks.Task<ZwKycCheckCreditResponse> CheckCreditAsync(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dojah.Net.Client.ApiResponse<ZwKycCheckCreditResponse> localVarResponse = await CheckCreditWithHttpInfoAsync(appId, idNumber, name, surname, gender, dob, maritalStatus, mobileNumber, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Credit Check 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="surname"> (optional)</param>
        /// <param name="gender"> (optional)</param>
        /// <param name="dob"> (optional)</param>
        /// <param name="maritalStatus"> (optional)</param>
        /// <param name="mobileNumber"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ZwKycCheckCreditResponse)</returns>
        public async System.Threading.Tasks.Task<Dojah.Net.Client.ApiResponse<ZwKycCheckCreditResponse>> CheckCreditWithHttpInfoAsync(string appId = default(string), string idNumber = default(string), string name = default(string), string surname = default(string), string gender = default(string), string dob = default(string), string maritalStatus = default(string), int? mobileNumber = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Dojah.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Dojah.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (idNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "id_number", idNumber, ""));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "name", name, ""));
            }
            if (surname != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "surname", surname, ""));
            }
            if (gender != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "gender", gender, ""));
            }
            if (dob != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "dob", dob, ""));
            }
            if (maritalStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "marital_status", maritalStatus, ""));
            }
            if (mobileNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "mobile_number", mobileNumber, ""));
            }
            if (appId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", Dojah.Net.Client.ClientUtils.ParameterToString(appId, dataFormat: "")); // header parameter
            }

            localVarRequestOptions.Operation = "ZWKYCApi.CheckCredit";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ZwKycCheckCreditResponse>("/api/v1/zw/kyc/fcb", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CheckCredit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// National ID Verification 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ZwKycVerifyIdResponse</returns>
        public ZwKycVerifyIdResponse VerifyId(string appId = default(string), string id = default(string), int operationIndex = 0)
        {
            Dojah.Net.Client.ApiResponse<ZwKycVerifyIdResponse> localVarResponse = VerifyIdWithHttpInfo(appId, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// National ID Verification 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ZwKycVerifyIdResponse</returns>
        public Dojah.Net.Client.ApiResponse<ZwKycVerifyIdResponse> VerifyIdWithHttpInfo(string appId = default(string), string id = default(string), int operationIndex = 0)
        {
            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Dojah.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Dojah.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "id", id, ""));
            }
            if (appId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", Dojah.Net.Client.ClientUtils.ParameterToString(appId)); // header parameter
            }

            localVarRequestOptions.Operation = "ZWKYCApi.VerifyId";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ZwKycVerifyIdResponse>("/api/v1/zw/kyc/nin", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// National ID Verification 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ZwKycVerifyIdResponse</returns>
        public async System.Threading.Tasks.Task<ZwKycVerifyIdResponse> VerifyIdAsync(string appId = default(string), string id = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dojah.Net.Client.ApiResponse<ZwKycVerifyIdResponse> localVarResponse = await VerifyIdWithHttpInfoAsync(appId, id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// National ID Verification 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ZwKycVerifyIdResponse)</returns>
        public async System.Threading.Tasks.Task<Dojah.Net.Client.ApiResponse<ZwKycVerifyIdResponse>> VerifyIdWithHttpInfoAsync(string appId = default(string), string id = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Dojah.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Dojah.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Dojah.Net.Client.ClientUtils.ParameterToMultiMap("", "id", id, ""));
            }
            if (appId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", Dojah.Net.Client.ClientUtils.ParameterToString(appId, dataFormat: "")); // header parameter
            }

            localVarRequestOptions.Operation = "ZWKYCApi.VerifyId";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ZwKycVerifyIdResponse>("/api/v1/zw/kyc/nin", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
