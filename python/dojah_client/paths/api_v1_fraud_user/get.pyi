# coding: utf-8

"""
    DOJAH Publilc APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from dataclasses import dataclass
import typing_extensions
import urllib3
from dojah_client.request_before_hook import request_before_hook
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

from dojah_client.model.fraud_screen_user_response import FraudScreenUserResponse as FraudScreenUserResponseSchema

from dojah_client.type.fraud_screen_user_response import FraudScreenUserResponse

# Query params
FirstNameSchema = schemas.StrSchema
LastNameSchema = schemas.StrSchema
DateOfBirthSchema = schemas.StrSchema
EmailSchema = schemas.StrSchema
PhoneSchema = schemas.StrSchema
IpAddressSchema = schemas.StrSchema
RequestRequiredQueryParams = typing_extensions.TypedDict(
    'RequestRequiredQueryParams',
    {
    }
)
RequestOptionalQueryParams = typing_extensions.TypedDict(
    'RequestOptionalQueryParams',
    {
        'first_name': typing.Union[FirstNameSchema, str, ],
        'last_name': typing.Union[LastNameSchema, str, ],
        'date_of_birth': typing.Union[DateOfBirthSchema, str, ],
        'email': typing.Union[EmailSchema, str, ],
        'phone': typing.Union[PhoneSchema, str, ],
        'ip_address': typing.Union[IpAddressSchema, str, ],
    },
    total=False
)


class RequestQueryParams(RequestRequiredQueryParams, RequestOptionalQueryParams):
    pass


request_query_first_name = api_client.QueryParameter(
    name="first_name",
    style=api_client.ParameterStyle.FORM,
    schema=FirstNameSchema,
    explode=True,
)
request_query_last_name = api_client.QueryParameter(
    name="last_name",
    style=api_client.ParameterStyle.FORM,
    schema=LastNameSchema,
    explode=True,
)
request_query_date_of_birth = api_client.QueryParameter(
    name="date_of_birth",
    style=api_client.ParameterStyle.FORM,
    schema=DateOfBirthSchema,
    explode=True,
)
request_query_email = api_client.QueryParameter(
    name="email",
    style=api_client.ParameterStyle.FORM,
    schema=EmailSchema,
    explode=True,
)
request_query_phone = api_client.QueryParameter(
    name="phone",
    style=api_client.ParameterStyle.FORM,
    schema=PhoneSchema,
    explode=True,
)
request_query_ip_address = api_client.QueryParameter(
    name="ip_address",
    style=api_client.ParameterStyle.FORM,
    schema=IpAddressSchema,
    explode=True,
)
# Header params
AppIdSchema = schemas.StrSchema
RequestRequiredHeaderParams = typing_extensions.TypedDict(
    'RequestRequiredHeaderParams',
    {
    }
)
RequestOptionalHeaderParams = typing_extensions.TypedDict(
    'RequestOptionalHeaderParams',
    {
        'AppId': typing.Union[AppIdSchema, str, ],
    },
    total=False
)


class RequestHeaderParams(RequestRequiredHeaderParams, RequestOptionalHeaderParams):
    pass


request_header_app_id = api_client.HeaderParameter(
    name="AppId",
    style=api_client.ParameterStyle.SIMPLE,
    schema=AppIdSchema,
)
AccessControlAllowOriginSchema = schemas.StrSchema
UuidSchema = schemas.StrSchema
XMoesifTransactionIdSchema = schemas.StrSchema
RateLimitLimitSchema = schemas.IntSchema
RateLimitRemainingSchema = schemas.IntSchema
RateLimitResetSchema = schemas.IntSchema
ServiceSchema = schemas.StrSchema
ProductSchema = schemas.StrSchema
PriceSchema = schemas.IntSchema
ETagSchema = schemas.StrSchema
VarySchema = schemas.StrSchema
ContentEncodingSchema = schemas.StrSchema
DateSchema = schemas.StrSchema
ConnectionSchema = schemas.StrSchema
KeepAliveSchema = schemas.StrSchema
TransferEncodingSchema = schemas.StrSchema
SchemaFor200ResponseBodyApplicationJson = FraudScreenUserResponseSchema
ResponseHeadersFor200 = typing_extensions.TypedDict(
    'ResponseHeadersFor200',
    {
        'Access-Control-Allow-Origin': AccessControlAllowOriginSchema,
        'uuid': UuidSchema,
        'x-moesif-transaction-id': XMoesifTransactionIdSchema,
        'RateLimit-Limit': RateLimitLimitSchema,
        'RateLimit-Remaining': RateLimitRemainingSchema,
        'RateLimit-Reset': RateLimitResetSchema,
        'service': ServiceSchema,
        'product': ProductSchema,
        'price': PriceSchema,
        'ETag': ETagSchema,
        'Vary': VarySchema,
        'Content-Encoding': ContentEncodingSchema,
        'Date': DateSchema,
        'Connection': ConnectionSchema,
        'Keep-Alive': KeepAliveSchema,
        'Transfer-Encoding': TransferEncodingSchema,
    }
)


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: FraudScreenUserResponse


@dataclass
class ApiResponseFor200Async(api_client.AsyncApiResponse):
    body: FraudScreenUserResponse


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    response_cls_async=ApiResponseFor200Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
    headers=[
        access_control_allow_origin_parameter,
        uuid_parameter,
        x_moesif_transaction_id_parameter,
        rate_limit_limit_parameter,
        rate_limit_remaining_parameter,
        rate_limit_reset_parameter,
        service_parameter,
        product_parameter,
        price_parameter,
        e_tag_parameter,
        vary_parameter,
        content_encoding_parameter,
        date_parameter,
        connection_parameter,
        keep_alive_parameter,
        transfer_encoding_parameter,
    ]
)
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _screen_user_mapped_args(
        self,
        app_id: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        email: typing.Optional[str] = None,
        phone: typing.Optional[str] = None,
        ip_address: typing.Optional[str] = None,
    ) -> api_client.MappedArgs:
        args: api_client.MappedArgs = api_client.MappedArgs()
        _query_params = {}
        _header_params = {}
        if first_name is not None:
            _query_params["first_name"] = first_name
        if last_name is not None:
            _query_params["last_name"] = last_name
        if date_of_birth is not None:
            _query_params["date_of_birth"] = date_of_birth
        if email is not None:
            _query_params["email"] = email
        if phone is not None:
            _query_params["phone"] = phone
        if ip_address is not None:
            _query_params["ip_address"] = ip_address
        if app_id is not None:
            _header_params["AppId"] = app_id
        args.query = _query_params
        args.header = _header_params
        return args

    async def _ascreen_user_oapg(
        self,
            query_params: typing.Optional[dict] = {},
            header_params: typing.Optional[dict] = {},
        skip_deserialization: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        """
        User Screening
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        self._verify_typed_dict_inputs_oapg(RequestHeaderParams, header_params)
        used_path = path.value
    
        prefix_separator_iterator = None
        for parameter in (
            request_query_first_name,
            request_query_last_name,
            request_query_date_of_birth,
            request_query_email,
            request_query_phone,
            request_query_ip_address,
        ):
            parameter_data = query_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            if prefix_separator_iterator is None:
                prefix_separator_iterator = parameter.get_prefix_separator_iterator()
            serialized_data = parameter.serialize(parameter_data, prefix_separator_iterator)
            for serialized_value in serialized_data.values():
                used_path += serialized_value
    
        _headers = HTTPHeaderDict()
        for parameter in (
            request_header_app_id,
        ):
            parameter_data = header_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            serialized_data = parameter.serialize(parameter_data)
            _headers.extend(serialized_data)
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'get'.upper()
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            headers=_headers,
        )
    
        response = await self.api_client.async_call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            prefix_separator_iterator=prefix_separator_iterator,
            timeout=timeout,
        )
    
        if stream:
            if not 200 <= response.http_response.status <= 299:
                body = (await response.http_response.content.read()).decode("utf-8")
                raise exceptions.ApiStreamingException(
                    status=response.http_response.status,
                    reason=response.http_response.reason,
                    body=body,
                )
    
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


    def _screen_user_oapg(
        self,
            query_params: typing.Optional[dict] = {},
            header_params: typing.Optional[dict] = {},
        skip_deserialization: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        User Screening
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        self._verify_typed_dict_inputs_oapg(RequestHeaderParams, header_params)
        used_path = path.value
    
        prefix_separator_iterator = None
        for parameter in (
            request_query_first_name,
            request_query_last_name,
            request_query_date_of_birth,
            request_query_email,
            request_query_phone,
            request_query_ip_address,
        ):
            parameter_data = query_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            if prefix_separator_iterator is None:
                prefix_separator_iterator = parameter.get_prefix_separator_iterator()
            serialized_data = parameter.serialize(parameter_data, prefix_separator_iterator)
            for serialized_value in serialized_data.values():
                used_path += serialized_value
    
        _headers = HTTPHeaderDict()
        for parameter in (
            request_header_app_id,
        ):
            parameter_data = header_params.get(parameter.name, schemas.unset)
            if parameter_data is schemas.unset:
                continue
            serialized_data = parameter.serialize(parameter_data)
            _headers.extend(serialized_data)
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'get'.upper()
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            headers=_headers,
        )
    
        response = self.api_client.call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            prefix_separator_iterator=prefix_separator_iterator,
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


