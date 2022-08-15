# Org.OpenAPITools.Api.CCWebhookApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCCWebhook**](CCWebhookApi.md#getccwebhook) | **POST** /webhook/v1/project/{project_id}/webhook/{webhook_identifier} | Get a webhook 
[**ListCCProjectWebhooks**](CCWebhookApi.md#listccprojectwebhooks) | **POST** /webhook/v1/project/{project_id}/webhooks | List project&#39;s webhooks 
[**ValidateCCWebhook**](CCWebhookApi.md#validateccwebhook) | **POST** /webhook/v1/project/{project_id}/webhook/{webhook_identifier}/validate | Validate a webhook 



## GetCCWebhook

> CCWebhook GetCCWebhook (string projectId, string webhookIdentifier)

Get a webhook 

Retrieve the details of a webhook sent to you.  `Cost: 0 Credit` (Free) (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCCWebhookExample
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

            var apiInstance = new CCWebhookApi(Configuration.Default);
            var projectId = project_WDQskRIfHQxj53N5mk5K;  // string | The ID of the project. Created and returned when a project is created.
            var webhookIdentifier = webhook/payment.received/payment_EyfDL6CsvFinpUnXgBXaUuqq3hCXa0;  // string | The ID of the webhook. Created and returned when a webhook is sent.

            try
            {
                // Get a webhook 
                CCWebhook result = apiInstance.GetCCWebhook(projectId, webhookIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CCWebhookApi.GetCCWebhook: " + e.Message );
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
 **projectId** | **string**| The ID of the project. Created and returned when a project is created. | 
 **webhookIdentifier** | **string**| The ID of the webhook. Created and returned when a webhook is sent. | 

### Return type

[**CCWebhook**](CCWebhook.md)

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
| **429** | Rate limited |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCCProjectWebhooks

> List&lt;CCWebhook&gt; ListCCProjectWebhooks (string projectId)

List project's webhooks 

List all webhooks sent to you and their respective responses from your server.  `Cost: 0 Credit` (Free) (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCCProjectWebhooksExample
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

            var apiInstance = new CCWebhookApi(Configuration.Default);
            var projectId = project_WDQskRIfHQxj53N5mk5K;  // string | The ID of the project. Created and returned when a project is created.

            try
            {
                // List project's webhooks 
                List<CCWebhook> result = apiInstance.ListCCProjectWebhooks(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CCWebhookApi.ListCCProjectWebhooks: " + e.Message );
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
 **projectId** | **string**| The ID of the project. Created and returned when a project is created. | 

### Return type

[**List&lt;CCWebhook&gt;**](CCWebhook.md)

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
| **429** | Rate limited |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateCCWebhook

> void ValidateCCWebhook (string projectId, string webhookIdentifier, CCWebhookValidateRequest cCWebhookValidateRequest = null)

Validate a webhook 

Validate whether a webhook you received was actually sent from us.  `Cost: 0 Credit` (Free) (<a href=\"#section/Pricing\">See Pricing</a>)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ValidateCCWebhookExample
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

            var apiInstance = new CCWebhookApi(Configuration.Default);
            var projectId = project_WDQskRIfHQxj53N5mk5K;  // string | The ID of the project. Created and returned when a project is created.
            var webhookIdentifier = webhook/payment.received/payment_EyfDL6CsvFinpUnXgBXaUuqq3hCXa0;  // string | The ID of the webhook. Created and returned when a webhook is sent.
            var cCWebhookValidateRequest = new CCWebhookValidateRequest(); // CCWebhookValidateRequest |  (optional) 

            try
            {
                // Validate a webhook 
                apiInstance.ValidateCCWebhook(projectId, webhookIdentifier, cCWebhookValidateRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CCWebhookApi.ValidateCCWebhook: " + e.Message );
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
 **projectId** | **string**| The ID of the project. Created and returned when a project is created. | 
 **webhookIdentifier** | **string**| The ID of the webhook. Created and returned when a webhook is sent. | 
 **cCWebhookValidateRequest** | [**CCWebhookValidateRequest**](CCWebhookValidateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Valid Webhook |  -  |
| **400** | Bad request / invalid webhook (check response message) |  -  |
| **401** | Invalid API key pair in headers |  -  |
| **429** | Rate limited |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

