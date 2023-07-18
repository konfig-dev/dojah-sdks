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

// GetNubanResponseEntity struct for GetNubanResponseEntity
type GetNubanResponseEntity struct {
	AccountCurrency *string `json:"account_currency,omitempty"`
	AccountName *string `json:"account_name,omitempty"`
	AccountNumber *string `json:"account_number,omitempty"`
	AccountType *string `json:"account_type,omitempty"`
	Address1 *string `json:"address_1,omitempty"`
	Address2 *string `json:"address_2,omitempty"`
	City *string `json:"city,omitempty"`
	CountryCode *string `json:"country_code,omitempty"`
	CountryOfBirth *string `json:"country_of_birth,omitempty"`
	CountryOfIssue *string `json:"country_of_issue,omitempty"`
	Dob *string `json:"dob,omitempty"`
	ExpiryDate *string `json:"expiry_date,omitempty"`
	FirstName *string `json:"first_name,omitempty"`
	IdentityNumber *string `json:"identity_number,omitempty"`
	IdentityType *string `json:"identity_type,omitempty"`
	LastName *string `json:"last_name,omitempty"`
	Nationality *string `json:"nationality,omitempty"`
	OtherNames *string `json:"other_names,omitempty"`
	Phone *string `json:"phone,omitempty"`
	PostalCode *string `json:"postal_code,omitempty"`
	Reference *string `json:"reference,omitempty"`
	StateCode *string `json:"state_code,omitempty"`
}

// NewGetNubanResponseEntity instantiates a new GetNubanResponseEntity object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetNubanResponseEntity() *GetNubanResponseEntity {
	this := GetNubanResponseEntity{}
	return &this
}

// NewGetNubanResponseEntityWithDefaults instantiates a new GetNubanResponseEntity object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetNubanResponseEntityWithDefaults() *GetNubanResponseEntity {
	this := GetNubanResponseEntity{}
	return &this
}

// GetAccountCurrency returns the AccountCurrency field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAccountCurrency() string {
	if o == nil || isNil(o.AccountCurrency) {
		var ret string
		return ret
	}
	return *o.AccountCurrency
}

// GetAccountCurrencyOk returns a tuple with the AccountCurrency field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAccountCurrencyOk() (*string, bool) {
	if o == nil || isNil(o.AccountCurrency) {
    return nil, false
	}
	return o.AccountCurrency, true
}

// HasAccountCurrency returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAccountCurrency() bool {
	if o != nil && !isNil(o.AccountCurrency) {
		return true
	}

	return false
}

// SetAccountCurrency gets a reference to the given string and assigns it to the AccountCurrency field.
func (o *GetNubanResponseEntity) SetAccountCurrency(v string) {
	o.AccountCurrency = &v
}

// GetAccountName returns the AccountName field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAccountName() string {
	if o == nil || isNil(o.AccountName) {
		var ret string
		return ret
	}
	return *o.AccountName
}

// GetAccountNameOk returns a tuple with the AccountName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAccountNameOk() (*string, bool) {
	if o == nil || isNil(o.AccountName) {
    return nil, false
	}
	return o.AccountName, true
}

// HasAccountName returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAccountName() bool {
	if o != nil && !isNil(o.AccountName) {
		return true
	}

	return false
}

// SetAccountName gets a reference to the given string and assigns it to the AccountName field.
func (o *GetNubanResponseEntity) SetAccountName(v string) {
	o.AccountName = &v
}

// GetAccountNumber returns the AccountNumber field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAccountNumber() string {
	if o == nil || isNil(o.AccountNumber) {
		var ret string
		return ret
	}
	return *o.AccountNumber
}

// GetAccountNumberOk returns a tuple with the AccountNumber field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAccountNumberOk() (*string, bool) {
	if o == nil || isNil(o.AccountNumber) {
    return nil, false
	}
	return o.AccountNumber, true
}

// HasAccountNumber returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAccountNumber() bool {
	if o != nil && !isNil(o.AccountNumber) {
		return true
	}

	return false
}

// SetAccountNumber gets a reference to the given string and assigns it to the AccountNumber field.
func (o *GetNubanResponseEntity) SetAccountNumber(v string) {
	o.AccountNumber = &v
}

