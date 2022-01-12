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
    /// CreateTestCandyMachineRequest
    /// </summary>
    [DataContract]
    public partial class CreateTestCandyMachineRequest :  IEquatable<CreateTestCandyMachineRequest>, IValidatableObject
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
        /// The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines. 
        /// </summary>
        /// <value>The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CandyMachineContractVersionEnum
        {
            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            [EnumMember(Value = "v2")]
            V2 = 1

        }

        /// <summary>
        /// The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines. 
        /// </summary>
        /// <value>The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines. </value>
        [DataMember(Name="candy_machine_contract_version", EmitDefaultValue=false)]
        public CandyMachineContractVersionEnum? CandyMachineContractVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestCandyMachineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTestCandyMachineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestCandyMachineRequest" /> class.
        /// </summary>
        /// <param name="wallet">wallet (required).</param>
        /// <param name="network">network (default to NetworkEnum.Devnet).</param>
        /// <param name="candyMachineContractVersion">The contract you want to use to create the candy machine. Note: Metaplex disabled the creation of &#x60;v1&#x60; candy machines on their smart contract, and so we no longer support the creation of &#x60;v1&#x60; test candy machines.  (default to CandyMachineContractVersionEnum.V2).</param>
        /// <param name="includeGatekeeper">Whether or not to include a gatekeeper for testing purposes. Only applies to v2 candy machines. (default to false).</param>
        public CreateTestCandyMachineRequest(Wallet wallet = default(Wallet), NetworkEnum? network = NetworkEnum.Devnet, CandyMachineContractVersionEnum? candyMachineContractVersion = CandyMachineContractVersionEnum.V2, bool includeGatekeeper = false)
        {
            // to ensure "wallet" is required (not null)
            if (wallet == null)
            {
                throw new InvalidDataException("wallet is a required property for CreateTestCandyMachineRequest and cannot be null");
            }
            else
            {
                this.Wallet = wallet;
            }

            // use default value if no "network" provided
            if (network == null)
            {
                this.Network = NetworkEnum.Devnet;
            }
            else
            {
                this.Network = network;
            }
            // use default value if no "candyMachineContractVersion" provided
            if (candyMachineContractVersion == null)
            {
                this.CandyMachineContractVersion = CandyMachineContractVersionEnum.V2;
            }
            else
            {
                this.CandyMachineContractVersion = candyMachineContractVersion;
            }
            // use default value if no "includeGatekeeper" provided
            if (includeGatekeeper == null)
            {
                this.IncludeGatekeeper = false;
            }
            else
            {
                this.IncludeGatekeeper = includeGatekeeper;
            }
        }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=true)]
        public Wallet Wallet { get; set; }



        /// <summary>
        /// Whether or not to include a gatekeeper for testing purposes. Only applies to v2 candy machines.
        /// </summary>
        /// <value>Whether or not to include a gatekeeper for testing purposes. Only applies to v2 candy machines.</value>
        [DataMember(Name="include_gatekeeper", EmitDefaultValue=false)]
        public bool IncludeGatekeeper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTestCandyMachineRequest {\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  CandyMachineContractVersion: ").Append(CandyMachineContractVersion).Append("\n");
            sb.Append("  IncludeGatekeeper: ").Append(IncludeGatekeeper).Append("\n");
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
            return this.Equals(input as CreateTestCandyMachineRequest);
        }

        /// <summary>
        /// Returns true if CreateTestCandyMachineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTestCandyMachineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTestCandyMachineRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.CandyMachineContractVersion == input.CandyMachineContractVersion ||
                    (this.CandyMachineContractVersion != null &&
                    this.CandyMachineContractVersion.Equals(input.CandyMachineContractVersion))
                ) && 
                (
                    this.IncludeGatekeeper == input.IncludeGatekeeper ||
                    (this.IncludeGatekeeper != null &&
                    this.IncludeGatekeeper.Equals(input.IncludeGatekeeper))
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
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.CandyMachineContractVersion != null)
                    hashCode = hashCode * 59 + this.CandyMachineContractVersion.GetHashCode();
                if (this.IncludeGatekeeper != null)
                    hashCode = hashCode * 59 + this.IncludeGatekeeper.GetHashCode();
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
