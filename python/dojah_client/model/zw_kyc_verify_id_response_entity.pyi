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


class ZwKycVerifyIdResponseEntity(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        
        class properties:
            person_no = schemas.StrSchema
            status = schemas.StrSchema
            surname = schemas.StrSchema
            first_name = schemas.StrSchema
            sex = schemas.StrSchema
            date_of_birth = schemas.StrSchema
            
            
            class date_of_death(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'date_of_death':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            
            
            class birth_place(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'birth_place':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            __annotations__ = {
                "person_no": person_no,
                "status": status,
                "surname": surname,
                "first_name": first_name,
                "sex": sex,
                "date_of_birth": date_of_birth,
                "date_of_death": date_of_death,
                "birth_place": birth_place,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["person_no"]) -> MetaOapg.properties.person_no: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["status"]) -> MetaOapg.properties.status: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["surname"]) -> MetaOapg.properties.surname: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["first_name"]) -> MetaOapg.properties.first_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sex"]) -> MetaOapg.properties.sex: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["date_of_birth"]) -> MetaOapg.properties.date_of_birth: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["date_of_death"]) -> MetaOapg.properties.date_of_death: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["birth_place"]) -> MetaOapg.properties.birth_place: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["person_no", "status", "surname", "first_name", "sex", "date_of_birth", "date_of_death", "birth_place", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["person_no"]) -> typing.Union[MetaOapg.properties.person_no, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["status"]) -> typing.Union[MetaOapg.properties.status, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["surname"]) -> typing.Union[MetaOapg.properties.surname, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["first_name"]) -> typing.Union[MetaOapg.properties.first_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sex"]) -> typing.Union[MetaOapg.properties.sex, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["date_of_birth"]) -> typing.Union[MetaOapg.properties.date_of_birth, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["date_of_death"]) -> typing.Union[MetaOapg.properties.date_of_death, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["birth_place"]) -> typing.Union[MetaOapg.properties.birth_place, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["person_no", "status", "surname", "first_name", "sex", "date_of_birth", "date_of_death", "birth_place", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        person_no: typing.Union[MetaOapg.properties.person_no, str, schemas.Unset] = schemas.unset,
        status: typing.Union[MetaOapg.properties.status, str, schemas.Unset] = schemas.unset,
        surname: typing.Union[MetaOapg.properties.surname, str, schemas.Unset] = schemas.unset,
        first_name: typing.Union[MetaOapg.properties.first_name, str, schemas.Unset] = schemas.unset,
        sex: typing.Union[MetaOapg.properties.sex, str, schemas.Unset] = schemas.unset,
        date_of_birth: typing.Union[MetaOapg.properties.date_of_birth, str, schemas.Unset] = schemas.unset,
        date_of_death: typing.Union[MetaOapg.properties.date_of_death, None, str, schemas.Unset] = schemas.unset,
        birth_place: typing.Union[MetaOapg.properties.birth_place, None, str, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'ZwKycVerifyIdResponseEntity':
        return super().__new__(
            cls,
            *args,
            person_no=person_no,
            status=status,
            surname=surname,
            first_name=first_name,
            sex=sex,
            date_of_birth=date_of_birth,
            date_of_death=date_of_death,
            birth_place=birth_place,
            _configuration=_configuration,
            **kwargs,
        )