// GetAccountType returns the AccountType field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAccountType() string {
	if o == nil || isNil(o.AccountType) {
		var ret string
		return ret
	}
	return *o.AccountType
}

// GetAccountTypeOk returns a tuple with the AccountType field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAccountTypeOk() (*string, bool) {
	if o == nil || isNil(o.AccountType) {
    return nil, false
	}
	return o.AccountType, true
}

// HasAccountType returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAccountType() bool {
	if o != nil && !isNil(o.AccountType) {
		return true
	}

	return false
}

// SetAccountType gets a reference to the given string and assigns it to the AccountType field.
func (o *GetNubanResponseEntity) SetAccountType(v string) {
	o.AccountType = &v
}

// GetAddress1 returns the Address1 field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAddress1() string {
	if o == nil || isNil(o.Address1) {
		var ret string
		return ret
	}
	return *o.Address1
}

// GetAddress1Ok returns a tuple with the Address1 field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAddress1Ok() (*string, bool) {
	if o == nil || isNil(o.Address1) {
    return nil, false
	}
	return o.Address1, true
}

// HasAddress1 returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAddress1() bool {
	if o != nil && !isNil(o.Address1) {
		return true
	}

	return false
}

// SetAddress1 gets a reference to the given string and assigns it to the Address1 field.
func (o *GetNubanResponseEntity) SetAddress1(v string) {
	o.Address1 = &v
}

// GetAddress2 returns the Address2 field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetAddress2() string {
	if o == nil || isNil(o.Address2) {
		var ret string
		return ret
	}
	return *o.Address2
}

// GetAddress2Ok returns a tuple with the Address2 field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetAddress2Ok() (*string, bool) {
	if o == nil || isNil(o.Address2) {
    return nil, false
	}
	return o.Address2, true
}

// HasAddress2 returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasAddress2() bool {
	if o != nil && !isNil(o.Address2) {
		return true
	}

	return false
}

// SetAddress2 gets a reference to the given string and assigns it to the Address2 field.
func (o *GetNubanResponseEntity) SetAddress2(v string) {
	o.Address2 = &v
}

// GetCity returns the City field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetCity() string {
	if o == nil || isNil(o.City) {
		var ret string
		return ret
	}
	return *o.City
}

// GetCityOk returns a tuple with the City field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetCityOk() (*string, bool) {
	if o == nil || isNil(o.City) {
    return nil, false
	}
	return o.City, true
}

// HasCity returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasCity() bool {
	if o != nil && !isNil(o.City) {
		return true
	}

	return false
}

// SetCity gets a reference to the given string and assigns it to the City field.
func (o *GetNubanResponseEntity) SetCity(v string) {
	o.City = &v
}

// GetCountryCode returns the CountryCode field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetCountryCode() string {
	if o == nil || isNil(o.CountryCode) {
		var ret string
		return ret
	}
	return *o.CountryCode
}

// GetCountryCodeOk returns a tuple with the CountryCode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetCountryCodeOk() (*string, bool) {
	if o == nil || isNil(o.CountryCode) {
    return nil, false
	}
	return o.CountryCode, true
}

// HasCountryCode returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasCountryCode() bool {
	if o != nil && !isNil(o.CountryCode) {
		return true
	}

	return false
}

// SetCountryCode gets a reference to the given string and assigns it to the CountryCode field.
func (o *GetNubanResponseEntity) SetCountryCode(v string) {
	o.CountryCode = &v
}

// GetCountryOfBirth returns the CountryOfBirth field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetCountryOfBirth() string {
	if o == nil || isNil(o.CountryOfBirth) {
		var ret string
		return ret
	}
	return *o.CountryOfBirth
}

// GetCountryOfBirthOk returns a tuple with the CountryOfBirth field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetCountryOfBirthOk() (*string, bool) {
	if o == nil || isNil(o.CountryOfBirth) {
    return nil, false
	}
	return o.CountryOfBirth, true
}

// HasCountryOfBirth returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasCountryOfBirth() bool {
	if o != nil && !isNil(o.CountryOfBirth) {
		return true
	}

	return false
}

// SetCountryOfBirth gets a reference to the given string and assigns it to the CountryOfBirth field.
func (o *GetNubanResponseEntity) SetCountryOfBirth(v string) {
	o.CountryOfBirth = &v
}

