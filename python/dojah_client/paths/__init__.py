# do not import all endpoints into this module because that uses a lot of memory and stack frames
# if you need the ability to import all endpoints from this module, import them with
# from dojah_client.apis.path_to_api import path_to_api

import enum


class PathValues(str, enum.Enum):
    API_V1_KYC_CAC = "/api/v1/kyc/cac"
    API_V1_KYC_TIN = "/api/v1/kyc/tin"
    API_V1_KYB_BUSINESS_SEARCH = "/api/v1/kyb/business/search"
    API_V1_KYB_BUSINESS_DETAIL = "/api/v1/kyb/business/detail"
    API_V1_GH_KYC_DL = "/api/v1/gh/kyc/dl"
    API_V1_GH_KYC_PASSPORT = "/api/v1/gh/kyc/passport"
    API_V1_GH_KYC_SSNIT = "/api/v1/gh/kyc/ssnit"
    API_V1_GH_KYC_VOTER = "/api/v1/gh/kyc/voter"
    API_V1_UG_KYC_VOTER = "/api/v1/ug/kyc/voter"
    API_V1_KE_KYC_ID = "/api/v1/ke/kyc/id"
    API_V1_KE_KYC_PASSPORT = "/api/v1/ke/kyc/passport"
    API_V1_TZ_KYC_NIN = "/api/v1/tz/kyc/nin"
    API_V1_ZW_KYC_NIN = "/api/v1/zw/kyc/nin"
    API_V1_ZW_KYC_FCB = "/api/v1/zw/kyc/fcb"
    API_V1_UK_KYC = "/api/v1/uk/kyc"
    API_V1_US_KYC = "/api/v1/us/kyc"
    API_V1_CA_KYC = "/api/v1/ca/kyc"
    API_V1_ZA_KYC_ID = "/api/v1/za/kyc/id"
    API_V1_KYC_NUBAN = "/api/v1/kyc/nuban"
    API_V1_KYC_BVN = "/api/v1/kyc/bvn"
    API_V1_KYC_BVN_BASIC = "/api/v1/kyc/bvn/basic"
    API_V1_KYC_BVN_FULL = "/api/v1/kyc/bvn/full"
    API_V1_KYC_NIN = "/api/v1/kyc/nin"
    API_V1_KYC_VNIN = "/api/v1/kyc/vnin"
    API_V1_KYC_BVN_ADVANCE = "/api/v1/kyc/bvn/advance"
    API_V1_KYC_PHONE_NUMBER_BASIC = "/api/v1/kyc/phone_number/basic"
    API_V1_KYC_PHONE_NUMBER = "/api/v1/kyc/phone_number"
    API_V1_KYC_DL = "/api/v1/kyc/dl"
    API_V1_KYC_PASSPORT = "/api/v1/kyc/passport"
    API_V1_KYC_VIN = "/api/v1/kyc/vin"
    API_V1_KYC_NUBAN_BVN = "/api/v1/kyc/nuban/bvn"
    API_V1_KYC_ADDRESS = "/api/v1/kyc/address"
    API_V1_KYC_ACCOUNTS = "/api/v1/kyc/accounts"
    API_V1_ML_LIVENESS = "/api/v1/ml/liveness"
    V1_KYC_BVN_VERIFY = "/v1/kyc/bvn/verify"
    API_V1_KYC_NIN_VERIFY = "/api/v1/kyc/nin/verify"
    V1_KYC_AGE_VERIFICATION = "/v1/kyc/age_verification"
    V1_KYC_BVN = "/v1/kyc/bvn"
    API_V1_KYC_VNIN_VERIFY = "/api/v1/kyc/vnin/verify"
    API_V1_DOCUMENT_ANALYSIS = "/api/v1/document/analysis"
    API_V1_MESSAGING_SMS = "/api/v1/messaging/sms"
    V1_MESSAGING_SMS_GET_STATUS = "/v1/messaging/sms/get_status"
    API_V1_MESSAGING_OTP = "/api/v1/messaging/otp"
    API_V1_MESSAGING_OTP_VALIDATE = "/api/v1/messaging/otp/validate"
    API_V1_MESSAGING_SENDER_IDS = "/api/v1/messaging/sender_ids"
    API_V1_MESSAGING_SENDER_ID = "/api/v1/messaging/sender_id"
    API_V1_KYC_PHOTOID_VERIFY = "/api/v1/kyc/photoid/verify"
    API_V1_AML_SCREENING_PLATFORM = "/api/v1/aml/screening/platform"
    API_V1_AML_SCREENING_INFO = "/api/v1/aml/screening/info"
    API_V1_FRAUD_IP = "/api/v1/fraud/ip"
    API_V1_KYC_EMAIL = "/api/v1/kyc/email"
    API_V1_FRAUD_USER = "/api/v1/fraud/user"
    API_V1_FRAUD_PHONE = "/api/v1/fraud/phone"
    V1_PURCHASE_AIRTIME = "/v1/purchase/airtime"
    V1_GENERAL_BANKS = "/v1/general/banks"
    API_V1_GENERAL_ACCOUNT = "/api/v1/general/account"
    V1_GENERAL_BIN = "/v1/general/bin"
    API_V1_BALANCE = "/api/v1/balance"
    API_V1_WEBHOOK_SUBSCRIBE = "/api/v1/webhook/subscribe"
    API_V1_WEBHOOK_DELETE = "/api/v1/webhook/delete"
    API_V1_WEBHOOK_FETCH = "/api/v1/webhook/fetch"
    API_V1_WEBHOOK_NOTIFY = "/api/v1/webhook/notify"
