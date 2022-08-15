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
    /// CandyMachineSearchRequest
    /// </summary>
    [DataContract]
    public partial class CandyMachineSearchRequest :  IEquatable<CandyMachineSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpdateAuthoritySearchMethodEnum
        {
            /// <summary>
            /// Enum Exactmatch for value: exact_match
            /// </summary>
            [EnumMember(Value = "exact_match")]
            Exactmatch = 1

        }

        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [DataMember(Name="update_authority_search_method", EmitDefaultValue=false)]
        public UpdateAuthoritySearchMethodEnum? UpdateAuthoritySearchMethod { get; set; }
        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfigAddressSearchMethodEnum
        {
            /// <summary>
            /// Enum Exactmatch for value: exact_match
            /// </summary>
            [EnumMember(Value = "exact_match")]
            Exactmatch = 1

        }

        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [DataMember(Name="config_address_search_method", EmitDefaultValue=false)]
        public ConfigAddressSearchMethodEnum? ConfigAddressSearchMethod { get; set; }
        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UuidSearchMethodEnum
        {
            /// <summary>
            /// Enum Exactmatch for value: exact_match
            /// </summary>
            [EnumMember(Value = "exact_match")]
            Exactmatch = 1

        }

        /// <summary>
        /// Only &#x60;exact_match&#x60; supported at this time
        /// </summary>
        /// <value>Only &#x60;exact_match&#x60; supported at this time</value>
        [DataMember(Name="uuid_search_method", EmitDefaultValue=false)]
        public UuidSearchMethodEnum? UuidSearchMethod { get; set; }
        /// <summary>
        /// Defines SymbolSearchMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SymbolSearchMethodEnum
        {
            /// <summary>
            /// Enum Beginswith for value: begins_with
            /// </summary>
            [EnumMember(Value = "begins_with")]
            Beginswith = 1,

            /// <summary>
            /// Enum Exactmatch for value: exact_match
            /// </summary>
            [EnumMember(Value = "exact_match")]
            Exactmatch = 2

        }

        /// <summary>
        /// Gets or Sets SymbolSearchMethod
        /// </summary>
        [DataMember(Name="symbol_search_method", EmitDefaultValue=false)]
        public SymbolSearchMethodEnum? SymbolSearchMethod { get; set; }
        /// <summary>
        /// Defines NftNameSearchMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NftNameSearchMethodEnum
        {
            /// <summary>
            /// Enum Beginswith for value: begins_with
            /// </summary>
            [EnumMember(Value = "begins_with")]
            Beginswith = 1,

            /// <summary>
            /// Enum Exactmatch for value: exact_match
            /// </summary>
            [EnumMember(Value = "exact_match")]
            Exactmatch = 2

        }

        /// <summary>
        /// Gets or Sets NftNameSearchMethod
        /// </summary>
        [DataMember(Name="nft_name_search_method", EmitDefaultValue=false)]
        public NftNameSearchMethodEnum? NftNameSearchMethod { get; set; }
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
        /// The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;. 
        /// </summary>
        /// <value>The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;. </value>
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
        /// The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;. 
        /// </summary>
        /// <value>The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;. </value>
        [DataMember(Name="candy_machine_contract_version", EmitDefaultValue=false)]
        public CandyMachineContractVersionEnum? CandyMachineContractVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CandyMachineSearchRequest" /> class.
        /// </summary>
        /// <param name="updateAuthority">The public key of the update authority of the candy machine.</param>
        /// <param name="updateAuthoritySearchMethod">Only &#x60;exact_match&#x60; supported at this time (default to UpdateAuthoritySearchMethodEnum.Exactmatch).</param>
        /// <param name="configAddress">The public key of the configuration of the candy machine.</param>
        /// <param name="configAddressSearchMethod">Only &#x60;exact_match&#x60; supported at this time (default to ConfigAddressSearchMethodEnum.Exactmatch).</param>
        /// <param name="uuid">The alphanumeric string of length six that corresponds to the candy machine. This is NOT the candy machine ID.  This is the first six letters of the configuration address and is also used to identify the candy machine. An example is &#x60;4zKV6i&#x60;. .</param>
        /// <param name="uuidSearchMethod">Only &#x60;exact_match&#x60; supported at this time (default to UuidSearchMethodEnum.Exactmatch).</param>
        /// <param name="symbol">The symbol associated with the candy machine.</param>
        /// <param name="symbolSearchMethod">symbolSearchMethod (default to SymbolSearchMethodEnum.Exactmatch).</param>
        /// <param name="nftName">The name of an NFT on the candy machine, minted or unminted. For example, to find The Solana Money Boys candy machine, you already know that each NFT is named \&quot;Solana Money Boy #0\&quot;, \&quot;Solana Money Boy #1\&quot;, and so on. So you could search with  nft_name&#x3D;\&quot;Solana Money Boy #0\&quot;, nft_name_index&#x3D;0, nft_name_search_method&#x3D;&#39;exact_match&#39;, for example, which would return the candy machine ID. This also works with candy machines that are not live but are uploaded. .</param>
        /// <param name="nftNameIndex">The index of the NFT to check, e.g., the 2nd NFT would have an index of 1. We cannot search all NFTs on a candy machine currently, so you must search an NFT at a particular position, such as the first, second, and so on. In general, nft_name_index&#x3D;0 works for most use cases.  (default to &quot;0&quot;).</param>
        /// <param name="nftNameSearchMethod">nftNameSearchMethod (default to NftNameSearchMethodEnum.Exactmatch).</param>
        /// <param name="network">network (default to NetworkEnum.Devnet).</param>
        /// <param name="candyMachineContractVersion">The candy machine contract you want to search.  If you want to search &#x60;v1&#x60; candy machines, set this to &#x60;v1&#x60;. If you want to search &#x60;v2&#x60; candy machines. set this to &#x60;v2&#x60;.  (default to CandyMachineContractVersionEnum.V1).</param>
        public CandyMachineSearchRequest(string updateAuthority = default(string), UpdateAuthoritySearchMethodEnum? updateAuthoritySearchMethod = UpdateAuthoritySearchMethodEnum.Exactmatch, string configAddress = default(string), ConfigAddressSearchMethodEnum? configAddressSearchMethod = ConfigAddressSearchMethodEnum.Exactmatch, string uuid = default(string), UuidSearchMethodEnum? uuidSearchMethod = UuidSearchMethodEnum.Exactmatch, string symbol = default(string), SymbolSearchMethodEnum? symbolSearchMethod = SymbolSearchMethodEnum.Exactmatch, string nftName = default(string), string nftNameIndex = "0", NftNameSearchMethodEnum? nftNameSearchMethod = NftNameSearchMethodEnum.Exactmatch, NetworkEnum? network = NetworkEnum.Devnet, CandyMachineContractVersionEnum? candyMachineContractVersion = CandyMachineContractVersionEnum.V1)
        {
            this.UpdateAuthority = updateAuthority;
            // use default value if no "updateAuthoritySearchMethod" provided
            if (updateAuthoritySearchMethod == null)
            {
                this.UpdateAuthoritySearchMethod = UpdateAuthoritySearchMethodEnum.Exactmatch;
            }
            else
            {
                this.UpdateAuthoritySearchMethod = updateAuthoritySearchMethod;
            }
            this.ConfigAddress = configAddress;
            // use default value if no "configAddressSearchMethod" provided
            if (configAddressSearchMethod == null)
            {
                this.ConfigAddressSearchMethod = ConfigAddressSearchMethodEnum.Exactmatch;
            }
            else
            {
                this.ConfigAddressSearchMethod = configAddressSearchMethod;
            }
            this.Uuid = uuid;
            // use default value if no "uuidSearchMethod" provided
            if (uuidSearchMethod == null)
            {
                this.UuidSearchMethod = UuidSearchMethodEnum.Exactmatch;
            }
            else
            {
                this.UuidSearchMethod = uuidSearchMethod;
            }
            this.Symbol = symbol;
            // use default value if no "symbolSearchMethod" provided
            if (symbolSearchMethod == null)
            {
                this.SymbolSearchMethod = SymbolSearchMethodEnum.Exactmatch;
            }
            else
            {
                this.SymbolSearchMethod = symbolSearchMethod;
            }
            this.NftName = nftName;
            // use default value if no "nftNameIndex" provided
            if (nftNameIndex == null)
            {
                this.NftNameIndex = "0";
            }
            else
            {
                this.NftNameIndex = nftNameIndex;
            }
            // use default value if no "nftNameSearchMethod" provided
            if (nftNameSearchMethod == null)
            {
                this.NftNameSearchMethod = NftNameSearchMethodEnum.Exactmatch;
            }
            else
            {
                this.NftNameSearchMethod = nftNameSearchMethod;
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
        /// The public key of the update authority of the candy machine
        /// </summary>
        /// <value>The public key of the update authority of the candy machine</value>
        [DataMember(Name="update_authority", EmitDefaultValue=false)]
        public string UpdateAuthority { get; set; }


        /// <summary>
        /// The public key of the configuration of the candy machine
        /// </summary>
        /// <value>The public key of the configuration of the candy machine</value>
        [DataMember(Name="config_address", EmitDefaultValue=false)]
        public string ConfigAddress { get; set; }


        /// <summary>
        /// The alphanumeric string of length six that corresponds to the candy machine. This is NOT the candy machine ID.  This is the first six letters of the configuration address and is also used to identify the candy machine. An example is &#x60;4zKV6i&#x60;. 
        /// </summary>
        /// <value>The alphanumeric string of length six that corresponds to the candy machine. This is NOT the candy machine ID.  This is the first six letters of the configuration address and is also used to identify the candy machine. An example is &#x60;4zKV6i&#x60;. </value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }


        /// <summary>
        /// The symbol associated with the candy machine
        /// </summary>
        /// <value>The symbol associated with the candy machine</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }


        /// <summary>
        /// The name of an NFT on the candy machine, minted or unminted. For example, to find The Solana Money Boys candy machine, you already know that each NFT is named \&quot;Solana Money Boy #0\&quot;, \&quot;Solana Money Boy #1\&quot;, and so on. So you could search with  nft_name&#x3D;\&quot;Solana Money Boy #0\&quot;, nft_name_index&#x3D;0, nft_name_search_method&#x3D;&#39;exact_match&#39;, for example, which would return the candy machine ID. This also works with candy machines that are not live but are uploaded. 
        /// </summary>
        /// <value>The name of an NFT on the candy machine, minted or unminted. For example, to find The Solana Money Boys candy machine, you already know that each NFT is named \&quot;Solana Money Boy #0\&quot;, \&quot;Solana Money Boy #1\&quot;, and so on. So you could search with  nft_name&#x3D;\&quot;Solana Money Boy #0\&quot;, nft_name_index&#x3D;0, nft_name_search_method&#x3D;&#39;exact_match&#39;, for example, which would return the candy machine ID. This also works with candy machines that are not live but are uploaded. </value>
        [DataMember(Name="nft_name", EmitDefaultValue=false)]
        public string NftName { get; set; }

        /// <summary>
        /// The index of the NFT to check, e.g., the 2nd NFT would have an index of 1. We cannot search all NFTs on a candy machine currently, so you must search an NFT at a particular position, such as the first, second, and so on. In general, nft_name_index&#x3D;0 works for most use cases. 
        /// </summary>
        /// <value>The index of the NFT to check, e.g., the 2nd NFT would have an index of 1. We cannot search all NFTs on a candy machine currently, so you must search an NFT at a particular position, such as the first, second, and so on. In general, nft_name_index&#x3D;0 works for most use cases. </value>
        [DataMember(Name="nft_name_index", EmitDefaultValue=false)]
        public string NftNameIndex { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CandyMachineSearchRequest {\n");
            sb.Append("  UpdateAuthority: ").Append(UpdateAuthority).Append("\n");
            sb.Append("  UpdateAuthoritySearchMethod: ").Append(UpdateAuthoritySearchMethod).Append("\n");
            sb.Append("  ConfigAddress: ").Append(ConfigAddress).Append("\n");
            sb.Append("  ConfigAddressSearchMethod: ").Append(ConfigAddressSearchMethod).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  UuidSearchMethod: ").Append(UuidSearchMethod).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SymbolSearchMethod: ").Append(SymbolSearchMethod).Append("\n");
            sb.Append("  NftName: ").Append(NftName).Append("\n");
            sb.Append("  NftNameIndex: ").Append(NftNameIndex).Append("\n");
            sb.Append("  NftNameSearchMethod: ").Append(NftNameSearchMethod).Append("\n");
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
            return this.Equals(input as CandyMachineSearchRequest);
        }

        /// <summary>
        /// Returns true if CandyMachineSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CandyMachineSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandyMachineSearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdateAuthority == input.UpdateAuthority ||
                    (this.UpdateAuthority != null &&
                    this.UpdateAuthority.Equals(input.UpdateAuthority))
                ) && 
                (
                    this.UpdateAuthoritySearchMethod == input.UpdateAuthoritySearchMethod ||
                    (this.UpdateAuthoritySearchMethod != null &&
                    this.UpdateAuthoritySearchMethod.Equals(input.UpdateAuthoritySearchMethod))
                ) && 
                (
                    this.ConfigAddress == input.ConfigAddress ||
                    (this.ConfigAddress != null &&
                    this.ConfigAddress.Equals(input.ConfigAddress))
                ) && 
                (
                    this.ConfigAddressSearchMethod == input.ConfigAddressSearchMethod ||
                    (this.ConfigAddressSearchMethod != null &&
                    this.ConfigAddressSearchMethod.Equals(input.ConfigAddressSearchMethod))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.UuidSearchMethod == input.UuidSearchMethod ||
                    (this.UuidSearchMethod != null &&
                    this.UuidSearchMethod.Equals(input.UuidSearchMethod))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.SymbolSearchMethod == input.SymbolSearchMethod ||
                    (this.SymbolSearchMethod != null &&
                    this.SymbolSearchMethod.Equals(input.SymbolSearchMethod))
                ) && 
                (
                    this.NftName == input.NftName ||
                    (this.NftName != null &&
                    this.NftName.Equals(input.NftName))
                ) && 
                (
                    this.NftNameIndex == input.NftNameIndex ||
                    (this.NftNameIndex != null &&
                    this.NftNameIndex.Equals(input.NftNameIndex))
                ) && 
                (
                    this.NftNameSearchMethod == input.NftNameSearchMethod ||
                    (this.NftNameSearchMethod != null &&
                    this.NftNameSearchMethod.Equals(input.NftNameSearchMethod))
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
                if (this.UpdateAuthority != null)
                    hashCode = hashCode * 59 + this.UpdateAuthority.GetHashCode();
                if (this.UpdateAuthoritySearchMethod != null)
                    hashCode = hashCode * 59 + this.UpdateAuthoritySearchMethod.GetHashCode();
                if (this.ConfigAddress != null)
                    hashCode = hashCode * 59 + this.ConfigAddress.GetHashCode();
                if (this.ConfigAddressSearchMethod != null)
                    hashCode = hashCode * 59 + this.ConfigAddressSearchMethod.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.UuidSearchMethod != null)
                    hashCode = hashCode * 59 + this.UuidSearchMethod.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.SymbolSearchMethod != null)
                    hashCode = hashCode * 59 + this.SymbolSearchMethod.GetHashCode();
                if (this.NftName != null)
                    hashCode = hashCode * 59 + this.NftName.GetHashCode();
                if (this.NftNameIndex != null)
                    hashCode = hashCode * 59 + this.NftNameIndex.GetHashCode();
                if (this.NftNameSearchMethod != null)
                    hashCode = hashCode * 59 + this.NftNameSearchMethod.GetHashCode();
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