// GetCountryOfIssue returns the CountryOfIssue field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetCountryOfIssue() string {
	if o == nil || isNil(o.CountryOfIssue) {
		var ret string
		return ret
	}
	return *o.CountryOfIssue
}

// GetCountryOfIssueOk returns a tuple with the CountryOfIssue field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetCountryOfIssueOk() (*string, bool) {
	if o == nil || isNil(o.CountryOfIssue) {
    return nil, false
	}
	return o.CountryOfIssue, true
}

// HasCountryOfIssue returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasCountryOfIssue() bool {
	if o != nil && !isNil(o.CountryOfIssue) {
		return true
	}

	return false
}

// SetCountryOfIssue gets a reference to the given string and assigns it to the CountryOfIssue field.
func (o *GetNubanResponseEntity) SetCountryOfIssue(v string) {
	o.CountryOfIssue = &v
}

// GetDob returns the Dob field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetDob() string {
	if o == nil || isNil(o.Dob) {
		var ret string
		return ret
	}
	return *o.Dob
}

// GetDobOk returns a tuple with the Dob field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetDobOk() (*string, bool) {
	if o == nil || isNil(o.Dob) {
    return nil, false
	}
	return o.Dob, true
}

// HasDob returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasDob() bool {
	if o != nil && !isNil(o.Dob) {
		return true
	}

	return false
}

// SetDob gets a reference to the given string and assigns it to the Dob field.
func (o *GetNubanResponseEntity) SetDob(v string) {
	o.Dob = &v
}

// GetExpiryDate returns the ExpiryDate field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetExpiryDate() string {
	if o == nil || isNil(o.ExpiryDate) {
		var ret string
		return ret
	}
	return *o.ExpiryDate
}

// GetExpiryDateOk returns a tuple with the ExpiryDate field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetExpiryDateOk() (*string, bool) {
	if o == nil || isNil(o.ExpiryDate) {
    return nil, false
	}
	return o.ExpiryDate, true
}

// HasExpiryDate returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasExpiryDate() bool {
	if o != nil && !isNil(o.ExpiryDate) {
		return true
	}

	return false
}

// SetExpiryDate gets a reference to the given string and assigns it to the ExpiryDate field.
func (o *GetNubanResponseEntity) SetExpiryDate(v string) {
	o.ExpiryDate = &v
}

// GetFirstName returns the FirstName field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetFirstName() string {
	if o == nil || isNil(o.FirstName) {
		var ret string
		return ret
	}
	return *o.FirstName
}

// GetFirstNameOk returns a tuple with the FirstName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetFirstNameOk() (*string, bool) {
	if o == nil || isNil(o.FirstName) {
    return nil, false
	}
	return o.FirstName, true
}

// HasFirstName returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasFirstName() bool {
	if o != nil && !isNil(o.FirstName) {
		return true
	}

	return false
}

// SetFirstName gets a reference to the given string and assigns it to the FirstName field.
func (o *GetNubanResponseEntity) SetFirstName(v string) {
	o.FirstName = &v
}

// GetIdentityNumber returns the IdentityNumber field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetIdentityNumber() string {
	if o == nil || isNil(o.IdentityNumber) {
		var ret string
		return ret
	}
	return *o.IdentityNumber
}

// GetIdentityNumberOk returns a tuple with the IdentityNumber field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetIdentityNumberOk() (*string, bool) {
	if o == nil || isNil(o.IdentityNumber) {
    return nil, false
	}
	return o.IdentityNumber, true
}

// HasIdentityNumber returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasIdentityNumber() bool {
	if o != nil && !isNil(o.IdentityNumber) {
		return true
	}

	return false
}

// SetIdentityNumber gets a reference to the given string and assigns it to the IdentityNumber field.
func (o *GetNubanResponseEntity) SetIdentityNumber(v string) {
	o.IdentityNumber = &v
}

// GetIdentityType returns the IdentityType field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetIdentityType() string {
	if o == nil || isNil(o.IdentityType) {
		var ret string
		return ret
	}
	return *o.IdentityType
}

// GetIdentityTypeOk returns a tuple with the IdentityType field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetIdentityTypeOk() (*string, bool) {
	if o == nil || isNil(o.IdentityType) {
    return nil, false
	}
	return o.IdentityType, true
}

