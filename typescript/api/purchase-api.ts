/* tslint:disable */
/* eslint-disable */
/**
 * DOJAH Publilc APIs
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This file is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */

import globalAxios, { AxiosPromise, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { DUMMY_BASE_URL, assertParamExists, setApiKeyToObject, setBasicAuthToObject, setBearerAuthToObject, setSearchParams, serializeDataIfNeeded, toPathString, createRequestFunction, isBrowser } from '../common';
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
// @ts-ignore
import { PurchaseAirtimeRequest } from '../models';
// @ts-ignore
import { PurchaseAirtimeResponse } from '../models';
import { paginate } from "../pagination/paginate";
import { requestBeforeHook } from '../requestBeforeHook';
import { PurchaseApiCustom } from "./purchase-api-custom";
/**
 * PurchaseApi - axios parameter creator
 * @export
 */
export const PurchaseApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @summary Purchase - Send Airtime
         * @param {PurchaseAirtimeRequest} purchaseAirtimeRequest 
         * @param {string} [appId] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        sendAirtime: async (purchaseAirtimeRequest: PurchaseAirtimeRequest, appId?: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'purchaseAirtimeRequest' is not null or undefined
            assertParamExists('sendAirtime', 'purchaseAirtimeRequest', purchaseAirtimeRequest)
            const localVarPath = `/v1/purchase/airtime`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication noauthAuth required
            if (appId != null) {
                localVarHeaderParameter['AppId'] = String(appId);
            }


    
            localVarHeaderParameter['Content-Type'] = 'application/json';

            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: purchaseAirtimeRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(purchaseAirtimeRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * PurchaseApi - functional programming interface
 * @export
 */
export const PurchaseApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = PurchaseApiAxiosParamCreator(configuration)
    return {
        /**
         * 
         * @summary Purchase - Send Airtime
         * @param {PurchaseApiSendAirtimeRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async sendAirtime(requestParameters: PurchaseApiSendAirtimeRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<PurchaseAirtimeResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.sendAirtime(requestParameters, requestParameters.appId, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * PurchaseApi - factory interface
 * @export
 */
export const PurchaseApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = PurchaseApiFp(configuration)
    return {
        /**
         * 
         * @summary Purchase - Send Airtime
         * @param {PurchaseApiSendAirtimeRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        sendAirtime(requestParameters: PurchaseApiSendAirtimeRequest, options?: AxiosRequestConfig): AxiosPromise<PurchaseAirtimeResponse> {
            return localVarFp.sendAirtime(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for sendAirtime operation in PurchaseApi.
 * @export
 * @interface PurchaseApiSendAirtimeRequest
 */
export type PurchaseApiSendAirtimeRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof PurchaseApiSendAirtime
    */
    readonly appId?: string
    
} & PurchaseAirtimeRequest

/**
 * PurchaseApi - object-oriented interface
 * @export
 * @class PurchaseApi
 * @extends {BaseAPI}
 */
export class PurchaseApi extends PurchaseApiCustom {
    /**
     * 
     * @summary Purchase - Send Airtime
     * @param {PurchaseApiSendAirtimeRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof PurchaseApi
     */
    public sendAirtime(requestParameters: PurchaseApiSendAirtimeRequest, options?: AxiosRequestConfig) {
        return PurchaseApiFp(this.configuration).sendAirtime(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
