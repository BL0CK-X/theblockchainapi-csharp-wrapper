# Org.OpenAPITools.Api.SolanaNFTMarketplacesApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SolanaBuyNFT**](SolanaNFTMarketplacesApi.md#solanabuynft) | **POST** /solana/nft/marketplaces/{exchange}/buy/{network}/{mint_address} | Buy
[**SolanaDelistNFT**](SolanaNFTMarketplacesApi.md#solanadelistnft) | **POST** /solana/nft/marketplaces/{exchange}/delist/{network}/{mint_address} | Delist
[**SolanaGetNFTListing**](SolanaNFTMarketplacesApi.md#solanagetnftlisting) | **GET** /solana/nft/marketplaces/listing/{network}/{mint_address} | Get NFT Listing
[**SolanaGetNFTMarketplaceAnalytics**](SolanaNFTMarketplacesApi.md#solanagetnftmarketplaceanalytics) | **POST** /solana/nft/marketplaces/analytics | Get NFT Analytics
[**SolanaGetNFTMarketplaceMarketShare**](SolanaNFTMarketplacesApi.md#solanagetnftmarketplacemarketshare) | **GET** /solana/nft/marketplaces/analytics/market_share | Get Marketplace Market Share
[**SolanaGetNFTMarketplaceRecentTransactions**](SolanaNFTMarketplacesApi.md#solanagetnftmarketplacerecenttransactions) | **GET** /solana/nft/marketplaces/analytics/recent_transactions | Get Recent NFT Transactions
[**SolanaListNFT**](SolanaNFTMarketplacesApi.md#solanalistnft) | **POST** /solana/nft/marketplaces/{exchange}/list/{network}/{mint_address} | List



## SolanaBuyNFT

> BuyResponse SolanaBuyNFT (string network, string exchange, string mintAddress, BuyRequest buyRequest = null)

Buy

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  `Cost: 25 Credits`, `Cost: 3 Credits on Devnet` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaBuyNFTExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);
            var network = devnet;  // string | The network ID
            var exchange = solsea;  // string | The NFT exchange to interact with
            var mintAddress = 7GA16mQup7ESJbaD6n49VCwVG9kRkyQDzWKhBSLjbYqr;  // string | The mint address of the NFT you want to buy
            var buyRequest = new BuyRequest(); // BuyRequest |  (optional) 

            try
            {
                // Buy
                BuyResponse result = apiInstance.SolanaBuyNFT(network, exchange, mintAddress, buyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaBuyNFT: " + e.Message );
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
 **exchange** | **string**| The NFT exchange to interact with | 
 **mintAddress** | **string**| The mint address of the NFT you want to buy | 
 **buyRequest** | [**BuyRequest**](BuyRequest.md)|  | [optional] 

### Return type

[**BuyResponse**](BuyResponse.md)

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


## SolanaDelistNFT

> DelistResponse SolanaDelistNFT (string network, string exchange, string mintAddress, DelistRequest delistRequest = null)

Delist

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  `Cost: 8 Credits`, `Cost: 3 Credits on Devnet` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaDelistNFTExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);
            var network = devnet;  // string | The network ID
            var exchange = solsea;  // string | The NFT exchange to interact with
            var mintAddress = 7GA16mQup7ESJbaD6n49VCwVG9kRkyQDzWKhBSLjbYqr;  // string | The mint address of the NFT you want to buy
            var delistRequest = new DelistRequest(); // DelistRequest |  (optional) 

            try
            {
                // Delist
                DelistResponse result = apiInstance.SolanaDelistNFT(network, exchange, mintAddress, delistRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaDelistNFT: " + e.Message );
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
 **exchange** | **string**| The NFT exchange to interact with | 
 **mintAddress** | **string**| The mint address of the NFT you want to buy | 
 **delistRequest** | [**DelistRequest**](DelistRequest.md)|  | [optional] 

### Return type

[**DelistResponse**](DelistResponse.md)

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


## SolanaGetNFTListing

> GetNFTListingResponse SolanaGetNFTListing (string network, string mintAddress)

Get NFT Listing

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  `Cost: 1 Credits`, (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetNFTListingExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);
            var network = devnet;  // string | The network ID
            var mintAddress = 7GA16mQup7ESJbaD6n49VCwVG9kRkyQDzWKhBSLjbYqr;  // string | The mint address of the NFT you want to buy

            try
            {
                // Get NFT Listing
                GetNFTListingResponse result = apiInstance.SolanaGetNFTListing(network, mintAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaGetNFTListing: " + e.Message );
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
 **mintAddress** | **string**| The mint address of the NFT you want to buy | 

### Return type

[**GetNFTListingResponse**](GetNFTListingResponse.md)

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
| **403** | Our API will throw a 403 if you are providing a body in the GET request.  Such requests are insecure and rejected. The solution is not to provide any sort of body in any GET request.  |  -  |
| **404** | No marketplace listing found for this NFT. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetNFTMarketplaceAnalytics

> NFTAnalyticsResponse SolanaGetNFTMarketplaceAnalytics (NFTAnalyticsRequest nFTAnalyticsRequest = null)

Get NFT Analytics

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\" target=\"_blank\">See examples (Python, JavaScript)</a>.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute <a href=\"https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\" target=\"_blank\">here</a>.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  `Cost: 15 Credits`, (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetNFTMarketplaceAnalyticsExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);
            var nFTAnalyticsRequest = new NFTAnalyticsRequest(); // NFTAnalyticsRequest |  (optional) 

            try
            {
                // Get NFT Analytics
                NFTAnalyticsResponse result = apiInstance.SolanaGetNFTMarketplaceAnalytics(nFTAnalyticsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaGetNFTMarketplaceAnalytics: " + e.Message );
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
 **nFTAnalyticsRequest** | [**NFTAnalyticsRequest**](NFTAnalyticsRequest.md)|  | [optional] 

### Return type

[**NFTAnalyticsResponse**](NFTAnalyticsResponse.md)

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
| **404** | No marketplace listing found for this NFT. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetNFTMarketplaceMarketShare

> Object SolanaGetNFTMarketplaceMarketShare ()

Get Marketplace Market Share

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  `Cost: 3 Credits`, (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetNFTMarketplaceMarketShareExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);

            try
            {
                // Get Marketplace Market Share
                Object result = apiInstance.SolanaGetNFTMarketplaceMarketShare();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaGetNFTMarketplaceMarketShare: " + e.Message );
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
| **403** | Our API will throw a 403 if you are providing a body in the GET request.  Such requests are insecure and rejected. The solution is not to provide any sort of body in any GET request.  |  -  |
| **404** | No marketplace listing found for this NFT. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaGetNFTMarketplaceRecentTransactions

> List&lt;NFTTransaction&gt; SolanaGetNFTMarketplaceRecentTransactions ()

Get Recent NFT Transactions

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\" target=\"_blank\">See examples (Python, JavaScript)</a>.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  `Cost: 15 Credits`, (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaGetNFTMarketplaceRecentTransactionsExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);

            try
            {
                // Get Recent NFT Transactions
                List<NFTTransaction> result = apiInstance.SolanaGetNFTMarketplaceRecentTransactions();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaGetNFTMarketplaceRecentTransactions: " + e.Message );
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

[**List&lt;NFTTransaction&gt;**](NFTTransaction.md)

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
| **403** | Our API will throw a 403 if you are providing a body in the GET request.  Such requests are insecure and rejected. The solution is not to provide any sort of body in any GET request.  |  -  |
| **404** | No marketplace listing found for this NFT. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SolanaListNFT

> ListResponse SolanaListNFT (string network, string exchange, string mintAddress, ListRequest listRequest = null)

List

<a href=\"https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\" target=\"_blank\">See examples (Python, JavaScript)</a>.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  `Cost: 12 Credits`, `Cost: 3 Credits on Devnet` (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SolanaListNFTExample
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

            var apiInstance = new SolanaNFTMarketplacesApi(Configuration.Default);
            var network = devnet;  // string | The network ID
            var exchange = solsea;  // string | The NFT exchange to interact with
            var mintAddress = 7GA16mQup7ESJbaD6n49VCwVG9kRkyQDzWKhBSLjbYqr;  // string | The mint address of the NFT you want to buy
            var listRequest = new ListRequest(); // ListRequest |  (optional) 

            try
            {
                // List
                ListResponse result = apiInstance.SolanaListNFT(network, exchange, mintAddress, listRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SolanaNFTMarketplacesApi.SolanaListNFT: " + e.Message );
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
 **exchange** | **string**| The NFT exchange to interact with | 
 **mintAddress** | **string**| The mint address of the NFT you want to buy | 
 **listRequest** | [**ListRequest**](ListRequest.md)|  | [optional] 

### Return type

[**ListResponse**](ListResponse.md)

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

