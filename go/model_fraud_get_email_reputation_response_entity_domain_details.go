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

// FraudGetEmailReputationResponseEntityDomainDetails struct for FraudGetEmailReputationResponseEntityDomainDetails
type FraudGetEmailReputationResponseEntityDomainDetails struct {
	Domain *string `json:"domain,omitempty"`
	Tld *string `json:"tld,omitempty"`
	Registered *bool `json:"registered,omitempty"`
	Created *string `json:"created,omitempty"`
	Updated *string `json:"updated,omitempty"`
	Expires *string `json:"expires,omitempty"`
	RegistrarName *string `json:"registrar_name,omitempty"`
	RegisteredTo NullableString `json:"registered_to,omitempty"`
	Disposable *bool `json:"disposable,omitempty"`
	Free *bool `json:"free,omitempty"`
	Custom *bool `json:"custom,omitempty"`
	DmarcEnforced *bool `json:"dmarc_enforced,omitempty"`
	SpfStrict *bool `json:"spf_strict,omitempty"`
	ValidMx *bool `json:"valid_mx,omitempty"`
	AcceptAll *bool `json:"accept_all,omitempty"`
	SuspiciousTld *bool `json:"suspicious_tld,omitempty"`
	WebsiteExists *bool `json:"website_exists,omitempty"`
}

// NewFraudGetEmailReputationResponseEntityDomainDetails instantiates a new FraudGetEmailReputationResponseEntityDomainDetails object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewFraudGetEmailReputationResponseEntityDomainDetails() *FraudGetEmailReputationResponseEntityDomainDetails {
	this := FraudGetEmailReputationResponseEntityDomainDetails{}
	return &this
}

// NewFraudGetEmailReputationResponseEntityDomainDetailsWithDefaults instantiates a new FraudGetEmailReputationResponseEntityDomainDetails object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewFraudGetEmailReputationResponseEntityDomainDetailsWithDefaults() *FraudGetEmailReputationResponseEntityDomainDetails {
	this := FraudGetEmailReputationResponseEntityDomainDetails{}
	return &this
}

// GetDomain returns the Domain field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDomain() string {
	if o == nil || isNil(o.Domain) {
		var ret string
		return ret
	}
	return *o.Domain
}

// GetDomainOk returns a tuple with the Domain field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDomainOk() (*string, bool) {
	if o == nil || isNil(o.Domain) {
    return nil, false
	}
	return o.Domain, true
}

// HasDomain returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasDomain() bool {
	if o != nil && !isNil(o.Domain) {
		return true
	}

	return false
}

// SetDomain gets a reference to the given string and assigns it to the Domain field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetDomain(v string) {
	o.Domain = &v
}

// GetTld returns the Tld field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetTld() string {
	if o == nil || isNil(o.Tld) {
		var ret string
		return ret
	}
	return *o.Tld
}

// GetTldOk returns a tuple with the Tld field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetTldOk() (*string, bool) {
	if o == nil || isNil(o.Tld) {
    return nil, false
	}
	return o.Tld, true
}

// HasTld returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasTld() bool {
	if o != nil && !isNil(o.Tld) {
		return true
	}

	return false
}

// SetTld gets a reference to the given string and assigns it to the Tld field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetTld(v string) {
	o.Tld = &v
}

// GetRegistered returns the Registered field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegistered() bool {
	if o == nil || isNil(o.Registered) {
		var ret bool
		return ret
	}
	return *o.Registered
}

// GetRegisteredOk returns a tuple with the Registered field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegisteredOk() (*bool, bool) {
	if o == nil || isNil(o.Registered) {
    return nil, false
	}
	return o.Registered, true
}

// HasRegistered returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasRegistered() bool {
	if o != nil && !isNil(o.Registered) {
		return true
	}

	return false
}

// SetRegistered gets a reference to the given bool and assigns it to the Registered field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetRegistered(v bool) {
	o.Registered = &v
}

// GetCreated returns the Created field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetCreated() string {
	if o == nil || isNil(o.Created) {
		var ret string
		return ret
	}
	return *o.Created
}

// GetCreatedOk returns a tuple with the Created field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetCreatedOk() (*string, bool) {
	if o == nil || isNil(o.Created) {
    return nil, false
	}
	return o.Created, true
}

// HasCreated returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasCreated() bool {
	if o != nil && !isNil(o.Created) {
		return true
	}

	return false
}

