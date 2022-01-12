
# Org.OpenAPITools.Model.GetCandyMetadataResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Authority** | **string** | The update authority of the candy machine | [optional] 
**Bump** | **decimal** |  | [optional] 
**CandyMachineId** | **string** | The ID of the candy machine  | [optional] 
**ConfigAddress** | **string** | The configuration public key address of the candy machine  | [optional] 
**Creators** | [**List&lt;GetCandyMetadataResponseCreators&gt;**](GetCandyMetadataResponseCreators.md) |  | [optional] 
**GoLiveDate** | **decimal** | The unix timestamp of the start date of the candy machine  | [optional] 
**IsMutable** | **bool** |  | [optional] 
**ItemsAvailable** | **decimal** | The number of NFTs available for mint from the candy machine  | [optional] 
**ItemsRedeemed** | **decimal** | The number of NFTs minted already from the candy machine  | [optional] 
**MaxNumberOfLines** | **decimal** |  | [optional] 
**MaxSupply** | **decimal** |  | [optional] 
**Price** | **decimal** | The price in Lamports for minting an NFT from the candy machine. 1e9 Lamport  &#x3D; 1 SOL  | [optional] 
**RetainAuthority** | **bool** |  | [optional] 
**SellerFeeBasisPoints** | **decimal** | The royalty the creators receive on each sale after the primary sale (the initial minting) (denominated in basis points (e.g., 75 basis points &#x3D; 0.75%))  | [optional] 
**Symbol** | **string** |  | [optional] 
**TokenMint** | **string** |  | [optional] 
**Uuid** | **string** | The uuid of the candy machine | [optional] 
**Wallet** | **string** | The public key address of the wallet that recevies the proceeds from NFT mints  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

