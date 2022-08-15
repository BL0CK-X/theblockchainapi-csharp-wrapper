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
    /// NFT
    /// </summary>
    [DataContract]
    public partial class NFT :  IEquatable<NFT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NFT" /> class.
        /// </summary>
        /// <param name="confirmed">Whether or not the NFT mint was confirmed or simply submitted for processing. The status depends on your input for &#x60;wait_for_confirmation&#x60;. This only is returned when you are minting an NFT, not when searching or retrieving the metadata..</param>
        /// <param name="data">data.</param>
        /// <param name="isMutable">isMutable.</param>
        /// <param name="mint">The public key address of the NFT .</param>
        /// <param name="primarySaleHappened">primarySaleHappened.</param>
        /// <param name="updateAuthority">A public key address that is usually that of the person who minted the NFT .</param>
        /// <param name="sellerFeeBasisPoints">sellerFeeBasisPoints.</param>
        /// <param name="mintSecretRecoveryPhrase">mintSecretRecoveryPhrase.</param>
        /// <param name="explorerUrl">explorerUrl.</param>
        /// <param name="metadataAccount">The metadata account of the NFT .</param>
        /// <param name="editionNonce">editionNonce.</param>
        /// <param name="tokenStandard">tokenStandard.</param>
        /// <param name="collection">collection.</param>
        /// <param name="uses">uses.</param>
        public NFT(bool confirmed = default(bool), NFTData data = default(NFTData), bool isMutable = default(bool), string mint = default(string), bool primarySaleHappened = default(bool), string updateAuthority = default(string), decimal sellerFeeBasisPoints = default(decimal), string mintSecretRecoveryPhrase = default(string), string explorerUrl = default(string), string metadataAccount = default(string), decimal editionNonce = default(decimal), decimal tokenStandard = default(decimal), NFTCollection collection = default(NFTCollection), decimal uses = default(decimal))
        {
            this.Confirmed = confirmed;
            this.Data = data;
            this.IsMutable = isMutable;
            this.Mint = mint;
            this.PrimarySaleHappened = primarySaleHappened;
            this.UpdateAuthority = updateAuthority;
            this.SellerFeeBasisPoints = sellerFeeBasisPoints;
            this.MintSecretRecoveryPhrase = mintSecretRecoveryPhrase;
            this.ExplorerUrl = explorerUrl;
            this.MetadataAccount = metadataAccount;
            this.EditionNonce = editionNonce;
            this.TokenStandard = tokenStandard;
            this.Collection = collection;
            this.Uses = uses;
        }

        /// <summary>
        /// Whether or not the NFT mint was confirmed or simply submitted for processing. The status depends on your input for &#x60;wait_for_confirmation&#x60;. This only is returned when you are minting an NFT, not when searching or retrieving the metadata.
        /// </summary>
        /// <value>Whether or not the NFT mint was confirmed or simply submitted for processing. The status depends on your input for &#x60;wait_for_confirmation&#x60;. This only is returned when you are minting an NFT, not when searching or retrieving the metadata.</value>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public bool Confirmed { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public NFTData Data { get; set; }

        /// <summary>
        /// Gets or Sets IsMutable
        /// </summary>
        [DataMember(Name="is_mutable", EmitDefaultValue=false)]
        public bool IsMutable { get; set; }

        /// <summary>
        /// The public key address of the NFT 
        /// </summary>
        /// <value>The public key address of the NFT </value>
        [DataMember(Name="mint", EmitDefaultValue=false)]
        public string Mint { get; set; }

        /// <summary>
        /// Gets or Sets PrimarySaleHappened
        /// </summary>
        [DataMember(Name="primary_sale_happened", EmitDefaultValue=false)]
        public bool PrimarySaleHappened { get; set; }

        /// <summary>
        /// A public key address that is usually that of the person who minted the NFT 
        /// </summary>
        /// <value>A public key address that is usually that of the person who minted the NFT </value>
        [DataMember(Name="update_authority", EmitDefaultValue=false)]
        public string UpdateAuthority { get; set; }

        /// <summary>
        /// Gets or Sets SellerFeeBasisPoints
        /// </summary>
        [DataMember(Name="seller_fee_basis_points", EmitDefaultValue=false)]
        public decimal SellerFeeBasisPoints { get; set; }

        /// <summary>
        /// Gets or Sets MintSecretRecoveryPhrase
        /// </summary>
        [DataMember(Name="mint_secret_recovery_phrase", EmitDefaultValue=false)]
        public string MintSecretRecoveryPhrase { get; set; }

        /// <summary>
        /// Gets or Sets ExplorerUrl
        /// </summary>
        [DataMember(Name="explorer_url", EmitDefaultValue=false)]
        public string ExplorerUrl { get; set; }

        /// <summary>
        /// The metadata account of the NFT 
        /// </summary>
        /// <value>The metadata account of the NFT </value>
        [DataMember(Name="metadata_account", EmitDefaultValue=false)]
        public string MetadataAccount { get; set; }

        /// <summary>
        /// Gets or Sets EditionNonce
        /// </summary>
        [DataMember(Name="edition_nonce", EmitDefaultValue=false)]
        public decimal EditionNonce { get; set; }

        /// <summary>
        /// Gets or Sets TokenStandard
        /// </summary>
        [DataMember(Name="token_standard", EmitDefaultValue=false)]
        public decimal TokenStandard { get; set; }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name="collection", EmitDefaultValue=false)]
        public NFTCollection Collection { get; set; }

        /// <summary>
        /// Gets or Sets Uses
        /// </summary>
        [DataMember(Name="uses", EmitDefaultValue=false)]
        public decimal Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NFT {\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  IsMutable: ").Append(IsMutable).Append("\n");
            sb.Append("  Mint: ").Append(Mint).Append("\n");
            sb.Append("  PrimarySaleHappened: ").Append(PrimarySaleHappened).Append("\n");
            sb.Append("  UpdateAuthority: ").Append(UpdateAuthority).Append("\n");
            sb.Append("  SellerFeeBasisPoints: ").Append(SellerFeeBasisPoints).Append("\n");
            sb.Append("  MintSecretRecoveryPhrase: ").Append(MintSecretRecoveryPhrase).Append("\n");
            sb.Append("  ExplorerUrl: ").Append(ExplorerUrl).Append("\n");
            sb.Append("  MetadataAccount: ").Append(MetadataAccount).Append("\n");
            sb.Append("  EditionNonce: ").Append(EditionNonce).Append("\n");
            sb.Append("  TokenStandard: ").Append(TokenStandard).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
            return this.Equals(input as NFT);
        }

        /// <summary>
        /// Returns true if NFT instances are equal
        /// </summary>
        /// <param name="input">Instance of NFT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NFT input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Confirmed == input.Confirmed ||
                    (this.Confirmed != null &&
                    this.Confirmed.Equals(input.Confirmed))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.IsMutable == input.IsMutable ||
                    (this.IsMutable != null &&
                    this.IsMutable.Equals(input.IsMutable))
                ) && 
                (
                    this.Mint == input.Mint ||
                    (this.Mint != null &&
                    this.Mint.Equals(input.Mint))
                ) && 
                (
                    this.PrimarySaleHappened == input.PrimarySaleHappened ||
                    (this.PrimarySaleHappened != null &&
                    this.PrimarySaleHappened.Equals(input.PrimarySaleHappened))
                ) && 
                (
                    this.UpdateAuthority == input.UpdateAuthority ||
                    (this.UpdateAuthority != null &&
                    this.UpdateAuthority.Equals(input.UpdateAuthority))
                ) && 
                (
                    this.SellerFeeBasisPoints == input.SellerFeeBasisPoints ||
                    (this.SellerFeeBasisPoints != null &&
                    this.SellerFeeBasisPoints.Equals(input.SellerFeeBasisPoints))
                ) && 
                (
                    this.MintSecretRecoveryPhrase == input.MintSecretRecoveryPhrase ||
                    (this.MintSecretRecoveryPhrase != null &&
                    this.MintSecretRecoveryPhrase.Equals(input.MintSecretRecoveryPhrase))
                ) && 
                (
                    this.ExplorerUrl == input.ExplorerUrl ||
                    (this.ExplorerUrl != null &&
                    this.ExplorerUrl.Equals(input.ExplorerUrl))
                ) && 
                (
                    this.MetadataAccount == input.MetadataAccount ||
                    (this.MetadataAccount != null &&
                    this.MetadataAccount.Equals(input.MetadataAccount))
                ) && 
                (
                    this.EditionNonce == input.EditionNonce ||
                    (this.EditionNonce != null &&
                    this.EditionNonce.Equals(input.EditionNonce))
                ) && 
                (
                    this.TokenStandard == input.TokenStandard ||
                    (this.TokenStandard != null &&
                    this.TokenStandard.Equals(input.TokenStandard))
                ) && 
                (
                    this.Collection == input.Collection ||
                    (this.Collection != null &&
                    this.Collection.Equals(input.Collection))
                ) && 
                (
                    this.Uses == input.Uses ||
                    (this.Uses != null &&
                    this.Uses.Equals(input.Uses))
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
                if (this.Confirmed != null)
                    hashCode = hashCode * 59 + this.Confirmed.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IsMutable != null)
                    hashCode = hashCode * 59 + this.IsMutable.GetHashCode();
                if (this.Mint != null)
                    hashCode = hashCode * 59 + this.Mint.GetHashCode();
                if (this.PrimarySaleHappened != null)
                    hashCode = hashCode * 59 + this.PrimarySaleHappened.GetHashCode();
                if (this.UpdateAuthority != null)
                    hashCode = hashCode * 59 + this.UpdateAuthority.GetHashCode();
                if (this.SellerFeeBasisPoints != null)
                    hashCode = hashCode * 59 + this.SellerFeeBasisPoints.GetHashCode();
                if (this.MintSecretRecoveryPhrase != null)
                    hashCode = hashCode * 59 + this.MintSecretRecoveryPhrase.GetHashCode();
                if (this.ExplorerUrl != null)
                    hashCode = hashCode * 59 + this.ExplorerUrl.GetHashCode();
                if (this.MetadataAccount != null)
                    hashCode = hashCode * 59 + this.MetadataAccount.GetHashCode();
                if (this.EditionNonce != null)
                    hashCode = hashCode * 59 + this.EditionNonce.GetHashCode();
                if (this.TokenStandard != null)
                    hashCode = hashCode * 59 + this.TokenStandard.GetHashCode();
                if (this.Collection != null)
                    hashCode = hashCode * 59 + this.Collection.GetHashCode();
                if (this.Uses != null)
                    hashCode = hashCode * 59 + this.Uses.GetHashCode();
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
