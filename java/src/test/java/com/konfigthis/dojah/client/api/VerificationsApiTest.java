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
import com.konfigthis.dojah.client.model.VerificationsVerifySelfieNinRequest;
import com.konfigthis.dojah.client.model.VerificationsVerifySelfieVninRequest;
import com.konfigthis.dojah.client.model.VerifyAgeResponse;
import com.konfigthis.dojah.client.model.VerifySelfieBvnRequest;
import com.konfigthis.dojah.client.model.VerifySelfieBvnResponse;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for VerificationsApi
 */
@Disabled
public class VerificationsApiTest {

    private static VerificationsApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new VerificationsApi(apiClient);
    }

    /**
     * KYC - Validate BVN
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void validateBvnTest() throws ApiException {
        String appId = null;
        Integer bvn = null;
        String firstName = null;
        String dob = null;
        Object response = api.validateBvn()
                .appId(appId)
                .bvn(bvn)
                .firstName(firstName)
                .dob(dob)
                .execute();
        // TODO: test validations
    }

    /**
     * KYC - Age Verification
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void verifyAgeTest() throws ApiException {
        String appId = null;
        String mode = null;
        Integer accountNumber = null;
        Integer bankCode = null;
        String dob = null;
        String firstName = null;
        String lastName = null;
        VerifyAgeResponse response = api.verifyAge()
                .appId(appId)
                .mode(mode)
                .accountNumber(accountNumber)
                .bankCode(bankCode)
                .dob(dob)
                .firstName(firstName)
                .lastName(lastName)
                .execute();
        // TODO: test validations
    }

    /**
     * KYV - Selfie BVN Verificatoin
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void verifySelfieBvnTest() throws ApiException {
        String bvn = null;
        String selfieImage = null;
        String appId = null;
        VerifySelfieBvnResponse response = api.verifySelfieBvn()
                .bvn(bvn)
                .selfieImage(selfieImage)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * KYC - Selfie NIN Verification
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void verifySelfieNinTest() throws ApiException {
        String nin = null;
        String selfieImage = null;
        String appId = null;
        Object response = api.verifySelfieNin()
                .nin(nin)
                .selfieImage(selfieImage)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * KYC - Selfie vNIN verification
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void verifySelfieVninTest() throws ApiException {
        String vnin = null;
        String selfieImage = null;
        String appId = null;
        Object response = api.verifySelfieVnin()
                .vnin(vnin)
                .selfieImage(selfieImage)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

}
