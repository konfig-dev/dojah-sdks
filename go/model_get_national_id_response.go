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

// GetNationalIdResponse struct for GetNationalIdResponse
type GetNationalIdResponse struct {
	Entity *GetNationalIdResponseEntity `json:"entity,omitempty"`
}

// NewGetNationalIdResponse instantiates a new GetNationalIdResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetNationalIdResponse() *GetNationalIdResponse {
	this := GetNationalIdResponse{}
	return &this
}

// NewGetNationalIdResponseWithDefaults instantiates a new GetNationalIdResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetNationalIdResponseWithDefaults() *GetNationalIdResponse {
	this := GetNationalIdResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetNationalIdResponse) GetEntity() GetNationalIdResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetNationalIdResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNationalIdResponse) GetEntityOk() (*GetNationalIdResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetNationalIdResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetNationalIdResponseEntity and assigns it to the Entity field.
func (o *GetNationalIdResponse) SetEntity(v GetNationalIdResponseEntity) {
	o.Entity = &v
}

func (o GetNationalIdResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetNationalIdResponse struct {
	value *GetNationalIdResponse
	isSet bool
}

func (v NullableGetNationalIdResponse) Get() *GetNationalIdResponse {
	return v.value
}

func (v *NullableGetNationalIdResponse) Set(val *GetNationalIdResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetNationalIdResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetNationalIdResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetNationalIdResponse(val *GetNationalIdResponse) *NullableGetNationalIdResponse {
	return &NullableGetNationalIdResponse{value: val, isSet: true}
}

func (v NullableGetNationalIdResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetNationalIdResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


