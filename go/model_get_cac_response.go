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

// GetCacResponse struct for GetCacResponse
type GetCacResponse struct {
	Entity *GetCacResponseEntity `json:"entity,omitempty"`
}

// NewGetCacResponse instantiates a new GetCacResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetCacResponse() *GetCacResponse {
	this := GetCacResponse{}
	return &this
}

// NewGetCacResponseWithDefaults instantiates a new GetCacResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetCacResponseWithDefaults() *GetCacResponse {
	this := GetCacResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetCacResponse) GetEntity() GetCacResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetCacResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetCacResponse) GetEntityOk() (*GetCacResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetCacResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetCacResponseEntity and assigns it to the Entity field.
func (o *GetCacResponse) SetEntity(v GetCacResponseEntity) {
	o.Entity = &v
}

func (o GetCacResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetCacResponse struct {
	value *GetCacResponse
	isSet bool
}

func (v NullableGetCacResponse) Get() *GetCacResponse {
	return v.value
}

func (v *NullableGetCacResponse) Set(val *GetCacResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetCacResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetCacResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetCacResponse(val *GetCacResponse) *NullableGetCacResponse {
	return &NullableGetCacResponse{value: val, isSet: true}
}

func (v NullableGetCacResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetCacResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


