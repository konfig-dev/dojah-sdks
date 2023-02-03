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

// GetKycDriversLicenseResponseEntityPersonalDetails struct for GetKycDriversLicenseResponseEntityPersonalDetails
type GetKycDriversLicenseResponseEntityPersonalDetails struct {
	Firstname *string `json:"firstname,omitempty"`
	Othername *string `json:"othername,omitempty"`
	Surname *string `json:"surname,omitempty"`
	MotherMaidenName *string `json:"mother_maiden_name,omitempty"`
	Gender *string `json:"gender,omitempty"`
	BirthDate *string `json:"birth_date,omitempty"`
	BloodGroupId *string `json:"blood_group_id,omitempty"`
	FacialMark *string `json:"facial_mark,omitempty"`
	Glasses *string `json:"glasses,omitempty"`
	Height *string `json:"height,omitempty"`
	UniversaltaxIdentityNumber *string `json:"universaltax_identity_number,omitempty"`
	NinNumber *string `json:"nin_number,omitempty"`
	Country *string `json:"country,omitempty"`
	State *string `json:"state,omitempty"`
	Lga *string `json:"lga,omitempty"`
	IsDisability *string `json:"is_disability,omitempty"`
	DisabilityReason *string `json:"disability_reason,omitempty"`
}

// NewGetKycDriversLicenseResponseEntityPersonalDetails instantiates a new GetKycDriversLicenseResponseEntityPersonalDetails object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetKycDriversLicenseResponseEntityPersonalDetails() *GetKycDriversLicenseResponseEntityPersonalDetails {
	this := GetKycDriversLicenseResponseEntityPersonalDetails{}
	return &this
}

// NewGetKycDriversLicenseResponseEntityPersonalDetailsWithDefaults instantiates a new GetKycDriversLicenseResponseEntityPersonalDetails object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetKycDriversLicenseResponseEntityPersonalDetailsWithDefaults() *GetKycDriversLicenseResponseEntityPersonalDetails {
	this := GetKycDriversLicenseResponseEntityPersonalDetails{}
	return &this
}

// GetFirstname returns the Firstname field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetFirstname() string {
	if o == nil || isNil(o.Firstname) {
		var ret string
		return ret
	}
	return *o.Firstname
}

// GetFirstnameOk returns a tuple with the Firstname field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetFirstnameOk() (*string, bool) {
	if o == nil || isNil(o.Firstname) {
    return nil, false
	}
	return o.Firstname, true
}

// HasFirstname returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasFirstname() bool {
	if o != nil && !isNil(o.Firstname) {
		return true
	}

	return false
}

// SetFirstname gets a reference to the given string and assigns it to the Firstname field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetFirstname(v string) {
	o.Firstname = &v
}

// GetOthername returns the Othername field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetOthername() string {
	if o == nil || isNil(o.Othername) {
		var ret string
		return ret
	}
	return *o.Othername
}

// GetOthernameOk returns a tuple with the Othername field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetOthernameOk() (*string, bool) {
	if o == nil || isNil(o.Othername) {
    return nil, false
	}
	return o.Othername, true
}

// HasOthername returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasOthername() bool {
	if o != nil && !isNil(o.Othername) {
		return true
	}

	return false
}

// SetOthername gets a reference to the given string and assigns it to the Othername field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetOthername(v string) {
	o.Othername = &v
}

// GetSurname returns the Surname field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetSurname() string {
	if o == nil || isNil(o.Surname) {
		var ret string
		return ret
	}
	return *o.Surname
}

// GetSurnameOk returns a tuple with the Surname field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetSurnameOk() (*string, bool) {
	if o == nil || isNil(o.Surname) {
    return nil, false
	}
	return o.Surname, true
}

// HasSurname returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasSurname() bool {
	if o != nil && !isNil(o.Surname) {
		return true
	}

	return false
}

// SetSurname gets a reference to the given string and assigns it to the Surname field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetSurname(v string) {
	o.Surname = &v
}

// GetMotherMaidenName returns the MotherMaidenName field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetMotherMaidenName() string {
	if o == nil || isNil(o.MotherMaidenName) {
		var ret string
		return ret
	}
	return *o.MotherMaidenName
}

