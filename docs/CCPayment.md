
# Org.OpenAPITools.Model.CCPayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **string** | The ID of the project  | [optional] 
**ProductId** | **string** | The ID of the associated product  | [optional] 
**PlanId** | **string** | The ID of the respective plan  | [optional] 
**PaymentId** | **string** | The unique ID of the payment  | [optional] 
**BlockchainIdentifier** | **string** | The unique identifier of the wallet from which the payment was made.  | [optional] 
**BlockchainPaymentDetails** | [**CCPaymentBlockchainPaymentDetails**](CCPaymentBlockchainPaymentDetails.md) |  | [optional] 
**CustomerId** | **string** | The ID of the customer  | [optional] 
**PaymentValidationCode** | **string** | The validation code shown to the customer. This is only visible to the customer who paid. They can use this code to redeem their subscription to their product.  | [optional] 
**PeriodEnd** | **decimal** | A UNIX time stamp, in seconds, that identifies the end of the period of the subscription  | [optional] 
**PeriodStart** | **decimal** | A UNIX time stamp, in seconds, that identifies the start of the period of the subscription  | [optional] 
**TransactionBlockchainIdentifier** | **string** | The string that uniquely identifies the blockchain transaction  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

