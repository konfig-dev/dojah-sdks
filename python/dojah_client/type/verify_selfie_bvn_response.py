# coding: utf-8

"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal


RequiredVerifySelfieBvnResponse = TypedDict("RequiredVerifySelfieBvnResponse", {
    })

OptionalVerifySelfieBvnResponse = TypedDict("OptionalVerifySelfieBvnResponse", {
    "entity": typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]],
    }, total=False)

class VerifySelfieBvnResponse(RequiredVerifySelfieBvnResponse, OptionalVerifySelfieBvnResponse):
    pass
