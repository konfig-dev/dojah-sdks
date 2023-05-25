# coding: utf-8

"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from dataclasses import dataclass
import typing_extensions
import urllib3
import json
from urllib3._collections import HTTPHeaderDict

from dojah_client.api_response import AsyncGeneratorResponse
from dojah_client import api_client, exceptions
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

from dojah_client.model.send_sms_request import SendSmsRequest as SendSmsRequestSchema
from dojah_client.model.send_sms_response import SendSmsResponse as SendSmsResponseSchema

from dojah_client.type.send_sms_response import SendSmsResponse
from dojah_client.type.send_sms_request import SendSmsRequest

from . import path

# body param
SchemaForRequestBodyApplicationJson = SendSmsRequestSchema


request_body_send_sms_request = api_client.RequestBody(
    content={
        'application/json': api_client.MediaType(
            schema=SchemaForRequestBodyApplicationJson),
    },
)
_auth = [
    'apikeyAuth',
    'appIdAuth',
]
XPoweredBySchema = schemas.StrSchema
x_powered_by_parameter = api_client.HeaderParameter(
    name="X-Powered-By",
    style=api_client.ParameterStyle.SIMPLE,
    schema=XPoweredBySchema,
)
AccessControlAllowOriginSchema = schemas.StrSchema
access_control_allow_origin_parameter = api_client.HeaderParameter(
    name="Access-Control-Allow-Origin",
    style=api_client.ParameterStyle.SIMPLE,
    schema=AccessControlAllowOriginSchema,
)
ContentLengthSchema = schemas.IntSchema
content_length_parameter = api_client.HeaderParameter(
    name="Content-Length",
    style=api_client.ParameterStyle.SIMPLE,
    schema=ContentLengthSchema,
)
ETagSchema = schemas.StrSchema
e_tag_parameter = api_client.HeaderParameter(
    name="ETag",
    style=api_client.ParameterStyle.SIMPLE,
    schema=ETagSchema,
)
DateSchema = schemas.StrSchema
date_parameter = api_client.HeaderParameter(
    name="Date",
    style=api_client.ParameterStyle.SIMPLE,
    schema=DateSchema,
)
ConnectionSchema = schemas.StrSchema
connection_parameter = api_client.HeaderParameter(
    name="Connection",
    style=api_client.ParameterStyle.SIMPLE,
    schema=ConnectionSchema,
)
SchemaFor200ResponseBodyApplicationJson = SendSmsResponseSchema
ResponseHeadersFor200 = typing_extensions.TypedDict(
    'ResponseHeadersFor200',
    {
        'X-Powered-By': XPoweredBySchema,
        'Access-Control-Allow-Origin': AccessControlAllowOriginSchema,
        'Content-Length': ContentLengthSchema,
        'ETag': ETagSchema,
        'Date': DateSchema,
        'Connection': ConnectionSchema,
    }
)


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: SendSmsResponse


