
# Org.OpenAPITools.Model.NFTOwnerAdvancedResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contract** | [**NFTOwnerAdvancedResponseContract**](NFTOwnerAdvancedResponseContract.md) |  | [optional] 
**Owner** | **string** | The public key of the wallet that has true ownership over the provided NFT. If listed, it is the lister. If placed on a loan, it is the loanee. If staked, it is the staker. If burned, it is the burner. Etc. Returns &#x60;null&#x60; in the edge case that we were unable to find the true owner. If this happens, please report it to us and we will try to adapt for this edge case.  | [optional] 
**Price** | **decimal** | The price of the NFT, if listed or loaned. If held, staked, or burned, this is null. | [optional] 
**State** | **string** | The state of the NFT | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

