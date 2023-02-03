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

// CategorizeTransactionsResponse struct for CategorizeTransactionsResponse
type CategorizeTransactionsResponse struct {
	Entity *CategorizeTransactionsResponseEntity `json:"entity,omitempty"`
}

// NewCategorizeTransactionsResponse instantiates a new CategorizeTransactionsResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCategorizeTransactionsResponse() *CategorizeTransactionsResponse {
	this := CategorizeTransactionsResponse{}
	return &this
}

// NewCategorizeTransactionsResponseWithDefaults instantiates a new CategorizeTransactionsResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCategorizeTransactionsResponseWithDefaults() *CategorizeTransactionsResponse {
	this := CategorizeTransactionsResponse{}
	return &this
}

// GetEntity returns the Entity field value if set, zero value otherwise.
func (o *CategorizeTransactionsResponse) GetEntity() CategorizeTransactionsResponseEntity {
	if o == nil || isNil(o.Entity) {
		var ret CategorizeTransactionsResponseEntity
		return ret
	}
	return *o.Entity
}

// GetEntityOk returns a tuple with the Entity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CategorizeTransactionsResponse) GetEntityOk() (*CategorizeTransactionsResponseEntity, bool) {
	if o == nil || isNil(o.Entity) {
    return nil, false
	}
	return o.Entity, true
}

// HasEntity returns a boolean if a field has been set.
func (o *CategorizeTransactionsResponse) HasEntity() bool {
	if o != nil && !isNil(o.Entity) {
		return true
	}

	return false
}

// SetEntity gets a reference to the given CategorizeTransactionsResponseEntity and assigns it to the Entity field.
func (o *CategorizeTransactionsResponse) SetEntity(v CategorizeTransactionsResponseEntity) {
	o.Entity = &v
}

func (o CategorizeTransactionsResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Entity) {
		toSerialize["entity"] = o.Entity
	}
	return json.Marshal(toSerialize)
}

type NullableCategorizeTransactionsResponse struct {
	value *CategorizeTransactionsResponse
	isSet bool
}

func (v NullableCategorizeTransactionsResponse) Get() *CategorizeTransactionsResponse {
	return v.value
}

func (v *NullableCategorizeTransactionsResponse) Set(val *CategorizeTransactionsResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableCategorizeTransactionsResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableCategorizeTransactionsResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCategorizeTransactionsResponse(val *CategorizeTransactionsResponse) *NullableCategorizeTransactionsResponse {
	return &NullableCategorizeTransactionsResponse{value: val, isSet: true}
}

func (v NullableCategorizeTransactionsResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCategorizeTransactionsResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


