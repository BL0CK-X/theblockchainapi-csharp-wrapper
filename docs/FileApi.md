# Org.OpenAPITools.Api.FileApi

All URIs are relative to *https://api.blockchainapi.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploadFile**](FileApi.md#uploadfile) | **POST** /file | Upload a file



## UploadFile

> GetFileResponse UploadFile ()

Upload a file

Easily upload a file to any of IPFS, Arweave, and Filecoin. Not publicly available. Please sign up for <a href=\"https://forms.gle/N4KSqcptpSrHQ1427\" target=\"_blank\">the waitlist</a>.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploadFileExample
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

            var apiInstance = new FileApi(Configuration.Default);

            try
            {
                // Upload a file
                GetFileResponse result = apiInstance.UploadFile();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FileApi.UploadFile: " + e.Message );
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

[**GetFileResponse**](GetFileResponse.md)

### Authorization

[APIKeyID](../README.md#APIKeyID), [APISecretKey](../README.md#APISecretKey)

### HTTP request headers

- **Content-Type**: multipart/form-data, application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request (check response message) |  -  |
| **402** | Payment required. Occurs when you run out of API requests. Upgrade &lt;a href&#x3D;\&quot;https://dashboard.theblockchainapi.com/billing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;. |  -  |
| **403** | Access denied. Must sign up and be approved for beta. See link for application in the description below the \&quot;File Upload\&quot; header. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

