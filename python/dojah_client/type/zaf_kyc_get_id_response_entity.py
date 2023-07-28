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


class RequiredZafKycGetIdResponseEntity(TypedDict):
    pass

class OptionalZafKycGetIdResponseEntity(TypedDict, total=False):
    birth_place_country: str

    birth_place_country_code: str

    booked_date: str

    card_date: str

    date_of_birth: str

    full_name: str

    gender: str

    id_blocked: str

    id_number: str

    issued_date: str

    last_name: str

    maiden_name: str

    marital_status: str

    on_HANIS: str

    on_NPR: str

    photo: str

    smart_card_issued: str

    status: typing.Union[int, float]

class ZafKycGetIdResponseEntity(RequiredZafKycGetIdResponseEntity, OptionalZafKycGetIdResponseEntity):
    pass
