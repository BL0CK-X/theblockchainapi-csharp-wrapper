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
    /// GetCandyMetadataResponse
    /// </summary>
    [DataContract]
    public partial class GetCandyMetadataResponse :  IEquatable<GetCandyMetadataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCandyMetadataResponse" /> class.
        /// </summary>
        /// <param name="authority">The update authority of the candy machine.</param>
        /// <param name="bump">bump.</param>
        /// <param name="candyMachineId">The ID of the candy machine .</param>
        /// <param name="configAddress">The configuration public key address of the candy machine .</param>
        /// <param name="creators">creators.</param>
        /// <param name="goLiveDate">The unix timestamp of the start date of the candy machine .</param>
        /// <param name="isMutable">isMutable.</param>
        /// <param name="itemsAvailable">The number of NFTs available for mint from the candy machine .</param>
        /// <param name="itemsRedeemed">The number of NFTs minted already from the candy machine .</param>
        /// <param name="maxNumberOfLines">maxNumberOfLines.</param>
        /// <param name="maxSupply">maxSupply.</param>
        /// <param name="price">The price in Lamports for minting an NFT from the candy machine. 1e9 Lamport  &#x3D; 1 SOL .</param>
        /// <param name="retainAuthority">retainAuthority.</param>
        /// <param name="sellerFeeBasisPoints">The royalty the creators receive on each sale after the primary sale (the initial minting) (denominated in basis points (e.g., 75 basis points &#x3D; 0.75%)) .</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="tokenMint">tokenMint.</param>
        /// <param name="uuid">The uuid of the candy machine.</param>
        /// <param name="wallet">The public key address of the wallet that recevies the proceeds from NFT mints .</param>
        public GetCandyMetadataResponse(string authority = default(string), decimal bump = default(decimal), string candyMachineId = default(string), string configAddress = default(string), List<GetCandyMetadataResponseCreators> creators = default(List<GetCandyMetadataResponseCreators>), decimal goLiveDate = default(decimal), bool isMutable = default(bool), decimal itemsAvailable = default(decimal), decimal itemsRedeemed = default(decimal), decimal maxNumberOfLines = default(decimal), decimal maxSupply = default(decimal), decimal price = default(decimal), bool retainAuthority = default(bool), decimal sellerFeeBasisPoints = default(decimal), string symbol = default(string), string tokenMint = default(string), string uuid = default(string), string wallet = default(string))
        {
            this.Authority = authority;
            this.Bump = bump;
            this.CandyMachineId = candyMachineId;
            this.ConfigAddress = configAddress;
            this.Creators = creators;
            this.GoLiveDate = goLiveDate;
            this.IsMutable = isMutable;
            this.ItemsAvailable = itemsAvailable;
            this.ItemsRedeemed = itemsRedeemed;
            this.MaxNumberOfLines = maxNumberOfLines;
            this.MaxSupply = maxSupply;
            this.Price = price;
            this.RetainAuthority = retainAuthority;
            this.SellerFeeBasisPoints = sellerFeeBasisPoints;
            this.Symbol = symbol;
            this.TokenMint = tokenMint;
            this.Uuid = uuid;
            this.Wallet = wallet;
        }

        /// <summary>
        /// The update authority of the candy machine
        /// </summary>
        /// <value>The update authority of the candy machine</value>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or Sets Bump
        /// </summary>
        [DataMember(Name="bump", EmitDefaultValue=false)]
        public decimal Bump { get; set; }

        /// <summary>
        /// The ID of the candy machine 
        /// </summary>
        /// <value>The ID of the candy machine </value>
        [DataMember(Name="candy_machine_id", EmitDefaultValue=false)]
        public string CandyMachineId { get; set; }

        /// <summary>
        /// The configuration public key address of the candy machine 
        /// </summary>
        /// <value>The configuration public key address of the candy machine </value>
        [DataMember(Name="config_address", EmitDefaultValue=false)]
        public string ConfigAddress { get; set; }

        /// <summary>
        /// Gets or Sets Creators
        /// </summary>
        [DataMember(Name="creators", EmitDefaultValue=false)]
        public List<GetCandyMetadataResponseCreators> Creators { get; set; }

        /// <summary>
        /// The unix timestamp of the start date of the candy machine 
        /// </summary>
        /// <value>The unix timestamp of the start date of the candy machine </value>
        [DataMember(Name="go_live_date", EmitDefaultValue=false)]
        public decimal GoLiveDate { get; set; }

        /// <summary>
        /// Gets or Sets IsMutable
        /// </summary>
        [DataMember(Name="is_mutable", EmitDefaultValue=false)]
        public bool IsMutable { get; set; }

        /// <summary>
        /// The number of NFTs available for mint from the candy machine 
        /// </summary>
        /// <value>The number of NFTs available for mint from the candy machine </value>
        [DataMember(Name="items_available", EmitDefaultValue=false)]
        public decimal ItemsAvailable { get; set; }

        /// <summary>
        /// The number of NFTs minted already from the candy machine 
        /// </summary>
        /// <value>The number of NFTs minted already from the candy machine </value>
        [DataMember(Name="items_redeemed", EmitDefaultValue=false)]
        public decimal ItemsRedeemed { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumberOfLines
        /// </summary>
        [DataMember(Name="max_number_of_lines", EmitDefaultValue=false)]
        public decimal MaxNumberOfLines { get; set; }

        /// <summary>
        /// Gets or Sets MaxSupply
        /// </summary>
        [DataMember(Name="max_supply", EmitDefaultValue=false)]
        public decimal MaxSupply { get; set; }

        /// <summary>
        /// The price in Lamports for minting an NFT from the candy machine. 1e9 Lamport  &#x3D; 1 SOL 
        /// </summary>
        /// <value>The price in Lamports for minting an NFT from the candy machine. 1e9 Lamport  &#x3D; 1 SOL </value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets RetainAuthority
        /// </summary>
        [DataMember(Name="retain_authority", EmitDefaultValue=false)]
        public bool RetainAuthority { get; set; }

        /// <summary>
        /// The royalty the creators receive on each sale after the primary sale (the initial minting) (denominated in basis points (e.g., 75 basis points &#x3D; 0.75%)) 
        /// </summary>
        /// <value>The royalty the creators receive on each sale after the primary sale (the initial minting) (denominated in basis points (e.g., 75 basis points &#x3D; 0.75%)) </value>
        [DataMember(Name="seller_fee_basis_points", EmitDefaultValue=false)]
        public decimal SellerFeeBasisPoints { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets TokenMint
        /// </summary>
        [DataMember(Name="token_mint", EmitDefaultValue=false)]
        public string TokenMint { get; set; }

        /// <summary>
        /// The uuid of the candy machine
        /// </summary>
        /// <value>The uuid of the candy machine</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The public key address of the wallet that recevies the proceeds from NFT mints 
        /// </summary>
        /// <value>The public key address of the wallet that recevies the proceeds from NFT mints </value>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public string Wallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCandyMetadataResponse {\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Bump: ").Append(Bump).Append("\n");
            sb.Append("  CandyMachineId: ").Append(CandyMachineId).Append("\n");
            sb.Append("  ConfigAddress: ").Append(ConfigAddress).Append("\n");
            sb.Append("  Creators: ").Append(Creators).Append("\n");
            sb.Append("  GoLiveDate: ").Append(GoLiveDate).Append("\n");
            sb.Append("  IsMutable: ").Append(IsMutable).Append("\n");
            sb.Append("  ItemsAvailable: ").Append(ItemsAvailable).Append("\n");
            sb.Append("  ItemsRedeemed: ").Append(ItemsRedeemed).Append("\n");
            sb.Append("  MaxNumberOfLines: ").Append(MaxNumberOfLines).Append("\n");
            sb.Append("  MaxSupply: ").Append(MaxSupply).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  RetainAuthority: ").Append(RetainAuthority).Append("\n");
            sb.Append("  SellerFeeBasisPoints: ").Append(SellerFeeBasisPoints).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TokenMint: ").Append(TokenMint).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
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
            return this.Equals(input as GetCandyMetadataResponse);
        }

        /// <summary>
        /// Returns true if GetCandyMetadataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCandyMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCandyMetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authority == input.Authority ||
                    (this.Authority != null &&
                    this.Authority.Equals(input.Authority))
                ) && 
                (
                    this.Bump == input.Bump ||
                    (this.Bump != null &&
                    this.Bump.Equals(input.Bump))
                ) && 
                (
                    this.CandyMachineId == input.CandyMachineId ||
                    (this.CandyMachineId != null &&
                    this.CandyMachineId.Equals(input.CandyMachineId))
                ) && 
                (
                    this.ConfigAddress == input.ConfigAddress ||
                    (this.ConfigAddress != null &&
                    this.ConfigAddress.Equals(input.ConfigAddress))
                ) && 
                (
                    this.Creators == input.Creators ||
                    this.Creators != null &&
                    input.Creators != null &&
                    this.Creators.SequenceEqual(input.Creators)
                ) && 
                (
                    this.GoLiveDate == input.GoLiveDate ||
                    (this.GoLiveDate != null &&
                    this.GoLiveDate.Equals(input.GoLiveDate))
                ) && 
                (
                    this.IsMutable == input.IsMutable ||
                    (this.IsMutable != null &&
                    this.IsMutable.Equals(input.IsMutable))
                ) && 
                (
                    this.ItemsAvailable == input.ItemsAvailable ||
                    (this.ItemsAvailable != null &&
                    this.ItemsAvailable.Equals(input.ItemsAvailable))
                ) && 
                (
                    this.ItemsRedeemed == input.ItemsRedeemed ||
                    (this.ItemsRedeemed != null &&
                    this.ItemsRedeemed.Equals(input.ItemsRedeemed))
                ) && 
                (
                    this.MaxNumberOfLines == input.MaxNumberOfLines ||
                    (this.MaxNumberOfLines != null &&
                    this.MaxNumberOfLines.Equals(input.MaxNumberOfLines))
                ) && 
                (
                    this.MaxSupply == input.MaxSupply ||
                    (this.MaxSupply != null &&
                    this.MaxSupply.Equals(input.MaxSupply))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.RetainAuthority == input.RetainAuthority ||
                    (this.RetainAuthority != null &&
                    this.RetainAuthority.Equals(input.RetainAuthority))
                ) && 
                (
                    this.SellerFeeBasisPoints == input.SellerFeeBasisPoints ||
                    (this.SellerFeeBasisPoints != null &&
                    this.SellerFeeBasisPoints.Equals(input.SellerFeeBasisPoints))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TokenMint == input.TokenMint ||
                    (this.TokenMint != null &&
                    this.TokenMint.Equals(input.TokenMint))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
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
                if (this.Authority != null)
                    hashCode = hashCode * 59 + this.Authority.GetHashCode();
                if (this.Bump != null)
                    hashCode = hashCode * 59 + this.Bump.GetHashCode();
                if (this.CandyMachineId != null)
                    hashCode = hashCode * 59 + this.CandyMachineId.GetHashCode();
                if (this.ConfigAddress != null)
                    hashCode = hashCode * 59 + this.ConfigAddress.GetHashCode();
                if (this.Creators != null)
                    hashCode = hashCode * 59 + this.Creators.GetHashCode();
                if (this.GoLiveDate != null)
                    hashCode = hashCode * 59 + this.GoLiveDate.GetHashCode();
                if (this.IsMutable != null)
                    hashCode = hashCode * 59 + this.IsMutable.GetHashCode();
                if (this.ItemsAvailable != null)
                    hashCode = hashCode * 59 + this.ItemsAvailable.GetHashCode();
                if (this.ItemsRedeemed != null)
                    hashCode = hashCode * 59 + this.ItemsRedeemed.GetHashCode();
                if (this.MaxNumberOfLines != null)
                    hashCode = hashCode * 59 + this.MaxNumberOfLines.GetHashCode();
                if (this.MaxSupply != null)
                    hashCode = hashCode * 59 + this.MaxSupply.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.RetainAuthority != null)
                    hashCode = hashCode * 59 + this.RetainAuthority.GetHashCode();
                if (this.SellerFeeBasisPoints != null)
                    hashCode = hashCode * 59 + this.SellerFeeBasisPoints.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.TokenMint != null)
                    hashCode = hashCode * 59 + this.TokenMint.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
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
