# Org.OpenAPITools.Api.SolanaCandyMachineApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SolanaGetAllNFTsFromCandyMachine**](SolanaCandyMachineApi.md#solanagetallnftsfromcandymachine) | **GET** /solana/nft/candy_machine/{network}/{candy_machine_id}/nfts | Get CM&#39;s NFTs  
[**SolanaGetCandyMachineMetadata**](SolanaCandyMachineApi.md#solanagetcandymachinemetadata) | **POST** /solana/nft/candy_machine/metadata | Get a CM&#39;s metadata 
[**SolanaListAllCandyMachines**](SolanaCandyMachineApi.md#solanalistallcandymachines) | **GET** /solana/nft/candy_machine/list | List all CMs
[**SolanaSearchCandyMachines**](SolanaCandyMachineApi.md#solanasearchcandymachines) | **POST** /solana/nft/candy_machine/search | Search CMs



## SolanaGetAllNFTsFromCandyMachine

> GetAllNFTsResponse SolanaGetAllNFTsFromCandyMachine (string network, string candyMachineId)

Get CM's NFTs  

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-candy-machine/get-candy-machine-all-nfts\" target=\"_blank\"> See examples (Python, JavaScript)</a>.  Use this endpoint to get the list of all NFTs (minted and unminted) from a Solana Candy Machine.  This works for `v1` and `v2` candy machines.   *However*, for `v2` only the value for `all_nfts` is provided. To determine which are minted and unminted follow this example.  You do not need to specify `v1` or `v2` for this endpoint as it will automatically determine it from the candy machine ID.  See example for how to get the list of NFT hashes <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-candy-machine/get-candy-machine-hash-table\" target=\"_blank\">here</a>.    `Cost: 2 Credits` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetAllNFTsFromCandyMachineExample
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

            var apiInstance = new SolanaCandyMachineApi(Configuration.Default);
            var network = mainnet-beta;  // string | The network ID
            var candyMachineId = FmkrvXRenCGtwBHw3VtBcExp8eTdnau97upaewF4GUEX;  // string | The ID of the candy machine

            try
            {
                // Get CM's NFTs  
                GetAllNFTsResponse result = apiInstance.SolanaGetAllNFTsFromCandyMachine(network, candyMachineId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaCandyMachineApi.SolanaGetAllNFTsFromCandyMachine: " + e.Message );
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
 **network** | **string**| The network ID | 
 **candyMachineId** | **string**| The ID of the candy machine | 

### Return type

[**GetAllNFTsResponse**](GetAllNFTsResponse.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response. Click \&quot;Expand All\&quot; on the right sidebar to see more. |  -  |
| **400** | Bad request (check response message) |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **404** | Not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetCandyMachineMetadata

> GetCandyMetadataResponse SolanaGetCandyMachineMetadata (GetCandyMetadataRequest getCandyMetadataRequest = null)

Get a CM's metadata 

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-candy-machine/get-candy-machine-metadata\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Use this endpoint to get metadata about a Metaplex candy machine. This includes the goLiveDate, itemsAvailable, and itemsRedeemed. To see what is included, expand the green successful response below.  NOTE: Supply exactly one of `candy_machine_id`, `config_address`, or `uuid`. If you provide more than one, you will receive a `400` error.   `Cost: 2 Credits` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetCandyMachineMetadataExample
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

            var apiInstance = new SolanaCandyMachineApi(Configuration.Default);
            var getCandyMetadataRequest = new GetCandyMetadataRequest(); // GetCandyMetadataRequest |  (optional) 

            try
            {
                // Get a CM's metadata 
                GetCandyMetadataResponse result = apiInstance.SolanaGetCandyMachineMetadata(getCandyMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaCandyMachineApi.SolanaGetCandyMachineMetadata: " + e.Message );
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
 **getCandyMetadataRequest** | [**GetCandyMetadataRequest**](GetCandyMetadataRequest.md)|  | [optional] 

### Return type

[**GetCandyMetadataResponse**](GetCandyMetadataResponse.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response.  |  -  |
| **400** | Bad request (check response message) |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaListAllCandyMachines

> Object SolanaListAllCandyMachines ()

List all CMs

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-candy-machine/list-all-candy-machines\" target=\"_blank\">See examples (Python, JavaScript)</a>.  With this endpoint, you can list all candy machines published to Solana mainnet.  We update this data every 15 minutes.  The output is a list of config addresses, currently about 17000 in length.  `Cost: 2 Credits` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaListAllCandyMachinesExample
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

            var apiInstance = new SolanaCandyMachineApi(Configuration.Default);

            try
            {
                // List all CMs
                Object result = apiInstance.SolanaListAllCandyMachines();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaCandyMachineApi.SolanaListAllCandyMachines: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

**Object**

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaSearchCandyMachines

> List&lt;string&gt; SolanaSearchCandyMachines (CandyMachineSearchRequest candyMachineSearchRequest = null)

Search CMs

<a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-candy-machine/search-candy-machines\" target=\"_blank\">See examples (Python, JavaScript)</a>.  With this endpoint, you can search candy machines by their symbol, name of NFTs, uuid, configuration address, and update authority.  The output is a list of config addresses.  You can also provide multiple search clauses, such as the update authority (`update_authority=\"G17UmNGnMJ851x3M1JXocgpft1afcYedjPuFpo1ohhCk\"`) and symbol begins with \"Sol\" (`symbol=\"Sol\", symbol_search_method='begins_with'`).  `Cost: 2 Credits` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaSearchCandyMachinesExample
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

            var apiInstance = new SolanaCandyMachineApi(Configuration.Default);
            var candyMachineSearchRequest = new CandyMachineSearchRequest(); // CandyMachineSearchRequest |  (optional) 

            try
            {
                // Search CMs
                List<string> result = apiInstance.SolanaSearchCandyMachines(candyMachineSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaCandyMachineApi.SolanaSearchCandyMachines: " + e.Message );
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
 **candyMachineSearchRequest** | [**CandyMachineSearchRequest**](CandyMachineSearchRequest.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request (check response message) |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

