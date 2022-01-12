
# Org.OpenAPITools.Model.CandyMachineSearchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdateAuthority** | **string** | The public key of the update authority of the candy machine | [optional] 
**UpdateAuthoritySearchMethod** | **string** | Only &#x60;exact_match&#x60; supported at this time | [optional] [default to UpdateAuthoritySearchMethodEnum.Exactmatch]
**ConfigAddress** | **string** | The public key of the configuration of the candy machine | [optional] 
**ConfigAddressSearchMethod** | **string** | Only &#x60;exact_match&#x60; supported at this time | [optional] [default to ConfigAddressSearchMethodEnum.Exactmatch]
**Uuid** | **string** | The alphanumeric string of length six that corresponds to the candy machine. This is NOT the candy machine ID.  This is the first six letters of the configuration address and is also used to identify the candy machine. An example is &#x60;4zKV6i&#x60;.  | [optional] 
**UuidSearchMethod** | **string** | Only &#x60;exact_match&#x60; supported at this time | [optional] [default to UuidSearchMethodEnum.Exactmatch]
**Symbol** | **string** | The symbol associated with the candy machine | [optional] 
**SymbolSearchMethod** | **string** |  | [optional] [default to SymbolSearchMethodEnum.Exactmatch]
**NftName** | **string** | The name of an NFT on the candy machine, minted or unminted. For example, to find The Solana Money Boys candy machine, you already know that each NFT is named \&quot;Solana Money Boy #0\&quot;, \&quot;Solana Money Boy #1\&quot;, and so on. So you could search with  nft_name&#x3D;\&quot;Solana Money Boy #0\&quot;, nft_name_index&#x3D;0, nft_name_search_method&#x3D;&#39;exact_match&#39;, for example, which would return the candy machine ID. This also works with candy machines that are not live but are uploaded.  | [optional] 
**NftNameIndex** | **string** | The index of the NFT to check, e.g., the 2nd NFT would have an index of 1. We cannot search all NFTs on a candy machine currently, so you must search an NFT at a particular position, such as the first, second, and so on. In general, nft_name_index&#x3D;0 works for most use cases.  | [optional] [default to "0"]
**NftNameSearchMethod** | **string** |  | [optional] [default to NftNameSearchMethodEnum.Exactmatch]
**Network** | **string** |  | [optional] [default to NetworkEnum.Devnet]
**CandyMachineContractVersion** | **string** | The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;.  | [optional] [default to CandyMachineContractVersionEnum.V1]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

