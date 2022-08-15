
# Org.OpenAPITools.Model.CCPaymentBlockchainPaymentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chain** | **string** | The chain on which the payment was made.  | [optional] 
**FeeAmount** | **string** | The fee taken by the blockchain API. This is shown in integer form.  | [optional] 
**PayoutAmount** | **string** | The amount paid to the project&#39;s payout wallet (the recipient of the payment). This is shown in integer form.  | [optional] 
**TokenBlockchainIdentifier** | **string** | The blockchain identifier of the token used to pay. Currently, we only support payments in USDC.  | [optional] 
**TotalPaid** | **string** | The total paid by the user when making the payment. This should match the amount set in the respective plan.  | [optional] 
**TransactionSignature** | **string** | The transaction signature which you can use to manually or automatically verify the transaction on the blockchain.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

