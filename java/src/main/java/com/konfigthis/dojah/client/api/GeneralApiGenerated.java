/*
 * DOJAH Publilc APIs
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.dojah.client.api;

import com.konfigthis.dojah.client.ApiCallback;
import com.konfigthis.dojah.client.ApiClient;
import com.konfigthis.dojah.client.ApiException;
import com.konfigthis.dojah.client.ApiResponse;
import com.konfigthis.dojah.client.Configuration;
import com.konfigthis.dojah.client.Pair;
import com.konfigthis.dojah.client.ProgressRequestBody;
import com.konfigthis.dojah.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.konfigthis.dojah.client.model.GeneralGetNubanResponse;
import com.konfigthis.dojah.client.model.GetBanksResponse;
import com.konfigthis.dojah.client.model.GetBinResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.ws.rs.core.GenericType;

public class GeneralApiGenerated {
    private ApiClient localVarApiClient;
    private int localHostIndex;
    private String localCustomBaseUrl;

    public GeneralApiGenerated() throws IllegalArgumentException {
        this(Configuration.getDefaultApiClient());
    }

    public GeneralApiGenerated(ApiClient apiClient) throws IllegalArgumentException {
        if (apiClient.getAppIdAuth() == null) {
            throw new IllegalArgumentException("\"Appid\" is required but no API key was provided. Please set \"Appid\" with ApiClient#setAppIdAuth(String).");
        }
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public int getHostIndex() {
        return localHostIndex;
    }

    public void setHostIndex(int hostIndex) {
        this.localHostIndex = hostIndex;
    }

    public String getCustomBaseUrl() {
        return localCustomBaseUrl;
    }

    public void setCustomBaseUrl(String customBaseUrl) {
        this.localCustomBaseUrl = customBaseUrl;
    }

    private okhttp3.Call getBanksCall(final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/v1/general/banks";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "apikeyAuth", "appIdAuth" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call getBanksValidateBeforeCall(final ApiCallback _callback) throws ApiException {
        return getBanksCall(_callback);

    }


    private ApiResponse<GetBanksResponse> getBanksWithHttpInfo() throws ApiException {
        okhttp3.Call localVarCall = getBanksValidateBeforeCall(null);
        Type localVarReturnType = new TypeToken<GetBanksResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call getBanksAsync(final ApiCallback<GetBanksResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = getBanksValidateBeforeCall(_callback);
        Type localVarReturnType = new TypeToken<GetBanksResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class GetBanksRequestBuilder {

        private GetBanksRequestBuilder() {
        }

        /**
         * Build call for getBanks
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            return getBanksCall(_callback);
        }


        /**
         * Execute getBanks request
         * @return GetBanksResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public GetBanksResponse execute() throws ApiException {
            ApiResponse<GetBanksResponse> localVarResp = getBanksWithHttpInfo();
            return localVarResp.getResponseBody();
        }

        /**
         * Execute getBanks request with HTTP info returned
         * @return ApiResponse&lt;GetBanksResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public ApiResponse<GetBanksResponse> executeWithHttpInfo() throws ApiException {
            return getBanksWithHttpInfo();
        }

        /**
         * Execute getBanks request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<GetBanksResponse> _callback) throws ApiException {
            return getBanksAsync(_callback);
        }
    }

    /**
     * General - Get Banks
     * 
     * @return GetBanksRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
     </table>
     */
    public GetBanksRequestBuilder getBanks() throws IllegalArgumentException {
        return new GetBanksRequestBuilder();
    }
    private okhttp3.Call getBinCall(Integer cardBin, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/v1/general/bin";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        if (cardBin != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("card_bin", cardBin));
        }

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "apikeyAuth", "appIdAuth" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call getBinValidateBeforeCall(Integer cardBin, final ApiCallback _callback) throws ApiException {
        return getBinCall(cardBin, _callback);

    }


    private ApiResponse<GetBinResponse> getBinWithHttpInfo(Integer cardBin) throws ApiException {
        okhttp3.Call localVarCall = getBinValidateBeforeCall(cardBin, null);
        Type localVarReturnType = new TypeToken<GetBinResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call getBinAsync(Integer cardBin, final ApiCallback<GetBinResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = getBinValidateBeforeCall(cardBin, _callback);
        Type localVarReturnType = new TypeToken<GetBinResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class GetBinRequestBuilder {
        private Integer cardBin;

        private GetBinRequestBuilder() {
        }

        /**
         * Set cardBin
         * @param cardBin  (optional)
         * @return GetBinRequestBuilder
         */
        public GetBinRequestBuilder cardBin(Integer cardBin) {
            this.cardBin = cardBin;
            return this;
        }
        
        /**
         * Build call for getBin
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            return getBinCall(cardBin, _callback);
        }


        /**
         * Execute getBin request
         * @return GetBinResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public GetBinResponse execute() throws ApiException {
            ApiResponse<GetBinResponse> localVarResp = getBinWithHttpInfo(cardBin);
            return localVarResp.getResponseBody();
        }

        /**
         * Execute getBin request with HTTP info returned
         * @return ApiResponse&lt;GetBinResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public ApiResponse<GetBinResponse> executeWithHttpInfo() throws ApiException {
            return getBinWithHttpInfo(cardBin);
        }

        /**
         * Execute getBin request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<GetBinResponse> _callback) throws ApiException {
            return getBinAsync(cardBin, _callback);
        }
    }

    /**
     * General Resolve BIN
     * 
     * @return GetBinRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
     </table>
     */
    public GetBinRequestBuilder getBin() throws IllegalArgumentException {
        return new GetBinRequestBuilder();
    }
    private okhttp3.Call getNubanCall(Integer bankCode, Integer accountNumber, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/api/v1/general/account";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        if (bankCode != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("bank_code", bankCode));
        }

        if (accountNumber != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("account_number", accountNumber));
        }

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "apikeyAuth", "appIdAuth" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call getNubanValidateBeforeCall(Integer bankCode, Integer accountNumber, final ApiCallback _callback) throws ApiException {
        return getNubanCall(bankCode, accountNumber, _callback);

    }


    private ApiResponse<GeneralGetNubanResponse> getNubanWithHttpInfo(Integer bankCode, Integer accountNumber) throws ApiException {
        okhttp3.Call localVarCall = getNubanValidateBeforeCall(bankCode, accountNumber, null);
        Type localVarReturnType = new TypeToken<GeneralGetNubanResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call getNubanAsync(Integer bankCode, Integer accountNumber, final ApiCallback<GeneralGetNubanResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = getNubanValidateBeforeCall(bankCode, accountNumber, _callback);
        Type localVarReturnType = new TypeToken<GeneralGetNubanResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class GetNubanRequestBuilder {
        private Integer bankCode;
        private Integer accountNumber;

        private GetNubanRequestBuilder() {
        }

        /**
         * Set bankCode
         * @param bankCode  (optional)
         * @return GetNubanRequestBuilder
         */
        public GetNubanRequestBuilder bankCode(Integer bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        
        /**
         * Set accountNumber
         * @param accountNumber  (optional)
         * @return GetNubanRequestBuilder
         */
        public GetNubanRequestBuilder accountNumber(Integer accountNumber) {
            this.accountNumber = accountNumber;
            return this;
        }
        
        /**
         * Build call for getNuban
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            return getNubanCall(bankCode, accountNumber, _callback);
        }


        /**
         * Execute getNuban request
         * @return GeneralGetNubanResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public GeneralGetNubanResponse execute() throws ApiException {
            ApiResponse<GeneralGetNubanResponse> localVarResp = getNubanWithHttpInfo(bankCode, accountNumber);
            return localVarResp.getResponseBody();
        }

        /**
         * Execute getNuban request with HTTP info returned
         * @return ApiResponse&lt;GeneralGetNubanResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public ApiResponse<GeneralGetNubanResponse> executeWithHttpInfo() throws ApiException {
            return getNubanWithHttpInfo(bankCode, accountNumber);
        }

        /**
         * Execute getNuban request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<GeneralGetNubanResponse> _callback) throws ApiException {
            return getNubanAsync(bankCode, accountNumber, _callback);
        }
    }

    /**
     * General Resolve NUBAN
     * 
     * @return GetNubanRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  * X-Powered-By -  <br>  * Access-Control-Allow-Origin -  <br>  * Content-Length -  <br>  * ETag -  <br>  * Date -  <br>  * Connection -  <br>  </td></tr>
     </table>
     */
    public GetNubanRequestBuilder getNuban() throws IllegalArgumentException {
        return new GetNubanRequestBuilder();
    }
}
