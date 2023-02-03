"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""


import unittest

import dojah_client
from dojah_client.api.kyb_api import KYBApi  # noqa: E501


class TestKYBApi(unittest.TestCase):
    """KYBApi unit test stubs"""

    def setUp(self):
        self.api = KYBApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_get_advanced_cac(self):
        """Test case for get_advanced_cac

        KYC - Get CAC Advanced  # noqa: E501
        """
        pass

    def test_get_basic_cac(self):
        """Test case for get_basic_cac

        KYB - Get CAC 2  # noqa: E501
        """
        pass

    def test_get_cac(self):
        """Test case for get_cac

        KYC - Get CAC   # noqa: E501
        """
        pass

    def test_get_tin(self):
        """Test case for get_tin

        KYC - Fetch Tin  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
