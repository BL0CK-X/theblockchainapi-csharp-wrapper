# Org.OpenAPITools - the C# library for the The Blockchain API

# About

Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly. 

You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>

# How to Use the API

To use the API, you simply need to create an API key pair.

Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.

# Feature Requests

Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).

# Contact

<figure>
    <img 
        width=\"40px\"
        height=\"40px\" 
        src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"
    />
    <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption>
</figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">
    <figure>
        <img 
            width=\"40px\"
            height=\"40px\" 
            src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"
        />
        <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>
    </figure>
</a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">
    <figure>
        <img 
            width=\"40px\"
            height=\"40px\" 
            src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"
        />
        <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>
    </figure>
</a> <a href=\"https://twitter.com/BlockchainAP1\" target=\"_blank\">
    <figure>
        <img 
            width=\"40px\"
            height=\"40px\" 
            src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"
        />
         <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>
    </figure>
</a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">
    <figure>
        <img 
            width=\"40px\"
            height=\"40px\" 
            src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"
        />
        <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>
    </figure>
</a>

# Security

Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet. 

<b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b> 

How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.

We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.

Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.

Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.

# Pricing

<b>Each user receives 50,000 free credits each month.</b> Each endpoint costs a certain amount credits. Scroll below to any endpoint (i.e., function) to see how much each endpoint costs. (Or CMD+F `Cost: 0 Credit`, for example)

You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>. 

We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.

If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.

# SDKs / API Wrappers

We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.

We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.

`pip install theblockchainapi`

We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.

`npm install theblockchainapi`

We also have auto-generated wrappers for the following languages:
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-csharp-wrapper\" target = \"_blank\">C#</a>
- <a href=\"https://github.com/BL0CK-X/theblockchainapi-dart-wrapper\" target = \"_blank\">Dart</a>

If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.