// GetMotherMaidenNameOk returns a tuple with the MotherMaidenName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetMotherMaidenNameOk() (*string, bool) {
	if o == nil || isNil(o.MotherMaidenName) {
    return nil, false
	}
	return o.MotherMaidenName, true
}

// HasMotherMaidenName returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasMotherMaidenName() bool {
	if o != nil && !isNil(o.MotherMaidenName) {
		return true
	}

	return false
}

// SetMotherMaidenName gets a reference to the given string and assigns it to the MotherMaidenName field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetMotherMaidenName(v string) {
	o.MotherMaidenName = &v
}

// GetGender returns the Gender field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetGender() string {
	if o == nil || isNil(o.Gender) {
		var ret string
		return ret
	}
	return *o.Gender
}

// GetGenderOk returns a tuple with the Gender field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetGenderOk() (*string, bool) {
	if o == nil || isNil(o.Gender) {
    return nil, false
	}
	return o.Gender, true
}

// HasGender returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasGender() bool {
	if o != nil && !isNil(o.Gender) {
		return true
	}

	return false
}

// SetGender gets a reference to the given string and assigns it to the Gender field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetGender(v string) {
	o.Gender = &v
}

// GetBirthDate returns the BirthDate field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetBirthDate() string {
	if o == nil || isNil(o.BirthDate) {
		var ret string
		return ret
	}
	return *o.BirthDate
}

// GetBirthDateOk returns a tuple with the BirthDate field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetBirthDateOk() (*string, bool) {
	if o == nil || isNil(o.BirthDate) {
    return nil, false
	}
	return o.BirthDate, true
}

// HasBirthDate returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasBirthDate() bool {
	if o != nil && !isNil(o.BirthDate) {
		return true
	}

	return false
}

// SetBirthDate gets a reference to the given string and assigns it to the BirthDate field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetBirthDate(v string) {
	o.BirthDate = &v
}

// GetBloodGroupId returns the BloodGroupId field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetBloodGroupId() string {
	if o == nil || isNil(o.BloodGroupId) {
		var ret string
		return ret
	}
	return *o.BloodGroupId
}

// GetBloodGroupIdOk returns a tuple with the BloodGroupId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetBloodGroupIdOk() (*string, bool) {
	if o == nil || isNil(o.BloodGroupId) {
    return nil, false
	}
	return o.BloodGroupId, true
}

// HasBloodGroupId returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasBloodGroupId() bool {
	if o != nil && !isNil(o.BloodGroupId) {
		return true
	}

	return false
}

// SetBloodGroupId gets a reference to the given string and assigns it to the BloodGroupId field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetBloodGroupId(v string) {
	o.BloodGroupId = &v
}

// GetFacialMark returns the FacialMark field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetFacialMark() string {
	if o == nil || isNil(o.FacialMark) {
		var ret string
		return ret
	}
	return *o.FacialMark
}

// GetFacialMarkOk returns a tuple with the FacialMark field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetFacialMarkOk() (*string, bool) {
	if o == nil || isNil(o.FacialMark) {
    return nil, false
	}
	return o.FacialMark, true
}

// HasFacialMark returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasFacialMark() bool {
	if o != nil && !isNil(o.FacialMark) {
		return true
	}

	return false
}

// SetFacialMark gets a reference to the given string and assigns it to the FacialMark field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetFacialMark(v string) {
	o.FacialMark = &v
}

// GetGlasses returns the Glasses field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetGlasses() string {
	if o == nil || isNil(o.Glasses) {
		var ret string
		return ret
	}
	return *o.Glasses
}

// GetGlassesOk returns a tuple with the Glasses field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetGlassesOk() (*string, bool) {
	if o == nil || isNil(o.Glasses) {
    return nil, false
	}
	return o.Glasses, true
}

// HasGlasses returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasGlasses() bool {
	if o != nil && !isNil(o.Glasses) {
		return true
	}

	return false
}

// SetGlasses gets a reference to the given string and assigns it to the Glasses field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetGlasses(v string) {
	o.Glasses = &v
}

// GetHeight returns the Height field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetHeight() string {
	if o == nil || isNil(o.Height) {
		var ret string
		return ret
	}
	return *o.Height
}

// GetHeightOk returns a tuple with the Height field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetHeightOk() (*string, bool) {
	if o == nil || isNil(o.Height) {
    return nil, false
	}
	return o.Height, true
}

