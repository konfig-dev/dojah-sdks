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


class NigeriaKycGetNinResponseEntity(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        
        class properties:
            title = schemas.StrSchema
            birth_country = schemas.StrSchema
            birth_date = schemas.StrSchema
            birth_lga = schemas.StrSchema
            birth_state = schemas.StrSchema
            central_id = schemas.StrSchema
            educational_level = schemas.StrSchema
            
            
            class email(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'email':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            employment_status = schemas.StrSchema
            first_name = schemas.StrSchema
            gender = schemas.StrSchema
            height = schemas.StrSchema
            
            
            class maiden_name(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'maiden_name':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            marital_status = schemas.StrSchema
            middle_name = schemas.StrSchema
            nationality = schemas.StrSchema
            nok_address_1 = schemas.StrSchema
        
            @staticmethod
            def nok_address_2() -> typing.Type['NigeriaKycGetNinResponseEntityNokAddress2']:
                return NigeriaKycGetNinResponseEntityNokAddress2
            nok_first_name = schemas.StrSchema
            nok_lga = schemas.StrSchema
            nok_state = schemas.StrSchema
            nok_surname = schemas.StrSchema
            nok_town = schemas.StrSchema
            origin_lga = schemas.StrSchema
            origin_place = schemas.StrSchema
            origin_state = schemas.StrSchema
            picture = schemas.StrSchema
            profession = schemas.StrSchema
            reference = schemas.StrSchema
            religion = schemas.StrSchema
            residence_address = schemas.StrSchema
            residence_lga = schemas.StrSchema
            residence_state = schemas.StrSchema
            residence_status = schemas.StrSchema
            residence_town = schemas.StrSchema
            signature = schemas.StrSchema
            spoken_language = schemas.StrSchema
            surname = schemas.StrSchema
            telephone = schemas.StrSchema
            __annotations__ = {
                "title": title,
                "birth_country": birth_country,
                "birth_date": birth_date,
                "birth_lga": birth_lga,
                "birth_state": birth_state,
                "central_id": central_id,
                "educational_level": educational_level,
                "email": email,
                "employment_status": employment_status,
                "first_name": first_name,
                "gender": gender,
                "height": height,
                "maiden_name": maiden_name,
                "marital_status": marital_status,
                "middle_name": middle_name,
                "nationality": nationality,
                "nok_address_1": nok_address_1,
                "nok_address_2": nok_address_2,
                "nok_first_name": nok_first_name,
                "nok_lga": nok_lga,
                "nok_state": nok_state,
                "nok_surname": nok_surname,
                "nok_town": nok_town,
                "origin_lga": origin_lga,
                "origin_place": origin_place,
                "origin_state": origin_state,
                "picture": picture,
                "profession": profession,
                "reference": reference,
                "religion": religion,
                "residence_address": residence_address,
                "residence_lga": residence_lga,
                "residence_state": residence_state,
                "residence_status": residence_status,
                "residence_town": residence_town,
                "signature": signature,
                "spoken_language": spoken_language,
                "surname": surname,
                "telephone": telephone,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["title"]) -> MetaOapg.properties.title: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["birth_country"]) -> MetaOapg.properties.birth_country: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["birth_date"]) -> MetaOapg.properties.birth_date: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["birth_lga"]) -> MetaOapg.properties.birth_lga: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["birth_state"]) -> MetaOapg.properties.birth_state: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["central_id"]) -> MetaOapg.properties.central_id: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["educational_level"]) -> MetaOapg.properties.educational_level: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["email"]) -> MetaOapg.properties.email: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["employment_status"]) -> MetaOapg.properties.employment_status: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["first_name"]) -> MetaOapg.properties.first_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["gender"]) -> MetaOapg.properties.gender: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["height"]) -> MetaOapg.properties.height: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["maiden_name"]) -> MetaOapg.properties.maiden_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["marital_status"]) -> MetaOapg.properties.marital_status: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["middle_name"]) -> MetaOapg.properties.middle_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nationality"]) -> MetaOapg.properties.nationality: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_address_1"]) -> MetaOapg.properties.nok_address_1: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_address_2"]) -> 'NigeriaKycGetNinResponseEntityNokAddress2': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_first_name"]) -> MetaOapg.properties.nok_first_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_lga"]) -> MetaOapg.properties.nok_lga: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_state"]) -> MetaOapg.properties.nok_state: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_surname"]) -> MetaOapg.properties.nok_surname: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["nok_town"]) -> MetaOapg.properties.nok_town: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["origin_lga"]) -> MetaOapg.properties.origin_lga: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["origin_place"]) -> MetaOapg.properties.origin_place: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["origin_state"]) -> MetaOapg.properties.origin_state: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["picture"]) -> MetaOapg.properties.picture: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["profession"]) -> MetaOapg.properties.profession: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["reference"]) -> MetaOapg.properties.reference: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["religion"]) -> MetaOapg.properties.religion: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["residence_address"]) -> MetaOapg.properties.residence_address: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["residence_lga"]) -> MetaOapg.properties.residence_lga: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["residence_state"]) -> MetaOapg.properties.residence_state: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["residence_status"]) -> MetaOapg.properties.residence_status: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["residence_town"]) -> MetaOapg.properties.residence_town: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["signature"]) -> MetaOapg.properties.signature: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["spoken_language"]) -> MetaOapg.properties.spoken_language: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["surname"]) -> MetaOapg.properties.surname: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["telephone"]) -> MetaOapg.properties.telephone: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["title", "birth_country", "birth_date", "birth_lga", "birth_state", "central_id", "educational_level", "email", "employment_status", "first_name", "gender", "height", "maiden_name", "marital_status", "middle_name", "nationality", "nok_address_1", "nok_address_2", "nok_first_name", "nok_lga", "nok_state", "nok_surname", "nok_town", "origin_lga", "origin_place", "origin_state", "picture", "profession", "reference", "religion", "residence_address", "residence_lga", "residence_state", "residence_status", "residence_town", "signature", "spoken_language", "surname", "telephone", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["title"]) -> typing.Union[MetaOapg.properties.title, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["birth_country"]) -> typing.Union[MetaOapg.properties.birth_country, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["birth_date"]) -> typing.Union[MetaOapg.properties.birth_date, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["birth_lga"]) -> typing.Union[MetaOapg.properties.birth_lga, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["birth_state"]) -> typing.Union[MetaOapg.properties.birth_state, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["central_id"]) -> typing.Union[MetaOapg.properties.central_id, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["educational_level"]) -> typing.Union[MetaOapg.properties.educational_level, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["email"]) -> typing.Union[MetaOapg.properties.email, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["employment_status"]) -> typing.Union[MetaOapg.properties.employment_status, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["first_name"]) -> typing.Union[MetaOapg.properties.first_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["gender"]) -> typing.Union[MetaOapg.properties.gender, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["height"]) -> typing.Union[MetaOapg.properties.height, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["maiden_name"]) -> typing.Union[MetaOapg.properties.maiden_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["marital_status"]) -> typing.Union[MetaOapg.properties.marital_status, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["middle_name"]) -> typing.Union[MetaOapg.properties.middle_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nationality"]) -> typing.Union[MetaOapg.properties.nationality, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_address_1"]) -> typing.Union[MetaOapg.properties.nok_address_1, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_address_2"]) -> typing.Union['NigeriaKycGetNinResponseEntityNokAddress2', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_first_name"]) -> typing.Union[MetaOapg.properties.nok_first_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_lga"]) -> typing.Union[MetaOapg.properties.nok_lga, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_state"]) -> typing.Union[MetaOapg.properties.nok_state, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_surname"]) -> typing.Union[MetaOapg.properties.nok_surname, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["nok_town"]) -> typing.Union[MetaOapg.properties.nok_town, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["origin_lga"]) -> typing.Union[MetaOapg.properties.origin_lga, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["origin_place"]) -> typing.Union[MetaOapg.properties.origin_place, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["origin_state"]) -> typing.Union[MetaOapg.properties.origin_state, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["picture"]) -> typing.Union[MetaOapg.properties.picture, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["profession"]) -> typing.Union[MetaOapg.properties.profession, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["reference"]) -> typing.Union[MetaOapg.properties.reference, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["religion"]) -> typing.Union[MetaOapg.properties.religion, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["residence_address"]) -> typing.Union[MetaOapg.properties.residence_address, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["residence_lga"]) -> typing.Union[MetaOapg.properties.residence_lga, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["residence_state"]) -> typing.Union[MetaOapg.properties.residence_state, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["residence_status"]) -> typing.Union[MetaOapg.properties.residence_status, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["residence_town"]) -> typing.Union[MetaOapg.properties.residence_town, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["signature"]) -> typing.Union[MetaOapg.properties.signature, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["spoken_language"]) -> typing.Union[MetaOapg.properties.spoken_language, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["surname"]) -> typing.Union[MetaOapg.properties.surname, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["telephone"]) -> typing.Union[MetaOapg.properties.telephone, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["title", "birth_country", "birth_date", "birth_lga", "birth_state", "central_id", "educational_level", "email", "employment_status", "first_name", "gender", "height", "maiden_name", "marital_status", "middle_name", "nationality", "nok_address_1", "nok_address_2", "nok_first_name", "nok_lga", "nok_state", "nok_surname", "nok_town", "origin_lga", "origin_place", "origin_state", "picture", "profession", "reference", "religion", "residence_address", "residence_lga", "residence_state", "residence_status", "residence_town", "signature", "spoken_language", "surname", "telephone", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        title: typing.Union[MetaOapg.properties.title, str, schemas.Unset] = schemas.unset,
        birth_country: typing.Union[MetaOapg.properties.birth_country, str, schemas.Unset] = schemas.unset,
        birth_date: typing.Union[MetaOapg.properties.birth_date, str, schemas.Unset] = schemas.unset,
        birth_lga: typing.Union[MetaOapg.properties.birth_lga, str, schemas.Unset] = schemas.unset,
        birth_state: typing.Union[MetaOapg.properties.birth_state, str, schemas.Unset] = schemas.unset,
        central_id: typing.Union[MetaOapg.properties.central_id, str, schemas.Unset] = schemas.unset,
        educational_level: typing.Union[MetaOapg.properties.educational_level, str, schemas.Unset] = schemas.unset,
        email: typing.Union[MetaOapg.properties.email, None, str, schemas.Unset] = schemas.unset,
        employment_status: typing.Union[MetaOapg.properties.employment_status, str, schemas.Unset] = schemas.unset,
        first_name: typing.Union[MetaOapg.properties.first_name, str, schemas.Unset] = schemas.unset,
        gender: typing.Union[MetaOapg.properties.gender, str, schemas.Unset] = schemas.unset,
        height: typing.Union[MetaOapg.properties.height, str, schemas.Unset] = schemas.unset,
        maiden_name: typing.Union[MetaOapg.properties.maiden_name, None, str, schemas.Unset] = schemas.unset,
        marital_status: typing.Union[MetaOapg.properties.marital_status, str, schemas.Unset] = schemas.unset,
        middle_name: typing.Union[MetaOapg.properties.middle_name, str, schemas.Unset] = schemas.unset,
        nationality: typing.Union[MetaOapg.properties.nationality, str, schemas.Unset] = schemas.unset,
        nok_address_1: typing.Union[MetaOapg.properties.nok_address_1, str, schemas.Unset] = schemas.unset,
        nok_address_2: typing.Union['NigeriaKycGetNinResponseEntityNokAddress2', schemas.Unset] = schemas.unset,
        nok_first_name: typing.Union[MetaOapg.properties.nok_first_name, str, schemas.Unset] = schemas.unset,
        nok_lga: typing.Union[MetaOapg.properties.nok_lga, str, schemas.Unset] = schemas.unset,
        nok_state: typing.Union[MetaOapg.properties.nok_state, str, schemas.Unset] = schemas.unset,
        nok_surname: typing.Union[MetaOapg.properties.nok_surname, str, schemas.Unset] = schemas.unset,
        nok_town: typing.Union[MetaOapg.properties.nok_town, str, schemas.Unset] = schemas.unset,
        origin_lga: typing.Union[MetaOapg.properties.origin_lga, str, schemas.Unset] = schemas.unset,
        origin_place: typing.Union[MetaOapg.properties.origin_place, str, schemas.Unset] = schemas.unset,
        origin_state: typing.Union[MetaOapg.properties.origin_state, str, schemas.Unset] = schemas.unset,
        picture: typing.Union[MetaOapg.properties.picture, str, schemas.Unset] = schemas.unset,
        profession: typing.Union[MetaOapg.properties.profession, str, schemas.Unset] = schemas.unset,
        reference: typing.Union[MetaOapg.properties.reference, str, schemas.Unset] = schemas.unset,
        religion: typing.Union[MetaOapg.properties.religion, str, schemas.Unset] = schemas.unset,
        residence_address: typing.Union[MetaOapg.properties.residence_address, str, schemas.Unset] = schemas.unset,
        residence_lga: typing.Union[MetaOapg.properties.residence_lga, str, schemas.Unset] = schemas.unset,
        residence_state: typing.Union[MetaOapg.properties.residence_state, str, schemas.Unset] = schemas.unset,
        residence_status: typing.Union[MetaOapg.properties.residence_status, str, schemas.Unset] = schemas.unset,
        residence_town: typing.Union[MetaOapg.properties.residence_town, str, schemas.Unset] = schemas.unset,
        signature: typing.Union[MetaOapg.properties.signature, str, schemas.Unset] = schemas.unset,
        spoken_language: typing.Union[MetaOapg.properties.spoken_language, str, schemas.Unset] = schemas.unset,
        surname: typing.Union[MetaOapg.properties.surname, str, schemas.Unset] = schemas.unset,
        telephone: typing.Union[MetaOapg.properties.telephone, str, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'NigeriaKycGetNinResponseEntity':
        return super().__new__(
            cls,
            *args,
            title=title,
            birth_country=birth_country,
            birth_date=birth_date,
            birth_lga=birth_lga,
            birth_state=birth_state,
            central_id=central_id,
            educational_level=educational_level,
            email=email,
            employment_status=employment_status,
            first_name=first_name,
            gender=gender,
            height=height,
            maiden_name=maiden_name,
            marital_status=marital_status,
            middle_name=middle_name,
            nationality=nationality,
            nok_address_1=nok_address_1,
            nok_address_2=nok_address_2,
            nok_first_name=nok_first_name,
            nok_lga=nok_lga,
            nok_state=nok_state,
            nok_surname=nok_surname,
            nok_town=nok_town,
            origin_lga=origin_lga,
            origin_place=origin_place,
            origin_state=origin_state,
            picture=picture,
            profession=profession,
            reference=reference,
            religion=religion,
            residence_address=residence_address,
            residence_lga=residence_lga,
            residence_state=residence_state,
            residence_status=residence_status,
            residence_town=residence_town,
            signature=signature,
            spoken_language=spoken_language,
            surname=surname,
            telephone=telephone,
            _configuration=_configuration,
            **kwargs,
        )

from dojah_client.model.nigeria_kyc_get_nin_response_entity_nok_address2 import NigeriaKycGetNinResponseEntityNokAddress2
