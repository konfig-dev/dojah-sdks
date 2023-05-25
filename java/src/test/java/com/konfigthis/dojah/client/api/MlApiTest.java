/*
 * DOJAH APIs
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
import com.konfigthis.dojah.client.model.GetDocumentAnalysisRequest;
import com.konfigthis.dojah.client.model.GetDocumentAnalysisResponse;
import com.konfigthis.dojah.client.model.GetGenericOcrTextRequest;
import com.konfigthis.dojah.client.model.GetGenericOcrTextResponse;
import com.konfigthis.dojah.client.model.GetOcrTextRequest;
import com.konfigthis.dojah.client.model.GetOcrTextResponse;
import com.konfigthis.dojah.client.model.VerifyPhotoIdWithSelfieRequest;
import com.konfigthis.dojah.client.model.VerifyPhotoIdWithSelfieResponse;
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
     * Document Analysis Drivers License
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getDocumentAnalysisTest() throws ApiException {
        String img = null;
        GetDocumentAnalysisResponse response = api.getDocumentAnalysis()
                .img(img)
                .execute();
        // TODO: test validations
    }

    /**
     * Generic OCR Service
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getGenericOcrTextTest() throws ApiException {
        String img = null;
        GetGenericOcrTextResponse response = api.getGenericOcrText()
                .img(img)
                .execute();
        // TODO: test validations
    }

    /**
     * BVN Ocr
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getOcrTextTest() throws ApiException {
        String image = null;
        GetOcrTextResponse response = api.getOcrText()
                .image(image)
                .execute();
        // TODO: test validations
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
        VerifyPhotoIdWithSelfieResponse response = api.verifyPhotoIdWithSelfie()
                .selfieImage(selfieImage)
                .photoidImage(photoidImage)
                .execute();
        // TODO: test validations
    }

}