// HasHeight returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasHeight() bool {
	if o != nil && !isNil(o.Height) {
		return true
	}

	return false
}

// SetHeight gets a reference to the given string and assigns it to the Height field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetHeight(v string) {
	o.Height = &v
}

// GetUniversaltaxIdentityNumber returns the UniversaltaxIdentityNumber field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetUniversaltaxIdentityNumber() string {
	if o == nil || isNil(o.UniversaltaxIdentityNumber) {
		var ret string
		return ret
	}
	return *o.UniversaltaxIdentityNumber
}

// GetUniversaltaxIdentityNumberOk returns a tuple with the UniversaltaxIdentityNumber field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetUniversaltaxIdentityNumberOk() (*string, bool) {
	if o == nil || isNil(o.UniversaltaxIdentityNumber) {
    return nil, false
	}
	return o.UniversaltaxIdentityNumber, true
}

// HasUniversaltaxIdentityNumber returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasUniversaltaxIdentityNumber() bool {
	if o != nil && !isNil(o.UniversaltaxIdentityNumber) {
		return true
	}

	return false
}

// SetUniversaltaxIdentityNumber gets a reference to the given string and assigns it to the UniversaltaxIdentityNumber field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetUniversaltaxIdentityNumber(v string) {
	o.UniversaltaxIdentityNumber = &v
}

// GetNinNumber returns the NinNumber field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetNinNumber() string {
	if o == nil || isNil(o.NinNumber) {
		var ret string
		return ret
	}
	return *o.NinNumber
}

// GetNinNumberOk returns a tuple with the NinNumber field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetNinNumberOk() (*string, bool) {
	if o == nil || isNil(o.NinNumber) {
    return nil, false
	}
	return o.NinNumber, true
}

// HasNinNumber returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasNinNumber() bool {
	if o != nil && !isNil(o.NinNumber) {
		return true
	}

	return false
}

// SetNinNumber gets a reference to the given string and assigns it to the NinNumber field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetNinNumber(v string) {
	o.NinNumber = &v
}

// GetCountry returns the Country field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetCountry() string {
	if o == nil || isNil(o.Country) {
		var ret string
		return ret
	}
	return *o.Country
}

// GetCountryOk returns a tuple with the Country field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetCountryOk() (*string, bool) {
	if o == nil || isNil(o.Country) {
    return nil, false
	}
	return o.Country, true
}

// HasCountry returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasCountry() bool {
	if o != nil && !isNil(o.Country) {
		return true
	}

	return false
}

// SetCountry gets a reference to the given string and assigns it to the Country field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetCountry(v string) {
	o.Country = &v
}

// GetState returns the State field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetState() string {
	if o == nil || isNil(o.State) {
		var ret string
		return ret
	}
	return *o.State
}

// GetStateOk returns a tuple with the State field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetStateOk() (*string, bool) {
	if o == nil || isNil(o.State) {
    return nil, false
	}
	return o.State, true
}

// HasState returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasState() bool {
	if o != nil && !isNil(o.State) {
		return true
	}

	return false
}

// SetState gets a reference to the given string and assigns it to the State field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetState(v string) {
	o.State = &v
}

// GetLga returns the Lga field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetLga() string {
	if o == nil || isNil(o.Lga) {
		var ret string
		return ret
	}
	return *o.Lga
}

// GetLgaOk returns a tuple with the Lga field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetLgaOk() (*string, bool) {
	if o == nil || isNil(o.Lga) {
    return nil, false
	}
	return o.Lga, true
}

// HasLga returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasLga() bool {
	if o != nil && !isNil(o.Lga) {
		return true
	}

	return false
}

// SetLga gets a reference to the given string and assigns it to the Lga field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetLga(v string) {
	o.Lga = &v
}

// GetIsDisability returns the IsDisability field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetIsDisability() string {
	if o == nil || isNil(o.IsDisability) {
		var ret string
		return ret
	}
	return *o.IsDisability
}

// GetIsDisabilityOk returns a tuple with the IsDisability field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetIsDisabilityOk() (*string, bool) {
	if o == nil || isNil(o.IsDisability) {
    return nil, false
	}
	return o.IsDisability, true
}

