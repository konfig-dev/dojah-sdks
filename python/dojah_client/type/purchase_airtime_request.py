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


class RequiredPurchaseAirtimeRequest(TypedDict):
    pass

class OptionalPurchaseAirtimeRequest(TypedDict, total=False):
    destination: str

    amount: str

class PurchaseAirtimeRequest(RequiredPurchaseAirtimeRequest, OptionalPurchaseAirtimeRequest):
    pass
