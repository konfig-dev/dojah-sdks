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

// GetGenericOcrTextResponse struct for GetGenericOcrTextResponse
type GetGenericOcrTextResponse struct {
	Entity *GetOcrTextResponseEntity `json:"entity,omitempty"`
}

// NewGetGenericOcrTextResponse instantiates a new GetGenericOcrTextResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetGenericOcrTextResponse() *GetGenericOcrTextResponse {
	this := GetGenericOcrTextResponse{}
	return &this
}

// NewGetGenericOcrTextResponseWithDefaults instantiates a new GetGenericOcrTextResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetGenericOcrTextResponseWithDefaults() *GetGenericOcrTextResponse {
	this := GetGenericOcrTextResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *GetGenericOcrTextResponse) GetEntity() GetOcrTextResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret GetOcrTextResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetGenericOcrTextResponse) GetEntityOk() (*GetOcrTextResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *GetGenericOcrTextResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given GetOcrTextResponseEntity and assigns it to the Entity field.
func (o *GetGenericOcrTextResponse) SetEntity(v GetOcrTextResponseEntity) {
	o.Entity = &v
}

func (o GetGenericOcrTextResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableGetGenericOcrTextResponse struct {
	value *GetGenericOcrTextResponse
	isSet bool
}

func (v NullableGetGenericOcrTextResponse) Get() *GetGenericOcrTextResponse {
	return v.value
}

func (v *NullableGetGenericOcrTextResponse) Set(val *GetGenericOcrTextResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetGenericOcrTextResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetGenericOcrTextResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetGenericOcrTextResponse(val *GetGenericOcrTextResponse) *NullableGetGenericOcrTextResponse {
	return &NullableGetGenericOcrTextResponse{value: val, isSet: true}
}

func (v NullableGetGenericOcrTextResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetGenericOcrTextResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


