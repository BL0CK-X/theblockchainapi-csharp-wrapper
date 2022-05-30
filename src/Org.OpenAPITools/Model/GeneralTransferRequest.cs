/*
 * The Blockchain API
 *
 * # About  Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly.   You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>  # How to Use the API  To use the API, you simply need to create an API key pair.  Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.  # Feature Requests  Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).  # Contact  <figure>     <img          width=\"40px\"         height=\"40px\"          src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"     />     <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption> </figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"         />         <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>     </figure> </a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"         />         <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>     </figure> </a> <a href=\"https://twitter.com/_BlockX_\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"         />          <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>     </figure> </a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"         />         <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>     </figure> </a>  # Security  Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet.   <b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b>   How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.  We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.  Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.  Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.  # Pricing  <b>Each user receives 100 free credits. Each user can call endpoints that cost 0 credits up to 50 requests/min before being rate-limited.</b> Thereafter, they can upgrade to have a higher rate limit. The purpose of this is to act like a free trial - - not to function like a freemium model where one can stay on the free tier indefinitely.  You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>.   We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.  If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.  # SDKs / API Wrappers  We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.  We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.  `pip install theblockchainapi`  We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.  `npm install theblockchainapi`  We also have auto-generated wrappers for the following languages: - <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-csharp-wrapper\" target = \"_blank\">C#</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-dart-wrapper\" target = \"_blank\">Dart</a>  If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.  If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.
 *
 * The version of the OpenAPI document: null
 * Contact: info@blockchainapi.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// GeneralTransferRequest
    /// </summary>
    [DataContract]
    public partial class GeneralTransferRequest :  IEquatable<GeneralTransferRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralTransferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeneralTransferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralTransferRequest" /> class.
        /// </summary>
        /// <param name="recipientBlockchainIdentifier">The blockchain identifier of the recipient to whom you want to send a token or NFT.  On Ethereum, this is the hex public address of the recipient (e.g., &#x60;0x150865ca659204a9a0cd0da00296c6b5db441172&#x60;)  On Solana, this is the public key of the recipient (e.g., &#x60;EW3nXn7X4NTWFKWaJgxKrFNoTSkop1cBUVHA21zrfF6u&#x60;).  (required).</param>
        /// <param name="wallet">wallet.</param>
        /// <param name="tokenBlockchainIdentifier">The &#x60;token_blockchain_identifier&#x60; identifies the token you wish to transfer.  - If you&#39;re transferring a native blockchain currency (e.g., SOL, ETH, BNB), then simply do not supply this value. - If you&#39;re transfering an NFT, then supply the token address of the NFT. On Solana, this is the &#x60;mint_address&#x60; or &#x60;mint&#x60; (the address of the mint). - If you&#39;re transfering a token, supply the token address. For Solana, you can find on this on the Solana Explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;.  Examples: - Ethereum: &#x60;0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48&#x60; - Solana: &#x60;CK1LHEANTu7RFqN3XMzo2AnZhyus2W1vue1njrxLEM1d&#x60;.</param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;.</param>
        /// <param name="amount">This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - Native Currency (e.g., SOL, ETH, BNB): Supply this value denominated in the native currency (e.g., in SOL (but not in Lamports), or in ETH (but not in Wei)) in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. If you want to send 0.0005 ETH, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. - NFT: This must be &#x60;1&#x60;. - Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000.    - For Solana, you can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. We are working on analogues of this endpoint for other blockchains. (default to &quot;1&quot;).</param>
        /// <param name="returnCompiledTransaction">- If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_blockchain_identifier&#x60;).  - If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_blockchain_identifier&#x60; is required in this case; do not provide both).    (default to false).</param>
        /// <param name="senderBlockchainIdentifier">To understand the purpose of &#x60;sender_blockchain_identifier&#x60; first note the following: There are two ways you can complete a transfer transaction:  - (1) we complete it for you with your &#x60;wallet&#x60; information or  - (2) we return the raw instruction data that you can sign and submit yourself (no private keys required).  When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s blockchain identifier (public key or address) which is the sender public key of the transaction.  When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_blockchain_identifier&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_blockchain_identifier&#x60; if and only if you are not providing &#x60;wallet&#x60; authentication information **and** you are returning a compiled transaction.  You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_blockchain_identifier&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_blockchain_identifier&#x60;. (default to &quot;null&quot;).</param>
        /// <param name="feePayerWallet">feePayerWallet.</param>
        public GeneralTransferRequest(string recipientBlockchainIdentifier = default(string), GeneralWallet wallet = default(GeneralWallet), string tokenBlockchainIdentifier = default(string), string network = default(string), string amount = "1", bool returnCompiledTransaction = false, string senderBlockchainIdentifier = "null", GeneralFeePayerWallet feePayerWallet = default(GeneralFeePayerWallet))
        {
            // to ensure "recipientBlockchainIdentifier" is required (not null)
            if (recipientBlockchainIdentifier == null)
            {
                throw new InvalidDataException("recipientBlockchainIdentifier is a required property for GeneralTransferRequest and cannot be null");
            }
            else
            {
                this.RecipientBlockchainIdentifier = recipientBlockchainIdentifier;
            }

            this.Wallet = wallet;
            this.TokenBlockchainIdentifier = tokenBlockchainIdentifier;
            this.Network = network;
            // use default value if no "amount" provided
            if (amount == null)
            {
                this.Amount = "1";
            }
            else
            {
                this.Amount = amount;
            }
            // use default value if no "returnCompiledTransaction" provided
            if (returnCompiledTransaction == null)
            {
                this.ReturnCompiledTransaction = false;
            }
            else
            {
                this.ReturnCompiledTransaction = returnCompiledTransaction;
            }
            // use default value if no "senderBlockchainIdentifier" provided
            if (senderBlockchainIdentifier == null)
            {
                this.SenderBlockchainIdentifier = "null";
            }
            else
            {
                this.SenderBlockchainIdentifier = senderBlockchainIdentifier;
            }
            this.FeePayerWallet = feePayerWallet;
        }

        /// <summary>
        /// The blockchain identifier of the recipient to whom you want to send a token or NFT.  On Ethereum, this is the hex public address of the recipient (e.g., &#x60;0x150865ca659204a9a0cd0da00296c6b5db441172&#x60;)  On Solana, this is the public key of the recipient (e.g., &#x60;EW3nXn7X4NTWFKWaJgxKrFNoTSkop1cBUVHA21zrfF6u&#x60;). 
        /// </summary>
        /// <value>The blockchain identifier of the recipient to whom you want to send a token or NFT.  On Ethereum, this is the hex public address of the recipient (e.g., &#x60;0x150865ca659204a9a0cd0da00296c6b5db441172&#x60;)  On Solana, this is the public key of the recipient (e.g., &#x60;EW3nXn7X4NTWFKWaJgxKrFNoTSkop1cBUVHA21zrfF6u&#x60;). </value>
        [DataMember(Name="recipient_blockchain_identifier", EmitDefaultValue=true)]
        public string RecipientBlockchainIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public GeneralWallet Wallet { get; set; }

        /// <summary>
        /// The &#x60;token_blockchain_identifier&#x60; identifies the token you wish to transfer.  - If you&#39;re transferring a native blockchain currency (e.g., SOL, ETH, BNB), then simply do not supply this value. - If you&#39;re transfering an NFT, then supply the token address of the NFT. On Solana, this is the &#x60;mint_address&#x60; or &#x60;mint&#x60; (the address of the mint). - If you&#39;re transfering a token, supply the token address. For Solana, you can find on this on the Solana Explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;.  Examples: - Ethereum: &#x60;0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48&#x60; - Solana: &#x60;CK1LHEANTu7RFqN3XMzo2AnZhyus2W1vue1njrxLEM1d&#x60;
        /// </summary>
        /// <value>The &#x60;token_blockchain_identifier&#x60; identifies the token you wish to transfer.  - If you&#39;re transferring a native blockchain currency (e.g., SOL, ETH, BNB), then simply do not supply this value. - If you&#39;re transfering an NFT, then supply the token address of the NFT. On Solana, this is the &#x60;mint_address&#x60; or &#x60;mint&#x60; (the address of the mint). - If you&#39;re transfering a token, supply the token address. For Solana, you can find on this on the Solana Explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;.  Examples: - Ethereum: &#x60;0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48&#x60; - Solana: &#x60;CK1LHEANTu7RFqN3XMzo2AnZhyus2W1vue1njrxLEM1d&#x60;</value>
        [DataMember(Name="token_blockchain_identifier", EmitDefaultValue=false)]
        public string TokenBlockchainIdentifier { get; set; }

        /// <summary>
        /// The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;
        /// </summary>
        /// <value>The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

        /// <summary>
        /// This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - Native Currency (e.g., SOL, ETH, BNB): Supply this value denominated in the native currency (e.g., in SOL (but not in Lamports), or in ETH (but not in Wei)) in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. If you want to send 0.0005 ETH, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. - NFT: This must be &#x60;1&#x60;. - Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000.    - For Solana, you can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. We are working on analogues of this endpoint for other blockchains.
        /// </summary>
        /// <value>This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - Native Currency (e.g., SOL, ETH, BNB): Supply this value denominated in the native currency (e.g., in SOL (but not in Lamports), or in ETH (but not in Wei)) in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. If you want to send 0.0005 ETH, then &#x60;amount &#x3D; \&quot;0.0005\&quot;&#x60;. - NFT: This must be &#x60;1&#x60;. - Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000.    - For Solana, you can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. We are working on analogues of this endpoint for other blockchains.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// - If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_blockchain_identifier&#x60;).  - If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_blockchain_identifier&#x60; is required in this case; do not provide both).   
        /// </summary>
        /// <value>- If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_blockchain_identifier&#x60;).  - If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_blockchain_identifier&#x60; is required in this case; do not provide both).   </value>
        [DataMember(Name="return_compiled_transaction", EmitDefaultValue=false)]
        public bool ReturnCompiledTransaction { get; set; }

        /// <summary>
        /// To understand the purpose of &#x60;sender_blockchain_identifier&#x60; first note the following: There are two ways you can complete a transfer transaction:  - (1) we complete it for you with your &#x60;wallet&#x60; information or  - (2) we return the raw instruction data that you can sign and submit yourself (no private keys required).  When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s blockchain identifier (public key or address) which is the sender public key of the transaction.  When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_blockchain_identifier&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_blockchain_identifier&#x60; if and only if you are not providing &#x60;wallet&#x60; authentication information **and** you are returning a compiled transaction.  You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_blockchain_identifier&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_blockchain_identifier&#x60;.
        /// </summary>
        /// <value>To understand the purpose of &#x60;sender_blockchain_identifier&#x60; first note the following: There are two ways you can complete a transfer transaction:  - (1) we complete it for you with your &#x60;wallet&#x60; information or  - (2) we return the raw instruction data that you can sign and submit yourself (no private keys required).  When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s blockchain identifier (public key or address) which is the sender public key of the transaction.  When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_blockchain_identifier&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_blockchain_identifier&#x60; if and only if you are not providing &#x60;wallet&#x60; authentication information **and** you are returning a compiled transaction.  You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_blockchain_identifier&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_blockchain_identifier&#x60;.</value>
        [DataMember(Name="sender_blockchain_identifier", EmitDefaultValue=false)]
        public string SenderBlockchainIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets FeePayerWallet
        /// </summary>
        [DataMember(Name="fee_payer_wallet", EmitDefaultValue=false)]
        public GeneralFeePayerWallet FeePayerWallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTransferRequest {\n");
            sb.Append("  RecipientBlockchainIdentifier: ").Append(RecipientBlockchainIdentifier).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  TokenBlockchainIdentifier: ").Append(TokenBlockchainIdentifier).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ReturnCompiledTransaction: ").Append(ReturnCompiledTransaction).Append("\n");
            sb.Append("  SenderBlockchainIdentifier: ").Append(SenderBlockchainIdentifier).Append("\n");
            sb.Append("  FeePayerWallet: ").Append(FeePayerWallet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTransferRequest);
        }

        /// <summary>
        /// Returns true if GeneralTransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneralTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneralTransferRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipientBlockchainIdentifier == input.RecipientBlockchainIdentifier ||
                    (this.RecipientBlockchainIdentifier != null &&
                    this.RecipientBlockchainIdentifier.Equals(input.RecipientBlockchainIdentifier))
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.TokenBlockchainIdentifier == input.TokenBlockchainIdentifier ||
                    (this.TokenBlockchainIdentifier != null &&
                    this.TokenBlockchainIdentifier.Equals(input.TokenBlockchainIdentifier))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ReturnCompiledTransaction == input.ReturnCompiledTransaction ||
                    (this.ReturnCompiledTransaction != null &&
                    this.ReturnCompiledTransaction.Equals(input.ReturnCompiledTransaction))
                ) && 
                (
                    this.SenderBlockchainIdentifier == input.SenderBlockchainIdentifier ||
                    (this.SenderBlockchainIdentifier != null &&
                    this.SenderBlockchainIdentifier.Equals(input.SenderBlockchainIdentifier))
                ) && 
                (
                    this.FeePayerWallet == input.FeePayerWallet ||
                    (this.FeePayerWallet != null &&
                    this.FeePayerWallet.Equals(input.FeePayerWallet))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RecipientBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.RecipientBlockchainIdentifier.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                if (this.TokenBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.TokenBlockchainIdentifier.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ReturnCompiledTransaction != null)
                    hashCode = hashCode * 59 + this.ReturnCompiledTransaction.GetHashCode();
                if (this.SenderBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.SenderBlockchainIdentifier.GetHashCode();
                if (this.FeePayerWallet != null)
                    hashCode = hashCode * 59 + this.FeePayerWallet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
