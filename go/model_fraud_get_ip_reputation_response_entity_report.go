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

// FraudGetIpReputationResponseEntityReport struct for FraudGetIpReputationResponseEntityReport
type FraudGetIpReputationResponseEntityReport struct {
	Ip *string `json:"ip,omitempty"`
	Blacklists *FraudGetIpReputationResponseEntityReportBlacklists `json:"blacklists,omitempty"`
	Information *FraudGetIpReputationResponseEntityReportInformation `json:"information,omitempty"`
	Anonymity *FraudGetIpReputationResponseEntityReportAnonymity `json:"anonymity,omitempty"`
	RiskScore *FraudGetIpReputationResponseEntityReportRiskScore `json:"risk_score,omitempty"`
}

// NewFraudGetIpReputationResponseEntityReport instantiates a new FraudGetIpReputationResponseEntityReport object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewFraudGetIpReputationResponseEntityReport() *FraudGetIpReputationResponseEntityReport {
	this := FraudGetIpReputationResponseEntityReport{}
	return &this
}

// NewFraudGetIpReputationResponseEntityReportWithDefaults instantiates a new FraudGetIpReputationResponseEntityReport object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewFraudGetIpReputationResponseEntityReportWithDefaults() *FraudGetIpReputationResponseEntityReport {
	this := FraudGetIpReputationResponseEntityReport{}
	return &this
}

// GetIp returns the Ip field value if set, zero value otherwise.
func (o *FraudGetIpReputationResponseEntityReport) GetIp() string {
	if o == nil || isNil(o.Ip) {
		var ret string
		return ret
	}
	return *o.Ip
}

// GetIpOk returns a tuple with the Ip field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetIpReputationResponseEntityReport) GetIpOk() (*string, bool) {
	if o == nil || isNil(o.Ip) {
    return nil, false
	}
	return o.Ip, true
}

// HasIp returns a boolean if a field has been set.
func (o *FraudGetIpReputationResponseEntityReport) HasIp() bool {
	if o != nil && !isNil(o.Ip) {
		return true
	}

	return false
}

// SetIp gets a reference to the given string and assigns it to the Ip field.
func (o *FraudGetIpReputationResponseEntityReport) SetIp(v string) {
	o.Ip = &v
}

// GetBlacklists returns the Blacklists field value if set, zero value otherwise.
func (o *FraudGetIpReputationResponseEntityReport) GetBlacklists() FraudGetIpReputationResponseEntityReportBlacklists {
	if o == nil || isNil(o.Blacklists) {
		var ret FraudGetIpReputationResponseEntityReportBlacklists
		return ret
	}
	return *o.Blacklists
}

// GetBlacklistsOk returns a tuple with the Blacklists field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetIpReputationResponseEntityReport) GetBlacklistsOk() (*FraudGetIpReputationResponseEntityReportBlacklists, bool) {
	if o == nil || isNil(o.Blacklists) {
    return nil, false
	}
	return o.Blacklists, true
}

// HasBlacklists returns a boolean if a field has been set.
func (o *FraudGetIpReputationResponseEntityReport) HasBlacklists() bool {
	if o != nil && !isNil(o.Blacklists) {
		return true
	}

	return false
}

// SetBlacklists gets a reference to the given FraudGetIpReputationResponseEntityReportBlacklists and assigns it to the Blacklists field.
func (o *FraudGetIpReputationResponseEntityReport) SetBlacklists(v FraudGetIpReputationResponseEntityReportBlacklists) {
	o.Blacklists = &v
}

// GetInformation returns the Information field value if set, zero value otherwise.
func (o *FraudGetIpReputationResponseEntityReport) GetInformation() FraudGetIpReputationResponseEntityReportInformation {
	if o == nil || isNil(o.Information) {
		var ret FraudGetIpReputationResponseEntityReportInformation
		return ret
	}
	return *o.Information
}

// GetInformationOk returns a tuple with the Information field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetIpReputationResponseEntityReport) GetInformationOk() (*FraudGetIpReputationResponseEntityReportInformation, bool) {
	if o == nil || isNil(o.Information) {
    return nil, false
	}
	return o.Information, true
}

// HasInformation returns a boolean if a field has been set.
func (o *FraudGetIpReputationResponseEntityReport) HasInformation() bool {
	if o != nil && !isNil(o.Information) {
		return true
	}

	return false
}

