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

// GetBinResponseEntity struct for GetBinResponseEntity
type GetBinResponseEntity struct {
	Bin *string `json:"bin,omitempty"`
	Brand *string `json:"brand,omitempty"`
	SubBrand *string `json:"sub_brand,omitempty"`
	CountryCode *string `json:"country_code,omitempty"`
	CountryName *string `json:"country_name,omitempty"`
	CardType *string `json:"card_type,omitempty"`
	Bank *string `json:"bank,omitempty"`
}

// NewGetBinResponseEntity instantiates a new GetBinResponseEntity object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetBinResponseEntity() *GetBinResponseEntity {
	this := GetBinResponseEntity{}
	return &this
}

// NewGetBinResponseEntityWithDefaults instantiates a new GetBinResponseEntity object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetBinResponseEntityWithDefaults() *GetBinResponseEntity {
	this := GetBinResponseEntity{}
	return &this
}

// GetBin returns the Bin field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetBin() string {
	if o == nil || isNil(o.Bin) {
		var ret string
		return ret
	}
	return *o.Bin
}

// GetBinOk returns a tuple with the Bin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetBinOk() (*string, bool) {
	if o == nil || isNil(o.Bin) {
    return nil, false
	}
	return o.Bin, true
}

// HasBin returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasBin() bool {
	if o != nil && !isNil(o.Bin) {
		return true
	}

	return false
}

// SetBin gets a reference to the given string and assigns it to the Bin field.
func (o *GetBinResponseEntity) SetBin(v string) {
	o.Bin = &v
}

// GetBrand returns the Brand field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetBrand() string {
	if o == nil || isNil(o.Brand) {
		var ret string
		return ret
	}
	return *o.Brand
}

// GetBrandOk returns a tuple with the Brand field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetBrandOk() (*string, bool) {
	if o == nil || isNil(o.Brand) {
    return nil, false
	}
	return o.Brand, true
}

// HasBrand returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasBrand() bool {
	if o != nil && !isNil(o.Brand) {
		return true
	}

	return false
}

// SetBrand gets a reference to the given string and assigns it to the Brand field.
func (o *GetBinResponseEntity) SetBrand(v string) {
	o.Brand = &v
}

// GetSubBrand returns the SubBrand field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetSubBrand() string {
	if o == nil || isNil(o.SubBrand) {
		var ret string
		return ret
	}
	return *o.SubBrand
}

// GetSubBrandOk returns a tuple with the SubBrand field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetSubBrandOk() (*string, bool) {
	if o == nil || isNil(o.SubBrand) {
    return nil, false
	}
	return o.SubBrand, true
}

// HasSubBrand returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasSubBrand() bool {
	if o != nil && !isNil(o.SubBrand) {
		return true
	}

	return false
}

// SetSubBrand gets a reference to the given string and assigns it to the SubBrand field.
func (o *GetBinResponseEntity) SetSubBrand(v string) {
	o.SubBrand = &v
}

// GetCountryCode returns the CountryCode field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetCountryCode() string {
	if o == nil || isNil(o.CountryCode) {
		var ret string
		return ret
	}
	return *o.CountryCode
}

// GetCountryCodeOk returns a tuple with the CountryCode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetCountryCodeOk() (*string, bool) {
	if o == nil || isNil(o.CountryCode) {
    return nil, false
	}
	return o.CountryCode, true
}

// HasCountryCode returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasCountryCode() bool {
	if o != nil && !isNil(o.CountryCode) {
		return true
	}

	return false
}

// SetCountryCode gets a reference to the given string and assigns it to the CountryCode field.
func (o *GetBinResponseEntity) SetCountryCode(v string) {
	o.CountryCode = &v
}

// GetCountryName returns the CountryName field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetCountryName() string {
	if o == nil || isNil(o.CountryName) {
		var ret string
		return ret
	}
	return *o.CountryName
}

// GetCountryNameOk returns a tuple with the CountryName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetCountryNameOk() (*string, bool) {
	if o == nil || isNil(o.CountryName) {
    return nil, false
	}
	return o.CountryName, true
}

// HasCountryName returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasCountryName() bool {
	if o != nil && !isNil(o.CountryName) {
		return true
	}

	return false
}

// SetCountryName gets a reference to the given string and assigns it to the CountryName field.
func (o *GetBinResponseEntity) SetCountryName(v string) {
	o.CountryName = &v
}

// GetCardType returns the CardType field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetCardType() string {
	if o == nil || isNil(o.CardType) {
		var ret string
		return ret
	}
	return *o.CardType
}

// GetCardTypeOk returns a tuple with the CardType field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetCardTypeOk() (*string, bool) {
	if o == nil || isNil(o.CardType) {
    return nil, false
	}
	return o.CardType, true
}

// HasCardType returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasCardType() bool {
	if o != nil && !isNil(o.CardType) {
		return true
	}

	return false
}

// SetCardType gets a reference to the given string and assigns it to the CardType field.
func (o *GetBinResponseEntity) SetCardType(v string) {
	o.CardType = &v
}

// GetBank returns the Bank field value if set, zero value otherwise.
func (o *GetBinResponseEntity) GetBank() string {
	if o == nil || isNil(o.Bank) {
		var ret string
		return ret
	}
	return *o.Bank
}

// GetBankOk returns a tuple with the Bank field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBinResponseEntity) GetBankOk() (*string, bool) {
	if o == nil || isNil(o.Bank) {
    return nil, false
	}
	return o.Bank, true
}

// HasBank returns a boolean if a field has been set.
func (o *GetBinResponseEntity) HasBank() bool {
	if o != nil && !isNil(o.Bank) {
		return true
	}

	return false
}

// SetBank gets a reference to the given string and assigns it to the Bank field.
func (o *GetBinResponseEntity) SetBank(v string) {
	o.Bank = &v
}

func (o GetBinResponseEntity) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Bin) {
		toSerialize["bin"] = o.Bin
	}
	if !isNil(o.Brand) {
		toSerialize["brand"] = o.Brand
	}
	if !isNil(o.SubBrand) {
		toSerialize["sub_brand"] = o.SubBrand
	}
	if !isNil(o.CountryCode) {
		toSerialize["country_code"] = o.CountryCode
	}
	if !isNil(o.CountryName) {
		toSerialize["country_name"] = o.CountryName
	}
	if !isNil(o.CardType) {
		toSerialize["card_type"] = o.CardType
	}
	if !isNil(o.Bank) {
		toSerialize["bank"] = o.Bank
	}
	return json.Marshal(toSerialize)
}

type NullableGetBinResponseEntity struct {
	value *GetBinResponseEntity
	isSet bool
}

func (v NullableGetBinResponseEntity) Get() *GetBinResponseEntity {
	return v.value
}

func (v *NullableGetBinResponseEntity) Set(val *GetBinResponseEntity) {
	v.value = val
	v.isSet = true
}

func (v NullableGetBinResponseEntity) IsSet() bool {
	return v.isSet
}

func (v *NullableGetBinResponseEntity) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetBinResponseEntity(val *GetBinResponseEntity) *NullableGetBinResponseEntity {
	return &NullableGetBinResponseEntity{value: val, isSet: true}
}

func (v NullableGetBinResponseEntity) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetBinResponseEntity) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


