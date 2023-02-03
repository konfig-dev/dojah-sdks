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

// GetBanksResponseEntityInner struct for GetBanksResponseEntityInner
type GetBanksResponseEntityInner struct {
	Name *string `json:"name,omitempty"`
	Code *string `json:"code,omitempty"`
	Longcode *string `json:"longcode,omitempty"`
	Gateway NullableString `json:"gateway,omitempty"`
	Slug *string `json:"slug,omitempty"`
	Country *string `json:"country,omitempty"`
	Currency *string `json:"currency,omitempty"`
}

// NewGetBanksResponseEntityInner instantiates a new GetBanksResponseEntityInner object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetBanksResponseEntityInner() *GetBanksResponseEntityInner {
	this := GetBanksResponseEntityInner{}
	return &this
}

// NewGetBanksResponseEntityInnerWithDefaults instantiates a new GetBanksResponseEntityInner object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetBanksResponseEntityInnerWithDefaults() *GetBanksResponseEntityInner {
	this := GetBanksResponseEntityInner{}
	return &this
}

// GetName returns the Name field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetName() string {
	if o == nil || isNil(o.Name) {
		var ret string
		return ret
	}
	return *o.Name
}

// GetNameOk returns a tuple with the Name field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetNameOk() (*string, bool) {
	if o == nil || isNil(o.Name) {
    return nil, false
	}
	return o.Name, true
}

// HasName returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasName() bool {
	if o != nil && !isNil(o.Name) {
		return true
	}

	return false
}

// SetName gets a reference to the given string and assigns it to the Name field.
func (o *GetBanksResponseEntityInner) SetName(v string) {
	o.Name = &v
}

// GetCode returns the Code field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetCode() string {
	if o == nil || isNil(o.Code) {
		var ret string
		return ret
	}
	return *o.Code
}

// GetCodeOk returns a tuple with the Code field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetCodeOk() (*string, bool) {
	if o == nil || isNil(o.Code) {
    return nil, false
	}
	return o.Code, true
}

// HasCode returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasCode() bool {
	if o != nil && !isNil(o.Code) {
		return true
	}

	return false
}

// SetCode gets a reference to the given string and assigns it to the Code field.
func (o *GetBanksResponseEntityInner) SetCode(v string) {
	o.Code = &v
}

// GetLongcode returns the Longcode field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetLongcode() string {
	if o == nil || isNil(o.Longcode) {
		var ret string
		return ret
	}
	return *o.Longcode
}

// GetLongcodeOk returns a tuple with the Longcode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetLongcodeOk() (*string, bool) {
	if o == nil || isNil(o.Longcode) {
    return nil, false
	}
	return o.Longcode, true
}

// HasLongcode returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasLongcode() bool {
	if o != nil && !isNil(o.Longcode) {
		return true
	}

	return false
}

// SetLongcode gets a reference to the given string and assigns it to the Longcode field.
func (o *GetBanksResponseEntityInner) SetLongcode(v string) {
	o.Longcode = &v
}

// GetGateway returns the Gateway field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *GetBanksResponseEntityInner) GetGateway() string {
	if o == nil || isNil(o.Gateway.Get()) {
		var ret string
		return ret
	}
	return *o.Gateway.Get()
}

// GetGatewayOk returns a tuple with the Gateway field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *GetBanksResponseEntityInner) GetGatewayOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return o.Gateway.Get(), o.Gateway.IsSet()
}

// HasGateway returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasGateway() bool {
	if o != nil && o.Gateway.IsSet() {
		return true
	}

	return false
}

// SetGateway gets a reference to the given NullableString and assigns it to the Gateway field.
func (o *GetBanksResponseEntityInner) SetGateway(v string) {
	o.Gateway.Set(&v)
}
// SetGatewayNil sets the value for Gateway to be an explicit nil
func (o *GetBanksResponseEntityInner) SetGatewayNil() {
	o.Gateway.Set(nil)
}