class ScreenUser(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    async def ascreen_user(
        self,
        app_id: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        email: typing.Optional[str] = None,
        phone: typing.Optional[str] = None,
        ip_address: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._screen_user_mapped_args(
            app_id=app_id,
            first_name=first_name,
            last_name=last_name,
            date_of_birth=date_of_birth,
            email=email,
            phone=phone,
            ip_address=ip_address,
        )
        return await self._ascreen_user_oapg(
            query_params=args.query,
            header_params=args.header,
        )
    
    def screen_user(
        self,
        app_id: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        email: typing.Optional[str] = None,
        phone: typing.Optional[str] = None,
        ip_address: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._screen_user_mapped_args(
            app_id=app_id,
            first_name=first_name,
            last_name=last_name,
            date_of_birth=date_of_birth,
            email=email,
            phone=phone,
            ip_address=ip_address,
        )
        return self._screen_user_oapg(
            query_params=args.query,
            header_params=args.header,
        )

class ApiForget(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    async def aget(
        self,
        app_id: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        email: typing.Optional[str] = None,
        phone: typing.Optional[str] = None,
        ip_address: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._screen_user_mapped_args(
            app_id=app_id,
            first_name=first_name,
            last_name=last_name,
            date_of_birth=date_of_birth,
            email=email,
            phone=phone,
            ip_address=ip_address,
        )
        return await self._ascreen_user_oapg(
            query_params=args.query,
            header_params=args.header,
        )
    
    def get(
        self,
        app_id: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        email: typing.Optional[str] = None,
        phone: typing.Optional[str] = None,
        ip_address: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._screen_user_mapped_args(
            app_id=app_id,
            first_name=first_name,
            last_name=last_name,
            date_of_birth=date_of_birth,
            email=email,
            phone=phone,
            ip_address=ip_address,
        )
        return self._screen_user_oapg(
            query_params=args.query,
            header_params=args.header,
        )

