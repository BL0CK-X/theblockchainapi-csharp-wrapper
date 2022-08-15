/*
 * The Blockchain API
 *
 * # About  Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly.   You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>  # How to Use the API  To use the API, you simply need to create an API key pair.  Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.  # Feature Requests  Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).  # Contact  <figure>     <img          width=\"40px\"         height=\"40px\"          src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"     />     <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption> </figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"         />         <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>     </figure> </a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"         />         <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>     </figure> </a> <a href=\"https://twitter.com/BlockchainAP1\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"         />          <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>     </figure> </a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"         />         <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>     </figure> </a>  # Security  Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet.   <b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b>   How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.  We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.  Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.  Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.  # Pricing  <b>Each user receives 50,000 free credits each month.</b> Each endpoint costs a certain amount credits. Scroll below to any endpoint (i.e., function) to see how much each endpoint costs. (Or CMD+F `Cost: 0 Credit`, for example)  You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>.   We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.  If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.  # SDKs / API Wrappers  We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.  We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.  `pip install theblockchainapi`  We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.  `npm install theblockchainapi`  We also have auto-generated wrappers for the following languages: - <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-csharp-wrapper\" target = \"_blank\">C#</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-dart-wrapper\" target = \"_blank\">Dart</a>  If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.  If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.
 *
 * The version of the OpenAPI document: null
 * Contact: info@blockchainapi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing SolanaWalletApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SolanaWalletApiTests
    {
        private SolanaWalletApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SolanaWalletApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SolanaWalletApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SolanaWalletApi
            //Assert.IsInstanceOf(typeof(SolanaWalletApi), instance);
        }

        
        /// <summary>
        /// Test SolanaDeriveAssociatedTokenAccountAddress
        /// </summary>
        [Test]
        public void SolanaDeriveAssociatedTokenAccountAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //string mintAddress = null;
            //var response = instance.SolanaDeriveAssociatedTokenAccountAddress(publicKey, mintAddress);
            //Assert.IsInstanceOf(typeof(ATAResponse), response, "response is ATAResponse");
        }
        
        /// <summary>
        /// Test SolanaDerivePrivateKey
        /// </summary>
        [Test]
        public void SolanaDerivePrivateKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetPublicKeyRequest getPublicKeyRequest = null;
            //var response = instance.SolanaDerivePrivateKey(getPublicKeyRequest);
            //Assert.IsInstanceOf(typeof(GeneratePrivateKey), response, "response is GeneratePrivateKey");
        }
        
        /// <summary>
        /// Test SolanaDerivePublicKey
        /// </summary>
        [Test]
        public void SolanaDerivePublicKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetPublicKeyRequest getPublicKeyRequest = null;
            //var response = instance.SolanaDerivePublicKey(getPublicKeyRequest);
            //Assert.IsInstanceOf(typeof(PublicKey), response, "response is PublicKey");
        }
        
        /// <summary>
        /// Test SolanaGeneratePrivateKey
        /// </summary>
        [Test]
        public void SolanaGeneratePrivateKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SolanaGeneratePrivateKey();
            //Assert.IsInstanceOf(typeof(GeneratePrivateKey), response, "response is GeneratePrivateKey");
        }
        
        /// <summary>
        /// Test SolanaGenerateSecretRecoveryPhrase
        /// </summary>
        [Test]
        public void SolanaGenerateSecretRecoveryPhraseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SolanaGenerateSecretRecoveryPhrase();
            //Assert.IsInstanceOf(typeof(SecretPhrase), response, "response is SecretPhrase");
        }
        
        /// <summary>
        /// Test SolanaGetAirdrop
        /// </summary>
        [Test]
        public void SolanaGetAirdropTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AirdropRequest airdropRequest = null;
            //var response = instance.SolanaGetAirdrop(airdropRequest);
            //Assert.IsInstanceOf(typeof(TransferResponse), response, "response is TransferResponse");
        }
        
        /// <summary>
        /// Test SolanaGetBalance
        /// </summary>
        [Test]
        public void SolanaGetBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BalanceRequest balanceRequest = null;
            //var response = instance.SolanaGetBalance(balanceRequest);
            //Assert.IsInstanceOf(typeof(BalanceResponse), response, "response is BalanceResponse");
        }
        
        /// <summary>
        /// Test SolanaGetNFTsBelongingToWallet
        /// </summary>
        [Test]
        public void SolanaGetNFTsBelongingToWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string publicKey = null;
            //var response = instance.SolanaGetNFTsBelongingToWallet(network, publicKey);
            //Assert.IsInstanceOf(typeof(ListNFTsResponse), response, "response is ListNFTsResponse");
        }
        
        /// <summary>
        /// Test SolanaGetTokensBelongingToWallet
        /// </summary>
        [Test]
        public void SolanaGetTokensBelongingToWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string publicKey = null;
            //bool? includeNfts = null;
            //bool? includeZeroBalanceHoldings = null;
            //var response = instance.SolanaGetTokensBelongingToWallet(network, publicKey, includeNfts, includeZeroBalanceHoldings);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test SolanaGetWalletTransactions
        /// </summary>
        [Test]
        public void SolanaGetWalletTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string publicKey = null;
            //var response = instance.SolanaGetWalletTransactions(network, publicKey);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test SolanaTransfer
        /// </summary>
        [Test]
        public void SolanaTransferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransferRequest transferRequest = null;
            //var response = instance.SolanaTransfer(transferRequest);
            //Assert.IsInstanceOf(typeof(DoubleTransferResponse), response, "response is DoubleTransferResponse");
        }
        
    }

}