If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: null
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.blockchainapi.com/v1";
            // Configure API key authorization: APIKeyID
            Configuration.Default.ApiKey.Add("APIKeyID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIKeyID", "Bearer");
            // Configure API key authorization: APISecretKey
            Configuration.Default.ApiKey.Add("APISecretKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APISecretKey", "Bearer");

            var apiInstance = new CCPaymentApi(Configuration.Default);
            var projectId = project_WDQskRIfHQxj53N5mk5K;  // string | The ID of the project. Created and returned when a project is created.
            var paymentIdentifier = ["payment_97jA1szpVjrSI5EvOb5zxNQFq5CfrC"];  // string | You can supply either `payment_id` or `payment_validation_code`.  The `payment_id` is only visible by you and uniquely identifies a payment.  The `payment_validation_code` is shown exclusively to the customer and the owner of the project. It can be used to redeem a payment. You can verify a payment by pulling the payment with the `payment_validation_code`.

            try
            {
                // Get a payment 
                CCPayment result = apiInstance.GetCCPayment(projectId, paymentIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CCPaymentApi.GetCCPayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.blockchainapi.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CCPaymentApi* | [**GetCCPayment**](docs/CCPaymentApi.md#getccpayment) | **GET** /checkout/v1/project/{project_id}/payment/{payment_identifier} | Get a payment 
*CCPaymentApi* | [**ListAllCCPayments**](docs/CCPaymentApi.md#listallccpayments) | **GET** /checkout/v1/payments | List all payments  
*CCPaymentApi* | [**ListCCProjectPayments**](docs/CCPaymentApi.md#listccprojectpayments) | **GET** /checkout/v1/project/{project_id}/payments | List a project's payments 
*CCProjectApi* | [**CreateCCProject**](docs/CCProjectApi.md#createccproject) | **POST** /checkout/v1/project | Create a project 
*CCProjectApi* | [**DeleteCCProject**](docs/CCProjectApi.md#deleteccproject) | **DELETE** /checkout/v1/project/{project_id} | Delete a project 
*CCProjectApi* | [**GetCCProject**](docs/CCProjectApi.md#getccproject) | **GET** /checkout/v1/project/{project_id} | Get a project 
*CCProjectApi* | [**ListCCProjects**](docs/CCProjectApi.md#listccprojects) | **GET** /checkout/v1/projects | List projects 
*CCProjectApi* | [**UpdateCCProject**](docs/CCProjectApi.md#updateccproject) | **PUT** /checkout/v1/project/{project_id} | Update a project 
*CCWebhookApi* | [**GetCCWebhook**](docs/CCWebhookApi.md#getccwebhook) | **POST** /webhook/v1/project/{project_id}/webhook/{webhook_identifier} | Get a webhook 
*CCWebhookApi* | [**ListCCProjectWebhooks**](docs/CCWebhookApi.md#listccprojectwebhooks) | **POST** /webhook/v1/project/{project_id}/webhooks | List project's webhooks 
*CCWebhookApi* | [**ValidateCCWebhook**](docs/CCWebhookApi.md#validateccwebhook) | **POST** /webhook/v1/project/{project_id}/webhook/{webhook_identifier}/validate | Validate a webhook 
*NameServiceApi* | [**GetBlockchainIdentifierFromName**](docs/NameServiceApi.md#getblockchainidentifierfromname) | **POST** /{blockchain}/{network}/name_service/name_to_blockchain_identifier | Get the identifier
*NameServiceApi* | [**GetNameForBlockchainIdentifier**](docs/NameServiceApi.md#getnameforblockchainidentifier) | **POST** /{blockchain}/{network}/name_service/blockchain_identifier_to_name | Get the name
*SolanaAccountApi* | [**SolanaGetAccount**](docs/SolanaAccountApi.md#solanagetaccount) | **GET** /solana/account/{network}/{public_key} | Get the details of an account on Solana
*SolanaAccountApi* | [**SolanaGetAccountIsCandyMachine**](docs/SolanaAccountApi.md#solanagetaccountiscandymachine) | **GET** /solana/account/{network}/{public_key}/is_candy_machine | Get if account is candy machine
*SolanaAccountApi* | [**SolanaGetAccountIsNFT**](docs/SolanaAccountApi.md#solanagetaccountisnft) | **GET** /solana/account/{network}/{public_key}/is_nft | Get if account is NFT
*SolanaCandyMachineApi* | [**SolanaGetAllNFTsFromCandyMachine**](docs/SolanaCandyMachineApi.md#solanagetallnftsfromcandymachine) | **GET** /solana/nft/candy_machine/{network}/{candy_machine_id}/nfts | Get CM's NFTs  
*SolanaCandyMachineApi* | [**SolanaGetCandyMachineMetadata**](docs/SolanaCandyMachineApi.md#solanagetcandymachinemetadata) | **POST** /solana/nft/candy_machine/metadata | Get a CM's metadata 
*SolanaCandyMachineApi* | [**SolanaListAllCandyMachines**](docs/SolanaCandyMachineApi.md#solanalistallcandymachines) | **GET** /solana/nft/candy_machine/list | List all CMs
*SolanaCandyMachineApi* | [**SolanaSearchCandyMachines**](docs/SolanaCandyMachineApi.md#solanasearchcandymachines) | **POST** /solana/nft/candy_machine/search | Search CMs
*SolanaNFTApi* | [**SolanaCreateNFT**](docs/SolanaNFTApi.md#solanacreatenft) | **POST** /solana/nft | Create an NFT on Solana
*SolanaNFTApi* | [**SolanaGetNFT**](docs/SolanaNFTApi.md#solanagetnft) | **GET** /solana/nft/{network}/{mint_address} | Get an NFT's metadata
*SolanaNFTApi* | [**SolanaGetNFTMintFee**](docs/SolanaNFTApi.md#solanagetnftmintfee) | **GET** /solana/nft/mint/fee | Get the NFT mint fee
*SolanaNFTApi* | [**SolanaGetNFTOwner**](docs/SolanaNFTApi.md#solanagetnftowner) | **GET** /solana/nft/{network}/{mint_address}/owner | Get owner of an NFT
*SolanaNFTApi* | [**SolanaGetNFTOwnerAdvanced**](docs/SolanaNFTApi.md#solanagetnftowneradvanced) | **GET** /solana/nft/{network}/{mint_address}/owner_advanced | Get owner of an NFT (advanced)
*SolanaNFTApi* | [**SolanaGetNFTsCandyMachineId**](docs/SolanaNFTApi.md#solanagetnftscandymachineid) | **POST** /solana/nft/candy_machine_id | Get the ID of the candy machine of an NFT 
*SolanaNFTApi* | [**SolanaSearchNFTs**](docs/SolanaNFTApi.md#solanasearchnfts) | **POST** /solana/nft/search | Search NFTs on Solana
*SolanaSPLTokenApi* | [**SolanaGetSPLToken**](docs/SolanaSPLTokenApi.md#solanagetspltoken) | **GET** /solana/spl-token/{network}/{public_key} | Get SPL token metadata
*SolanaTransactionApi* | [**SolanaGetTransaction**](docs/SolanaTransactionApi.md#solanagettransaction) | **GET** /solana/transaction/{network}/{tx_signature} | Get the details of a transaction made on Solana
*SolanaWalletApi* | [**SolanaDeriveAssociatedTokenAccountAddress**](docs/SolanaWalletApi.md#solanaderiveassociatedtokenaccountaddress) | **GET** /solana/wallet/{public_key}/associated_token_account/{mint_address} | Derive an associated token account address
*SolanaWalletApi* | [**SolanaDerivePrivateKey**](docs/SolanaWalletApi.md#solanaderiveprivatekey) | **POST** /solana/wallet/private_key | Derive private key
*SolanaWalletApi* | [**SolanaDerivePublicKey**](docs/SolanaWalletApi.md#solanaderivepublickey) | **POST** /solana/wallet/public_key | Derive public key
*SolanaWalletApi* | [**SolanaGeneratePrivateKey**](docs/SolanaWalletApi.md#solanagenerateprivatekey) | **POST** /solana/wallet/generate/private_key | Generate private key
*SolanaWalletApi* | [**SolanaGenerateSecretRecoveryPhrase**](docs/SolanaWalletApi.md#solanageneratesecretrecoveryphrase) | **POST** /solana/wallet/generate/secret_recovery_phrase | Generate secret phrase
*SolanaWalletApi* | [**SolanaGetAirdrop**](docs/SolanaWalletApi.md#solanagetairdrop) | **POST** /solana/wallet/airdrop | Get an airdrop on devnet
*SolanaWalletApi* | [**SolanaGetBalance**](docs/SolanaWalletApi.md#solanagetbalance) | **POST** /solana/wallet/balance | Get wallet's balance in SOL or any SPL
*SolanaWalletApi* | [**SolanaGetNFTsBelongingToWallet**](docs/SolanaWalletApi.md#solanagetnftsbelongingtowallet) | **GET** /solana/wallet/{network}/{public_key}/nfts | Get address's NFTs
*SolanaWalletApi* | [**SolanaGetTokensBelongingToWallet**](docs/SolanaWalletApi.md#solanagettokensbelongingtowallet) | **GET** /solana/wallet/{network}/{public_key}/tokens | Get address's tokens and respective balances
*SolanaWalletApi* | [**SolanaGetWalletTransactions**](docs/SolanaWalletApi.md#solanagetwallettransactions) | **GET** /solana/wallet/{network}/{public_key}/transactions | Get address's associated transaction signatures
*SolanaWalletApi* | [**SolanaTransfer**](docs/SolanaWalletApi.md#solanatransfer) | **POST** /solana/wallet/transfer | Transfer SOL, a token, or an NFT to another address
*TokenApi* | [**GetTokenMetadata**](docs/TokenApi.md#gettokenmetadata) | **GET** /{blockchain}/{network}/token/{token_blockchain_identifier} | Get a token's metadata
*TokenApi* | [**ListAllTokens**](docs/TokenApi.md#listalltokens) | **GET** /{blockchain}/{network}/all_tokens | List all tokens
*TransactionApi* | [**GetTransaction**](docs/TransactionApi.md#gettransaction) | **GET** /{blockchain}/transaction/{network}/{transaction_blockchain_identifier} | Get the details of a transaction made on a blockchain
*WalletApi* | [**DerivePrivateKey**](docs/WalletApi.md#deriveprivatekey) | **POST** /{blockchain}/wallet/private_key | Derive private key
*WalletApi* | [**DeriveWalletIdentifier**](docs/WalletApi.md#derivewalletidentifier) | **POST** /{blockchain}/wallet/identifier | Derive wallet identifier
*WalletApi* | [**GeneratePrivateKey**](docs/WalletApi.md#generateprivatekey) | **POST** /{blockchain}/wallet/generate/private_key | Generate private key
*WalletApi* | [**GenerateSeedPhrase**](docs/WalletApi.md#generateseedphrase) | **POST** /{blockchain}/wallet/generate/secret_recovery_phrase | Generate seed phrase
*WalletApi* | [**GetAirdrop**](docs/WalletApi.md#getairdrop) | **POST** /{blockchain}/wallet/airdrop | Get an airdrop
*WalletApi* | [**GetBalance**](docs/WalletApi.md#getbalance) | **POST** /{blockchain}/wallet/balance | Get wallet's balance of X
*WalletApi* | [**Transfer**](docs/WalletApi.md#transfer) | **POST** /{blockchain}/wallet/transfer | Transfer crypto, a token, or an NFT to another wallet


## Documentation for Models

 - [Model.ATAResponse](docs/ATAResponse.md)
 - [Model.Account](docs/Account.md)
 - [Model.AccountContext](docs/AccountContext.md)
 - [Model.AccountIsCandyMachine](docs/AccountIsCandyMachine.md)
 - [Model.AccountIsNFT](docs/AccountIsNFT.md)
 - [Model.AccountValue](docs/AccountValue.md)
 - [Model.AirdropRequest](docs/AirdropRequest.md)
 - [Model.AvalancheCChainPublicAddress](docs/AvalancheCChainPublicAddress.md)
 - [Model.AvalancheXPChainPublicAddress](docs/AvalancheXPChainPublicAddress.md)
 - [Model.B58PrivateKey](docs/B58PrivateKey.md)
 - [Model.BSCPublicAddress](docs/BSCPublicAddress.md)
 - [Model.BalanceRequest](docs/BalanceRequest.md)
 - [Model.BalanceResponse](docs/BalanceResponse.md)
 - [Model.CCPayment](docs/CCPayment.md)
 - [Model.CCPaymentBlockchainPaymentDetails](docs/CCPaymentBlockchainPaymentDetails.md)
 - [Model.CCProject](docs/CCProject.md)
 - [Model.CCProjectCreateRequest](docs/CCProjectCreateRequest.md)
 - [Model.CCProjectCreateRequestCustomerIdToCollect](docs/CCProjectCreateRequestCustomerIdToCollect.md)
 - [Model.CCProjectCreateRequestPayoutMethod](docs/CCProjectCreateRequestPayoutMethod.md)
 - [Model.CCWebhook](docs/CCWebhook.md)
 - [Model.CCWebhookValidateRequest](docs/CCWebhookValidateRequest.md)
 - [Model.CandyMachineSearchRequest](docs/CandyMachineSearchRequest.md)
 - [Model.DoubleTransferResponse](docs/DoubleTransferResponse.md)
 - [Model.EthereumPublicAddress](docs/EthereumPublicAddress.md)
 - [Model.EthereumTransaction](docs/EthereumTransaction.md)
 - [Model.EthereumTransactionCompiledResponse](docs/EthereumTransactionCompiledResponse.md)
 - [Model.EthereumTransactionMadeResponse](docs/EthereumTransactionMadeResponse.md)
 - [Model.FeePayerWallet](docs/FeePayerWallet.md)
 - [Model.GeneralAirdropRequest](docs/GeneralAirdropRequest.md)
 - [Model.GeneralB58PrivateKey](docs/GeneralB58PrivateKey.md)
 - [Model.GeneralBalanceRequest](docs/GeneralBalanceRequest.md)
 - [Model.GeneralBalanceResponse](docs/GeneralBalanceResponse.md)
 - [Model.GeneralFeePayerWallet](docs/GeneralFeePayerWallet.md)
 - [Model.GeneralGeneratePrivateKeyResponse](docs/GeneralGeneratePrivateKeyResponse.md)
 - [Model.GeneralPrivateKey](docs/GeneralPrivateKey.md)
 - [Model.GeneralSecretPhrase](docs/GeneralSecretPhrase.md)
 - [Model.GeneralSecretRecoveryPhrase](docs/GeneralSecretRecoveryPhrase.md)
 - [Model.GeneralTransaction](docs/GeneralTransaction.md)
 - [Model.GeneralTransactionMadeResponse](docs/GeneralTransactionMadeResponse.md)
 - [Model.GeneralTransactionResponse](docs/GeneralTransactionResponse.md)
 - [Model.GeneralTransferRequest](docs/GeneralTransferRequest.md)
 - [Model.GeneralWallet](docs/GeneralWallet.md)
 - [Model.GeneratePrivateKey](docs/GeneratePrivateKey.md)
 - [Model.GenerateSeedPhraseRequest](docs/GenerateSeedPhraseRequest.md)
 - [Model.GetAllNFTsResponse](docs/GetAllNFTsResponse.md)
 - [Model.GetAllNFTsResponseMintedNfts](docs/GetAllNFTsResponseMintedNfts.md)
 - [Model.GetAllNFTsResponseUnmintedNfts](docs/GetAllNFTsResponseUnmintedNfts.md)
 - [Model.GetCandyMachineIDRequest](docs/GetCandyMachineIDRequest.md)
 - [Model.GetCandyMachineIDResponse](docs/GetCandyMachineIDResponse.md)
 - [Model.GetCandyMetadataErrorResponse](docs/GetCandyMetadataErrorResponse.md)
 - [Model.GetCandyMetadataRequest](docs/GetCandyMetadataRequest.md)
 - [Model.GetCandyMetadataResponse](docs/GetCandyMetadataResponse.md)
 - [Model.GetCandyMetadataResponseCreators](docs/GetCandyMetadataResponseCreators.md)
 - [Model.GetPublicKeyRequest](docs/GetPublicKeyRequest.md)
 - [Model.GetSPLTokenResponse](docs/GetSPLTokenResponse.md)
 - [Model.HexPrivateKey](docs/HexPrivateKey.md)
 - [Model.InputBlockchainIdentifier](docs/InputBlockchainIdentifier.md)
 - [Model.InputName](docs/InputName.md)
 - [Model.ListNFTsResponse](docs/ListNFTsResponse.md)
 - [Model.NFT](docs/NFT.md)
 - [Model.NFTCollection](docs/NFTCollection.md)
 - [Model.NFTData](docs/NFTData.md)
 - [Model.NFTMintErrorResponse](docs/NFTMintErrorResponse.md)
 - [Model.NFTMintFee](docs/NFTMintFee.md)
 - [Model.NFTMintRequest](docs/NFTMintRequest.md)
 - [Model.NFTOwnerAdvancedResponse](docs/NFTOwnerAdvancedResponse.md)
 - [Model.NFTOwnerAdvancedResponseContract](docs/NFTOwnerAdvancedResponseContract.md)
 - [Model.NFTOwnerResponse](docs/NFTOwnerResponse.md)
 - [Model.NFTSearchRequest](docs/NFTSearchRequest.md)
 - [Model.NFTSearchResponse](docs/NFTSearchResponse.md)
 - [Model.NearPublicKey](docs/NearPublicKey.md)
 - [Model.PrivateKey](docs/PrivateKey.md)
 - [Model.PublicKey](docs/PublicKey.md)
 - [Model.SecretPhrase](docs/SecretPhrase.md)
 - [Model.SecretRecoveryPhrase](docs/SecretRecoveryPhrase.md)
 - [Model.SolanaPublicKey](docs/SolanaPublicKey.md)
 - [Model.SolanaTransaction](docs/SolanaTransaction.md)
 - [Model.SolanaTransactionCompiledResponse](docs/SolanaTransactionCompiledResponse.md)
 - [Model.SolanaTransactionMadeResponse](docs/SolanaTransactionMadeResponse.md)
 - [Model.SupplyWalletRequest](docs/SupplyWalletRequest.md)
 - [Model.TokenMetadataResponse](docs/TokenMetadataResponse.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionResult](docs/TransactionResult.md)
 - [Model.TransferRequest](docs/TransferRequest.md)
 - [Model.TransferResponse](docs/TransferResponse.md)
 - [Model.TransferResponseCompiled](docs/TransferResponseCompiled.md)
 - [Model.Wallet](docs/Wallet.md)
 - [Model.WalletIdentifiers](docs/WalletIdentifiers.md)


## Documentation for Authorization


### APIKeyID

- **Type**: API key

- **API key parameter name**: APIKeyID
- **Location**: HTTP header


### APISecretKey

- **Type**: API key

- **API key parameter name**: APISecretKey
- **Location**: HTTP header

