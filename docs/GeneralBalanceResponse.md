
# Org.OpenAPITools.Model.GeneralBalanceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **decimal** | The balance of the token in the wallet  | 
**IntegerBalance** | **decimal** | Not included if retreiving native token (e.g., SOL, ETH, BNB, etc.) balance  | [optional] 
**Decimals** | **decimal** | Not included if retreiving native token (e.g., SOL, ETH, BNB, etc.) balance.  | [optional] 
**Network** | **string** | The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60; | 
**Unit** | **string** | Not included if retreiving a token / NFT balance  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

