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

// GetSsnitResponse struct for GetSsnitResponse
type GetSsnitResponse struct {
	Entity *GetSsnitResponseEntity `json:"entity,omitempty"`
}

// NewGetSsnitResponse instantiates a new GetSsnitResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetSsnitResponse() *GetSsnitResponse {
	this := GetSsnitResponse{}
	return &this
}

// NewGetSsnitResponseWithDefaults instantiates a new GetSsnitResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetSsnitResponseWithDefaults() *GetSsnitResponse {
	this := GetSsnitResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetSsnitResponse) GetEntity() GetSsnitResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetSsnitResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetSsnitResponse) GetEntityOk() (*GetSsnitResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetSsnitResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetSsnitResponseEntity and assigns it to the Entity field.
func (o *GetSsnitResponse) SetEntity(v GetSsnitResponseEntity) {
	o.Entity = &v
}

func (o GetSsnitResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetSsnitResponse struct {
	value *GetSsnitResponse
	isSet bool
}

func (v NullableGetSsnitResponse) Get() *GetSsnitResponse {
	return v.value
}

func (v *NullableGetSsnitResponse) Set(val *GetSsnitResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetSsnitResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetSsnitResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetSsnitResponse(val *GetSsnitResponse) *NullableGetSsnitResponse {
	return &NullableGetSsnitResponse{value: val, isSet: true}
}

func (v NullableGetSsnitResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetSsnitResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


