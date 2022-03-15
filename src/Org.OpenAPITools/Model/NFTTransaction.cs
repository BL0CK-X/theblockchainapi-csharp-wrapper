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
    /// NFTTransaction
    /// </summary>
    [DataContract]
    public partial class NFTTransaction :  IEquatable<NFTTransaction>, IValidatableObject
    {
        /// <summary>
        /// The NFT exchange on which the transaction occurred
        /// </summary>
        /// <value>The NFT exchange on which the transaction occurred</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExchangeEnum
        {
            /// <summary>
            /// Enum Solsea for value: solsea
            /// </summary>
            [EnumMember(Value = "solsea")]
            Solsea = 1,

            /// <summary>
            /// Enum MagicEden for value: magic-eden
            /// </summary>
            [EnumMember(Value = "magic-eden")]
            MagicEden = 2,

            /// <summary>
            /// Enum AlphaArt for value: alpha-art
            /// </summary>
            [EnumMember(Value = "alpha-art")]
            AlphaArt = 3,

            /// <summary>
            /// Enum DigitalEyes for value: digital-eyes
            /// </summary>
            [EnumMember(Value = "digital-eyes")]
            DigitalEyes = 4,

            /// <summary>
            /// Enum Solanart for value: solanart
            /// </summary>
            [EnumMember(Value = "solanart")]
            Solanart = 5,

            /// <summary>
            /// Enum ExchangeArt for value: exchange-art
            /// </summary>
            [EnumMember(Value = "exchange-art")]
            ExchangeArt = 6

        }

        /// <summary>
        /// The NFT exchange on which the transaction occurred
        /// </summary>
        /// <value>The NFT exchange on which the transaction occurred</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public ExchangeEnum? Exchange { get; set; }
        /// <summary>
        /// A readable version of the NFT exchange
        /// </summary>
        /// <value>A readable version of the NFT exchange</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExchangeReadableEnum
        {
            /// <summary>
            /// Enum SolSea for value: SolSea
            /// </summary>
            [EnumMember(Value = "SolSea")]
            SolSea = 1,

            /// <summary>
            /// Enum MagicEden for value: Magic Eden
            /// </summary>
            [EnumMember(Value = "Magic Eden")]
            MagicEden = 2,

            /// <summary>
            /// Enum AlphaArt for value: Alpha Art
            /// </summary>
            [EnumMember(Value = "Alpha Art")]
            AlphaArt = 3,

            /// <summary>
            /// Enum DigitalEyes for value: Digital Eyes
            /// </summary>
            [EnumMember(Value = "Digital Eyes")]
            DigitalEyes = 4,

            /// <summary>
            /// Enum Solanart for value: Solanart
            /// </summary>
            [EnumMember(Value = "Solanart")]
            Solanart = 5,

            /// <summary>
            /// Enum ExchangeArt for value: Exchange.art
            /// </summary>
            [EnumMember(Value = "Exchange.art")]
            ExchangeArt = 6

        }

        /// <summary>
        /// A readable version of the NFT exchange
        /// </summary>
        /// <value>A readable version of the NFT exchange</value>
        [DataMember(Name="exchange_readable", EmitDefaultValue=false)]
        public ExchangeReadableEnum? ExchangeReadable { get; set; }
        /// <summary>
        /// The operation of the transaction
        /// </summary>
        /// <value>The operation of the transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 1,

            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 2,

            /// <summary>
            /// Enum Delist for value: de_list
            /// </summary>
            [EnumMember(Value = "de_list")]
            Delist = 3,

            /// <summary>
            /// Enum Updatelisting for value: update_listing
            /// </summary>
            [EnumMember(Value = "update_listing")]
            Updatelisting = 4

        }

        /// <summary>
        /// The operation of the transaction
        /// </summary>
        /// <value>The operation of the transaction</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NFTTransaction" /> class.
        /// </summary>
        /// <param name="blockTime">An epoch time stamp in UTC time that represents the time of the block where the transaction was processed .</param>
        /// <param name="exchange">The NFT exchange on which the transaction occurred.</param>
        /// <param name="exchangeReadable">A readable version of the NFT exchange.</param>
        /// <param name="mintAddress">The mint address of the NFT .</param>
        /// <param name="operation">The operation of the transaction.</param>
        /// <param name="seller">The public key of the wallet that listed the NFT.</param>
        /// <param name="buyer">The public key of the buyer. This only exists in &#x60;buy&#x60; transactions. .</param>
        /// <param name="transactionSignature">The signature of the transaction. You can look up each transaction on explorer.solana.com .</param>
        public NFTTransaction(decimal blockTime = default(decimal), ExchangeEnum? exchange = default(ExchangeEnum?), ExchangeReadableEnum? exchangeReadable = default(ExchangeReadableEnum?), string mintAddress = default(string), OperationEnum? operation = default(OperationEnum?), string seller = default(string), string buyer = default(string), string transactionSignature = default(string))
        {
            this.BlockTime = blockTime;
            this.Exchange = exchange;
            this.ExchangeReadable = exchangeReadable;
            this.MintAddress = mintAddress;
            this.Operation = operation;
            this.Seller = seller;
            this.Buyer = buyer;
            this.TransactionSignature = transactionSignature;
        }

        /// <summary>
        /// An epoch time stamp in UTC time that represents the time of the block where the transaction was processed 
        /// </summary>
        /// <value>An epoch time stamp in UTC time that represents the time of the block where the transaction was processed </value>
        [DataMember(Name="block_time", EmitDefaultValue=false)]
        public decimal BlockTime { get; set; }



        /// <summary>
        /// The mint address of the NFT 
        /// </summary>
        /// <value>The mint address of the NFT </value>
        [DataMember(Name="mint_address", EmitDefaultValue=false)]
        public string MintAddress { get; set; }


        /// <summary>
        /// The public key of the wallet that listed the NFT
        /// </summary>
        /// <value>The public key of the wallet that listed the NFT</value>
        [DataMember(Name="seller", EmitDefaultValue=false)]
        public string Seller { get; set; }

        /// <summary>
        /// The public key of the buyer. This only exists in &#x60;buy&#x60; transactions. 
        /// </summary>
        /// <value>The public key of the buyer. This only exists in &#x60;buy&#x60; transactions. </value>
        [DataMember(Name="buyer", EmitDefaultValue=false)]
        public string Buyer { get; set; }

        /// <summary>
        /// The signature of the transaction. You can look up each transaction on explorer.solana.com 
        /// </summary>
        /// <value>The signature of the transaction. You can look up each transaction on explorer.solana.com </value>
        [DataMember(Name="transaction_signature", EmitDefaultValue=false)]
        public string TransactionSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NFTTransaction {\n");
            sb.Append("  BlockTime: ").Append(BlockTime).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  ExchangeReadable: ").Append(ExchangeReadable).Append("\n");
            sb.Append("  MintAddress: ").Append(MintAddress).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Seller: ").Append(Seller).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  TransactionSignature: ").Append(TransactionSignature).Append("\n");
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
            return this.Equals(input as NFTTransaction);
        }

        /// <summary>
        /// Returns true if NFTTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of NFTTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NFTTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockTime == input.BlockTime ||
                    (this.BlockTime != null &&
                    this.BlockTime.Equals(input.BlockTime))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.ExchangeReadable == input.ExchangeReadable ||
                    (this.ExchangeReadable != null &&
                    this.ExchangeReadable.Equals(input.ExchangeReadable))
                ) && 
                (
                    this.MintAddress == input.MintAddress ||
                    (this.MintAddress != null &&
                    this.MintAddress.Equals(input.MintAddress))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Seller == input.Seller ||
                    (this.Seller != null &&
                    this.Seller.Equals(input.Seller))
                ) && 
                (
                    this.Buyer == input.Buyer ||
                    (this.Buyer != null &&
                    this.Buyer.Equals(input.Buyer))
                ) && 
                (
                    this.TransactionSignature == input.TransactionSignature ||
                    (this.TransactionSignature != null &&
                    this.TransactionSignature.Equals(input.TransactionSignature))
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
                if (this.BlockTime != null)
                    hashCode = hashCode * 59 + this.BlockTime.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.ExchangeReadable != null)
                    hashCode = hashCode * 59 + this.ExchangeReadable.GetHashCode();
                if (this.MintAddress != null)
                    hashCode = hashCode * 59 + this.MintAddress.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Seller != null)
                    hashCode = hashCode * 59 + this.Seller.GetHashCode();
                if (this.Buyer != null)
                    hashCode = hashCode * 59 + this.Buyer.GetHashCode();
                if (this.TransactionSignature != null)
                    hashCode = hashCode * 59 + this.TransactionSignature.GetHashCode();
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
