/*
DOJAH Publilc APIs

Use Dojah to verify, onboard and manage user identity across Africa!

API version: 1.0.0
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package dojah

import (
	"bytes"
	"context"
	"io/ioutil"
	"net/http"
	"net/url"
)


// GeneralApiService GeneralApi service
type GeneralApiService service

type GeneralApiGetBanksRequest struct {
	ctx context.Context
	ApiService *GeneralApiService
	appId *string
}

func (r GeneralApiGetBanksRequest) AppId(appId string) GeneralApiGetBanksRequest {
	r.appId = &appId
	return r
}

func (r GeneralApiGetBanksRequest) Execute() (*GetBanksResponse, *http.Response, error) {
	return r.ApiService.GetBanksExecute(r)
}

/*
GetBanks General - Get Banks

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @return GeneralApiGetBanksRequest
*/
func (a *GeneralApiService) GetBanks() GeneralApiGetBanksRequest {
	return GeneralApiGetBanksRequest{
		ApiService: a,
		ctx: a.client.cfg.Context,
	}
}

// Execute executes the request
//  @return GetBanksResponse
func (a *GeneralApiService) GetBanksExecute(r GeneralApiGetBanksRequest) (*GetBanksResponse, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodGet
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  *GetBanksResponse
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "GeneralApiService.GetBanks")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/v1/general/banks"

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}

	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"application/json"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	if r.appId != nil {
		localVarHeaderParams["AppId"] = parameterToString(*r.appId, "")
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = ioutil.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}

type GeneralApiGetBinRequest struct {
	ctx context.Context
	ApiService *GeneralApiService
	appId *string
	cardBin *int32
}

func (r GeneralApiGetBinRequest) AppId(appId string) GeneralApiGetBinRequest {
	r.appId = &appId
	return r
}

func (r GeneralApiGetBinRequest) CardBin(cardBin int32) GeneralApiGetBinRequest {
	r.cardBin = &cardBin
	return r
}

func (r GeneralApiGetBinRequest) Execute() (*GetBinResponse, *http.Response, error) {
	return r.ApiService.GetBinExecute(r)
}

/*
GetBin General Resolve BIN

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @return GeneralApiGetBinRequest
*/
func (a *GeneralApiService) GetBin() GeneralApiGetBinRequest {
	return GeneralApiGetBinRequest{
		ApiService: a,
		ctx: a.client.cfg.Context,
	}
}

// Execute executes the request
//  @return GetBinResponse
func (a *GeneralApiService) GetBinExecute(r GeneralApiGetBinRequest) (*GetBinResponse, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodGet
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  *GetBinResponse
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "GeneralApiService.GetBin")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/v1/general/bin"

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}

	if r.cardBin != nil {
		localVarQueryParams.Add("card_bin", parameterToString(*r.cardBin, ""))
	}
	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"application/json"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	if r.appId != nil {
		localVarHeaderParams["AppId"] = parameterToString(*r.appId, "")
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = ioutil.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}

type GeneralApiGetNubanRequest struct {
	ctx context.Context
	ApiService *GeneralApiService
	appId *string
	bankCode *int32
	accountNumber *int32
}

func (r GeneralApiGetNubanRequest) AppId(appId string) GeneralApiGetNubanRequest {
	r.appId = &appId
	return r
}

func (r GeneralApiGetNubanRequest) BankCode(bankCode int32) GeneralApiGetNubanRequest {
	r.bankCode = &bankCode
	return r
}

func (r GeneralApiGetNubanRequest) AccountNumber(accountNumber int32) GeneralApiGetNubanRequest {
	r.accountNumber = &accountNumber
	return r
}

func (r GeneralApiGetNubanRequest) Execute() (*GeneralGetNubanResponse, *http.Response, error) {
	return r.ApiService.GetNubanExecute(r)
}

/*
GetNuban General Resolve NUBAN

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @return GeneralApiGetNubanRequest
*/
func (a *GeneralApiService) GetNuban() GeneralApiGetNubanRequest {
	return GeneralApiGetNubanRequest{
		ApiService: a,
		ctx: a.client.cfg.Context,
	}
}

// Execute executes the request
//  @return GeneralGetNubanResponse
func (a *GeneralApiService) GetNubanExecute(r GeneralApiGetNubanRequest) (*GeneralGetNubanResponse, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodGet
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  *GeneralGetNubanResponse
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "GeneralApiService.GetNuban")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/api/v1/general/account"

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}

	if r.bankCode != nil {
		localVarQueryParams.Add("bank_code", parameterToString(*r.bankCode, ""))
	}
	if r.accountNumber != nil {
		localVarQueryParams.Add("account_number", parameterToString(*r.accountNumber, ""))
	}
	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"application/json"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	if r.appId != nil {
		localVarHeaderParams["AppId"] = parameterToString(*r.appId, "")
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = ioutil.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}
