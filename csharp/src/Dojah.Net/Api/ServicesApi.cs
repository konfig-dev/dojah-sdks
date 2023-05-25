/*
 * DOJAH APIs
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
    public interface IServicesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Categorize Transactions
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CategorizeTransactionsResponse</returns>
        CategorizeTransactionsResponse CategorizeTransactions(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0);

        /// <summary>
        /// Categorize Transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CategorizeTransactionsResponse</returns>
        ApiResponse<CategorizeTransactionsResponse> CategorizeTransactionsWithHttpInfo(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Categorize Transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CategorizeTransactionsResponse</returns>
        System.Threading.Tasks.Task<CategorizeTransactionsResponse> CategorizeTransactionsAsync(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Categorize Transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CategorizeTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategorizeTransactionsResponse>> CategorizeTransactionsWithHttpInfoAsync(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicesApi : IServicesApiSync, IServicesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServicesApi : IServicesApi
    {
        private Dojah.Net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ServicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServicesApi(Dojah.Net.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ServicesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ServicesApi(Dojah.Net.Client.ISynchronousClient client, Dojah.Net.Client.IAsynchronousClient asyncClient, Dojah.Net.Client.IReadableConfiguration configuration)
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
        /// Categorize Transactions 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CategorizeTransactionsResponse</returns>
        public CategorizeTransactionsResponse CategorizeTransactions(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0)
        {
            Dojah.Net.Client.ApiResponse<CategorizeTransactionsResponse> localVarResponse = CategorizeTransactionsWithHttpInfo(categorizeTransactionsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Categorize Transactions 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CategorizeTransactionsResponse</returns>
        public Dojah.Net.Client.ApiResponse<CategorizeTransactionsResponse> CategorizeTransactionsWithHttpInfo(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0)
        {
            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.Data = categorizeTransactionsRequest;

            localVarRequestOptions.Operation = "ServicesApi.CategorizeTransactions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apikeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (appIdAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AppId")))
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", this.Configuration.GetApiKeyWithPrefix("AppId"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CategorizeTransactionsResponse>("/v1/ml/categorize_transaction", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CategorizeTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Categorize Transactions 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CategorizeTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<CategorizeTransactionsResponse> CategorizeTransactionsAsync(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Dojah.Net.Client.ApiResponse<CategorizeTransactionsResponse> localVarResponse = await CategorizeTransactionsWithHttpInfoAsync(categorizeTransactionsRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Categorize Transactions 
        /// </summary>
        /// <exception cref="Dojah.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categorizeTransactionsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CategorizeTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<Dojah.Net.Client.ApiResponse<CategorizeTransactionsResponse>> CategorizeTransactionsWithHttpInfoAsync(CategorizeTransactionsRequest categorizeTransactionsRequest = default(CategorizeTransactionsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Dojah.Net.Client.RequestOptions localVarRequestOptions = new Dojah.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            localVarRequestOptions.Data = categorizeTransactionsRequest;

            localVarRequestOptions.Operation = "ServicesApi.CategorizeTransactions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apikeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (appIdAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AppId")))
            {
                localVarRequestOptions.HeaderParameters.Add("AppId", this.Configuration.GetApiKeyWithPrefix("AppId"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CategorizeTransactionsResponse>("/v1/ml/categorize_transaction", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CategorizeTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
