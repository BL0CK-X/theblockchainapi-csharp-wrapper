
# Org.OpenAPITools.Model.GetAllNFTsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MintedNfts** | [**List&lt;GetAllNFTsResponseMintedNfts&gt;**](GetAllNFTsResponseMintedNfts.md) | The minted NFTs. Only filled in for &#x60;v1&#x60; candy machines. Left empty for &#x60;v2&#x60;. | [optional] 
**UnmintedNfts** | [**List&lt;GetAllNFTsResponseUnmintedNfts&gt;**](GetAllNFTsResponseUnmintedNfts.md) | The unminted NFTs. Only filled in for &#x60;v1&#x60; candy machines. Left empty for &#x60;v2&#x60;. | [optional] 
**AllNfts** | [**List&lt;GetAllNFTsResponseUnmintedNfts&gt;**](GetAllNFTsResponseUnmintedNfts.md) | The list of all NFTs. Filled in for both &#x60;v1&#x60; and &#x60;v2&#x60; NFTs. | [optional] 
**Accurate** | **bool** | Whether or not the division of NFTs among minted and unminted is accurate. If it is not accurate, then it is possible that NFTs have been included in the &#x60;minted&#x60; list that are not actually minted. If it is accurate, then the split of  minted and unminted is correct. &#x60;v1&#x60; candy machines always return a correct minted/unminted split.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