// SetInformation gets a reference to the given FraudGetIpReputationResponseEntityReportInformation and assigns it to the Information field.
func (o *FraudGetIpReputationResponseEntityReport) SetInformation(v FraudGetIpReputationResponseEntityReportInformation) {
	o.Information = &v
}

// GetAnonymity returns the Anonymity field value if set, zero value otherwise.
func (o *FraudGetIpReputationResponseEntityReport) GetAnonymity() FraudGetIpReputationResponseEntityReportAnonymity {
	if o == nil || isNil(o.Anonymity) {
		var ret FraudGetIpReputationResponseEntityReportAnonymity
		return ret
	}
	return *o.Anonymity
}

// GetAnonymityOk returns a tuple with the Anonymity field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetIpReputationResponseEntityReport) GetAnonymityOk() (*FraudGetIpReputationResponseEntityReportAnonymity, bool) {
	if o == nil || isNil(o.Anonymity) {
    return nil, false
	}
	return o.Anonymity, true
}

// HasAnonymity returns a boolean if a field has been set.
func (o *FraudGetIpReputationResponseEntityReport) HasAnonymity() bool {
	if o != nil && !isNil(o.Anonymity) {
		return true
	}

	return false
}

// SetAnonymity gets a reference to the given FraudGetIpReputationResponseEntityReportAnonymity and assigns it to the Anonymity field.
func (o *FraudGetIpReputationResponseEntityReport) SetAnonymity(v FraudGetIpReputationResponseEntityReportAnonymity) {
	o.Anonymity = &v
}

// GetRiskScore returns the RiskScore field value if set, zero value otherwise.
func (o *FraudGetIpReputationResponseEntityReport) GetRiskScore() FraudGetIpReputationResponseEntityReportRiskScore {
	if o == nil || isNil(o.RiskScore) {
		var ret FraudGetIpReputationResponseEntityReportRiskScore
		return ret
	}
	return *o.RiskScore
}

// GetRiskScoreOk returns a tuple with the RiskScore field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *FraudGetIpReputationResponseEntityReport) GetRiskScoreOk() (*FraudGetIpReputationResponseEntityReportRiskScore, bool) {
	if o == nil || isNil(o.RiskScore) {
    return nil, false
	}
	return o.RiskScore, true
}

// HasRiskScore returns a boolean if a field has been set.
func (o *FraudGetIpReputationResponseEntityReport) HasRiskScore() bool {
	if o != nil && !isNil(o.RiskScore) {
		return true
	}

	return false
}

// SetRiskScore gets a reference to the given FraudGetIpReputationResponseEntityReportRiskScore and assigns it to the RiskScore field.
func (o *FraudGetIpReputationResponseEntityReport) SetRiskScore(v FraudGetIpReputationResponseEntityReportRiskScore) {
	o.RiskScore = &v
}

func (o FraudGetIpReputationResponseEntityReport) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if !isNil(o.Ip) {
		toSerialize["ip"] = o.Ip
	}
	if !isNil(o.Blacklists) {
		toSerialize["blacklists"] = o.Blacklists
	}
	if !isNil(o.Information) {
		toSerialize["information"] = o.Information
	}
	if !isNil(o.Anonymity) {
		toSerialize["anonymity"] = o.Anonymity
	}
	if !isNil(o.RiskScore) {
		toSerialize["risk_score"] = o.RiskScore
	}
	return json.Marshal(toSerialize)
}

type NullableFraudGetIpReputationResponseEntityReport struct {
	value *FraudGetIpReputationResponseEntityReport
	isSet bool
}

func (v NullableFraudGetIpReputationResponseEntityReport) Get() *FraudGetIpReputationResponseEntityReport {
	return v.value
}

func (v *NullableFraudGetIpReputationResponseEntityReport) Set(val *FraudGetIpReputationResponseEntityReport) {
	v.value = val
	v.isSet = true
}

func (v NullableFraudGetIpReputationResponseEntityReport) IsSet() bool {
	return v.isSet
}

func (v *NullableFraudGetIpReputationResponseEntityReport) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableFraudGetIpReputationResponseEntityReport(val *FraudGetIpReputationResponseEntityReport) *NullableFraudGetIpReputationResponseEntityReport {
	return &NullableFraudGetIpReputationResponseEntityReport{value: val, isSet: true}
}

func (v NullableFraudGetIpReputationResponseEntityReport) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableFraudGetIpReputationResponseEntityReport) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


