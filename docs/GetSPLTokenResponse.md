
# Org.OpenAPITools.Model.GetSPLTokenResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Decimals** | **decimal** | The number of decimals of the token. For example, if the USDC token has 6 decimals, then you need 1 * 10e6 &#x3D; 1,000,000 tokens to have 1 USDC. The purpose of this is that everything must be stored as  an integer. Thus, if there are $100 USDC in total, there must be $100 * 10e6 tokens in order for the $100 to be divisible into lower denominations than $1.  | [optional] 
**FreezeAuthority** | **string** | Public key address | [optional] 
**MintAuthority** | **string** | Public key address | [optional] 
**IsInitialized** | **bool** |  | [optional] 
**Supply** | **string** | The supply of the token | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