// HasIdentityType returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasIdentityType() bool {
	if o != nil && !isNil(o.IdentityType) {
		return true
	}

	return false
}

// SetIdentityType gets a reference to the given string and assigns it to the IdentityType field.
func (o *GetNubanResponseEntity) SetIdentityType(v string) {
	o.IdentityType = &v
}

// GetLastName returns the LastName field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetLastName() string {
	if o == nil || isNil(o.LastName) {
		var ret string
		return ret
	}
	return *o.LastName
}

// GetLastNameOk returns a tuple with the LastName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetLastNameOk() (*string, bool) {
	if o == nil || isNil(o.LastName) {
    return nil, false
	}
	return o.LastName, true
}

// HasLastName returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasLastName() bool {
	if o != nil && !isNil(o.LastName) {
		return true
	}

	return false
}

// SetLastName gets a reference to the given string and assigns it to the LastName field.
func (o *GetNubanResponseEntity) SetLastName(v string) {
	o.LastName = &v
}

// GetNationality returns the Nationality field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetNationality() string {
	if o == nil || isNil(o.Nationality) {
		var ret string
		return ret
	}
	return *o.Nationality
}

// GetNationalityOk returns a tuple with the Nationality field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetNationalityOk() (*string, bool) {
	if o == nil || isNil(o.Nationality) {
    return nil, false
	}
	return o.Nationality, true
}

// HasNationality returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasNationality() bool {
	if o != nil && !isNil(o.Nationality) {
		return true
	}

	return false
}

// SetNationality gets a reference to the given string and assigns it to the Nationality field.
func (o *GetNubanResponseEntity) SetNationality(v string) {
	o.Nationality = &v
}

// GetOtherNames returns the OtherNames field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetOtherNames() string {
	if o == nil || isNil(o.OtherNames) {
		var ret string
		return ret
	}
	return *o.OtherNames
}

// GetOtherNamesOk returns a tuple with the OtherNames field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetOtherNamesOk() (*string, bool) {
	if o == nil || isNil(o.OtherNames) {
    return nil, false
	}
	return o.OtherNames, true
}

// HasOtherNames returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasOtherNames() bool {
	if o != nil && !isNil(o.OtherNames) {
		return true
	}

	return false
}

// SetOtherNames gets a reference to the given string and assigns it to the OtherNames field.
func (o *GetNubanResponseEntity) SetOtherNames(v string) {
	o.OtherNames = &v
}

// GetPhone returns the Phone field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetPhone() string {
	if o == nil || isNil(o.Phone) {
		var ret string
		return ret
	}
	return *o.Phone
}

// GetPhoneOk returns a tuple with the Phone field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetPhoneOk() (*string, bool) {
	if o == nil || isNil(o.Phone) {
    return nil, false
	}
	return o.Phone, true
}

// HasPhone returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasPhone() bool {
	if o != nil && !isNil(o.Phone) {
		return true
	}

	return false
}

// SetPhone gets a reference to the given string and assigns it to the Phone field.
func (o *GetNubanResponseEntity) SetPhone(v string) {
	o.Phone = &v
}

// GetPostalCode returns the PostalCode field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetPostalCode() string {
	if o == nil || isNil(o.PostalCode) {
		var ret string
		return ret
	}
	return *o.PostalCode
}

// GetPostalCodeOk returns a tuple with the PostalCode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetPostalCodeOk() (*string, bool) {
	if o == nil || isNil(o.PostalCode) {
    return nil, false
	}
	return o.PostalCode, true
}

// HasPostalCode returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasPostalCode() bool {
	if o != nil && !isNil(o.PostalCode) {
		return true
	}

	return false
}

// SetPostalCode gets a reference to the given string and assigns it to the PostalCode field.
func (o *GetNubanResponseEntity) SetPostalCode(v string) {
	o.PostalCode = &v
}

// GetReference returns the Reference field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetReference() string {
	if o == nil || isNil(o.Reference) {
		var ret string
		return ret
	}
	return *o.Reference
}

// GetReferenceOk returns a tuple with the Reference field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetReferenceOk() (*string, bool) {
	if o == nil || isNil(o.Reference) {
    return nil, false
	}
	return o.Reference, true
}

