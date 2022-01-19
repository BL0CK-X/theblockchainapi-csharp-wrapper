/*
 * The Blockchain API
 *
 * # About  Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly.   You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>  # How to Use the API  To use the API, you simply need to create an API key pair.  Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.  # Feature Requests  Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).  # Contact  <figure>     <img          width=\"40px\"         height=\"40px\"          src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"     />     <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption> </figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"         />         <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>     </figure> </a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"         />         <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>     </figure> </a> <a href=\"https://twitter.com/_BlockX_\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"         />          <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>     </figure> </a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"         />         <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>     </figure> </a>  # Security  Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet.   <b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b>   How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.  We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.  Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.  Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.  # Pricing  <b>Each user receives 500 free credits.</b>  You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>.   We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.  If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.  # SDKs / API Wrappers  We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.  We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.  `pip install theblockchainapi`  We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.  `npm install theblockchainapi`  We also have auto-generated wrappers for the following languages: - <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a>  If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.  If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.
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
    /// GetNFTListingResponse
    /// </summary>
    [DataContract]
    public partial class GetNFTListingResponse :  IEquatable<GetNFTListingResponse>, IValidatableObject
    {
        /// <summary>
        /// The ID of the exchange where the NFT is listed 
        /// </summary>
        /// <value>The ID of the exchange where the NFT is listed </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExchangeEnum
        {
            /// <summary>
            /// Enum Solsea for value: solsea
            /// </summary>
            [EnumMember(Value = "solsea")]
            Solsea = 1

        }

        /// <summary>
        /// The ID of the exchange where the NFT is listed 
        /// </summary>
        /// <value>The ID of the exchange where the NFT is listed </value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public ExchangeEnum? Exchange { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNFTListingResponse" /> class.
        /// </summary>
        /// <param name="exchange">The ID of the exchange where the NFT is listed .</param>
        /// <param name="exchangeReadable">A readable version of the exchange ID .</param>
        /// <param name="listingTransactionSignature">The signature of the listing transaction .</param>
        /// <param name="mintAddress">The mint address of the NFT .</param>
        /// <param name="price">The price of the NFT in Lamports. Represented as an integer..</param>
        public GetNFTListingResponse(ExchangeEnum? exchange = default(ExchangeEnum?), string exchangeReadable = default(string), string listingTransactionSignature = default(string), string mintAddress = default(string), decimal price = default(decimal))
        {
            this.Exchange = exchange;
            this.ExchangeReadable = exchangeReadable;
            this.ListingTransactionSignature = listingTransactionSignature;
            this.MintAddress = mintAddress;
            this.Price = price;
        }


        /// <summary>
        /// A readable version of the exchange ID 
        /// </summary>
        /// <value>A readable version of the exchange ID </value>
        [DataMember(Name="exchange_readable", EmitDefaultValue=false)]
        public string ExchangeReadable { get; set; }

        /// <summary>
        /// The signature of the listing transaction 
        /// </summary>
        /// <value>The signature of the listing transaction </value>
        [DataMember(Name="listing_transaction_signature", EmitDefaultValue=false)]
        public string ListingTransactionSignature { get; set; }

        /// <summary>
        /// The mint address of the NFT 
        /// </summary>
        /// <value>The mint address of the NFT </value>
        [DataMember(Name="mint_address", EmitDefaultValue=false)]
        public string MintAddress { get; set; }

        /// <summary>
        /// The price of the NFT in Lamports. Represented as an integer.
        /// </summary>
        /// <value>The price of the NFT in Lamports. Represented as an integer.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetNFTListingResponse {\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  ExchangeReadable: ").Append(ExchangeReadable).Append("\n");
            sb.Append("  ListingTransactionSignature: ").Append(ListingTransactionSignature).Append("\n");
            sb.Append("  MintAddress: ").Append(MintAddress).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as GetNFTListingResponse);
        }

        /// <summary>
        /// Returns true if GetNFTListingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetNFTListingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetNFTListingResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ListingTransactionSignature == input.ListingTransactionSignature ||
                    (this.ListingTransactionSignature != null &&
                    this.ListingTransactionSignature.Equals(input.ListingTransactionSignature))
                ) && 
                (
                    this.MintAddress == input.MintAddress ||
                    (this.MintAddress != null &&
                    this.MintAddress.Equals(input.MintAddress))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.ExchangeReadable != null)
                    hashCode = hashCode * 59 + this.ExchangeReadable.GetHashCode();
                if (this.ListingTransactionSignature != null)
                    hashCode = hashCode * 59 + this.ListingTransactionSignature.GetHashCode();
                if (this.MintAddress != null)
                    hashCode = hashCode * 59 + this.MintAddress.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