// SetCreated gets a reference to the given string and assigns it to the Created field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetCreated(v string) {
	o.Created = &v
}

// GetUpdated returns the Updated field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetUpdated() string {
	if o == nil || isNil(o.Updated) {
		var ret string
		return ret
	}
	return *o.Updated
}

// GetUpdatedOk returns a tuple with the Updated field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetUpdatedOk() (*string, bool) {
	if o == nil || isNil(o.Updated) {
    return nil, false
	}
	return o.Updated, true
}

// HasUpdated returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasUpdated() bool {
	if o != nil && !isNil(o.Updated) {
		return true
	}

	return false
}

// SetUpdated gets a reference to the given string and assigns it to the Updated field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetUpdated(v string) {
	o.Updated = &v
}

// GetExpires returns the Expires field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetExpires() string {
	if o == nil || isNil(o.Expires) {
		var ret string
		return ret
	}
	return *o.Expires
}

// GetExpiresOk returns a tuple with the Expires field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetExpiresOk() (*string, bool) {
	if o == nil || isNil(o.Expires) {
    return nil, false
	}
	return o.Expires, true
}

// HasExpires returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasExpires() bool {
	if o != nil && !isNil(o.Expires) {
		return true
	}

	return false
}

// SetExpires gets a reference to the given string and assigns it to the Expires field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetExpires(v string) {
	o.Expires = &v
}

// GetRegistrarName returns the RegistrarName field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegistrarName() string {
	if o == nil || isNil(o.RegistrarName) {
		var ret string
		return ret
	}
	return *o.RegistrarName
}

// GetRegistrarNameOk returns a tuple with the RegistrarName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegistrarNameOk() (*string, bool) {
	if o == nil || isNil(o.RegistrarName) {
    return nil, false
	}
	return o.RegistrarName, true
}

// HasRegistrarName returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasRegistrarName() bool {
	if o != nil && !isNil(o.RegistrarName) {
		return true
	}

	return false
}

// SetRegistrarName gets a reference to the given string and assigns it to the RegistrarName field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetRegistrarName(v string) {
	o.RegistrarName = &v
}

// GetRegisteredTo returns the RegisteredTo field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegisteredTo() string {
	if o == nil || isNil(o.RegisteredTo.Get()) {
		var ret string
		return ret
	}
	return *o.RegisteredTo.Get()
}

// GetRegisteredToOk returns a tuple with the RegisteredTo field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetRegisteredToOk() (*string, bool) {
	if o == nil {
    return nil, false
	}
	return o.RegisteredTo.Get(), o.RegisteredTo.IsSet()
}

// HasRegisteredTo returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasRegisteredTo() bool {
	if o != nil && o.RegisteredTo.IsSet() {
		return true
	}

	return false
}

// SetRegisteredTo gets a reference to the given NullableString and assigns it to the RegisteredTo field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetRegisteredTo(v string) {
	o.RegisteredTo.Set(&v)
}
// SetRegisteredToNil sets the value for RegisteredTo to be an explicit nil
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetRegisteredToNil() {
	o.RegisteredTo.Set(nil)
}

// UnsetRegisteredTo ensures that no value is present for RegisteredTo, not even an explicit nil
func (o *FraudGetEmailReputationResponseEntityDomainDetails) UnsetRegisteredTo() {
	o.RegisteredTo.Unset()
}

// GetDisposable returns the Disposable field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDisposable() bool {
	if o == nil || isNil(o.Disposable) {
		var ret bool
		return ret
	}
	return *o.Disposable
}

// GetDisposableOk returns a tuple with the Disposable field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDisposableOk() (*bool, bool) {
	if o == nil || isNil(o.Disposable) {
    return nil, false
	}
	return o.Disposable, true
}

// HasDisposable returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasDisposable() bool {
	if o != nil && !isNil(o.Disposable) {
		return true
	}

	return false
}

// SetDisposable gets a reference to the given bool and assigns it to the Disposable field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetDisposable(v bool) {
	o.Disposable = &v
}

// GetFree returns the Free field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetFree() bool {
	if o == nil || isNil(o.Free) {
		var ret bool
		return ret
	}
	return *o.Free
}

// GetFreeOk returns a tuple with the Free field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetFreeOk() (*bool, bool) {
	if o == nil || isNil(o.Free) {
    return nil, false
	}
	return o.Free, true
}

