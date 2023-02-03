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

// VerifyPhotoIdWithSelfieResponse struct for VerifyPhotoIdWithSelfieResponse
type VerifyPhotoIdWithSelfieResponse struct {
	Entity *VerifyPhotoIdWithSelfieResponseEntity `json:"entity,omitempty"`
}

// NewVerifyPhotoIdWithSelfieResponse instantiates a new VerifyPhotoIdWithSelfieResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewVerifyPhotoIdWithSelfieResponse() *VerifyPhotoIdWithSelfieResponse {
	this := VerifyPhotoIdWithSelfieResponse{}
	return &this
}

// NewVerifyPhotoIdWithSelfieResponseWithDefaults instantiates a new VerifyPhotoIdWithSelfieResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewVerifyPhotoIdWithSelfieResponseWithDefaults() *VerifyPhotoIdWithSelfieResponse {
	this := VerifyPhotoIdWithSelfieResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *VerifyPhotoIdWithSelfieResponse) GetEntity() VerifyPhotoIdWithSelfieResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret VerifyPhotoIdWithSelfieResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *VerifyPhotoIdWithSelfieResponse) GetEntityOk() (*VerifyPhotoIdWithSelfieResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *VerifyPhotoIdWithSelfieResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given VerifyPhotoIdWithSelfieResponseEntity and assigns it to the Entity field.
func (o *VerifyPhotoIdWithSelfieResponse) SetEntity(v VerifyPhotoIdWithSelfieResponseEntity) {
	o.Entity = &v
}

func (o VerifyPhotoIdWithSelfieResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableVerifyPhotoIdWithSelfieResponse struct {
	value *VerifyPhotoIdWithSelfieResponse
	isSet bool
}

func (v NullableVerifyPhotoIdWithSelfieResponse) Get() *VerifyPhotoIdWithSelfieResponse {
	return v.value
}

func (v *NullableVerifyPhotoIdWithSelfieResponse) Set(val *VerifyPhotoIdWithSelfieResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableVerifyPhotoIdWithSelfieResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableVerifyPhotoIdWithSelfieResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableVerifyPhotoIdWithSelfieResponse(val *VerifyPhotoIdWithSelfieResponse) *NullableVerifyPhotoIdWithSelfieResponse {
	return &NullableVerifyPhotoIdWithSelfieResponse{value: val, isSet: true}
}

func (v NullableVerifyPhotoIdWithSelfieResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableVerifyPhotoIdWithSelfieResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


