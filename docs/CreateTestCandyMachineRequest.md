
# Org.OpenAPITools.Model.CreateTestCandyMachineRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Wallet** | [**Wallet**](Wallet.md) |  | 
**Network** | **string** |  | [optional] [default to NetworkEnum.Devnet]
**CandyMachineContractVersion** | **string** | The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines.  | [optional] [default to CandyMachineContractVersionEnum.V2]
**IncludeGatekeeper** | **bool** | Whether or not to include a gatekeeper for testing purposes. Only applies to v2 candy machines. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

