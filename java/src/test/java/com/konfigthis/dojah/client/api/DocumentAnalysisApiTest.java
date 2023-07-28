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
import com.konfigthis.dojah.client.model.AnalyzeDocumentResponse;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for DocumentAnalysisApi
 */
@Disabled
public class DocumentAnalysisApiTest {

    private static DocumentAnalysisApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new DocumentAnalysisApi(apiClient);
    }

    /**
     * KYC - Document Analysis
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void analyzeDocumentTest() throws ApiException {
        AnalyzeDocumentResponse response = api.analyzeDocument()
                .execute();
        // TODO: test validations
    }

}
