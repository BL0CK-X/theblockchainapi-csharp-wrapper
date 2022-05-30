
# Org.OpenAPITools.Model.GeneralTransactionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionBlockchainIdentifier** | **string** | The identifier of the transaction | [optional] 
**TransactionConfirmed** | **bool** | Whether or not the transaction was confirmed | [optional] 
**B58CompiledTransaction** | **string** | A base58 encoded byte array in string representation. Really easy to submit to Phantom. See &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/blob/main/examples/tutorials/phantom_tutorials/transfer_solana.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt; for an example on how to submit it to a Phantom wallet for signing. | [optional] 
**CompiledTransaction** | **Object** | An array of integers representing the bytes of the transaction | [optional] 
**ChainId** | **string** | Indicates the chain that the transaction was compiled for (e.g., ropsten or mainnet).  | [optional] 
**Data** | **string** | The transaction data  | [optional] 
**From** | **string** | The address expected to sign and submit the transaction  | [optional] 
**To** | **string** | The contract. This should match your provided value for &#x60;token_blockchain_identifier&#x60;.  | [optional] 
**Gas** | **decimal** |  | [optional] 
**MaxFeePerGas** | **decimal** |  | [optional] 
**MaxPriorityFeePerGas** | **decimal** |  | [optional] 
**Nonce** | **decimal** |  | [optional] 
**Value** | **decimal** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