@dataclass
class ApiResponseFor200Async(api_client.AsyncApiResponse):
    body: SendSmsResponse


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    response_cls_async=ApiResponseFor200Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
    headers=[
        x_powered_by_parameter,
        access_control_allow_origin_parameter,
        content_length_parameter,
        e_tag_parameter,
        date_parameter,
        connection_parameter,
    ]
)
_status_code_to_response = {
    '200': _response_for_200,
}
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _send_sms_mapped_args(
        self,
        destination: typing.Optional[str] = None,
        message: typing.Optional[str] = None,
        channel: typing.Optional[str] = None,
        sender_id: typing.Optional[str] = None,
    ) -> api_client.MappedArgs:
        args: api_client.MappedArgs = api_client.MappedArgs()
        _body = {}
        if destination is not None:
            _body["destination"] = destination
        if message is not None:
            _body["message"] = message
        if channel is not None:
            _body["channel"] = channel
        if sender_id is not None:
            _body["sender_id"] = sender_id
        args.body = _body
        return args

    async def _asend_sms_oapg(
        self,
        body: typing.Any = None,
        skip_deserialization: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        """
        Messaging - Send SMS
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        used_path = path.value
    
        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
    
        _fields = None
        _body = None
        if body is not schemas.unset:
            serialized_data = request_body_send_sms_request.serialize(body, content_type)
            _headers.add('Content-Type', content_type)
            if 'fields' in serialized_data:
                _fields = serialized_data['fields']
            elif 'body' in serialized_data:
                _body = serialized_data['body']    
        response = await self.api_client.async_call_api(
            resource_path=used_path,
            method='post'.upper(),
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            timeout=timeout,
        )
        
        if stream:
            async def stream_iterator():
                """
                iterates over response.http_response.content and closes connection once iteration has finished
                """
                async for line in response.http_response.content:
                    if line == b'\r\n':
                        continue
                    yield line
                response.http_response.close()
                await response.session.close()
            return AsyncGeneratorResponse(
                content=stream_iterator(),
                headers=response.http_response.headers,
                status=response.http_response.status,
                response=response.http_response
            )
    
        response_for_status = _status_code_to_response.get(str(response.http_response.status))
        if response_for_status:
            api_response = await response_for_status.deserialize_async(
                                                    response,
                                                    self.api_client.configuration,
                                                    skip_deserialization=skip_deserialization
                                                )
        else:
            # If response data is JSON then deserialize for SDK consumer convenience
            is_json = api_client.JSONDetector._content_type_is_json(response.http_response.headers.get('Content-Type', ''))
            api_response = api_client.ApiResponseWithoutDeserializationAsync(
                body=await response.http_response.json() if is_json else await response.http_response.text(),
                response=response.http_response,
                round_trip_time=response.round_trip_time,
                status=response.http_response.status,
                headers=response.http_response.headers,
            )
    
        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)
    
        # cleanup session / response
        response.http_response.close()
        await response.session.close()
    
        return api_response

    def _send_sms_oapg(
        self,
        body: typing.Any = None,
        skip_deserialization: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        content_type: str = 'application/json',
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        Messaging - Send SMS
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        used_path = path.value
    
        _headers = HTTPHeaderDict()
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
    
        _fields = None
        _body = None
        if body is not schemas.unset:
            serialized_data = request_body_send_sms_request.serialize(body, content_type)
            _headers.add('Content-Type', content_type)
            if 'fields' in serialized_data:
                _fields = serialized_data['fields']
            elif 'body' in serialized_data:
                _body = serialized_data['body']    
        response = self.api_client.call_api(
            resource_path=used_path,
            method='post'.upper(),
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
            timeout=timeout,
        )
    
        response_for_status = _status_code_to_response.get(str(response.http_response.status))
        if response_for_status:
            api_response = response_for_status.deserialize(
                                                    response,
                                                    self.api_client.configuration,
                                                    skip_deserialization=skip_deserialization
                                                )
        else:
            # If response data is JSON then deserialize for SDK consumer convenience
            is_json = api_client.JSONDetector._content_type_is_json(response.http_response.headers.get('Content-Type', ''))
            api_response = api_client.ApiResponseWithoutDeserialization(
                body=json.loads(response.http_response.data) if is_json else response.http_response.data,
                response=response.http_response,
                round_trip_time=response.round_trip_time,
                status=response.http_response.status,
                headers=response.http_response.headers,
            )
    
        if not 200 <= api_response.status <= 299:
            raise exceptions.ApiException(api_response=api_response)
    
        return api_response

class SendSms(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    async def asend_sms(
        self,
        destination: typing.Optional[str] = None,
        message: typing.Optional[str] = None,
        channel: typing.Optional[str] = None,
        sender_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._send_sms_mapped_args(
            destination=destination,
            message=message,
            channel=channel,
            sender_id=sender_id,
        )
        return await self._asend_sms_oapg(
            body=args.body,
        )
    
    def send_sms(
        self,
        destination: typing.Optional[str] = None,
        message: typing.Optional[str] = None,
        channel: typing.Optional[str] = None,
        sender_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._send_sms_mapped_args(
            destination=destination,
            message=message,
            channel=channel,
            sender_id=sender_id,
        )
        return self._send_sms_oapg(
            body=args.body,
        )

class ApiForpost(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    async def apost(
        self,
        destination: typing.Optional[str] = None,
        message: typing.Optional[str] = None,
        channel: typing.Optional[str] = None,
        sender_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._send_sms_mapped_args(
            destination=destination,
            message=message,
            channel=channel,
            sender_id=sender_id,
        )
        return await self._asend_sms_oapg(
            body=args.body,
        )
    
    def post(
        self,
        destination: typing.Optional[str] = None,
        message: typing.Optional[str] = None,
        channel: typing.Optional[str] = None,
        sender_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._send_sms_mapped_args(
            destination=destination,
            message=message,
            channel=channel,
            sender_id=sender_id,
        )
        return self._send_sms_oapg(
            body=args.body,
        )

