/*
 * The Blockchain API
 *
 * # About  Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly.   You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>  # How to Use the API  To use the API, you simply need to create an API key pair.  Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.  # Feature Requests  Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).  # Contact  <figure>     <img          width=\"40px\"         height=\"40px\"          src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"     />     <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption> </figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"         />         <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>     </figure> </a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"         />         <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>     </figure> </a> <a href=\"https://twitter.com/BlockchainAP1\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"         />          <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>     </figure> </a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"         />         <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>     </figure> </a>  # Security  Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet.   <b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b>   How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.  We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.  Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.  Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.  # Pricing  <b>Each user receives 50,000 free credits each month.</b> Each endpoint costs a certain amount credits. Scroll below to any endpoint (i.e., function) to see how much each endpoint costs. (Or CMD+F `Cost: 0 Credit`, for example)  You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>.   We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.  If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.  # SDKs / API Wrappers  We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.  We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.  `pip install theblockchainapi`  We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.  `npm install theblockchainapi`  We also have auto-generated wrappers for the following languages: - <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-csharp-wrapper\" target = \"_blank\">C#</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-dart-wrapper\" target = \"_blank\">Dart</a>  If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.  If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.
 *
 * The version of the OpenAPI document: null
 * Contact: info@blockchainapi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing EthereumTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EthereumTransactionTests
    {
        // TODO uncomment below to declare an instance variable for EthereumTransaction
        //private EthereumTransaction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EthereumTransaction
            //instance = new EthereumTransaction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EthereumTransaction
        /// </summary>
        [Test]
        public void EthereumTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EthereumTransaction
            //Assert.IsInstanceOf(typeof(EthereumTransaction), instance);
        }


        /// <summary>
        /// Test the property 'AccessList'
        /// </summary>
        [Test]
        public void AccessListTest()
        {
            // TODO unit test for the property 'AccessList'
        }
        /// <summary>
        /// Test the property 'BlockHash'
        /// </summary>
        [Test]
        public void BlockHashTest()
        {
            // TODO unit test for the property 'BlockHash'
        }
        /// <summary>
        /// Test the property 'BlockNumber'
        /// </summary>
        [Test]
        public void BlockNumberTest()
        {
            // TODO unit test for the property 'BlockNumber'
        }
        /// <summary>
        /// Test the property 'ChainId'
        /// </summary>
        [Test]
        public void ChainIdTest()
        {
            // TODO unit test for the property 'ChainId'
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }
        /// <summary>
        /// Test the property 'Gas'
        /// </summary>
        [Test]
        public void GasTest()
        {
            // TODO unit test for the property 'Gas'
        }
        /// <summary>
        /// Test the property 'GasPrice'
        /// </summary>
        [Test]
        public void GasPriceTest()
        {
            // TODO unit test for the property 'GasPrice'
        }
        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Test]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'Input'
        /// </summary>
        [Test]
        public void InputTest()
        {
            // TODO unit test for the property 'Input'
        }
        /// <summary>
        /// Test the property 'MaxFeePerGas'
        /// </summary>
        [Test]
        public void MaxFeePerGasTest()
        {
            // TODO unit test for the property 'MaxFeePerGas'
        }
        /// <summary>
        /// Test the property 'MaxPriorityFeePerGas'
        /// </summary>
        [Test]
        public void MaxPriorityFeePerGasTest()
        {
            // TODO unit test for the property 'MaxPriorityFeePerGas'
        }
        /// <summary>
        /// Test the property 'Nonce'
        /// </summary>
        [Test]
        public void NonceTest()
        {
            // TODO unit test for the property 'Nonce'
        }
        /// <summary>
        /// Test the property 'R'
        /// </summary>
        [Test]
        public void RTest()
        {
            // TODO unit test for the property 'R'
        }
        /// <summary>
        /// Test the property 'S'
        /// </summary>
        [Test]
        public void STest()
        {
            // TODO unit test for the property 'S'
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }
        /// <summary>
        /// Test the property 'TransactionIndex'
        /// </summary>
        [Test]
        public void TransactionIndexTest()
        {
            // TODO unit test for the property 'TransactionIndex'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'V'
        /// </summary>
        [Test]
        public void VTest()
        {
            // TODO unit test for the property 'V'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}
