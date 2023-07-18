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
import com.konfigthis.dojah.client.model.GetNationalIdResponse;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for KeKycApi
 */
@Disabled
public class KeKycApiTest {

    private static KeKycApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new KeKycApi(apiClient);
    }

    /**
     * KYC - National ID
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getNationalIdTest() throws ApiException {
        String appId = null;
        Integer id = null;
        GetNationalIdResponse response = api.getNationalId()
                .appId(appId)
                .id(id)
                .execute();
        // TODO: test validations
    }

    /**
     * KYC - Passport
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getPassportTest() throws ApiException {
        String appId = null;
        Object response = api.getPassport()
                .appId(appId)
                .execute();
        // TODO: test validations
    }

}
