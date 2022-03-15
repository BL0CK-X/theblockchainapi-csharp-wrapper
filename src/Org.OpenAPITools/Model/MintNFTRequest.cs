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
    /// MintNFTRequest
    /// </summary>
    [DataContract]
    public partial class MintNFTRequest :  IEquatable<MintNFTRequest>, IValidatableObject
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
        /// The candy machine contract of the candy machine from which you&#39;re minting. If you are minting from a &#x60;v1&#x60; candy machine ID, set this to &#x60;v1&#x60;. If you are minting from a &#x60;v2&#x60; candy machine ID, set this to &#x60;v2&#x60;. If you don&#39;t know which the version of your candy machine, check out &lt;a href&#x3D;\&quot;#operation/solanaGetAccountIsCandyMachine\&quot;&gt;this endpoint&lt;/a&gt;. 
        /// </summary>
        /// <value>The candy machine contract of the candy machine from which you&#39;re minting. If you are minting from a &#x60;v1&#x60; candy machine ID, set this to &#x60;v1&#x60;. If you are minting from a &#x60;v2&#x60; candy machine ID, set this to &#x60;v2&#x60;. If you don&#39;t know which the version of your candy machine, check out &lt;a href&#x3D;\&quot;#operation/solanaGetAccountIsCandyMachine\&quot;&gt;this endpoint&lt;/a&gt;. </value>
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
            V2 = 2

        }

        /// <summary>
        /// The candy machine contract of the candy machine from which you&#39;re minting. If you are minting from a &#x60;v1&#x60; candy machine ID, set this to &#x60;v1&#x60;. If you are minting from a &#x60;v2&#x60; candy machine ID, set this to &#x60;v2&#x60;. If you don&#39;t know which the version of your candy machine, check out &lt;a href&#x3D;\&quot;#operation/solanaGetAccountIsCandyMachine\&quot;&gt;this endpoint&lt;/a&gt;. 
        /// </summary>
        /// <value>The candy machine contract of the candy machine from which you&#39;re minting. If you are minting from a &#x60;v1&#x60; candy machine ID, set this to &#x60;v1&#x60;. If you are minting from a &#x60;v2&#x60; candy machine ID, set this to &#x60;v2&#x60;. If you don&#39;t know which the version of your candy machine, check out &lt;a href&#x3D;\&quot;#operation/solanaGetAccountIsCandyMachine\&quot;&gt;this endpoint&lt;/a&gt;. </value>
        [DataMember(Name="candy_machine_contract_version", EmitDefaultValue=false)]
        public CandyMachineContractVersionEnum? CandyMachineContractVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintNFTRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintNFTRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintNFTRequest" /> class.
        /// </summary>
        /// <param name="wallet">wallet (required).</param>
        /// <param name="configAddress">The config address of the candy machine. You can retrieve this if you have the candy machine ID using &lt;a href&#x3D;\&quot;#operation/solanaGetCandyMachineDetails\&quot;&gt;this endpoint&lt;/a&gt; and retrieving the &#x60;config_address&#x60; from the response.  A candy machine ID is the same thing as a configuration address for v2 candy machines.  (required).</param>
        /// <param name="network">network (default to NetworkEnum.Devnet).</param>
        /// <param name="candyMachineContractVersion">The candy machine contract of the candy machine from which you&#39;re minting. If you are minting from a &#x60;v1&#x60; candy machine ID, set this to &#x60;v1&#x60;. If you are minting from a &#x60;v2&#x60; candy machine ID, set this to &#x60;v2&#x60;. If you don&#39;t know which the version of your candy machine, check out &lt;a href&#x3D;\&quot;#operation/solanaGetAccountIsCandyMachine\&quot;&gt;this endpoint&lt;/a&gt;.  (default to CandyMachineContractVersionEnum.V1).</param>
        public MintNFTRequest(Wallet wallet = default(Wallet), string configAddress = default(string), NetworkEnum? network = NetworkEnum.Devnet, CandyMachineContractVersionEnum? candyMachineContractVersion = CandyMachineContractVersionEnum.V1)
        {
            // to ensure "wallet" is required (not null)
            if (wallet == null)
            {
                throw new InvalidDataException("wallet is a required property for MintNFTRequest and cannot be null");
            }
            else
            {
                this.Wallet = wallet;
            }

            // to ensure "configAddress" is required (not null)
            if (configAddress == null)
            {
                throw new InvalidDataException("configAddress is a required property for MintNFTRequest and cannot be null");
            }
            else
            {
                this.ConfigAddress = configAddress;
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
                this.CandyMachineContractVersion = CandyMachineContractVersionEnum.V1;
            }
            else
            {
                this.CandyMachineContractVersion = candyMachineContractVersion;
            }
        }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=true)]
        public Wallet Wallet { get; set; }

        /// <summary>
        /// The config address of the candy machine. You can retrieve this if you have the candy machine ID using &lt;a href&#x3D;\&quot;#operation/solanaGetCandyMachineDetails\&quot;&gt;this endpoint&lt;/a&gt; and retrieving the &#x60;config_address&#x60; from the response.  A candy machine ID is the same thing as a configuration address for v2 candy machines. 
        /// </summary>
        /// <value>The config address of the candy machine. You can retrieve this if you have the candy machine ID using &lt;a href&#x3D;\&quot;#operation/solanaGetCandyMachineDetails\&quot;&gt;this endpoint&lt;/a&gt; and retrieving the &#x60;config_address&#x60; from the response.  A candy machine ID is the same thing as a configuration address for v2 candy machines. </value>
        [DataMember(Name="config_address", EmitDefaultValue=true)]
        public string ConfigAddress { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MintNFTRequest {\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  ConfigAddress: ").Append(ConfigAddress).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(input as MintNFTRequest);
        }

        /// <summary>
        /// Returns true if MintNFTRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MintNFTRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintNFTRequest input)
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
                    this.ConfigAddress == input.ConfigAddress ||
                    (this.ConfigAddress != null &&
                    this.ConfigAddress.Equals(input.ConfigAddress))
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
                if (this.ConfigAddress != null)
                    hashCode = hashCode * 59 + this.ConfigAddress.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
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
