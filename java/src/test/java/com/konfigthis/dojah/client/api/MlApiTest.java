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
import com.konfigthis.dojah.client.model.MlVerifyPhotoIdWithSelfieRequest;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for MlApi
 */
@Disabled
public class MlApiTest {

    private static MlApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new MlApi(apiClient);
    }

    /**
     * KYC - Selfie Photo ID Verification
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void verifyPhotoIdWithSelfieTest() throws ApiException {
        String selfieImage = null;
        String photoidImage = null;
        Object response = api.verifyPhotoIdWithSelfie()
                .selfieImage(selfieImage)
                .photoidImage(photoidImage)
                .execute();
        // TODO: test validations
    }

}
