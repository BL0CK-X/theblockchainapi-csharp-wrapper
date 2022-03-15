
# Org.OpenAPITools.Model.NFTAnalyticsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **Object** | The start time used in the API request.  | [optional] 
**EndTime** | **Object** | The end time used in the API request.   | [optional] 
**TransactionHistory** | [**NFTAnalyticsResponseTransactionHistory**](NFTAnalyticsResponseTransactionHistory.md) |  | [optional] 
**Floor** | **decimal** | The minimum active listing price for the collection in the given time period. The listing must have been processed before &#x60;end_time&#x60; and still active (not delisted or purchased) by &#x60;end_time&#x60; in order to affect the floor calculation.  | [optional] 
**Volume** | **decimal** | The sum of the sale prices for the given time period.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

