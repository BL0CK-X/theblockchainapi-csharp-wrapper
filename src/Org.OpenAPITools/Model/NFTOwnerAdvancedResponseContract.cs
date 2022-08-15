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
    /// The contract the NFT interacted with most recently. If there is none, this is null. 
    /// </summary>
    [DataContract]
    public partial class NFTOwnerAdvancedResponseContract :  IEquatable<NFTOwnerAdvancedResponseContract>, IValidatableObject
    {
        /// <summary>
        /// The type of the contract that it last interacted with
        /// </summary>
        /// <value>The type of the contract that it last interacted with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractTypeEnum
        {
            /// <summary>
            /// Enum Marketplace for value: marketplace
            /// </summary>
            [EnumMember(Value = "marketplace")]
            Marketplace = 1,

            /// <summary>
            /// Enum Otc for value: otc
            /// </summary>
            [EnumMember(Value = "otc")]
            Otc = 2,

            /// <summary>
            /// Enum Loan for value: loan
            /// </summary>
            [EnumMember(Value = "loan")]
            Loan = 3,

            /// <summary>
            /// Enum Staking for value: staking
            /// </summary>
            [EnumMember(Value = "staking")]
            Staking = 4,

            /// <summary>
            /// Enum Burned for value: burned
            /// </summary>
            [EnumMember(Value = "burned")]
            Burned = 5

        }

        /// <summary>
        /// The type of the contract that it last interacted with
        /// </summary>
        /// <value>The type of the contract that it last interacted with</value>
        [DataMember(Name="contract_type", EmitDefaultValue=false)]
        public ContractTypeEnum? ContractType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NFTOwnerAdvancedResponseContract" /> class.
        /// </summary>
        /// <param name="contractType">The type of the contract that it last interacted with.</param>
        /// <param name="contractId">The string identifier (not the public key) that we denote the contract with..</param>
        /// <param name="contractBlockchainIdentifier">The public key of the contract.</param>
        /// <param name="contractName">The readable name of the contract (e.g., Magic Eden).</param>
        public NFTOwnerAdvancedResponseContract(ContractTypeEnum? contractType = default(ContractTypeEnum?), string contractId = default(string), string contractBlockchainIdentifier = default(string), string contractName = default(string))
        {
            this.ContractType = contractType;
            this.ContractId = contractId;
            this.ContractBlockchainIdentifier = contractBlockchainIdentifier;
            this.ContractName = contractName;
        }


        /// <summary>
        /// The string identifier (not the public key) that we denote the contract with.
        /// </summary>
        /// <value>The string identifier (not the public key) that we denote the contract with.</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// The public key of the contract
        /// </summary>
        /// <value>The public key of the contract</value>
        [DataMember(Name="contract_blockchain_identifier", EmitDefaultValue=false)]
        public string ContractBlockchainIdentifier { get; set; }

        /// <summary>
        /// The readable name of the contract (e.g., Magic Eden)
        /// </summary>
        /// <value>The readable name of the contract (e.g., Magic Eden)</value>
        [DataMember(Name="contract_name", EmitDefaultValue=false)]
        public string ContractName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NFTOwnerAdvancedResponseContract {\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ContractBlockchainIdentifier: ").Append(ContractBlockchainIdentifier).Append("\n");
            sb.Append("  ContractName: ").Append(ContractName).Append("\n");
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
            return this.Equals(input as NFTOwnerAdvancedResponseContract);
        }

        /// <summary>
        /// Returns true if NFTOwnerAdvancedResponseContract instances are equal
        /// </summary>
        /// <param name="input">Instance of NFTOwnerAdvancedResponseContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NFTOwnerAdvancedResponseContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.ContractBlockchainIdentifier == input.ContractBlockchainIdentifier ||
                    (this.ContractBlockchainIdentifier != null &&
                    this.ContractBlockchainIdentifier.Equals(input.ContractBlockchainIdentifier))
                ) && 
                (
                    this.ContractName == input.ContractName ||
                    (this.ContractName != null &&
                    this.ContractName.Equals(input.ContractName))
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
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.ContractBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.ContractBlockchainIdentifier.GetHashCode();
                if (this.ContractName != null)
                    hashCode = hashCode * 59 + this.ContractName.GetHashCode();
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
