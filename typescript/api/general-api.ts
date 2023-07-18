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
import { GeneralGetNubanResponse } from '../models';
// @ts-ignore
import { GetBanksResponse } from '../models';
// @ts-ignore
import { GetBinResponse } from '../models';
import { paginate } from "../pagination/paginate";
import { requestBeforeHook } from '../requestBeforeHook';
import { GeneralApiCustom } from "./general-api-custom";
/**
 * GeneralApi - axios parameter creator
 * @export
 */
export const GeneralApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * 
         * @summary General - Get Banks
         * @param {string} [appId] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getBanks: async (appId?: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/v1/general/banks`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apikeyAuth required
            if (appId != null) {
                localVarHeaderParameter['AppId'] = String(appId);
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary General Resolve BIN
         * @param {string} [appId] 
         * @param {number} [cardBin] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getBin: async (appId?: string, cardBin?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/v1/general/bin`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apikeyAuth required
            if (cardBin !== undefined) {
                localVarQueryParameter['card_bin'] = cardBin;
            }

            if (appId != null) {
                localVarHeaderParameter['AppId'] = String(appId);
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary General Resolve NUBAN
         * @param {string} [appId] 
         * @param {number} [bankCode] 
         * @param {number} [accountNumber] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getNuban: async (appId?: string, bankCode?: number, accountNumber?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/api/v1/general/account`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apikeyAuth required
            if (bankCode !== undefined) {
                localVarQueryParameter['bank_code'] = bankCode;
            }

            if (accountNumber !== undefined) {
                localVarQueryParameter['account_number'] = accountNumber;
            }

            if (appId != null) {
                localVarHeaderParameter['AppId'] = String(appId);
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * GeneralApi - functional programming interface
 * @export
 */
export const GeneralApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = GeneralApiAxiosParamCreator(configuration)
    return {
        /**
         * 
         * @summary General - Get Banks
         * @param {GeneralApiGetBanksRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getBanks(requestParameters: GeneralApiGetBanksRequest = {}, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<GetBanksResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getBanks(requestParameters.appId, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary General Resolve BIN
         * @param {GeneralApiGetBinRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getBin(requestParameters: GeneralApiGetBinRequest = {}, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<GetBinResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getBin(requestParameters.appId, requestParameters.cardBin, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * 
         * @summary General Resolve NUBAN
         * @param {GeneralApiGetNubanRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async getNuban(requestParameters: GeneralApiGetNubanRequest = {}, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<GeneralGetNubanResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.getNuban(requestParameters.appId, requestParameters.bankCode, requestParameters.accountNumber, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * GeneralApi - factory interface
 * @export
 */
export const GeneralApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = GeneralApiFp(configuration)
    return {
        /**
         * 
         * @summary General - Get Banks
         * @param {GeneralApiGetBanksRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getBanks(requestParameters: GeneralApiGetBanksRequest = {}, options?: AxiosRequestConfig): AxiosPromise<GetBanksResponse> {
            return localVarFp.getBanks(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary General Resolve BIN
         * @param {GeneralApiGetBinRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getBin(requestParameters: GeneralApiGetBinRequest = {}, options?: AxiosRequestConfig): AxiosPromise<GetBinResponse> {
            return localVarFp.getBin(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary General Resolve NUBAN
         * @param {GeneralApiGetNubanRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        getNuban(requestParameters: GeneralApiGetNubanRequest = {}, options?: AxiosRequestConfig): AxiosPromise<GeneralGetNubanResponse> {
            return localVarFp.getNuban(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for getBanks operation in GeneralApi.
 * @export
 * @interface GeneralApiGetBanksRequest
 */
export type GeneralApiGetBanksRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof GeneralApiGetBanks
    */
    readonly appId?: string
    
}

/**
 * Request parameters for getBin operation in GeneralApi.
 * @export
 * @interface GeneralApiGetBinRequest
 */
export type GeneralApiGetBinRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof GeneralApiGetBin
    */
    readonly appId?: string
    
    /**
    * 
    * @type {number}
    * @memberof GeneralApiGetBin
    */
    readonly cardBin?: number
    
}

/**
 * Request parameters for getNuban operation in GeneralApi.
 * @export
 * @interface GeneralApiGetNubanRequest
 */
export type GeneralApiGetNubanRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof GeneralApiGetNuban
    */
    readonly appId?: string
    
    /**
    * 
    * @type {number}
    * @memberof GeneralApiGetNuban
    */
    readonly bankCode?: number
    
    /**
    * 
    * @type {number}
    * @memberof GeneralApiGetNuban
    */
    readonly accountNumber?: number
    
}

/**
 * GeneralApi - object-oriented interface
 * @export
 * @class GeneralApi
 * @extends {BaseAPI}
 */
export class GeneralApi extends GeneralApiCustom {
    /**
     * 
     * @summary General - Get Banks
     * @param {GeneralApiGetBanksRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof GeneralApi
     */
    public getBanks(requestParameters: GeneralApiGetBanksRequest = {}, options?: AxiosRequestConfig) {
        return GeneralApiFp(this.configuration).getBanks(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary General Resolve BIN
     * @param {GeneralApiGetBinRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof GeneralApi
     */
    public getBin(requestParameters: GeneralApiGetBinRequest = {}, options?: AxiosRequestConfig) {
        return GeneralApiFp(this.configuration).getBin(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * 
     * @summary General Resolve NUBAN
     * @param {GeneralApiGetNubanRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof GeneralApi
     */
    public getNuban(requestParameters: GeneralApiGetNubanRequest = {}, options?: AxiosRequestConfig) {
        return GeneralApiFp(this.configuration).getNuban(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
