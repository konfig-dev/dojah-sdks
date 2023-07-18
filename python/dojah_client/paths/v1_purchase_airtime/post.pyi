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

from dojah_client.model.purchase_airtime_response import PurchaseAirtimeResponse as PurchaseAirtimeResponseSchema
from dojah_client.model.purchase_airtime_request import PurchaseAirtimeRequest as PurchaseAirtimeRequestSchema

from dojah_client.type.purchase_airtime_request import PurchaseAirtimeRequest
from dojah_client.type.purchase_airtime_response import PurchaseAirtimeResponse

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
# body param
SchemaForRequestBodyApplicationJson = PurchaseAirtimeRequestSchema


request_body_purchase_airtime_request = api_client.RequestBody(
    content={
        'application/json': api_client.MediaType(
            schema=SchemaForRequestBodyApplicationJson),
    },
    required=True,
)
DateSchema = schemas.StrSchema
TransferEncodingSchema = schemas.StrSchema
ConnectionSchema = schemas.StrSchema
AccessControlAllowOriginSchema = schemas.StrSchema
XMoesifTransactionIdSchema = schemas.StrSchema
EtagSchema = schemas.StrSchema
VarySchema = schemas.StrSchema
CFCacheStatusSchema = schemas.StrSchema
ExpectCTSchema = schemas.StrSchema
ReportToSchema = schemas.StrSchema
NELSchema = schemas.StrSchema
ServerSchema = schemas.StrSchema
CFRAYSchema = schemas.StrSchema
ContentEncodingSchema = schemas.StrSchema
AltSvcSchema = schemas.StrSchema
SchemaFor200ResponseBodyApplicationJson = PurchaseAirtimeResponseSchema
ResponseHeadersFor200 = typing_extensions.TypedDict(
    'ResponseHeadersFor200',
    {
        'Date': DateSchema,
        'Transfer-Encoding': TransferEncodingSchema,
        'Connection': ConnectionSchema,
        'access-control-allow-origin': AccessControlAllowOriginSchema,
        'x-moesif-transaction-id': XMoesifTransactionIdSchema,
        'etag': EtagSchema,
        'vary': VarySchema,
        'CF-Cache-Status': CFCacheStatusSchema,
        'Expect-CT': ExpectCTSchema,
        'Report-To': ReportToSchema,
        'NEL': NELSchema,
        'Server': ServerSchema,
        'CF-RAY': CFRAYSchema,
        'Content-Encoding': ContentEncodingSchema,
        'alt-svc': AltSvcSchema,
    }
)


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: PurchaseAirtimeResponse


@dataclass
class ApiResponseFor200Async(api_client.AsyncApiResponse):
    body: PurchaseAirtimeResponse


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    response_cls_async=ApiResponseFor200Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
    headers=[
        date_parameter,
        transfer_encoding_parameter,
        connection_parameter,
        access_control_allow_origin_parameter,
        x_moesif_transaction_id_parameter,
        etag_parameter,
        vary_parameter,
        cf_cache_status_parameter,
        expect_ct_parameter,
        report_to_parameter,
        nel_parameter,
        server_parameter,
        cf_ray_parameter,
        content_encoding_parameter,
        alt_svc_parameter,
    ]
)
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _send_airtime_mapped_args(
        self,
        destination: typing.Optional[str] = None,
        amount: typing.Optional[str] = None,
        app_id: typing.Optional[str] = None,
    ) -> api_client.MappedArgs:
        args: api_client.MappedArgs = api_client.MappedArgs()
        _header_params = {}
        _body = {}
        if destination is not None:
            _body["destination"] = destination
        if amount is not None:
            _body["amount"] = amount
        args.body = _body
        if app_id is not None:
            _header_params["AppId"] = app_id
        args.header = _header_params
        return args

    async def _asend_airtime_oapg(
        self,
        body: typing.Any = None,
            header_params: typing.Optional[dict] = {},
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
        Purchase - Send Airtime
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestHeaderParams, header_params)
        used_path = path.value
    
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
        method = 'post'.upper()
        _headers.add('Content-Type', content_type)
    
        if body is schemas.unset:
            raise exceptions.ApiValueError(
                'The required body parameter has an invalid value of: unset. Set a valid value instead')
        _fields = None
        _body = None
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            body=body,
            auth_settings=_auth,
            headers=_headers,
        )
        serialized_data = request_body_purchase_airtime_request.serialize(body, content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
    
        response = await self.api_client.async_call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            fields=_fields,
            serialized_body=_body,
            body=body,
            auth_settings=_auth,
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


    def _send_airtime_oapg(
        self,
        body: typing.Any = None,
            header_params: typing.Optional[dict] = {},
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
        Purchase - Send Airtime
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestHeaderParams, header_params)
        used_path = path.value
    
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
        method = 'post'.upper()
        _headers.add('Content-Type', content_type)
    
        if body is schemas.unset:
            raise exceptions.ApiValueError(
                'The required body parameter has an invalid value of: unset. Set a valid value instead')
        _fields = None
        _body = None
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            body=body,
            auth_settings=_auth,
            headers=_headers,
        )
        serialized_data = request_body_purchase_airtime_request.serialize(body, content_type)
        if 'fields' in serialized_data:
            _fields = serialized_data['fields']
        elif 'body' in serialized_data:
            _body = serialized_data['body']
    
        response = self.api_client.call_api(
            resource_path=used_path,
            method=method,
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


class SendAirtime(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    async def asend_airtime(
        self,
        destination: typing.Optional[str] = None,
        amount: typing.Optional[str] = None,
        app_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._send_airtime_mapped_args(
            destination=destination,
            amount=amount,
            app_id=app_id,
        )
        return await self._asend_airtime_oapg(
            body=args.body,
            header_params=args.header,
        )
    
    def send_airtime(
        self,
        destination: typing.Optional[str] = None,
        amount: typing.Optional[str] = None,
        app_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._send_airtime_mapped_args(
            destination=destination,
            amount=amount,
            app_id=app_id,
        )
        return self._send_airtime_oapg(
            body=args.body,
            header_params=args.header,
        )

class ApiForpost(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    async def apost(
        self,
        destination: typing.Optional[str] = None,
        amount: typing.Optional[str] = None,
        app_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._send_airtime_mapped_args(
            destination=destination,
            amount=amount,
            app_id=app_id,
        )
        return await self._asend_airtime_oapg(
            body=args.body,
            header_params=args.header,
        )
    
    def post(
        self,
        destination: typing.Optional[str] = None,
        amount: typing.Optional[str] = None,
        app_id: typing.Optional[str] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._send_airtime_mapped_args(
            destination=destination,
            amount=amount,
            app_id=app_id,
        )
        return self._send_airtime_oapg(
            body=args.body,
            header_params=args.header,
        )

