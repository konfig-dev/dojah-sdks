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
import com.konfigthis.dojah.client.model.DeleteWebhookResponse;
import com.konfigthis.dojah.client.model.GetWebhooksResponse;
import com.konfigthis.dojah.client.model.NotifyWebhookRequest;
import com.konfigthis.dojah.client.model.NotifyWebhookRequestData;
import com.konfigthis.dojah.client.model.NotifyWebhookResponse;
import com.konfigthis.dojah.client.model.SubscribeServiceRequest;
import com.konfigthis.dojah.client.model.SubscribeServiceResponse;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for WebHooksApi
 */
@Disabled
public class WebHooksApiTest {

    private static WebHooksApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new WebHooksApi(apiClient);
    }

    /**
     * Delete Webhook
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void deleteWebhookTest() throws ApiException {
        String appId = null;
        DeleteWebhookResponse response = api.deleteWebhook()
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Fetch All Webhooks
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getWebhooksTest() throws ApiException {
        String appId = null;
        GetWebhooksResponse response = api.getWebhooks()
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Post Hook
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void notifyWebhookTest() throws ApiException {
        String subject = null;
        NotifyWebhookRequestData data = null;
        String appId = null;
        NotifyWebhookResponse response = api.notifyWebhook()
                .subject(subject)
                .data(data)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

    /**
     * Subscribe to service
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void subscribeServiceTest() throws ApiException {
        String webhook = null;
        String service = null;
        String appId = null;
        SubscribeServiceResponse response = api.subscribeService()
                .webhook(webhook)
                .service(service)
                .appId(appId)
                .execute();
        // TODO: test validations
    }

}
