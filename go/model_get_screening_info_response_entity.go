/*
DOJAH APIs

Use Dojah to verify, onboard and manage user identity across Africa!

API version: 1.0.0
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package dojah

import (
	"encoding/json"
)

// GetScreeningInfoResponseEntity struct for GetScreeningInfoResponseEntity
type GetScreeningInfoResponseEntity struct {
	Result *GetScreeningInfoResponseEntityResult `json:"result,omitempty"`
	Uuid *string `json:"uuid,omitempty"`
}

// NewGetScreeningInfoResponseEntity instantiates a new GetScreeningInfoResponseEntity object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetScreeningInfoResponseEntity() *GetScreeningInfoResponseEntity {
	this := GetScreeningInfoResponseEntity{}
	return &this
}

// NewGetScreeningInfoResponseEntityWithDefaults instantiates a new GetScreeningInfoResponseEntity object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetScreeningInfoResponseEntityWithDefaults() *GetScreeningInfoResponseEntity {
	this := GetScreeningInfoResponseEntity{}
	return &this
}

// GetResult returns the Result field value if set, zero value otherwise.
func (o *GetScreeningInfoResponseEntity) GetResult() GetScreeningInfoResponseEntityResult {
	if o == nil || isNil(o.Result) {
		var ret GetScreeningInfoResponseEntityResult
		return ret
	}
	return *o.Result
}

// GetResultOk returns a tuple with the Result field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetScreeningInfoResponseEntity) GetResultOk() (*GetScreeningInfoResponseEntityResult, bool) {
	if o == nil || isNil(o.Result) {
    return nil, false
	}
	return o.Result, true
}

// HasResult returns a boolean if a field has been set.
func (o *GetScreeningInfoResponseEntity) HasResult() bool {
	if o != nil && !isNil(o.Result) {
		return true
	}

	return false
}

// SetResult gets a reference to the given GetScreeningInfoResponseEntityResult and assigns it to the Result field.
func (o *GetScreeningInfoResponseEntity) SetResult(v GetScreeningInfoResponseEntityResult) {
	o.Result = &v
}

// GetUuid returns the Uuid field value if set, zero value otherwise.
func (o *GetScreeningInfoResponseEntity) GetUuid() string {
	if o == nil || isNil(o.Uuid) {
		var ret string
		return ret
	}
	return *o.Uuid
}

// GetUuidOk returns a tuple with the Uuid field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetScreeningInfoResponseEntity) GetUuidOk() (*string, bool) {
	if o == nil || isNil(o.Uuid) {
    return nil, false
	}
	return o.Uuid, true
}

// HasUuid returns a boolean if a field has been set.
func (o *GetScreeningInfoResponseEntity) HasUuid() bool {
	if o != nil && !isNil(o.Uuid) {
		return true
	}

	return false
}

// SetUuid gets a reference to the given string and assigns it to the Uuid field.
func (o *GetScreeningInfoResponseEntity) SetUuid(v string) {
	o.Uuid = &v
}

func (o GetScreeningInfoResponseEntity) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Result) {
		toSerialize["result"] = o.Result
	}
	if !isNil(o.Uuid) {
		toSerialize["uuid"] = o.Uuid
	}
	return json.Marshal(toSerialize)
}

type NullableGetScreeningInfoResponseEntity struct {
	value *GetScreeningInfoResponseEntity
	isSet bool
}

func (v NullableGetScreeningInfoResponseEntity) Get() *GetScreeningInfoResponseEntity {
	return v.value
}

func (v *NullableGetScreeningInfoResponseEntity) Set(val *GetScreeningInfoResponseEntity) {
	v.value = val
	v.isSet = true
}

func (v NullableGetScreeningInfoResponseEntity) IsSet() bool {
	return v.isSet
}

func (v *NullableGetScreeningInfoResponseEntity) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetScreeningInfoResponseEntity(val *GetScreeningInfoResponseEntity) *NullableGetScreeningInfoResponseEntity {
	return &NullableGetScreeningInfoResponseEntity{value: val, isSet: true}
}

func (v NullableGetScreeningInfoResponseEntity) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetScreeningInfoResponseEntity) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


