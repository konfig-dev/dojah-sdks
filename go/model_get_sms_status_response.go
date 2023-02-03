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

// GetSmsStatusResponse struct for GetSmsStatusResponse
type GetSmsStatusResponse struct {
	Entity *GetSmsStatusResponseEntity `json:"entity,omitempty"`
}

// NewGetSmsStatusResponse instantiates a new GetSmsStatusResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetSmsStatusResponse() *GetSmsStatusResponse {
	this := GetSmsStatusResponse{}
	return &this
}

// NewGetSmsStatusResponseWithDefaults instantiates a new GetSmsStatusResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetSmsStatusResponseWithDefaults() *GetSmsStatusResponse {
	this := GetSmsStatusResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetSmsStatusResponse) GetEntity() GetSmsStatusResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetSmsStatusResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetSmsStatusResponse) GetEntityOk() (*GetSmsStatusResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetSmsStatusResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetSmsStatusResponseEntity and assigns it to the Entity field.
func (o *GetSmsStatusResponse) SetEntity(v GetSmsStatusResponseEntity) {
	o.Entity = &v
}

func (o GetSmsStatusResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetSmsStatusResponse struct {
	value *GetSmsStatusResponse
	isSet bool
}

func (v NullableGetSmsStatusResponse) Get() *GetSmsStatusResponse {
	return v.value
}

func (v *NullableGetSmsStatusResponse) Set(val *GetSmsStatusResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetSmsStatusResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetSmsStatusResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetSmsStatusResponse(val *GetSmsStatusResponse) *NullableGetSmsStatusResponse {
	return &NullableGetSmsStatusResponse{value: val, isSet: true}
}

func (v NullableGetSmsStatusResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetSmsStatusResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