// UnsetGateway ensures that no value is present for Gateway, not even an explicit nil
func (o *GetBanksResponseEntityInner) UnsetGateway() {
	o.Gateway.Unset()
}

// GetSlug returns the Slug field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetSlug() string {
	if o == nil || isNil(o.Slug) {
		var ret string
		return ret
	}
	return *o.Slug
}

// GetSlugOk returns a tuple with the Slug field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetSlugOk() (*string, bool) {
	if o == nil || isNil(o.Slug) {
    return nil, false
	}
	return o.Slug, true
}

// HasSlug returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasSlug() bool {
	if o != nil && !isNil(o.Slug) {
		return true
	}

	return false
}

// SetSlug gets a reference to the given string and assigns it to the Slug field.
func (o *GetBanksResponseEntityInner) SetSlug(v string) {
	o.Slug = &v
}

// GetCountry returns the Country field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetCountry() string {
	if o == nil || isNil(o.Country) {
		var ret string
		return ret
	}
	return *o.Country
}

// GetCountryOk returns a tuple with the Country field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetCountryOk() (*string, bool) {
	if o == nil || isNil(o.Country) {
    return nil, false
	}
	return o.Country, true
}

// HasCountry returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasCountry() bool {
	if o != nil && !isNil(o.Country) {
		return true
	}

	return false
}

// SetCountry gets a reference to the given string and assigns it to the Country field.
func (o *GetBanksResponseEntityInner) SetCountry(v string) {
	o.Country = &v
}

// GetCurrency returns the Currency field value if set, zero value otherwise.
func (o *GetBanksResponseEntityInner) GetCurrency() string {
	if o == nil || isNil(o.Currency) {
		var ret string
		return ret
	}
	return *o.Currency
}

// GetCurrencyOk returns a tuple with the Currency field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *GetBanksResponseEntityInner) GetCurrencyOk() (*string, bool) {
	if o == nil || isNil(o.Currency) {
    return nil, false
	}
	return o.Currency, true
}

// HasCurrency returns a boolean if a field has been set.
func (o *GetBanksResponseEntityInner) HasCurrency() bool {
	if o != nil && !isNil(o.Currency) {
		return true
	}

	return false
}

// SetCurrency gets a reference to the given string and assigns it to the Currency field.
func (o *GetBanksResponseEntityInner) SetCurrency(v string) {
	o.Currency = &v
}

func (o GetBanksResponseEntityInner) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Name) {
		toSerialize["name"] = o.Name
	}
	if !isNil(o.Code) {
		toSerialize["code"] = o.Code
	}
	if !isNil(o.Longcode) {
		toSerialize["longcode"] = o.Longcode
	}
	if o.Gateway.IsSet() {
		toSerialize["gateway"] = o.Gateway.Get()
	}
	if !isNil(o.Slug) {
		toSerialize["slug"] = o.Slug
	}
	if !isNil(o.Country) {
		toSerialize["country"] = o.Country
	}
	if !isNil(o.Currency) {
		toSerialize["currency"] = o.Currency
	}
	return json.Marshal(toSerialize)
}

type NullableGetBanksResponseEntityInner struct {
	value *GetBanksResponseEntityInner
	isSet bool
}

func (v NullableGetBanksResponseEntityInner) Get() *GetBanksResponseEntityInner {
	return v.value
}

func (v *NullableGetBanksResponseEntityInner) Set(val *GetBanksResponseEntityInner) {
	v.value = val
	v.isSet = true
}

func (v NullableGetBanksResponseEntityInner) IsSet() bool {
	return v.isSet
}

func (v *NullableGetBanksResponseEntityInner) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetBanksResponseEntityInner(val *GetBanksResponseEntityInner) *NullableGetBanksResponseEntityInner {
	return &NullableGetBanksResponseEntityInner{value: val, isSet: true}
}

func (v NullableGetBanksResponseEntityInner) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetBanksResponseEntityInner) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


