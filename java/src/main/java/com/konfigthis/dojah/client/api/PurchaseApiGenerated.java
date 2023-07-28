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


import com.konfigthis.dojah.client.model.PurchaseAirtimeRequest;
import com.konfigthis.dojah.client.model.PurchaseAirtimeResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.ws.rs.core.GenericType;

public class PurchaseApiGenerated {
    private ApiClient localVarApiClient;
    private int localHostIndex;
    private String localCustomBaseUrl;

    public PurchaseApiGenerated() throws IllegalArgumentException {
        this(Configuration.getDefaultApiClient());
    }

    public PurchaseApiGenerated(ApiClient apiClient) throws IllegalArgumentException {
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

    private okhttp3.Call sendAirtimeCall(PurchaseAirtimeRequest purchaseAirtimeRequest, final ApiCallback _callback) throws ApiException {
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

        Object localVarPostBody = purchaseAirtimeRequest;

        // create path and map variables
        String localVarPath = "/v1/purchase/airtime";

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
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "appIdAuth", "noauthAuth" };
        return localVarApiClient.buildCall(basePath, localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call sendAirtimeValidateBeforeCall(PurchaseAirtimeRequest purchaseAirtimeRequest, final ApiCallback _callback) throws ApiException {
        // verify the required parameter 'purchaseAirtimeRequest' is set
        if (purchaseAirtimeRequest == null) {
            throw new ApiException("Missing the required parameter 'purchaseAirtimeRequest' when calling sendAirtime(Async)");
        }

        return sendAirtimeCall(purchaseAirtimeRequest, _callback);

    }


    private ApiResponse<PurchaseAirtimeResponse> sendAirtimeWithHttpInfo(PurchaseAirtimeRequest purchaseAirtimeRequest) throws ApiException {
        okhttp3.Call localVarCall = sendAirtimeValidateBeforeCall(purchaseAirtimeRequest, null);
        Type localVarReturnType = new TypeToken<PurchaseAirtimeResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    private okhttp3.Call sendAirtimeAsync(PurchaseAirtimeRequest purchaseAirtimeRequest, final ApiCallback<PurchaseAirtimeResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = sendAirtimeValidateBeforeCall(purchaseAirtimeRequest, _callback);
        Type localVarReturnType = new TypeToken<PurchaseAirtimeResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }

    public class SendAirtimeRequestBuilder {
        private String destination;
        private String amount;

        private SendAirtimeRequestBuilder() {
        }

        /**
         * Set destination
         * @param destination  (optional)
         * @return SendAirtimeRequestBuilder
         */
        public SendAirtimeRequestBuilder destination(String destination) {
            this.destination = destination;
            return this;
        }
        
        /**
         * Set amount
         * @param amount  (optional)
         * @return SendAirtimeRequestBuilder
         */
        public SendAirtimeRequestBuilder amount(String amount) {
            this.amount = amount;
            return this;
        }
        
        /**
         * Build call for sendAirtime
         * @param _callback ApiCallback API callback
         * @return Call to execute
         * @throws ApiException If fail to serialize the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * Date -  <br>  * Transfer-Encoding -  <br>  * Connection -  <br>  * access-control-allow-origin -  <br>  * x-moesif-transaction-id -  <br>  * etag -  <br>  * vary -  <br>  * CF-Cache-Status -  <br>  * Expect-CT -  <br>  * Report-To -  <br>  * NEL -  <br>  * Server -  <br>  * CF-RAY -  <br>  * Content-Encoding -  <br>  * alt-svc -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call buildCall(final ApiCallback _callback) throws ApiException {
            PurchaseAirtimeRequest purchaseAirtimeRequest = buildBodyParams();
            return sendAirtimeCall(purchaseAirtimeRequest, _callback);
        }

        private PurchaseAirtimeRequest buildBodyParams() {
            PurchaseAirtimeRequest purchaseAirtimeRequest = new PurchaseAirtimeRequest();
            purchaseAirtimeRequest.destination(this.destination);
            purchaseAirtimeRequest.amount(this.amount);
            return purchaseAirtimeRequest;
        }

        /**
         * Execute sendAirtime request
         * @return PurchaseAirtimeResponse
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * Date -  <br>  * Transfer-Encoding -  <br>  * Connection -  <br>  * access-control-allow-origin -  <br>  * x-moesif-transaction-id -  <br>  * etag -  <br>  * vary -  <br>  * CF-Cache-Status -  <br>  * Expect-CT -  <br>  * Report-To -  <br>  * NEL -  <br>  * Server -  <br>  * CF-RAY -  <br>  * Content-Encoding -  <br>  * alt-svc -  <br>  </td></tr>
         </table>
         */
        public PurchaseAirtimeResponse execute() throws ApiException {
            PurchaseAirtimeRequest purchaseAirtimeRequest = buildBodyParams();
            ApiResponse<PurchaseAirtimeResponse> localVarResp = sendAirtimeWithHttpInfo(purchaseAirtimeRequest);
            return localVarResp.getResponseBody();
        }

        /**
         * Execute sendAirtime request with HTTP info returned
         * @return ApiResponse&lt;PurchaseAirtimeResponse&gt;
         * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * Date -  <br>  * Transfer-Encoding -  <br>  * Connection -  <br>  * access-control-allow-origin -  <br>  * x-moesif-transaction-id -  <br>  * etag -  <br>  * vary -  <br>  * CF-Cache-Status -  <br>  * Expect-CT -  <br>  * Report-To -  <br>  * NEL -  <br>  * Server -  <br>  * CF-RAY -  <br>  * Content-Encoding -  <br>  * alt-svc -  <br>  </td></tr>
         </table>
         */
        public ApiResponse<PurchaseAirtimeResponse> executeWithHttpInfo() throws ApiException {
            PurchaseAirtimeRequest purchaseAirtimeRequest = buildBodyParams();
            return sendAirtimeWithHttpInfo(purchaseAirtimeRequest);
        }

        /**
         * Execute sendAirtime request (asynchronously)
         * @param _callback The callback to be executed when the API call finishes
         * @return The request call
         * @throws ApiException If fail to process the API call, e.g. serializing the request body object
         * @http.response.details
         <table summary="Response Details" border="1">
            <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
            <tr><td> 200 </td><td> OK </td><td>  * Date -  <br>  * Transfer-Encoding -  <br>  * Connection -  <br>  * access-control-allow-origin -  <br>  * x-moesif-transaction-id -  <br>  * etag -  <br>  * vary -  <br>  * CF-Cache-Status -  <br>  * Expect-CT -  <br>  * Report-To -  <br>  * NEL -  <br>  * Server -  <br>  * CF-RAY -  <br>  * Content-Encoding -  <br>  * alt-svc -  <br>  </td></tr>
         </table>
         */
        public okhttp3.Call executeAsync(final ApiCallback<PurchaseAirtimeResponse> _callback) throws ApiException {
            PurchaseAirtimeRequest purchaseAirtimeRequest = buildBodyParams();
            return sendAirtimeAsync(purchaseAirtimeRequest, _callback);
        }
    }

    /**
     * Purchase - Send Airtime
     * 
     * @param purchaseAirtimeRequest  (required)
     * @return SendAirtimeRequestBuilder
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  * Date -  <br>  * Transfer-Encoding -  <br>  * Connection -  <br>  * access-control-allow-origin -  <br>  * x-moesif-transaction-id -  <br>  * etag -  <br>  * vary -  <br>  * CF-Cache-Status -  <br>  * Expect-CT -  <br>  * Report-To -  <br>  * NEL -  <br>  * Server -  <br>  * CF-RAY -  <br>  * Content-Encoding -  <br>  * alt-svc -  <br>  </td></tr>
     </table>
     */
    public SendAirtimeRequestBuilder sendAirtime() throws IllegalArgumentException {
        return new SendAirtimeRequestBuilder();
    }
}
