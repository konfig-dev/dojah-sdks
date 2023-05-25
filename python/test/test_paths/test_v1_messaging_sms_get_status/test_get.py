# coding: utf-8

"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

import unittest
from unittest.mock import patch

import urllib3

import dojah_client
from dojah_client.paths.v1_messaging_sms_get_status import get
from dojah_client import configuration, schemas, api_client

from .. import ApiTestMixin


class TestV1MessagingSmsGetStatus(ApiTestMixin, unittest.TestCase):
    """
    V1MessagingSmsGetStatus unit test stubs
        Messaging - Get SMS Status
    """

    def setUp(self):
        pass

    def tearDown(self):
        pass

    response_status = 200




if __name__ == '__main__':
    unittest.main()
