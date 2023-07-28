# coding: utf-8

"""
    DOJAH Publilc APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal

from dojah_client.type.fraud_screen_phone_response_entity_account_details_registered import FraudScreenPhoneResponseEntityAccountDetailsRegistered

class RequiredFraudScreenPhoneResponseEntity(TypedDict):
    pass

class OptionalFraudScreenPhoneResponseEntity(TypedDict, total=False):
    number: typing.Union[int, float]

    valid: bool

    disposable: bool

    type: str

    country: str

    carrier: str

    score: typing.Union[int, float]

    account_details_registered: FraudScreenPhoneResponseEntityAccountDetailsRegistered

class FraudScreenPhoneResponseEntity(RequiredFraudScreenPhoneResponseEntity, OptionalFraudScreenPhoneResponseEntity):
    pass
