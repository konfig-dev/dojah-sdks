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



from . import path

# Query params
CountrySchema = schemas.StrSchema
FirstNameSchema = schemas.StrSchema
LastNameSchema = schemas.StrSchema
StreetNameSchema = schemas.StrSchema
DateOfBirthSchema = schemas.StrSchema
HouseNumberSchema = schemas.IntSchema
PostCodeSchema = schemas.IntSchema
RequestRequiredQueryParams = typing_extensions.TypedDict(
    'RequestRequiredQueryParams',
    {
    }
)
RequestOptionalQueryParams = typing_extensions.TypedDict(
    'RequestOptionalQueryParams',
    {
        'country': typing.Union[CountrySchema, str, ],
        'first_name': typing.Union[FirstNameSchema, str, ],
        'last_name': typing.Union[LastNameSchema, str, ],
        'street_name': typing.Union[StreetNameSchema, str, ],
        'date_of_birth': typing.Union[DateOfBirthSchema, str, ],
        'house_number': typing.Union[HouseNumberSchema, decimal.Decimal, int, ],
        'post_code': typing.Union[PostCodeSchema, decimal.Decimal, int, ],
    },
    total=False
)


class RequestQueryParams(RequestRequiredQueryParams, RequestOptionalQueryParams):
    pass


request_query_country = api_client.QueryParameter(
    name="country",
    style=api_client.ParameterStyle.FORM,
    schema=CountrySchema,
    explode=True,
)
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
request_query_street_name = api_client.QueryParameter(
    name="street_name",
    style=api_client.ParameterStyle.FORM,
    schema=StreetNameSchema,
    explode=True,
)
request_query_date_of_birth = api_client.QueryParameter(
    name="date_of_birth",
    style=api_client.ParameterStyle.FORM,
    schema=DateOfBirthSchema,
    explode=True,
)
request_query_house_number = api_client.QueryParameter(
    name="house_number",
    style=api_client.ParameterStyle.FORM,
    schema=HouseNumberSchema,
    explode=True,
)
request_query_post_code = api_client.QueryParameter(
    name="post_code",
    style=api_client.ParameterStyle.FORM,
    schema=PostCodeSchema,
    explode=True,
)
_auth = [
    'appIdAuth',
]
SchemaFor200ResponseBodyApplicationJson = schemas.DictSchema


@dataclass
class ApiResponseFor200(api_client.ApiResponse):
    body: typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]]


@dataclass
class ApiResponseFor200Async(api_client.AsyncApiResponse):
    body: typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]]


_response_for_200 = api_client.OpenApiResponse(
    response_cls=ApiResponseFor200,
    response_cls_async=ApiResponseFor200Async,
    content={
        'application/json': api_client.MediaType(
            schema=SchemaFor200ResponseBodyApplicationJson),
    },
)
_status_code_to_response = {
    '200': _response_for_200,
}
_all_accept_content_types = (
    'application/json',
)