// HasFree returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasFree() bool {
	if o != nil && !isNil(o.Free) {
		return true
	}

	return false
}

// SetFree gets a reference to the given bool and assigns it to the Free field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetFree(v bool) {
	o.Free = &v
}

// GetCustom returns the Custom field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetCustom() bool {
	if o == nil || isNil(o.Custom) {
		var ret bool
		return ret
	}
	return *o.Custom
}

// GetCustomOk returns a tuple with the Custom field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetCustomOk() (*bool, bool) {
	if o == nil || isNil(o.Custom) {
    return nil, false
	}
	return o.Custom, true
}

// HasCustom returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasCustom() bool {
	if o != nil && !isNil(o.Custom) {
		return true
	}

	return false
}

// SetCustom gets a reference to the given bool and assigns it to the Custom field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetCustom(v bool) {
	o.Custom = &v
}

// GetDmarcEnforced returns the DmarcEnforced field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDmarcEnforced() bool {
	if o == nil || isNil(o.DmarcEnforced) {
		var ret bool
		return ret
	}
	return *o.DmarcEnforced
}

// GetDmarcEnforcedOk returns a tuple with the DmarcEnforced field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetDmarcEnforcedOk() (*bool, bool) {
	if o == nil || isNil(o.DmarcEnforced) {
    return nil, false
	}
	return o.DmarcEnforced, true
}

// HasDmarcEnforced returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasDmarcEnforced() bool {
	if o != nil && !isNil(o.DmarcEnforced) {
		return true
	}

	return false
}

// SetDmarcEnforced gets a reference to the given bool and assigns it to the DmarcEnforced field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetDmarcEnforced(v bool) {
	o.DmarcEnforced = &v
}

// GetSpfStrict returns the SpfStrict field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetSpfStrict() bool {
	if o == nil || isNil(o.SpfStrict) {
		var ret bool
		return ret
	}
	return *o.SpfStrict
}

// GetSpfStrictOk returns a tuple with the SpfStrict field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetSpfStrictOk() (*bool, bool) {
	if o == nil || isNil(o.SpfStrict) {
    return nil, false
	}
	return o.SpfStrict, true
}

// HasSpfStrict returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasSpfStrict() bool {
	if o != nil && !isNil(o.SpfStrict) {
		return true
	}

	return false
}

// SetSpfStrict gets a reference to the given bool and assigns it to the SpfStrict field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetSpfStrict(v bool) {
	o.SpfStrict = &v
}

// GetValidMx returns the ValidMx field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetValidMx() bool {
	if o == nil || isNil(o.ValidMx) {
		var ret bool
		return ret
	}
	return *o.ValidMx
}

// GetValidMxOk returns a tuple with the ValidMx field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetValidMxOk() (*bool, bool) {
	if o == nil || isNil(o.ValidMx) {
    return nil, false
	}
	return o.ValidMx, true
}

// HasValidMx returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasValidMx() bool {
	if o != nil && !isNil(o.ValidMx) {
		return true
	}

	return false
}

// SetValidMx gets a reference to the given bool and assigns it to the ValidMx field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetValidMx(v bool) {
	o.ValidMx = &v
}

// GetAcceptAll returns the AcceptAll field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetAcceptAll() bool {
	if o == nil || isNil(o.AcceptAll) {
		var ret bool
		return ret
	}
	return *o.AcceptAll
}

// GetAcceptAllOk returns a tuple with the AcceptAll field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetAcceptAllOk() (*bool, bool) {
	if o == nil || isNil(o.AcceptAll) {
    return nil, false
	}
	return o.AcceptAll, true
}

// HasAcceptAll returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasAcceptAll() bool {
	if o != nil && !isNil(o.AcceptAll) {
		return true
	}

	return false
}

// SetAcceptAll gets a reference to the given bool and assigns it to the AcceptAll field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetAcceptAll(v bool) {
	o.AcceptAll = &v
}

// GetSuspiciousTld returns the SuspiciousTld field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetSuspiciousTld() bool {
	if o == nil || isNil(o.SuspiciousTld) {
		var ret bool
		return ret
	}
	return *o.SuspiciousTld
}

// GetSuspiciousTldOk returns a tuple with the SuspiciousTld field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetSuspiciousTldOk() (*bool, bool) {
	if o == nil || isNil(o.SuspiciousTld) {
    return nil, false
	}
	return o.SuspiciousTld, true
}

