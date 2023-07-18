/*
DOJAH Publilc APIs

Use Dojah to verify, onboard and manage user identity across Africa!

API version: 1.0.0
*/

// Code generated by Konfig (https://konfigthis.com); DO NOT EDIT.

package dojah

import (
	"encoding/json"
)

// GetKycDriversLicenseResponse struct for GetKycDriversLicenseResponse
type GetKycDriversLicenseResponse struct {
	Entity *GetKycDriversLicenseResponseEntity `json:"entity,omitempty"`
}

// NewGetKycDriversLicenseResponse instantiates a new GetKycDriversLicenseResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetKycDriversLicenseResponse() *GetKycDriversLicenseResponse {
	this := GetKycDriversLicenseResponse{}
	return &this
}

// NewGetKycDriversLicenseResponseWithDefaults instantiates a new GetKycDriversLicenseResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetKycDriversLicenseResponseWithDefaults() *GetKycDriversLicenseResponse {
	this := GetKycDriversLicenseResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponse) GetEntity() GetKycDriversLicenseResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetKycDriversLicenseResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponse) GetEntityOk() (*GetKycDriversLicenseResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetKycDriversLicenseResponseEntity and assigns it to the Entity field.
func (o *GetKycDriversLicenseResponse) SetEntity(v GetKycDriversLicenseResponseEntity) {
	o.Entity = &v
}

func (o GetKycDriversLicenseResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetKycDriversLicenseResponse struct {
	value *GetKycDriversLicenseResponse
	isSet bool
}

func (v NullableGetKycDriversLicenseResponse) Get() *GetKycDriversLicenseResponse {
	return v.value
}

func (v *NullableGetKycDriversLicenseResponse) Set(val *GetKycDriversLicenseResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetKycDriversLicenseResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetKycDriversLicenseResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetKycDriversLicenseResponse(val *GetKycDriversLicenseResponse) *NullableGetKycDriversLicenseResponse {
	return &NullableGetKycDriversLicenseResponse{value: val, isSet: true}
}

func (v NullableGetKycDriversLicenseResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetKycDriversLicenseResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