class BaseApi(api_client.Api):

    def _ca_ekyc_mapped_args(
        self,
        country: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        street_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        house_number: typing.Optional[int] = None,
        post_code: typing.Optional[int] = None,
    ) -> api_client.MappedArgs:
        args: api_client.MappedArgs = api_client.MappedArgs()
        _query_params = {}
        if country is not None:
            _query_params["country"] = country
        if first_name is not None:
            _query_params["first_name"] = first_name
        if last_name is not None:
            _query_params["last_name"] = last_name
        if street_name is not None:
            _query_params["street_name"] = street_name
        if date_of_birth is not None:
            _query_params["date_of_birth"] = date_of_birth
        if house_number is not None:
            _query_params["house_number"] = house_number
        if post_code is not None:
            _query_params["post_code"] = post_code
        args.query = _query_params
        return args

    async def _aca_ekyc_oapg(
        self,
            query_params: typing.Optional[dict] = {},
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
        Canada Ekyc
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        used_path = path.value
    
        prefix_separator_iterator = None
        for parameter in (
            request_query_country,
            request_query_first_name,
            request_query_last_name,
            request_query_street_name,
            request_query_date_of_birth,
            request_query_house_number,
            request_query_post_code,
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
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'get'.upper()
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            auth_settings=_auth,
            headers=_headers,
        )
    
        response = await self.api_client.async_call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            auth_settings=_auth,
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


    def _ca_ekyc_oapg(
        self,
            query_params: typing.Optional[dict] = {},
        skip_deserialization: bool = False,
        timeout: typing.Optional[typing.Union[int, typing.Tuple]] = None,
        accept_content_types: typing.Tuple[str] = _all_accept_content_types,
        stream: bool = False,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        """
        Canada Ekyc
        :param skip_deserialization: If true then api_response.response will be set but
            api_response.body and api_response.headers will not be deserialized into schema
            class instances
        """
        self._verify_typed_dict_inputs_oapg(RequestQueryParams, query_params)
        used_path = path.value
    
        prefix_separator_iterator = None
        for parameter in (
            request_query_country,
            request_query_first_name,
            request_query_last_name,
            request_query_street_name,
            request_query_date_of_birth,
            request_query_house_number,
            request_query_post_code,
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
        # TODO add cookie handling
        if accept_content_types:
            for accept_content_type in accept_content_types:
                _headers.add('Accept', accept_content_type)
        method = 'get'.upper()
        request_before_hook(
            resource_path=used_path,
            method=method,
            configuration=self.api_client.configuration,
            auth_settings=_auth,
            headers=_headers,
        )
    
        response = self.api_client.call_api(
            resource_path=used_path,
            method=method,
            headers=_headers,
            auth_settings=_auth,
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


class CaEkyc(BaseApi):
    # this class is used by api classes that refer to endpoints with operationId fn names

    async def aca_ekyc(
        self,
        country: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        street_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        house_number: typing.Optional[int] = None,
        post_code: typing.Optional[int] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._ca_ekyc_mapped_args(
            country=country,
            first_name=first_name,
            last_name=last_name,
            street_name=street_name,
            date_of_birth=date_of_birth,
            house_number=house_number,
            post_code=post_code,
        )
        return await self._aca_ekyc_oapg(
            query_params=args.query,
        )
    
    def ca_ekyc(
        self,
        country: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        street_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        house_number: typing.Optional[int] = None,
        post_code: typing.Optional[int] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._ca_ekyc_mapped_args(
            country=country,
            first_name=first_name,
            last_name=last_name,
            street_name=street_name,
            date_of_birth=date_of_birth,
            house_number=house_number,
            post_code=post_code,
        )
        return self._ca_ekyc_oapg(
            query_params=args.query,
        )

class ApiForget(BaseApi):
    # this class is used by api classes that refer to endpoints by path and http method names

    async def aget(
        self,
        country: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        street_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        house_number: typing.Optional[int] = None,
        post_code: typing.Optional[int] = None,
    ) -> typing.Union[
        ApiResponseFor200Async,
        api_client.ApiResponseWithoutDeserializationAsync,
        AsyncGeneratorResponse,
    ]:
        args = self._ca_ekyc_mapped_args(
            country=country,
            first_name=first_name,
            last_name=last_name,
            street_name=street_name,
            date_of_birth=date_of_birth,
            house_number=house_number,
            post_code=post_code,
        )
        return await self._aca_ekyc_oapg(
            query_params=args.query,
        )
    
    def get(
        self,
        country: typing.Optional[str] = None,
        first_name: typing.Optional[str] = None,
        last_name: typing.Optional[str] = None,
        street_name: typing.Optional[str] = None,
        date_of_birth: typing.Optional[str] = None,
        house_number: typing.Optional[int] = None,
        post_code: typing.Optional[int] = None,
    ) -> typing.Union[
        ApiResponseFor200,
        api_client.ApiResponseWithoutDeserialization,
    ]:
        args = self._ca_ekyc_mapped_args(
            country=country,
            first_name=first_name,
            last_name=last_name,
            street_name=street_name,
            date_of_birth=date_of_birth,
            house_number=house_number,
            post_code=post_code,
        )
        return self._ca_ekyc_oapg(
            query_params=args.query,
        )