// HasSuspiciousTld returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasSuspiciousTld() bool {
	if o != nil && !isNil(o.SuspiciousTld) {
		return true
	}

	return false
}

// SetSuspiciousTld gets a reference to the given bool and assigns it to the SuspiciousTld field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetSuspiciousTld(v bool) {
	o.SuspiciousTld = &v
}

// GetWebsiteExists returns the WebsiteExists field value if set, zero value otherwise.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetWebsiteExists() bool {
	if o == nil || isNil(o.WebsiteExists) {
		var ret bool
		return ret
	}
	return *o.WebsiteExists
}

// GetWebsiteExistsOk returns a tuple with the WebsiteExists field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) GetWebsiteExistsOk() (*bool, bool) {
	if o == nil || isNil(o.WebsiteExists) {
    return nil, false
	}
	return o.WebsiteExists, true
}

// HasWebsiteExists returns a boolean if a field has been set.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) HasWebsiteExists() bool {
	if o != nil && !isNil(o.WebsiteExists) {
		return true
	}

	return false
}

// SetWebsiteExists gets a reference to the given bool and assigns it to the WebsiteExists field.
func (o *FraudGetEmailReputationResponseEntityDomainDetails) SetWebsiteExists(v bool) {
	o.WebsiteExists = &v
}

func (o FraudGetEmailReputationResponseEntityDomainDetails) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Domain) {
		toSerialize["domain"] = o.Domain
	}
	if !isNil(o.Tld) {
		toSerialize["tld"] = o.Tld
	}
	if !isNil(o.Registered) {
		toSerialize["registered"] = o.Registered
	}
	if !isNil(o.Created) {
		toSerialize["created"] = o.Created
	}
	if !isNil(o.Updated) {
		toSerialize["updated"] = o.Updated
	}
	if !isNil(o.Expires) {
		toSerialize["expires"] = o.Expires
	}
	if !isNil(o.RegistrarName) {
		toSerialize["registrar_name"] = o.RegistrarName
	}
	if o.RegisteredTo.IsSet() {
		toSerialize["registered_to"] = o.RegisteredTo.Get()
	}
	if !isNil(o.Disposable) {
		toSerialize["disposable"] = o.Disposable
	}
	if !isNil(o.Free) {
		toSerialize["free"] = o.Free
	}
	if !isNil(o.Custom) {
		toSerialize["custom"] = o.Custom
	}
	if !isNil(o.DmarcEnforced) {
		toSerialize["dmarc_enforced"] = o.DmarcEnforced
	}
	if !isNil(o.SpfStrict) {
		toSerialize["spf_strict"] = o.SpfStrict
	}
	if !isNil(o.ValidMx) {
		toSerialize["valid_mx"] = o.ValidMx
	}
	if !isNil(o.AcceptAll) {
		toSerialize["accept_all"] = o.AcceptAll
	}
	if !isNil(o.SuspiciousTld) {
		toSerialize["suspicious_tld"] = o.SuspiciousTld
	}
	if !isNil(o.WebsiteExists) {
		toSerialize["website_exists"] = o.WebsiteExists
	}
	return json.Marshal(toSerialize)
}

type NullableFraudGetEmailReputationResponseEntityDomainDetails struct {
	value *FraudGetEmailReputationResponseEntityDomainDetails
	isSet bool
}

func (v NullableFraudGetEmailReputationResponseEntityDomainDetails) Get() *FraudGetEmailReputationResponseEntityDomainDetails {
	return v.value
}

func (v *NullableFraudGetEmailReputationResponseEntityDomainDetails) Set(val *FraudGetEmailReputationResponseEntityDomainDetails) {
	v.value = val
	v.isSet = true
}

func (v NullableFraudGetEmailReputationResponseEntityDomainDetails) IsSet() bool {
	return v.isSet
}

func (v *NullableFraudGetEmailReputationResponseEntityDomainDetails) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableFraudGetEmailReputationResponseEntityDomainDetails(val *FraudGetEmailReputationResponseEntityDomainDetails) *NullableFraudGetEmailReputationResponseEntityDomainDetails {
	return &NullableFraudGetEmailReputationResponseEntityDomainDetails{value: val, isSet: true}
}

func (v NullableFraudGetEmailReputationResponseEntityDomainDetails) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableFraudGetEmailReputationResponseEntityDomainDetails) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


