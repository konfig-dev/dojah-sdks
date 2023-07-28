# coding: utf-8

"""
    DOJAH Publilc APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from dojah_client import schemas  # noqa: F401


class RequestSenderIdResponseEntity(
    schemas.ListSchema
):
    """NOTE:
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        
        @staticmethod
        def items() -> typing.Type['RequestSenderIdResponseEntityItem']:
            return RequestSenderIdResponseEntityItem

    def __new__(
        cls,
        arg: typing.Union[typing.Tuple['RequestSenderIdResponseEntityItem'], typing.List['RequestSenderIdResponseEntityItem']],
        _configuration: typing.Optional[schemas.Configuration] = None,
    ) -> 'RequestSenderIdResponseEntity':
        return super().__new__(
            cls,
            arg,
            _configuration=_configuration,
        )

    def __getitem__(self, i: int) -> 'RequestSenderIdResponseEntityItem':
        return super().__getitem__(i)

from dojah_client.model.request_sender_id_response_entity_item import RequestSenderIdResponseEntityItem
