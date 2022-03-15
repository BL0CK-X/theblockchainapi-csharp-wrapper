
# Org.OpenAPITools.Model.NFTTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockTime** | **decimal** | An epoch time stamp in UTC time that represents the time of the block where the transaction was processed  | [optional] 
**Exchange** | **string** | The NFT exchange on which the transaction occurred | [optional] 
**ExchangeReadable** | **string** | A readable version of the NFT exchange | [optional] 
**MintAddress** | **string** | The mint address of the NFT  | [optional] 
**Operation** | **string** | The operation of the transaction | [optional] 
**Seller** | **string** | The public key of the wallet that listed the NFT | [optional] 
**Buyer** | **string** | The public key of the buyer. This only exists in &#x60;buy&#x60; transactions.  | [optional] 
**TransactionSignature** | **string** | The signature of the transaction. You can look up each transaction on explorer.solana.com  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

