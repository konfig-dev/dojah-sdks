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

// GetKycDriversLicenseResponseEntity struct for GetKycDriversLicenseResponseEntity
type GetKycDriversLicenseResponseEntity struct {
	PersonalDetails *GetKycDriversLicenseResponseEntityPersonalDetails `json:"personal_details,omitempty"`
}

// NewGetKycDriversLicenseResponseEntity instantiates a new GetKycDriversLicenseResponseEntity object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetKycDriversLicenseResponseEntity() *GetKycDriversLicenseResponseEntity {
	this := GetKycDriversLicenseResponseEntity{}
	return &this
}

// NewGetKycDriversLicenseResponseEntityWithDefaults instantiates a new GetKycDriversLicenseResponseEntity object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetKycDriversLicenseResponseEntityWithDefaults() *GetKycDriversLicenseResponseEntity {
	this := GetKycDriversLicenseResponseEntity{}
	return &this
}

// GetPersonalDetails returns the PersonalDetails field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntity) GetPersonalDetails() GetKycDriversLicenseResponseEntityPersonalDetails {
	if o == nil || isNil(o.PersonalDetails) {
		var ret GetKycDriversLicenseResponseEntityPersonalDetails
		return ret
	}
	return *o.PersonalDetails
}

// GetPersonalDetailsOk returns a tuple with the PersonalDetails field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntity) GetPersonalDetailsOk() (*GetKycDriversLicenseResponseEntityPersonalDetails, bool) {
	if o == nil || isNil(o.PersonalDetails) {
    return nil, false
	}
	return o.PersonalDetails, true
}

// HasPersonalDetails returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntity) HasPersonalDetails() bool {
	if o != nil && !isNil(o.PersonalDetails) {
		return true
	}

	return false
}

// SetPersonalDetails gets a reference to the given GetKycDriversLicenseResponseEntityPersonalDetails and assigns it to the PersonalDetails field.
func (o *GetKycDriversLicenseResponseEntity) SetPersonalDetails(v GetKycDriversLicenseResponseEntityPersonalDetails) {
	o.PersonalDetails = &v
}

func (o GetKycDriversLicenseResponseEntity) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.PersonalDetails) {
		toSerialize["personal_details"] = o.PersonalDetails
	}
	return json.Marshal(toSerialize)
}

type NullableGetKycDriversLicenseResponseEntity struct {
	value *GetKycDriversLicenseResponseEntity
	isSet bool
}

func (v NullableGetKycDriversLicenseResponseEntity) Get() *GetKycDriversLicenseResponseEntity {
	return v.value
}

func (v *NullableGetKycDriversLicenseResponseEntity) Set(val *GetKycDriversLicenseResponseEntity) {
	v.value = val
	v.isSet = true
}

func (v NullableGetKycDriversLicenseResponseEntity) IsSet() bool {
	return v.isSet
}

func (v *NullableGetKycDriversLicenseResponseEntity) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetKycDriversLicenseResponseEntity(val *GetKycDriversLicenseResponseEntity) *NullableGetKycDriversLicenseResponseEntity {
	return &NullableGetKycDriversLicenseResponseEntity{value: val, isSet: true}
}

func (v NullableGetKycDriversLicenseResponseEntity) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetKycDriversLicenseResponseEntity) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


