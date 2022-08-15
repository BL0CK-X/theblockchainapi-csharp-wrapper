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
    /// TransferRequest
    /// </summary>
    [DataContract]
    public partial class TransferRequest :  IEquatable<TransferRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Network
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkEnum
        {
            /// <summary>
            /// Enum Devnet for value: devnet
            /// </summary>
            [EnumMember(Value = "devnet")]
            Devnet = 1,

            /// <summary>
            /// Enum MainnetBeta for value: mainnet-beta
            /// </summary>
            [EnumMember(Value = "mainnet-beta")]
            MainnetBeta = 2

        }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public NetworkEnum? Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRequest" /> class.
        /// </summary>
        /// <param name="waitForConfirmation">Whether to wait for the transaction to be confirmed on the blockchain or simply be processed.  Processed means that our node has picked up the transaction request, but not that it was confirmed by the Solana cluster.  Confirmed means that the cluster voted on your transaction and approved it. To be completely sure that the transaction succeeded, you can either set &#x60;wait_for_confirmation&#x3D;True&#x60; (call takes 20 seconds with True; about 4 seconds for processed) or you can [get the transaction metadata](/#tag/Solana-Transaction/operation/solanaGetTransaction) using the signature in the response returned. Once it returns the metadata, then the transaction should have succeeded.  (default to true).</param>
        /// <param name="recipientAddress">The public key address of the recipient to whom you want to send a token or NFT (required).</param>
        /// <param name="wallet">wallet.</param>
        /// <param name="tokenAddress">If you&#39;re transfering an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;. If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;. .</param>
        /// <param name="network">network (default to NetworkEnum.Devnet).</param>
        /// <param name="amount">This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - NFT: This must be &#39;1&#39;. - SPL Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000. You can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. - SOL: Supply this value denominated in SOL in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then amount &#x3D; \&quot;0.0005\&quot;. (default to &quot;1&quot;).</param>
        /// <param name="returnCompiledTransaction">If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;).  If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  (default to false).</param>
        /// <param name="senderPublicKey">To understand the purpose of &#x60;sender_public_key&#x60; first note the following: There are two ways you can complete a transfer transaction: (1) we complete it for you with your &#x60;wallet&#x60; information or (2) we return the raw instruction data that you can sign and submit yourself (no private keys required). When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s public key, which is the sender public key of the transaction. When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_public_key&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_public_key&#x60; only if you are not providing &#x60;wallet&#x60; authentication information and you are returning a compiled transaction. You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_public_key&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_public_key&#x60;.  (default to &quot;null&quot;).</param>
        /// <param name="feePayerWallet">feePayerWallet.</param>
        public TransferRequest(bool waitForConfirmation = true, string recipientAddress = default(string), Wallet wallet = default(Wallet), string tokenAddress = default(string), NetworkEnum? network = NetworkEnum.Devnet, string amount = "1", bool returnCompiledTransaction = false, string senderPublicKey = "null", FeePayerWallet feePayerWallet = default(FeePayerWallet))
        {
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new InvalidDataException("recipientAddress is a required property for TransferRequest and cannot be null");
            }
            else
            {
                this.RecipientAddress = recipientAddress;
            }

            // use default value if no "waitForConfirmation" provided
            if (waitForConfirmation == null)
            {
                this.WaitForConfirmation = true;
            }
            else
            {
                this.WaitForConfirmation = waitForConfirmation;
            }
            this.Wallet = wallet;
            this.TokenAddress = tokenAddress;
            // use default value if no "network" provided
            if (network == null)
            {
                this.Network = NetworkEnum.Devnet;
            }
            else
            {
                this.Network = network;
            }
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
            // use default value if no "senderPublicKey" provided
            if (senderPublicKey == null)
            {
                this.SenderPublicKey = "null";
            }
            else
            {
                this.SenderPublicKey = senderPublicKey;
            }
            this.FeePayerWallet = feePayerWallet;
        }

        /// <summary>
        /// Whether to wait for the transaction to be confirmed on the blockchain or simply be processed.  Processed means that our node has picked up the transaction request, but not that it was confirmed by the Solana cluster.  Confirmed means that the cluster voted on your transaction and approved it. To be completely sure that the transaction succeeded, you can either set &#x60;wait_for_confirmation&#x3D;True&#x60; (call takes 20 seconds with True; about 4 seconds for processed) or you can [get the transaction metadata](/#tag/Solana-Transaction/operation/solanaGetTransaction) using the signature in the response returned. Once it returns the metadata, then the transaction should have succeeded. 
        /// </summary>
        /// <value>Whether to wait for the transaction to be confirmed on the blockchain or simply be processed.  Processed means that our node has picked up the transaction request, but not that it was confirmed by the Solana cluster.  Confirmed means that the cluster voted on your transaction and approved it. To be completely sure that the transaction succeeded, you can either set &#x60;wait_for_confirmation&#x3D;True&#x60; (call takes 20 seconds with True; about 4 seconds for processed) or you can [get the transaction metadata](/#tag/Solana-Transaction/operation/solanaGetTransaction) using the signature in the response returned. Once it returns the metadata, then the transaction should have succeeded. </value>
        [DataMember(Name="wait_for_confirmation", EmitDefaultValue=false)]
        public bool WaitForConfirmation { get; set; }

        /// <summary>
        /// The public key address of the recipient to whom you want to send a token or NFT
        /// </summary>
        /// <value>The public key address of the recipient to whom you want to send a token or NFT</value>
        [DataMember(Name="recipient_address", EmitDefaultValue=true)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public Wallet Wallet { get; set; }

        /// <summary>
        /// If you&#39;re transfering an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;. If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;. 
        /// </summary>
        /// <value>If you&#39;re transfering an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;. If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;. </value>
        [DataMember(Name="token_address", EmitDefaultValue=false)]
        public string TokenAddress { get; set; }


        /// <summary>
        /// This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - NFT: This must be &#39;1&#39;. - SPL Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000. You can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. - SOL: Supply this value denominated in SOL in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then amount &#x3D; \&quot;0.0005\&quot;.
        /// </summary>
        /// <value>This value must be a string. What you provide here depends on if you are sending an NFT, an SPL token, or SOL.  - NFT: This must be &#39;1&#39;. - SPL Token: This must be an integer in string format. To convert from what you see on a wallet UI (e.g., 1 ATLAS, 1 USDC) to an integer value, you have to multiply that value by 10^&lt;i&gt;x&lt;/i&gt; where &lt;i&gt;x&lt;/i&gt; is the number of decimals. For example, to transfer 0.2 USDC, if USDC uses 6 decimals, then the amount is 0.2 * 10^6 &#x3D; 200000. You can get the number of decimals for a given SPL token &lt;a href&#x3D;\&quot;#operation/solanaGetSPLToken\&quot;&gt;here&lt;/a&gt;. - SOL: Supply this value denominated in SOL in a string format. This does not need to be an integer. For example, if you want to send 0.0005 SOL, then amount &#x3D; \&quot;0.0005\&quot;.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;).  If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both). 
        /// </summary>
        /// <value>If &#x60;false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;).  If &#x60;true&#x60;, we compile the transaction (either &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both). </value>
        [DataMember(Name="return_compiled_transaction", EmitDefaultValue=false)]
        public bool ReturnCompiledTransaction { get; set; }

        /// <summary>
        /// To understand the purpose of &#x60;sender_public_key&#x60; first note the following: There are two ways you can complete a transfer transaction: (1) we complete it for you with your &#x60;wallet&#x60; information or (2) we return the raw instruction data that you can sign and submit yourself (no private keys required). When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s public key, which is the sender public key of the transaction. When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_public_key&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_public_key&#x60; only if you are not providing &#x60;wallet&#x60; authentication information and you are returning a compiled transaction. You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_public_key&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_public_key&#x60;. 
        /// </summary>
        /// <value>To understand the purpose of &#x60;sender_public_key&#x60; first note the following: There are two ways you can complete a transfer transaction: (1) we complete it for you with your &#x60;wallet&#x60; information or (2) we return the raw instruction data that you can sign and submit yourself (no private keys required). When you provide your &#x60;wallet&#x60; authentication, we are able to determine your wallet&#39;s public key, which is the sender public key of the transaction. When you are not providing your &#x60;wallet&#x60; as authentication, we still need the &#x60;sender_public_key&#x60; to be able to return the compiled transaction. Thus, you provide &#x60;sender_public_key&#x60; only if you are not providing &#x60;wallet&#x60; authentication information and you are returning a compiled transaction. You will receive an error if you provide both &#x60;wallet&#x60; and &#x60;sender_public_key&#x60;. You will receive an error if you provide neither &#x60;wallet&#x60; nor &#x60;sender_public_key&#x60;. </value>
        [DataMember(Name="sender_public_key", EmitDefaultValue=false)]
        public string SenderPublicKey { get; set; }

        /// <summary>
        /// Gets or Sets FeePayerWallet
        /// </summary>
        [DataMember(Name="fee_payer_wallet", EmitDefaultValue=false)]
        public FeePayerWallet FeePayerWallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRequest {\n");
            sb.Append("  WaitForConfirmation: ").Append(WaitForConfirmation).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ReturnCompiledTransaction: ").Append(ReturnCompiledTransaction).Append("\n");
            sb.Append("  SenderPublicKey: ").Append(SenderPublicKey).Append("\n");
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
            return this.Equals(input as TransferRequest);
        }

        /// <summary>
        /// Returns true if TransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WaitForConfirmation == input.WaitForConfirmation ||
                    (this.WaitForConfirmation != null &&
                    this.WaitForConfirmation.Equals(input.WaitForConfirmation))
                ) && 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
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
                    this.SenderPublicKey == input.SenderPublicKey ||
                    (this.SenderPublicKey != null &&
                    this.SenderPublicKey.Equals(input.SenderPublicKey))
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
                if (this.WaitForConfirmation != null)
                    hashCode = hashCode * 59 + this.WaitForConfirmation.GetHashCode();
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                if (this.TokenAddress != null)
                    hashCode = hashCode * 59 + this.TokenAddress.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ReturnCompiledTransaction != null)
                    hashCode = hashCode * 59 + this.ReturnCompiledTransaction.GetHashCode();
                if (this.SenderPublicKey != null)
                    hashCode = hashCode * 59 + this.SenderPublicKey.GetHashCode();
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
