
# Org.OpenAPITools.Model.NFT

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Confirmed** | **bool** | Whether or not the NFT mint was confirmed or simply submitted for processing. The status depends on your input for &#x60;wait_for_confirmation&#x60;. This only is returned when you are minting an NFT, not when searching or retrieving the metadata. | [optional] 
**Data** | [**NFTData**](NFTData.md) |  | [optional] 
**IsMutable** | **bool** |  | [optional] 
**Mint** | **string** | The public key address of the NFT  | [optional] 
**PrimarySaleHappened** | **bool** |  | [optional] 
**UpdateAuthority** | **string** | A public key address that is usually that of the person who minted the NFT  | [optional] 
**SellerFeeBasisPoints** | **decimal** |  | [optional] 
**MintSecretRecoveryPhrase** | **string** |  | [optional] 
**ExplorerUrl** | **string** |  | [optional] 
**MetadataAccount** | **string** | The metadata account of the NFT  | [optional] 
**EditionNonce** | **decimal** |  | [optional] 
**TokenStandard** | **decimal** |  | [optional] 
**Collection** | [**NFTCollection**](NFTCollection.md) |  | [optional] 
**Uses** | **decimal** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