// HasReference returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasReference() bool {
	if o != nil && !isNil(o.Reference) {
		return true
	}

	return false
}

// SetReference gets a reference to the given string and assigns it to the Reference field.
func (o *GetNubanResponseEntity) SetReference(v string) {
	o.Reference = &v
}

// GetStateCode returns the StateCode field value if set, zero value otherwise.
func (o *GetNubanResponseEntity) GetStateCode() string {
	if o == nil || isNil(o.StateCode) {
		var ret string
		return ret
	}
	return *o.StateCode
}

// GetStateCodeOk returns a tuple with the StateCode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetNubanResponseEntity) GetStateCodeOk() (*string, bool) {
	if o == nil || isNil(o.StateCode) {
    return nil, false
	}
	return o.StateCode, true
}

// HasStateCode returns a boolean if a field has been set.
func (o *GetNubanResponseEntity) HasStateCode() bool {
	if o != nil && !isNil(o.StateCode) {
		return true
	}

	return false
}

// SetStateCode gets a reference to the given string and assigns it to the StateCode field.
func (o *GetNubanResponseEntity) SetStateCode(v string) {
	o.StateCode = &v
}

func (o GetNubanResponseEntity) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.AccountCurrency) {
		toSerialize["account_currency"] = o.AccountCurrency
	}
	if !isNil(o.AccountName) {
		toSerialize["account_name"] = o.AccountName
	}
	if !isNil(o.AccountNumber) {
		toSerialize["account_number"] = o.AccountNumber
	}
	if !isNil(o.AccountType) {
		toSerialize["account_type"] = o.AccountType
	}
	if !isNil(o.Address1) {
		toSerialize["address_1"] = o.Address1
	}
	if !isNil(o.Address2) {
		toSerialize["address_2"] = o.Address2
	}
	if !isNil(o.City) {
		toSerialize["city"] = o.City
	}
	if !isNil(o.CountryCode) {
		toSerialize["country_code"] = o.CountryCode
	}
	if !isNil(o.CountryOfBirth) {
		toSerialize["country_of_birth"] = o.CountryOfBirth
	}
	if !isNil(o.CountryOfIssue) {
		toSerialize["country_of_issue"] = o.CountryOfIssue
	}
	if !isNil(o.Dob) {
		toSerialize["dob"] = o.Dob
	}
	if !isNil(o.ExpiryDate) {
		toSerialize["expiry_date"] = o.ExpiryDate
	}
	if !isNil(o.FirstName) {
		toSerialize["first_name"] = o.FirstName
	}
	if !isNil(o.IdentityNumber) {
		toSerialize["identity_number"] = o.IdentityNumber
	}
	if !isNil(o.IdentityType) {
		toSerialize["identity_type"] = o.IdentityType
	}
	if !isNil(o.LastName) {
		toSerialize["last_name"] = o.LastName
	}
	if !isNil(o.Nationality) {
		toSerialize["nationality"] = o.Nationality
	}
	if !isNil(o.OtherNames) {
		toSerialize["other_names"] = o.OtherNames
	}
	if !isNil(o.Phone) {
		toSerialize["phone"] = o.Phone
	}
	if !isNil(o.PostalCode) {
		toSerialize["postal_code"] = o.PostalCode
	}
	if !isNil(o.Reference) {
		toSerialize["reference"] = o.Reference
	}
	if !isNil(o.StateCode) {
		toSerialize["state_code"] = o.StateCode
	}
	return json.Marshal(toSerialize)
}

type NullableGetNubanResponseEntity struct {
	value *GetNubanResponseEntity
	isSet bool
}

func (v NullableGetNubanResponseEntity) Get() *GetNubanResponseEntity {
	return v.value
}

func (v *NullableGetNubanResponseEntity) Set(val *GetNubanResponseEntity) {
	v.value = val
	v.isSet = true
}

func (v NullableGetNubanResponseEntity) IsSet() bool {
	return v.isSet
}

func (v *NullableGetNubanResponseEntity) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetNubanResponseEntity(val *GetNubanResponseEntity) *NullableGetNubanResponseEntity {
	return &NullableGetNubanResponseEntity{value: val, isSet: true}
}

func (v NullableGetNubanResponseEntity) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetNubanResponseEntity) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


