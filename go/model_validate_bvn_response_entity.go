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

// ValidateBvnResponseEntity struct for ValidateBvnResponseEntity
type ValidateBvnResponseEntity struct {
	Bvn *ValidateBvnResponseEntityBvn `json:"bvn,omitempty"`
	FirstName *ValidateBvnResponseEntityFirstName `json:"first_name,omitempty"`
}

// NewValidateBvnResponseEntity instantiates a new ValidateBvnResponseEntity object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewValidateBvnResponseEntity() *ValidateBvnResponseEntity {
	this := ValidateBvnResponseEntity{}
	return &this
}

// NewValidateBvnResponseEntityWithDefaults instantiates a new ValidateBvnResponseEntity object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewValidateBvnResponseEntityWithDefaults() *ValidateBvnResponseEntity {
	this := ValidateBvnResponseEntity{}
	return &this
}

// GetBvn returns the Bvn field value if set, zero value otherwise.
func (o *ValidateBvnResponseEntity) GetBvn() ValidateBvnResponseEntityBvn {
	if o == nil || isNil(o.Bvn) {
		var ret ValidateBvnResponseEntityBvn
		return ret
	}
	return *o.Bvn
}

// GetBvnOk returns a tuple with the Bvn field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ValidateBvnResponseEntity) GetBvnOk() (*ValidateBvnResponseEntityBvn, bool) {
	if o == nil || isNil(o.Bvn) {
    return nil, false
	}
	return o.Bvn, true
}

// HasBvn returns a boolean if a field has been set.
func (o *ValidateBvnResponseEntity) HasBvn() bool {
	if o != nil && !isNil(o.Bvn) {
		return true
	}

	return false
}

// SetBvn gets a reference to the given ValidateBvnResponseEntityBvn and assigns it to the Bvn field.
func (o *ValidateBvnResponseEntity) SetBvn(v ValidateBvnResponseEntityBvn) {
	o.Bvn = &v
}

// GetFirstName returns the FirstName field value if set, zero value otherwise.
func (o *ValidateBvnResponseEntity) GetFirstName() ValidateBvnResponseEntityFirstName {
	if o == nil || isNil(o.FirstName) {
		var ret ValidateBvnResponseEntityFirstName
		return ret
	}
	return *o.FirstName
}

// GetFirstNameOk returns a tuple with the FirstName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ValidateBvnResponseEntity) GetFirstNameOk() (*ValidateBvnResponseEntityFirstName, bool) {
	if o == nil || isNil(o.FirstName) {
    return nil, false
	}
	return o.FirstName, true
}

// HasFirstName returns a boolean if a field has been set.
func (o *ValidateBvnResponseEntity) HasFirstName() bool {
	if o != nil && !isNil(o.FirstName) {
		return true
	}

	return false
}

// SetFirstName gets a reference to the given ValidateBvnResponseEntityFirstName and assigns it to the FirstName field.
func (o *ValidateBvnResponseEntity) SetFirstName(v ValidateBvnResponseEntityFirstName) {
	o.FirstName = &v
}

func (o ValidateBvnResponseEntity) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Bvn) {
		toSerialize["bvn"] = o.Bvn
	}
	if !isNil(o.FirstName) {
		toSerialize["first_name"] = o.FirstName
	}
	return json.Marshal(toSerialize)
}

type NullableValidateBvnResponseEntity struct {
	value *ValidateBvnResponseEntity
	isSet bool
}

func (v NullableValidateBvnResponseEntity) Get() *ValidateBvnResponseEntity {
	return v.value
}

func (v *NullableValidateBvnResponseEntity) Set(val *ValidateBvnResponseEntity) {
	v.value = val
	v.isSet = true
}

func (v NullableValidateBvnResponseEntity) IsSet() bool {
	return v.isSet
}

func (v *NullableValidateBvnResponseEntity) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableValidateBvnResponseEntity(val *ValidateBvnResponseEntity) *NullableValidateBvnResponseEntity {
	return &NullableValidateBvnResponseEntity{value: val, isSet: true}
}

func (v NullableValidateBvnResponseEntity) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableValidateBvnResponseEntity) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