// HasIsDisability returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasIsDisability() bool {
	if o != nil && !isNil(o.IsDisability) {
		return true
	}

	return false
}

// SetIsDisability gets a reference to the given string and assigns it to the IsDisability field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetIsDisability(v string) {
	o.IsDisability = &v
}

// GetDisabilityReason returns the DisabilityReason field value if set, zero value otherwise.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetDisabilityReason() string {
	if o == nil || isNil(o.DisabilityReason) {
		var ret string
		return ret
	}
	return *o.DisabilityReason
}

// GetDisabilityReasonOk returns a tuple with the DisabilityReason field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) GetDisabilityReasonOk() (*string, bool) {
	if o == nil || isNil(o.DisabilityReason) {
    return nil, false
	}
	return o.DisabilityReason, true
}

// HasDisabilityReason returns a boolean if a field has been set.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) HasDisabilityReason() bool {
	if o != nil && !isNil(o.DisabilityReason) {
		return true
	}

	return false
}

// SetDisabilityReason gets a reference to the given string and assigns it to the DisabilityReason field.
func (o *GetKycDriversLicenseResponseEntityPersonalDetails) SetDisabilityReason(v string) {
	o.DisabilityReason = &v
}

func (o GetKycDriversLicenseResponseEntityPersonalDetails) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Firstname) {
		toSerialize["firstname"] = o.Firstname
	}
	if !isNil(o.Othername) {
		toSerialize["othername"] = o.Othername
	}
	if !isNil(o.Surname) {
		toSerialize["surname"] = o.Surname
	}
	if !isNil(o.MotherMaidenName) {
		toSerialize["mother_maiden_name"] = o.MotherMaidenName
	}
	if !isNil(o.Gender) {
		toSerialize["gender"] = o.Gender
	}
	if !isNil(o.BirthDate) {
		toSerialize["birth_date"] = o.BirthDate
	}
	if !isNil(o.BloodGroupId) {
		toSerialize["blood_group_id"] = o.BloodGroupId
	}
	if !isNil(o.FacialMark) {
		toSerialize["facial_mark"] = o.FacialMark
	}
	if !isNil(o.Glasses) {
		toSerialize["glasses"] = o.Glasses
	}
	if !isNil(o.Height) {
		toSerialize["height"] = o.Height
	}
	if !isNil(o.UniversaltaxIdentityNumber) {
		toSerialize["universaltax_identity_number"] = o.UniversaltaxIdentityNumber
	}
	if !isNil(o.NinNumber) {
		toSerialize["nin_number"] = o.NinNumber
	}
	if !isNil(o.Country) {
		toSerialize["country"] = o.Country
	}
	if !isNil(o.State) {
		toSerialize["state"] = o.State
	}
	if !isNil(o.Lga) {
		toSerialize["lga"] = o.Lga
	}
	if !isNil(o.IsDisability) {
		toSerialize["is_disability"] = o.IsDisability
	}
	if !isNil(o.DisabilityReason) {
		toSerialize["disability_reason"] = o.DisabilityReason
	}
	return json.Marshal(toSerialize)
}

type NullableGetKycDriversLicenseResponseEntityPersonalDetails struct {
	value *GetKycDriversLicenseResponseEntityPersonalDetails
	isSet bool
}

func (v NullableGetKycDriversLicenseResponseEntityPersonalDetails) Get() *GetKycDriversLicenseResponseEntityPersonalDetails {
	return v.value
}

func (v *NullableGetKycDriversLicenseResponseEntityPersonalDetails) Set(val *GetKycDriversLicenseResponseEntityPersonalDetails) {
	v.value = val
	v.isSet = true
}

func (v NullableGetKycDriversLicenseResponseEntityPersonalDetails) IsSet() bool {
	return v.isSet
}

func (v *NullableGetKycDriversLicenseResponseEntityPersonalDetails) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetKycDriversLicenseResponseEntityPersonalDetails(val *GetKycDriversLicenseResponseEntityPersonalDetails) *NullableGetKycDriversLicenseResponseEntityPersonalDetails {
	return &NullableGetKycDriversLicenseResponseEntityPersonalDetails{value: val, isSet: true}
}

func (v NullableGetKycDriversLicenseResponseEntityPersonalDetails) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetKycDriversLicenseResponseEntityPersonalDetails) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


