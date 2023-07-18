/*
DOJAH Publilc APIs

Testing GlobalKYCApiService

*/

// Code generated by Konfig (https://konfigthis.com);

package dojah

import (
    "github.com/stretchr/testify/assert"
    "github.com/stretchr/testify/require"
    "testing"
    dojah "github.com/dojah-inc/dojah-sdks/go"
)

func Test_dojah_GlobalKYCApiService(t *testing.T) {

    configuration := dojah.NewConfiguration()
    
    
    apiClient := dojah.NewAPIClient(configuration)

    t.Run("Test GlobalKYCApiService CaEkyc", func(t *testing.T) {

        t.Skip("skip test")  // remove to run test

        resp, httpRes, err := apiClient.GlobalKYCApi.CaEkyc().Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)

    })

    t.Run("Test GlobalKYCApiService GetUsSsn", func(t *testing.T) {

        t.Skip("skip test")  // remove to run test

        resp, httpRes, err := apiClient.GlobalKYCApi.GetUsSsn().Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)

    })

    t.Run("Test GlobalKYCApiService UkTwoPlusTwo", func(t *testing.T) {

        t.Skip("skip test")  // remove to run test

        resp, httpRes, err := apiClient.GlobalKYCApi.UkTwoPlusTwo().Execute()

        require.Nil(t, err)
        require.NotNil(t, resp)
        assert.Equal(t, 200, httpRes.StatusCode)

    })

}
