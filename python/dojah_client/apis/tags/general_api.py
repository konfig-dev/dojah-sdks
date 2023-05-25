# coding: utf-8

"""
    DOJAH APIs

    Use Dojah to verify, onboard and manage user identity across Africa!

    The version of the OpenAPI document: 1.0.0
    Generated by: https://konfigthis.com
"""

from dojah_client.paths.v1_general_banks.get import GetBanks
from dojah_client.paths.v1_general_bin.get import GetBin
from dojah_client.paths.v1_purchase_data_plans.get import GetDataPlans
from dojah_client.paths.v1_general_account.get import GetNuban
from dojah_client.paths.api_v1_balance.get import GetWalletBalance
from dojah_client.paths.v1_purchase_airtime.post import PurchaseAirtime
from dojah_client.paths.v1_purchase_data.post import PurchaseData


class GeneralApi(
    GetBanks,
    GetBin,
    GetDataPlans,
    GetNuban,
    GetWalletBalance,
    PurchaseAirtime,
    PurchaseData,
):
    """NOTE:
    This class is auto generated by Konfig (https://konfigthis.com)
    """
    pass
