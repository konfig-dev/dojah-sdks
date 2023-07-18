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


class GetKycPassportResponse(
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
                        passport_number = schemas.StrSchema
                        date_of_issue = schemas.StrSchema
                        expiry_date = schemas.StrSchema
                        document_type = schemas.StrSchema
                        issue_place = schemas.StrSchema
                        surname = schemas.StrSchema
                        first_name = schemas.StrSchema
                        other_names = schemas.StrSchema
                        date_of_birth = schemas.StrSchema
                        gender = schemas.StrSchema
                        photo = schemas.StrSchema
                        __annotations__ = {
                            "passport_number": passport_number,
                            "date_of_issue": date_of_issue,
                            "expiry_date": expiry_date,
                            "document_type": document_type,
                            "issue_place": issue_place,
                            "surname": surname,
                            "first_name": first_name,
                            "other_names": other_names,
                            "date_of_birth": date_of_birth,
                            "gender": gender,
                            "photo": photo,
                        }
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["passport_number"]) -> MetaOapg.properties.passport_number: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["date_of_issue"]) -> MetaOapg.properties.date_of_issue: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["expiry_date"]) -> MetaOapg.properties.expiry_date: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["document_type"]) -> MetaOapg.properties.document_type: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["issue_place"]) -> MetaOapg.properties.issue_place: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["surname"]) -> MetaOapg.properties.surname: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["first_name"]) -> MetaOapg.properties.first_name: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["other_names"]) -> MetaOapg.properties.other_names: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["date_of_birth"]) -> MetaOapg.properties.date_of_birth: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["gender"]) -> MetaOapg.properties.gender: ...
                
                @typing.overload
                def __getitem__(self, name: typing_extensions.Literal["photo"]) -> MetaOapg.properties.photo: ...
                
                @typing.overload
                def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
                
                def __getitem__(self, name: typing.Union[typing_extensions.Literal["passport_number", "date_of_issue", "expiry_date", "document_type", "issue_place", "surname", "first_name", "other_names", "date_of_birth", "gender", "photo", ], str]):
                    # dict_instance[name] accessor
                    return super().__getitem__(name)
                
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["passport_number"]) -> typing.Union[MetaOapg.properties.passport_number, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["date_of_issue"]) -> typing.Union[MetaOapg.properties.date_of_issue, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["expiry_date"]) -> typing.Union[MetaOapg.properties.expiry_date, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["document_type"]) -> typing.Union[MetaOapg.properties.document_type, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["issue_place"]) -> typing.Union[MetaOapg.properties.issue_place, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["surname"]) -> typing.Union[MetaOapg.properties.surname, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["first_name"]) -> typing.Union[MetaOapg.properties.first_name, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["other_names"]) -> typing.Union[MetaOapg.properties.other_names, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["date_of_birth"]) -> typing.Union[MetaOapg.properties.date_of_birth, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["gender"]) -> typing.Union[MetaOapg.properties.gender, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: typing_extensions.Literal["photo"]) -> typing.Union[MetaOapg.properties.photo, schemas.Unset]: ...
                
                @typing.overload
                def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
                
                def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["passport_number", "date_of_issue", "expiry_date", "document_type", "issue_place", "surname", "first_name", "other_names", "date_of_birth", "gender", "photo", ], str]):
                    return super().get_item_oapg(name)
                
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, ],
                    passport_number: typing.Union[MetaOapg.properties.passport_number, str, schemas.Unset] = schemas.unset,
                    date_of_issue: typing.Union[MetaOapg.properties.date_of_issue, str, schemas.Unset] = schemas.unset,
                    expiry_date: typing.Union[MetaOapg.properties.expiry_date, str, schemas.Unset] = schemas.unset,
                    document_type: typing.Union[MetaOapg.properties.document_type, str, schemas.Unset] = schemas.unset,
                    issue_place: typing.Union[MetaOapg.properties.issue_place, str, schemas.Unset] = schemas.unset,
                    surname: typing.Union[MetaOapg.properties.surname, str, schemas.Unset] = schemas.unset,
                    first_name: typing.Union[MetaOapg.properties.first_name, str, schemas.Unset] = schemas.unset,
                    other_names: typing.Union[MetaOapg.properties.other_names, str, schemas.Unset] = schemas.unset,
                    date_of_birth: typing.Union[MetaOapg.properties.date_of_birth, str, schemas.Unset] = schemas.unset,
                    gender: typing.Union[MetaOapg.properties.gender, str, schemas.Unset] = schemas.unset,
                    photo: typing.Union[MetaOapg.properties.photo, str, schemas.Unset] = schemas.unset,
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'entity':
                    return super().__new__(
                        cls,
                        *args,
                        passport_number=passport_number,
                        date_of_issue=date_of_issue,
                        expiry_date=expiry_date,
                        document_type=document_type,
                        issue_place=issue_place,
                        surname=surname,
                        first_name=first_name,
                        other_names=other_names,
                        date_of_birth=date_of_birth,
                        gender=gender,
                        photo=photo,
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
    ) -> 'GetKycPassportResponse':
        return super().__new__(
            cls,
            *args,
            entity=entity,
            _configuration=_configuration,
            **kwargs,
        )
