# coding: utf-8

"""
    DOJAH APIs

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


class CategorizeTransactionsResponse(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        
        class properties:
            
            
            class entity(
                schemas.DictSchema
            ):
            
            
                class MetaOapg:
                    
                    class properties:
                        category = schemas.StrSchema
                        sub_category = schemas.StrSchema
                        service_id = schemas.NumberSchema
                        is_subscription = schemas.NumberSchema
                        duration = schemas.StrSchema
                        service_name = schemas.StrSchema
                        label = schemas.StrSchema
                        mode_of_payment = schemas.StrSchema
                        __annotations__ = {
                            "category": category,
                            "sub_category": sub_category,
                            "service_id": service_id,
                            "is_subscription": is_subscription,
                            "duration": duration,
                            "service_name": service_name,
                            "label": label,
                            "mode_of_payment": mode_of_payment,
                        }
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["category"]) -> MetaOapg.properties.category: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["sub_category"]) -> MetaOapg.properties.sub_category: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["service_id"]) -> MetaOapg.properties.service_id: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["is_subscription"]) -> MetaOapg.properties.is_subscription: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["duration"]) -> MetaOapg.properties.duration: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["service_name"]) -> MetaOapg.properties.service_name: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["label"]) -> MetaOapg.properties.label: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["mode_of_payment"]) -> MetaOapg.properties.mode_of_payment: ...
                
                @typing.overload
                def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
                
                def __getitem__(self, name: typing.Union[typing_extensions.Literal["category", "sub_category", "service_id", "is_subscription", "duration", "service_name", "label", "mode_of_payment", ], str]):
                    # dict_instance[name] accessor
                    return super().__getitem__(name)
                
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["category"]) -> typing.Union[MetaOapg.properties.category, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["sub_category"]) -> typing.Union[MetaOapg.properties.sub_category, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["service_id"]) -> typing.Union[MetaOapg.properties.service_id, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["is_subscription"]) -> typing.Union[MetaOapg.properties.is_subscription, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["duration"]) -> typing.Union[MetaOapg.properties.duration, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["service_name"]) -> typing.Union[MetaOapg.properties.service_name, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["label"]) -> typing.Union[MetaOapg.properties.label, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["mode_of_payment"]) -> typing.Union[MetaOapg.properties.mode_of_payment, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
                
                def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["category", "sub_category", "service_id", "is_subscription", "duration", "service_name", "label", "mode_of_payment", ], str]):
                    return super().get_item_oapg(name)
                
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, ],
                    category: typing.Union[MetaOapg.properties.category, str, schemas.Unset] = schemas.unset,
                    sub_category: typing.Union[MetaOapg.properties.sub_category, str, schemas.Unset] = schemas.unset,
                    service_id: typing.Union[MetaOapg.properties.service_id, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
                    is_subscription: typing.Union[MetaOapg.properties.is_subscription, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
                    duration: typing.Union[MetaOapg.properties.duration, str, schemas.Unset] = schemas.unset,
                    service_name: typing.Union[MetaOapg.properties.service_name, str, schemas.Unset] = schemas.unset,
                    label: typing.Union[MetaOapg.properties.label, str, schemas.Unset] = schemas.unset,
                    mode_of_payment: typing.Union[MetaOapg.properties.mode_of_payment, str, schemas.Unset] = schemas.unset,
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'entity':
                    return super().__new__(
                        cls,
                        *args,
                        category=category,
                        sub_category=sub_category,
                        service_id=service_id,
                        is_subscription=is_subscription,
                        duration=duration,
                        service_name=service_name,
                        label=label,
                        mode_of_payment=mode_of_payment,
                        _configuration=_configuration,
                        **kwargs,
                    )
            __annotations__ = {
                "entity": entity,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["entity"]) -> MetaOapg.properties.entity: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["entity", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["entity"]) -> typing.Union[MetaOapg.properties.entity, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["entity", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        entity: typing.Union[MetaOapg.properties.entity, dict, frozendict.frozendict, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'CategorizeTransactionsResponse':
        return super().__new__(
            cls,
            *args,
            entity=entity,
            _configuration=_configuration,
            **kwargs,
        )
