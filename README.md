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
</a> <a href=\"https://twitter.com/_BlockX_\" target=\"_blank\">
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

<b>Each user receives 100 free credits. Each user can call endpoints that cost 0 credits up to 50 requests/min before being rate-limited.</b> Thereafter, they can upgrade to have a higher rate limit. The purpose of this is to act like a free trial - - not to function like a freemium model where one can stay on the free tier indefinitely.

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

            var apiInstance = new EndpointApi(Configuration.Default);
            var endpointReference = new EndpointReference(); // EndpointReference |  (optional) 

            try
            {
                // Delete an endpoint 
                apiInstance.DeleteEndpoint(endpointReference);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EndpointApi.DeleteEndpoint: " + e.Message );
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
*EndpointApi* | [**DeleteEndpoint**](docs/EndpointApi.md#deleteendpoint) | **POST** /endpoint/delete | Delete an endpoint 
*EndpointApi* | [**GetEndpoint**](docs/EndpointApi.md#getendpoint) | **POST** /endpoint/metadata | Get an endpoint's metadata 
*EndpointApi* | [**ListEndpoints**](docs/EndpointApi.md#listendpoints) | **GET** /endpoint/list | List all endpoints 
*EndpointApi* | [**SetEndpoint**](docs/EndpointApi.md#setendpoint) | **POST** /endpoint | Create / update an endpoint 
*FileApi* | [**UploadFile**](docs/FileApi.md#uploadfile) | **POST** /file | Upload a file
*ProjectApi* | [**CreateProject**](docs/ProjectApi.md#createproject) | **POST** /project | Create a project 
*ProjectApi* | [**CreateProjectVersion**](docs/ProjectApi.md#createprojectversion) | **POST** /project/{project_id}/{version} | Create a new project version 
*ProjectApi* | [**DeleteProject**](docs/ProjectApi.md#deleteproject) | **DELETE** /project/{project_id} | Delete a project 
*ProjectApi* | [**DeleteProjectVersion**](docs/ProjectApi.md#deleteprojectversion) | **DELETE** /project/{project_id}/{version} | Delete a project version 
*ProjectApi* | [**GetProject**](docs/ProjectApi.md#getproject) | **GET** /project/{project_id} | Get a project's metadata 
*ProjectApi* | [**GetProjectDeploymentStatus**](docs/ProjectApi.md#getprojectdeploymentstatus) | **POST** /project/{project_id}/deploy/status | Get deployment status 
*ProjectApi* | [**GetProjectDeploymentURL**](docs/ProjectApi.md#getprojectdeploymenturl) | **POST** /project/{project_id}/deploy/url | Get the deployment URL 
*ProjectApi* | [**GetProjectStats**](docs/ProjectApi.md#getprojectstats) | **GET** /project/{project_id}/stats | Get a project's stats 
*ProjectApi* | [**ListProjects**](docs/ProjectApi.md#listprojects) | **GET** /project/list | List projects 
*ProjectApi* | [**UpdateProject**](docs/ProjectApi.md#updateproject) | **POST** /project/{project_id} | Update a project 
*ProjectApi* | [**UpdateProjectDocumentation**](docs/ProjectApi.md#updateprojectdocumentation) | **POST** /project/{project_id}/{version}/documentation | Update the project's documentation 
*SolanaAccountApi* | [**SolanaGetAccount**](docs/SolanaAccountApi.md#solanagetaccount) | **GET** /solana/account/{network}/{public_key} | Get the details of an account on Solana
*SolanaAccountApi* | [**SolanaGetAccountIsCandyMachine**](docs/SolanaAccountApi.md#solanagetaccountiscandymachine) | **GET** /solana/account/{network}/{public_key}/is_candy_machine | Get if account is candy machine
*SolanaAccountApi* | [**SolanaGetAccountIsNFT**](docs/SolanaAccountApi.md#solanagetaccountisnft) | **GET** /solana/account/{network}/{public_key}/is_nft | Get if account is NFT
*SolanaCandyMachineApi* | [**SolanaCreateTestCandyMachine**](docs/SolanaCandyMachineApi.md#solanacreatetestcandymachine) | **POST** /solana/nft/candy_machine | Create a test CM
*SolanaCandyMachineApi* | [**SolanaGetAllNFTsFromCandyMachine**](docs/SolanaCandyMachineApi.md#solanagetallnftsfromcandymachine) | **GET** /solana/nft/candy_machine/{network}/{candy_machine_id}/nfts | Get CM's NFTs  
*SolanaCandyMachineApi* | [**SolanaGetCandyMachineMetadata**](docs/SolanaCandyMachineApi.md#solanagetcandymachinemetadata) | **POST** /solana/nft/candy_machine/metadata | Get a CM's metadata 
*SolanaCandyMachineApi* | [**SolanaListAllCandyMachines**](docs/SolanaCandyMachineApi.md#solanalistallcandymachines) | **GET** /solana/nft/candy_machine/list | List all CMs
*SolanaCandyMachineApi* | [**SolanaMintFromCandyMachine**](docs/SolanaCandyMachineApi.md#solanamintfromcandymachine) | **POST** /solana/nft/candy_machine/mint | Mint from a CM
*SolanaCandyMachineApi* | [**SolanaSearchCandyMachines**](docs/SolanaCandyMachineApi.md#solanasearchcandymachines) | **POST** /solana/nft/candy_machine/search | Search CMs
*SolanaNFTApi* | [**SolanaCreateNFT**](docs/SolanaNFTApi.md#solanacreatenft) | **POST** /solana/nft | Create an NFT on Solana
*SolanaNFTApi* | [**SolanaGetNFT**](docs/SolanaNFTApi.md#solanagetnft) | **GET** /solana/nft/{network}/{mint_address} | Get an NFT's metadata
*SolanaNFTApi* | [**SolanaGetNFTMintFee**](docs/SolanaNFTApi.md#solanagetnftmintfee) | **GET** /solana/nft/mint/fee | Get the NFT mint fee
*SolanaNFTApi* | [**SolanaGetNFTOwner**](docs/SolanaNFTApi.md#solanagetnftowner) | **GET** /solana/nft/{network}/{mint_address}/owner | Get owner of an NFT
*SolanaNFTApi* | [**SolanaGetNFTsCandyMachineId**](docs/SolanaNFTApi.md#solanagetnftscandymachineid) | **POST** /solana/nft/candy_machine_id | Get the ID of the candy machine of an NFT 
*SolanaNFTApi* | [**SolanaSearchNFTs**](docs/SolanaNFTApi.md#solanasearchnfts) | **POST** /solana/nft/search | Search NFTs on Solana
*SolanaNFTMarketplacesApi* | [**SolanaBuyNFT**](docs/SolanaNFTMarketplacesApi.md#solanabuynft) | **POST** /solana/nft/marketplaces/{exchange}/buy/{network}/{mint_address} | Buy
*SolanaNFTMarketplacesApi* | [**SolanaDelistNFT**](docs/SolanaNFTMarketplacesApi.md#solanadelistnft) | **POST** /solana/nft/marketplaces/{exchange}/delist/{network}/{mint_address} | Delist
*SolanaNFTMarketplacesApi* | [**SolanaGetNFTListing**](docs/SolanaNFTMarketplacesApi.md#solanagetnftlisting) | **GET** /solana/nft/marketplaces/listing/{network}/{mint_address} | Get NFT Listing
*SolanaNFTMarketplacesApi* | [**SolanaGetNFTMarketplaceAnalytics**](docs/SolanaNFTMarketplacesApi.md#solanagetnftmarketplaceanalytics) | **POST** /solana/nft/marketplaces/analytics | Get NFT Analytics
*SolanaNFTMarketplacesApi* | [**SolanaGetNFTMarketplaceMarketShare**](docs/SolanaNFTMarketplacesApi.md#solanagetnftmarketplacemarketshare) | **GET** /solana/nft/marketplaces/analytics/market_share | Get Marketplace Market Share
*SolanaNFTMarketplacesApi* | [**SolanaGetNFTMarketplaceRecentTransactions**](docs/SolanaNFTMarketplacesApi.md#solanagetnftmarketplacerecenttransactions) | **GET** /solana/nft/marketplaces/analytics/recent_transactions | Get Recent NFT Transactions
*SolanaNFTMarketplacesApi* | [**SolanaListNFT**](docs/SolanaNFTMarketplacesApi.md#solanalistnft) | **POST** /solana/nft/marketplaces/{exchange}/list/{network}/{mint_address} | List
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


## Documentation for Models

 - [Model.ATAResponse](docs/ATAResponse.md)
 - [Model.Account](docs/Account.md)
 - [Model.AccountContext](docs/AccountContext.md)
 - [Model.AccountIsCandyMachine](docs/AccountIsCandyMachine.md)
 - [Model.AccountIsNFT](docs/AccountIsNFT.md)
 - [Model.AccountValue](docs/AccountValue.md)
 - [Model.AirdropRequest](docs/AirdropRequest.md)
 - [Model.B58PrivateKey](docs/B58PrivateKey.md)
 - [Model.BalanceRequest](docs/BalanceRequest.md)
 - [Model.BalanceResponse](docs/BalanceResponse.md)
 - [Model.BuyRequest](docs/BuyRequest.md)
 - [Model.BuyResponse](docs/BuyResponse.md)
 - [Model.CandyMachineSearchRequest](docs/CandyMachineSearchRequest.md)
 - [Model.CreateTestCandyMachineRequest](docs/CreateTestCandyMachineRequest.md)
 - [Model.CreateTestCandyMachineResponse](docs/CreateTestCandyMachineResponse.md)
 - [Model.DelistRequest](docs/DelistRequest.md)
 - [Model.DelistResponse](docs/DelistResponse.md)
 - [Model.DoubleTransferResponse](docs/DoubleTransferResponse.md)
 - [Model.Endpoint](docs/Endpoint.md)
 - [Model.EndpointReference](docs/EndpointReference.md)
 - [Model.FeePayerWallet](docs/FeePayerWallet.md)
 - [Model.GeneratePrivateKey](docs/GeneratePrivateKey.md)
 - [Model.GetAllNFTsResponse](docs/GetAllNFTsResponse.md)
 - [Model.GetAllNFTsResponseMintedNfts](docs/GetAllNFTsResponseMintedNfts.md)
 - [Model.GetAllNFTsResponseUnmintedNfts](docs/GetAllNFTsResponseUnmintedNfts.md)
 - [Model.GetCandyMachineIDRequest](docs/GetCandyMachineIDRequest.md)
 - [Model.GetCandyMachineIDResponse](docs/GetCandyMachineIDResponse.md)
 - [Model.GetCandyMetadataErrorResponse](docs/GetCandyMetadataErrorResponse.md)
 - [Model.GetCandyMetadataRequest](docs/GetCandyMetadataRequest.md)
 - [Model.GetCandyMetadataResponse](docs/GetCandyMetadataResponse.md)
 - [Model.GetCandyMetadataResponseCreators](docs/GetCandyMetadataResponseCreators.md)
 - [Model.GetFileResponse](docs/GetFileResponse.md)
 - [Model.GetNFTListingResponse](docs/GetNFTListingResponse.md)
 - [Model.GetPublicKeyRequest](docs/GetPublicKeyRequest.md)
 - [Model.GetSPLTokenResponse](docs/GetSPLTokenResponse.md)
 - [Model.Group](docs/Group.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.ListNFTsResponse](docs/ListNFTsResponse.md)
 - [Model.ListRequest](docs/ListRequest.md)
 - [Model.ListResponse](docs/ListResponse.md)
 - [Model.MintNFTErrorResponse](docs/MintNFTErrorResponse.md)
 - [Model.MintNFTRequest](docs/MintNFTRequest.md)
 - [Model.MintNFTResponse](docs/MintNFTResponse.md)
 - [Model.NFT](docs/NFT.md)
 - [Model.NFTAnalyticsRequest](docs/NFTAnalyticsRequest.md)
 - [Model.NFTAnalyticsResponse](docs/NFTAnalyticsResponse.md)
 - [Model.NFTAnalyticsResponseTransactionHistory](docs/NFTAnalyticsResponseTransactionHistory.md)
 - [Model.NFTData](docs/NFTData.md)
 - [Model.NFTMintErrorResponse](docs/NFTMintErrorResponse.md)
 - [Model.NFTMintFee](docs/NFTMintFee.md)
 - [Model.NFTMintRequest](docs/NFTMintRequest.md)
 - [Model.NFTOwnerResponse](docs/NFTOwnerResponse.md)
 - [Model.NFTSearchRequest](docs/NFTSearchRequest.md)
 - [Model.NFTSearchResponse](docs/NFTSearchResponse.md)
 - [Model.NFTTransaction](docs/NFTTransaction.md)
 - [Model.ParameterSpecification](docs/ParameterSpecification.md)
 - [Model.PrivateKey](docs/PrivateKey.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectCreateRequest](docs/ProjectCreateRequest.md)
 - [Model.ProjectDeploymentURL](docs/ProjectDeploymentURL.md)
 - [Model.PublicKey](docs/PublicKey.md)
 - [Model.SecretPhrase](docs/SecretPhrase.md)
 - [Model.SecretRecoveryPhrase](docs/SecretRecoveryPhrase.md)
 - [Model.StatItem](docs/StatItem.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionResult](docs/TransactionResult.md)
 - [Model.TransferRequest](docs/TransferRequest.md)
 - [Model.TransferResponse](docs/TransferResponse.md)
 - [Model.TransferResponseCompiled](docs/TransferResponseCompiled.md)
 - [Model.UploadFileRequest](docs/UploadFileRequest.md)
 - [Model.Wallet](docs/Wallet.md)


## Documentation for Authorization


### APIKeyID

- **Type**: API key

- **API key parameter name**: APIKeyID
- **Location**: HTTP header


### APISecretKey

- **Type**: API key

- **API key parameter name**: APISecretKey
- **Location**: HTTP header

