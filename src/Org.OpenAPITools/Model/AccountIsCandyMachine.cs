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
    /// AccountIsCandyMachine
    /// </summary>
    [DataContract]
    public partial class AccountIsCandyMachine :  IEquatable<AccountIsCandyMachine>, IValidatableObject
    {
        /// <summary>
        /// Whether or not this corresponds to candy machine v1, candy machine v2, or a Magic Eden candy machine.
        /// </summary>
        /// <value>Whether or not this corresponds to candy machine v1, candy machine v2, or a Magic Eden candy machine.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CandyMachineContractVersionEnum
        {
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            [EnumMember(Value = "v1")]
            V1 = 1,

            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            [EnumMember(Value = "v2")]
            V2 = 2,

            /// <summary>
            /// Enum MagicEdenV1 for value: magic-eden-v1
            /// </summary>
            [EnumMember(Value = "magic-eden-v1")]
            MagicEdenV1 = 3

        }

        /// <summary>
        /// Whether or not this corresponds to candy machine v1, candy machine v2, or a Magic Eden candy machine.
        /// </summary>
        /// <value>Whether or not this corresponds to candy machine v1, candy machine v2, or a Magic Eden candy machine.</value>
        [DataMember(Name="candy_machine_contract_version", EmitDefaultValue=false)]
        public CandyMachineContractVersionEnum? CandyMachineContractVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIsCandyMachine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountIsCandyMachine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIsCandyMachine" /> class.
        /// </summary>
        /// <param name="isCandyMachine">isCandyMachine (required).</param>
        /// <param name="candyMachineContractVersion">Whether or not this corresponds to candy machine v1, candy machine v2, or a Magic Eden candy machine..</param>
        public AccountIsCandyMachine(bool isCandyMachine = default(bool), CandyMachineContractVersionEnum? candyMachineContractVersion = default(CandyMachineContractVersionEnum?))
        {
            // to ensure "isCandyMachine" is required (not null)
            if (isCandyMachine == null)
            {
                throw new InvalidDataException("isCandyMachine is a required property for AccountIsCandyMachine and cannot be null");
            }
            else
            {
                this.IsCandyMachine = isCandyMachine;
            }

            this.CandyMachineContractVersion = candyMachineContractVersion;
        }

        /// <summary>
        /// Gets or Sets IsCandyMachine
        /// </summary>
        [DataMember(Name="is_candy_machine", EmitDefaultValue=true)]
        public bool IsCandyMachine { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIsCandyMachine {\n");
            sb.Append("  IsCandyMachine: ").Append(IsCandyMachine).Append("\n");
            sb.Append("  CandyMachineContractVersion: ").Append(CandyMachineContractVersion).Append("\n");
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
            return this.Equals(input as AccountIsCandyMachine);
        }

        /// <summary>
        /// Returns true if AccountIsCandyMachine instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountIsCandyMachine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIsCandyMachine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCandyMachine == input.IsCandyMachine ||
                    (this.IsCandyMachine != null &&
                    this.IsCandyMachine.Equals(input.IsCandyMachine))
                ) && 
                (
                    this.CandyMachineContractVersion == input.CandyMachineContractVersion ||
                    (this.CandyMachineContractVersion != null &&
                    this.CandyMachineContractVersion.Equals(input.CandyMachineContractVersion))
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
                if (this.IsCandyMachine != null)
                    hashCode = hashCode * 59 + this.IsCandyMachine.GetHashCode();
                if (this.CandyMachineContractVersion != null)
                    hashCode = hashCode * 59 + this.CandyMachineContractVersion.GetHashCode();
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
