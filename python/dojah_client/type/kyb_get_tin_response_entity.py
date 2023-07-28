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


class RequiredKybGetTinResponseEntity(TypedDict):
    pass

class OptionalKybGetTinResponseEntity(TypedDict, total=False):
    Search: str

    Taxpayer_Name: str

    CAC_Reg_No: str

    FIRSTIN: str

    JITTIN: str

    Tax_Office: str

    Phone_No: str

    Email: str

class KybGetTinResponseEntity(RequiredKybGetTinResponseEntity, OptionalKybGetTinResponseEntity):
    pass
