"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""


import re  # noqa: F401
import sys  # noqa: F401

from dojah_client.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
    OpenApiModel
)
from dojah_client.exceptions import ApiAttributeError


def lazy_import():
    from dojah_client.model.verify_selfie_nin_response_entity_selfie_verification import VerifySelfieNinResponseEntitySelfieVerification
    globals()['VerifySelfieNinResponseEntitySelfieVerification'] = VerifySelfieNinResponseEntitySelfieVerification


class VerifySelfieNinResponseEntity(ModelNormal):
    """NOTE: This class is auto generated by Konfig.
    Ref: https://konfigthis.com

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
    }

    validations = {
    }

    @cached_property
    def additional_properties_type():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded
        """
        lazy_import()
        return (bool, dict, float, int, list, str, none_type,)  # noqa: E501

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        lazy_import()
        return {
            'title': (str,),  # noqa: E501
            'nin': (str,),  # noqa: E501
            'firstname': (str,),  # noqa: E501
            'middlename': (str,),  # noqa: E501
            'surname': (str,),  # noqa: E501
            'maidenname': (str,),  # noqa: E501
            'telephoneno': (str,),  # noqa: E501
            'state': (str,),  # noqa: E501
            'place': (str,),  # noqa: E501
            'profession': (str,),  # noqa: E501
            'height': (str,),  # noqa: E501
            'email': (str,),  # noqa: E501
            'birthdate': (str,),  # noqa: E501
            'birthstate': (str,),  # noqa: E501
            'birthcountry': (str,),  # noqa: E501
            'central_id': (str,),  # noqa: E501
            'documentno': (str,),  # noqa: E501
            'educationallevel': (str,),  # noqa: E501
            'employmentstatus': (str,),  # noqa: E501
            'nok_firstname': (str,),  # noqa: E501
            'nok_lastname': (str,),  # noqa: E501
            'nok_middlename': (str,),  # noqa: E501
            'nok_address1': (str,),  # noqa: E501
            'nok_address2': (str,),  # noqa: E501
            'nok_lga': (str,),  # noqa: E501
            'nok_state': (str,),  # noqa: E501
            'nok_town': (str,),  # noqa: E501
            'nok_postalcode': (str,),  # noqa: E501
            'othername': (str,),  # noqa: E501
            'pfirstname': (str,),  # noqa: E501
            'photo': (str,),  # noqa: E501
            'pmiddlename': (str,),  # noqa: E501
            'psurname': (str,),  # noqa: E501
            'nspokenlang': (str,),  # noqa: E501
            'ospokenlang': (str,),  # noqa: E501
            'religion': (str,),  # noqa: E501
            'residence_town': (str,),  # noqa: E501
            'residence_lga': (str,),  # noqa: E501
            'residence_state': (str,),  # noqa: E501
            'residencestatus': (str,),  # noqa: E501
            'residence_address_line1': (str,),  # noqa: E501
            'residence_address_line2': (str,),  # noqa: E501
            'self_origin_lga': (str,),  # noqa: E501
            'self_origin_place': (str,),  # noqa: E501
            'self_origin_state': (str,),  # noqa: E501
            'signature': (str,),  # noqa: E501
            'nationality': (str,),  # noqa: E501
            'gender': (str,),  # noqa: E501
            'tracking_id': (str,),  # noqa: E501
            'selfie_verification': (VerifySelfieNinResponseEntitySelfieVerification,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'title': 'title',  # noqa: E501
        'nin': 'nin',  # noqa: E501
        'firstname': 'firstname',  # noqa: E501
        'middlename': 'middlename',  # noqa: E501
        'surname': 'surname',  # noqa: E501
        'maidenname': 'maidenname',  # noqa: E501
        'telephoneno': 'telephoneno',  # noqa: E501
        'state': 'state',  # noqa: E501
        'place': 'place',  # noqa: E501
        'profession': 'profession',  # noqa: E501
        'height': 'height',  # noqa: E501
        'email': 'email',  # noqa: E501
        'birthdate': 'birthdate',  # noqa: E501
        'birthstate': 'birthstate',  # noqa: E501
        'birthcountry': 'birthcountry',  # noqa: E501
        'central_id': 'centralID',  # noqa: E501
        'documentno': 'documentno',  # noqa: E501
        'educationallevel': 'educationallevel',  # noqa: E501
        'employmentstatus': 'employmentstatus',  # noqa: E501
        'nok_firstname': 'nok_firstname',  # noqa: E501
        'nok_lastname': 'nok_lastname',  # noqa: E501
        'nok_middlename': 'nok_middlename',  # noqa: E501
        'nok_address1': 'nok_address1',  # noqa: E501
        'nok_address2': 'nok_address2',  # noqa: E501
        'nok_lga': 'nok_lga',  # noqa: E501
        'nok_state': 'nok_state',  # noqa: E501
        'nok_town': 'nok_town',  # noqa: E501
        'nok_postalcode': 'nok_postalcode',  # noqa: E501
        'othername': 'othername',  # noqa: E501
        'pfirstname': 'pfirstname',  # noqa: E501
        'photo': 'photo',  # noqa: E501
        'pmiddlename': 'pmiddlename',  # noqa: E501
        'psurname': 'psurname',  # noqa: E501
        'nspokenlang': 'nspokenlang',  # noqa: E501
        'ospokenlang': 'ospokenlang',  # noqa: E501
        'religion': 'religion',  # noqa: E501
        'residence_town': 'residence_Town',  # noqa: E501
        'residence_lga': 'residence_lga',  # noqa: E501
        'residence_state': 'residence_state',  # noqa: E501
        'residencestatus': 'residencestatus',  # noqa: E501
        'residence_address_line1': 'residence_AddressLine1',  # noqa: E501
        'residence_address_line2': 'residence_AddressLine2',  # noqa: E501
        'self_origin_lga': 'self_origin_lga',  # noqa: E501
        'self_origin_place': 'self_origin_place',  # noqa: E501
        'self_origin_state': 'self_origin_state',  # noqa: E501
        'signature': 'signature',  # noqa: E501
        'nationality': 'nationality',  # noqa: E501
        'gender': 'gender',  # noqa: E501
        'tracking_id': 'trackingId',  # noqa: E501
        'selfie_verification': 'selfie_verification',  # noqa: E501
    }

    read_only_vars = {
    }

    _composed_schemas = {}

    @classmethod
    @convert_js_args_to_python_args
    def _from_openapi_data(cls, *args, **kwargs):  # noqa: E501
        """VerifySelfieNinResponseEntity - a model defined in OpenAPI

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            title (str): [optional]  # noqa: E501
            nin (str): [optional]  # noqa: E501
            firstname (str): [optional]  # noqa: E501
            middlename (str): [optional]  # noqa: E501
            surname (str): [optional]  # noqa: E501
            maidenname (str): [optional]  # noqa: E501
            telephoneno (str): [optional]  # noqa: E501
            state (str): [optional]  # noqa: E501
            place (str): [optional]  # noqa: E501
            profession (str): [optional]  # noqa: E501
            height (str): [optional]  # noqa: E501
            email (str): [optional]  # noqa: E501
            birthdate (str): [optional]  # noqa: E501
            birthstate (str): [optional]  # noqa: E501
            birthcountry (str): [optional]  # noqa: E501
            central_id (str): [optional]  # noqa: E501
            documentno (str): [optional]  # noqa: E501
            educationallevel (str): [optional]  # noqa: E501
            employmentstatus (str): [optional]  # noqa: E501
            nok_firstname (str): [optional]  # noqa: E501
            nok_lastname (str): [optional]  # noqa: E501
            nok_middlename (str): [optional]  # noqa: E501
            nok_address1 (str): [optional]  # noqa: E501
            nok_address2 (str): [optional]  # noqa: E501
            nok_lga (str): [optional]  # noqa: E501
            nok_state (str): [optional]  # noqa: E501
            nok_town (str): [optional]  # noqa: E501
            nok_postalcode (str): [optional]  # noqa: E501
            othername (str): [optional]  # noqa: E501
            pfirstname (str): [optional]  # noqa: E501
            photo (str): [optional]  # noqa: E501
            pmiddlename (str): [optional]  # noqa: E501
            psurname (str): [optional]  # noqa: E501
            nspokenlang (str): [optional]  # noqa: E501
            ospokenlang (str): [optional]  # noqa: E501
            religion (str): [optional]  # noqa: E501
            residence_town (str): [optional]  # noqa: E501
            residence_lga (str): [optional]  # noqa: E501
            residence_state (str): [optional]  # noqa: E501
            residencestatus (str): [optional]  # noqa: E501
            residence_address_line1 (str): [optional]  # noqa: E501
            residence_address_line2 (str): [optional]  # noqa: E501
            self_origin_lga (str): [optional]  # noqa: E501
            self_origin_place (str): [optional]  # noqa: E501
            self_origin_state (str): [optional]  # noqa: E501
            signature (str): [optional]  # noqa: E501
            nationality (str): [optional]  # noqa: E501
            gender (str): [optional]  # noqa: E501
            tracking_id (str): [optional]  # noqa: E501
            selfie_verification (VerifySelfieNinResponseEntitySelfieVerification): [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', True)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        self = super(OpenApiModel, cls).__new__(cls)

        if args:
            for arg in args:
                if isinstance(arg, dict):
                    kwargs.update(arg)
                else:
                    raise ApiTypeError(
                        "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                            args,
                            self.__class__.__name__,
                        ),
                        path_to_item=_path_to_item,
                        valid_classes=(self.__class__,),
                    )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
        return self

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
    ])

    @convert_js_args_to_python_args
    def __init__(self, *args, **kwargs):  # noqa: E501
        """VerifySelfieNinResponseEntity - a model defined in OpenAPI

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            title (str): [optional]  # noqa: E501
            nin (str): [optional]  # noqa: E501
            firstname (str): [optional]  # noqa: E501
            middlename (str): [optional]  # noqa: E501
            surname (str): [optional]  # noqa: E501
            maidenname (str): [optional]  # noqa: E501
            telephoneno (str): [optional]  # noqa: E501
            state (str): [optional]  # noqa: E501
            place (str): [optional]  # noqa: E501
            profession (str): [optional]  # noqa: E501
            height (str): [optional]  # noqa: E501
            email (str): [optional]  # noqa: E501
            birthdate (str): [optional]  # noqa: E501
            birthstate (str): [optional]  # noqa: E501
            birthcountry (str): [optional]  # noqa: E501
            central_id (str): [optional]  # noqa: E501
            documentno (str): [optional]  # noqa: E501
            educationallevel (str): [optional]  # noqa: E501
            employmentstatus (str): [optional]  # noqa: E501
            nok_firstname (str): [optional]  # noqa: E501
            nok_lastname (str): [optional]  # noqa: E501
            nok_middlename (str): [optional]  # noqa: E501
            nok_address1 (str): [optional]  # noqa: E501
            nok_address2 (str): [optional]  # noqa: E501
            nok_lga (str): [optional]  # noqa: E501
            nok_state (str): [optional]  # noqa: E501
            nok_town (str): [optional]  # noqa: E501
            nok_postalcode (str): [optional]  # noqa: E501
            othername (str): [optional]  # noqa: E501
            pfirstname (str): [optional]  # noqa: E501
            photo (str): [optional]  # noqa: E501
            pmiddlename (str): [optional]  # noqa: E501
            psurname (str): [optional]  # noqa: E501
            nspokenlang (str): [optional]  # noqa: E501
            ospokenlang (str): [optional]  # noqa: E501
            religion (str): [optional]  # noqa: E501
            residence_town (str): [optional]  # noqa: E501
            residence_lga (str): [optional]  # noqa: E501
            residence_state (str): [optional]  # noqa: E501
            residencestatus (str): [optional]  # noqa: E501
            residence_address_line1 (str): [optional]  # noqa: E501
            residence_address_line2 (str): [optional]  # noqa: E501
            self_origin_lga (str): [optional]  # noqa: E501
            self_origin_place (str): [optional]  # noqa: E501
            self_origin_state (str): [optional]  # noqa: E501
            signature (str): [optional]  # noqa: E501
            nationality (str): [optional]  # noqa: E501
            gender (str): [optional]  # noqa: E501
            tracking_id (str): [optional]  # noqa: E501
            selfie_verification (VerifySelfieNinResponseEntitySelfieVerification): [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            for arg in args:
                if isinstance(arg, dict):
                    kwargs.update(arg)
                else:
                    raise ApiTypeError(
                        "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                            args,
                            self.__class__.__name__,
                        ),
                        path_to_item=_path_to_item,
                        valid_classes=(self.__class__,),
                    )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
            if var_name in self.read_only_vars:
                raise ApiAttributeError(f"`{var_name}` is a read-only attribute. Use `from_openapi_data` to instantiate "
                                     f"class with read only attributes.")
