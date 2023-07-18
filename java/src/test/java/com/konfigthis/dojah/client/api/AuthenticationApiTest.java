/*
 * DOJAH Publilc APIs
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.dojah.client.api;

import com.konfigthis.dojah.client.ApiException;
import com.konfigthis.dojah.client.ApiClient;
import com.konfigthis.dojah.client.ApiException;
import com.konfigthis.dojah.client.Configuration;
import com.konfigthis.dojah.client.model.AuthenticationSendOtpRequest;
import com.konfigthis.dojah.client.model.AuthenticationSendOtpResponse;
import com.konfigthis.dojah.client.model.AuthenticationValidateOtpResponse;
import com.konfigthis.dojah.client.model.GetSenderIdResponse;
import com.konfigthis.dojah.client.model.GetSmsStatusResponse;
import com.konfigthis.dojah.client.model.RequestSenderIdRequest;
import com.konfigthis.dojah.client.model.RequestSenderIdResponse;
import com.konfigthis.dojah.client.model.SendSmsRequest;
import com.konfigthis.dojah.client.model.SendSmsResponse;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AuthenticationApi
 */
@Disabled
public class AuthenticationApiTest {

    private static AuthenticationApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new AuthenticationApi(apiClient);
    }

    /**
     * Messaging - Get Sender IDs
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getSenderIdTest() throws ApiException {
        String appId = null;
        GetSenderIdResponse response = api.getSenderId()
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Messaging - Get SMS Status
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getSmsStatusTest() throws ApiException {
        String appId = null;
        String messageId = null;
        GetSmsStatusResponse response = api.getSmsStatus()
                .appId(appId)
                .messageId(messageId)
                .execute();
        // TODO: test validations
    }

    /**
     * Messaging - Request Sender ID
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void requestSenderIdTest() throws ApiException {
        String senderId = null;
        String appId = null;
        RequestSenderIdResponse response = api.requestSenderId()
                .senderId(senderId)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Messaging - Send OTP
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void sendOtpTest() throws ApiException {
        String destination = null;
        Double length = null;
        String channel = null;
        String senderId = null;
        Boolean priority = null;
        String appId = null;
        AuthenticationSendOtpResponse response = api.sendOtp()
                .destination(destination)
                .length(length)
                .channel(channel)
                .senderId(senderId)
                .priority(priority)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Messaging - Send SMS
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void sendSmsTest() throws ApiException {
        String destination = null;
        String message = null;
        String channel = null;
        String senderId = null;
        String appId = null;
        SendSmsResponse response = api.sendSms()
                .destination(destination)
                .message(message)
                .channel(channel)
                .senderId(senderId)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Messaging - Validate OTP
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void validateOtpTest() throws ApiException {
        String appId = null;
        String referenceId = null;
        Integer code = null;
        AuthenticationValidateOtpResponse response = api.validateOtp()
                .appId(appId)
                .referenceId(referenceId)
                .code(code)
                .execute();
        // TODO: test validations
    }

}
