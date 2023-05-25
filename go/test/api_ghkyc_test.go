/*
DOJAH APIs

Testing GHKYCApiService

*/

// Code generated by Konfig (https://konfigthis.com);

package dojah

import (
	"context"
	"os"
	"testing"

	dojah "github.com/dojah-inc/dojah-sdks/go"
	"github.com/stretchr/testify/assert"
	"github.com/stretchr/testify/require"
)

func Test_dojah_GHKYCApiService(t *testing.T) {

	apiKey := os.Getenv("DOJAH_API_KEY")
	appId := os.Getenv("DOJAH_APP_ID")
	configuration := dojah.NewConfiguration()
	configuration.Context = context.WithValue(configuration.Context, dojah.ContextAPIKeys, map[string]dojah.APIKey{
		"apikeyAuth": {Key: apiKey},
		"appIdAuth":  {Key: appId},
	})
	configuration.Context = context.WithValue(configuration.Context, dojah.ContextServerIndex, 1)
	apiClient := dojah.NewAPIClient(configuration)

	t.Run("Test GHKYCApiService GetDriversLicense", func(t *testing.T) {

		request := apiClient.GHKYCApi.GetDriversLicense()
		request.Id("V00000")
		request.FullName("John Doe")
		request.DateOfBirth("1988-09-01")
		resp, httpRes, err := request.Execute()

		require.Nil(t, err)
		require.NotNil(t, resp)
		assert.Equal(t, 200, httpRes.StatusCode)

	})

	t.Run("Test GHKYCApiService GetPassport", func(t *testing.T) {

		request := apiClient.GHKYCApi.GetPassport()
		request.Id("V00000")
		request.FirstName("John")
		request.LastName("Doe")
		request.MiddleName("")
		request.DateOfBirth("1988-09-01")
		resp, httpRes, err := request.Execute()

		require.Nil(t, err)
		require.NotNil(t, resp)
		assert.Equal(t, 200, httpRes.StatusCode)

	})

	t.Run("Test GHKYCApiService GetSsnit", func(t *testing.T) {

		t.Skip("skip test") // remove to run test

		resp, httpRes, err := apiClient.GHKYCApi.GetSsnit().Execute()

		require.Nil(t, err)
		require.NotNil(t, resp)
		assert.Equal(t, 200, httpRes.StatusCode)

	})

}
