# Org.OpenAPITools.Api.SolanaAccountApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SolanaGetAccount**](SolanaAccountApi.md#solanagetaccount) | **GET** /solana/account/{network}/{public_key} | Get the details of an account on Solana
[**SolanaGetAccountIsCandyMachine**](SolanaAccountApi.md#solanagetaccountiscandymachine) | **GET** /solana/account/{network}/{public_key}/is_candy_machine | Get if account is candy machine
[**SolanaGetAccountIsNFT**](SolanaAccountApi.md#solanagetaccountisnft) | **GET** /solana/account/{network}/{public_key}/is_nft | Get if account is NFT



## SolanaGetAccount

> Account SolanaGetAccount (string network, string publicKey)

Get the details of an account on Solana

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-account/get-account\" target=\"_blank\">See examples (Python, JavaScript)</a>.      Get the details of an account on Solana. Learn more about accounts <a href=\"https://docs.solana.com/developing/programming-model/accounts\" target=\"_blank\">here</a>.  `Cost: 1 Credit` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetAccountExample
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

            var apiInstance = new SolanaAccountApi(Configuration.Default);
            var network = mainnet-beta;  // string | The network ID (devnet, mainnet-beta)
            var publicKey = EEr5yQpNXf7Bru6Rt5podx56HGW9CEehXqgRGh2wa71w;  // string | The public key of the account

            try
            {
                // Get the details of an account on Solana
                Account result = apiInstance.SolanaGetAccount(network, publicKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaAccountApi.SolanaGetAccount: " + e.Message );
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
 **network** | **string**| The network ID (devnet, mainnet-beta) | 
 **publicKey** | **string**| The public key of the account | 

### Return type

[**Account**](Account.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account found. Details in response. |  -  |
| **400** | Invalid input or issue retrieving transaction. See response for details |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **404** | Task not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetAccountIsCandyMachine

> AccountIsCandyMachine SolanaGetAccountIsCandyMachine (string network, string publicKey)

Get if account is candy machine

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-account/get-is-candy-machine\" target=\"_blank\">See examples (Python, JavaScript)</a>.      Determine whether or not a public key address corresponds to a candy machine ID or candy machine configuration.  `Cost: 1 Credit` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetAccountIsCandyMachineExample
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

            var apiInstance = new SolanaAccountApi(Configuration.Default);
            var network = mainnet-beta;  // string | The network ID (devnet, mainnet-beta)
            var publicKey = EEr5yQpNXf7Bru6Rt5podx56HGW9CEehXqgRGh2wa71w;  // string | The public key of the account

            try
            {
                // Get if account is candy machine
                AccountIsCandyMachine result = apiInstance.SolanaGetAccountIsCandyMachine(network, publicKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaAccountApi.SolanaGetAccountIsCandyMachine: " + e.Message );
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
 **network** | **string**| The network ID (devnet, mainnet-beta) | 
 **publicKey** | **string**| The public key of the account | 

### Return type

[**AccountIsCandyMachine**](AccountIsCandyMachine.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Invalid input or issue retrieving transaction. See response for details |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **404** | Task not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetAccountIsNFT

> AccountIsNFT SolanaGetAccountIsNFT (string network, string publicKey)

Get if account is NFT

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-account/get-is-nft\" target=\"_blank\">See examples (Python, JavaScript)</a>.      Determine whether or not a public key is an NFT `mint address`  `Cost: 1 Credit` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetAccountIsNFTExample
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

            var apiInstance = new SolanaAccountApi(Configuration.Default);
            var network = mainnet-beta;  // string | The network ID (devnet, mainnet-beta)
            var publicKey = EEr5yQpNXf7Bru6Rt5podx56HGW9CEehXqgRGh2wa71w;  // string | The public key of the account

            try
            {
                // Get if account is NFT
                AccountIsNFT result = apiInstance.SolanaGetAccountIsNFT(network, publicKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaAccountApi.SolanaGetAccountIsNFT: " + e.Message );
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
 **network** | **string**| The network ID (devnet, mainnet-beta) | 
 **publicKey** | **string**| The public key of the account | 

### Return type

[**AccountIsNFT**](AccountIsNFT.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Invalid input or issue retrieving transaction. See response for details |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **404** | Task not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

