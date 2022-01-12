# Org.OpenAPITools.Api.SolanaSPLTokenApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SolanaGetSPLToken**](SolanaSPLTokenApi.md#solanagetspltoken) | **GET** /solana/spl-token/{network}/{public_key} | Get SPL token metadata



## SolanaGetSPLToken

> GetSPLTokenResponse SolanaGetSPLToken (string publicKey, string network)

Get SPL token metadata

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-spl-token/get-spl-token\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Retrieves basic information about an SPL token given its `mint_address`.  You can see the mint addresses of popular SPL tokens <a href=\"https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\" target=\"_blank\">here</a>.  Some example mint addresses of SPL tokens: - USDC: EPjFWdd5AufqSSqeM2qN1xzybapC8G4wEGGkZwyTDt1v - Mango: MangoCzJ36AjZyKwVj3VnYU4GTonjfVEnJmvvWaxLac - Serum: SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt - Raydium: 4k3Dyjzvzp8eMZWUXbBCjEvwSkkk59S5iCNLY3QrkX6R - wSOL: So11111111111111111111111111111111111111112 - ATLAS: ATLASXmbPQxBUYbxPsV97usA3fPQYEqzQBUHgiFCUsXx  `Cost: 1 Credit` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetSPLTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.blockchainapi.com/v1";
            // Configure API key authorization: APIKeyID
            Configuration.Default.AddApiKey("APIKeyID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("APIKeyID", "Bearer");
            // Configure API key authorization: APISecretKey
            Configuration.Default.AddApiKey("APISecretKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("APISecretKey", "Bearer");

            var apiInstance = new SolanaSPLTokenApi(Configuration.Default);
            var publicKey = MangoCzJ36AjZyKwVj3VnYU4GTonjfVEnJmvvWaxLac;  // string | The public key of the token
            var network = mainnet-beta;  // string | The network ID (devnet, mainnet-beta)

            try
            {
                // Get SPL token metadata
                GetSPLTokenResponse result = apiInstance.SolanaGetSPLToken(publicKey, network);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaSPLTokenApi.SolanaGetSPLToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The public key of the token | 
 **network** | **string**| The network ID (devnet, mainnet-beta) | 

### Return type

[**GetSPLTokenResponse**](GetSPLTokenResponse.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request (check response message) |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **404** | Account not found / not initialized with this public key address. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

