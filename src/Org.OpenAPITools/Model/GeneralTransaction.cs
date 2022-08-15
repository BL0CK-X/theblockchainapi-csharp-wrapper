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
    /// GeneralTransaction
    /// </summary>
    [DataContract]
    public partial class GeneralTransaction :  IEquatable<GeneralTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralTransaction" /> class.
        /// </summary>
        /// <param name="accessList">accessList.</param>
        /// <param name="blockHash">blockHash.</param>
        /// <param name="blockNumber">blockNumber.</param>
        /// <param name="chainId">chainId.</param>
        /// <param name="from">from.</param>
        /// <param name="gas">gas.</param>
        /// <param name="gasPrice">gasPrice.</param>
        /// <param name="hash">hash.</param>
        /// <param name="input">input.</param>
        /// <param name="maxFeePerGas">maxFeePerGas.</param>
        /// <param name="maxPriorityFeePerGas">maxPriorityFeePerGas.</param>
        /// <param name="nonce">nonce.</param>
        /// <param name="r">r.</param>
        /// <param name="s">s.</param>
        /// <param name="to">to.</param>
        /// <param name="transactionIndex">transactionIndex.</param>
        /// <param name="type">type.</param>
        /// <param name="v">v.</param>
        /// <param name="value">value.</param>
        /// <param name="blockTime">blockTime.</param>
        /// <param name="meta">meta.</param>
        /// <param name="slot">slot.</param>
        /// <param name="transaction">transaction.</param>
        public GeneralTransaction(Object accessList = default(Object), string blockHash = default(string), string blockNumber = default(string), string chainId = default(string), string from = default(string), string gas = default(string), string gasPrice = default(string), string hash = default(string), string input = default(string), string maxFeePerGas = default(string), string maxPriorityFeePerGas = default(string), string nonce = default(string), string r = default(string), string s = default(string), string to = default(string), string transactionIndex = default(string), string type = default(string), string v = default(string), string value = default(string), decimal blockTime = default(decimal), Object meta = default(Object), decimal slot = default(decimal), Object transaction = default(Object))
        {
            this.AccessList = accessList;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
            this.ChainId = chainId;
            this.From = from;
            this.Gas = gas;
            this.GasPrice = gasPrice;
            this.Hash = hash;
            this.Input = input;
            this.MaxFeePerGas = maxFeePerGas;
            this.MaxPriorityFeePerGas = maxPriorityFeePerGas;
            this.Nonce = nonce;
            this.R = r;
            this.S = s;
            this.To = to;
            this.TransactionIndex = transactionIndex;
            this.Type = type;
            this.V = v;
            this.Value = value;
            this.BlockTime = blockTime;
            this.Meta = meta;
            this.Slot = slot;
            this.Transaction = transaction;
        }

        /// <summary>
        /// Gets or Sets AccessList
        /// </summary>
        [DataMember(Name="access_list", EmitDefaultValue=false)]
        public Object AccessList { get; set; }

        /// <summary>
        /// Gets or Sets BlockHash
        /// </summary>
        [DataMember(Name="block_hash", EmitDefaultValue=false)]
        public string BlockHash { get; set; }

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [DataMember(Name="block_number", EmitDefaultValue=false)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name="chain_id", EmitDefaultValue=false)]
        public string ChainId { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Gas
        /// </summary>
        [DataMember(Name="gas", EmitDefaultValue=false)]
        public string Gas { get; set; }

        /// <summary>
        /// Gets or Sets GasPrice
        /// </summary>
        [DataMember(Name="gas_price", EmitDefaultValue=false)]
        public string GasPrice { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets MaxFeePerGas
        /// </summary>
        [DataMember(Name="max_fee_per_gas", EmitDefaultValue=false)]
        public string MaxFeePerGas { get; set; }

        /// <summary>
        /// Gets or Sets MaxPriorityFeePerGas
        /// </summary>
        [DataMember(Name="max_priority_fee_per_gas", EmitDefaultValue=false)]
        public string MaxPriorityFeePerGas { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets R
        /// </summary>
        [DataMember(Name="r", EmitDefaultValue=false)]
        public string R { get; set; }

        /// <summary>
        /// Gets or Sets S
        /// </summary>
        [DataMember(Name="s", EmitDefaultValue=false)]
        public string S { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIndex
        /// </summary>
        [DataMember(Name="transaction_index", EmitDefaultValue=false)]
        public string TransactionIndex { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets V
        /// </summary>
        [DataMember(Name="v", EmitDefaultValue=false)]
        public string V { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets BlockTime
        /// </summary>
        [DataMember(Name="block_time", EmitDefaultValue=false)]
        public decimal BlockTime { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Gets or Sets Slot
        /// </summary>
        [DataMember(Name="slot", EmitDefaultValue=false)]
        public decimal Slot { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Object Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTransaction {\n");
            sb.Append("  AccessList: ").Append(AccessList).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  MaxFeePerGas: ").Append(MaxFeePerGas).Append("\n");
            sb.Append("  MaxPriorityFeePerGas: ").Append(MaxPriorityFeePerGas).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  TransactionIndex: ").Append(TransactionIndex).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  BlockTime: ").Append(BlockTime).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as GeneralTransaction);
        }

        /// <summary>
        /// Returns true if GeneralTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneralTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneralTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessList == input.AccessList ||
                    (this.AccessList != null &&
                    this.AccessList.Equals(input.AccessList))
                ) && 
                (
                    this.BlockHash == input.BlockHash ||
                    (this.BlockHash != null &&
                    this.BlockHash.Equals(input.BlockHash))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    (this.ChainId != null &&
                    this.ChainId.Equals(input.ChainId))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Gas == input.Gas ||
                    (this.Gas != null &&
                    this.Gas.Equals(input.Gas))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.MaxFeePerGas == input.MaxFeePerGas ||
                    (this.MaxFeePerGas != null &&
                    this.MaxFeePerGas.Equals(input.MaxFeePerGas))
                ) && 
                (
                    this.MaxPriorityFeePerGas == input.MaxPriorityFeePerGas ||
                    (this.MaxPriorityFeePerGas != null &&
                    this.MaxPriorityFeePerGas.Equals(input.MaxPriorityFeePerGas))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.TransactionIndex == input.TransactionIndex ||
                    (this.TransactionIndex != null &&
                    this.TransactionIndex.Equals(input.TransactionIndex))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.V == input.V ||
                    (this.V != null &&
                    this.V.Equals(input.V))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.BlockTime == input.BlockTime ||
                    (this.BlockTime != null &&
                    this.BlockTime.Equals(input.BlockTime))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.AccessList != null)
                    hashCode = hashCode * 59 + this.AccessList.GetHashCode();
                if (this.BlockHash != null)
                    hashCode = hashCode * 59 + this.BlockHash.GetHashCode();
                if (this.BlockNumber != null)
                    hashCode = hashCode * 59 + this.BlockNumber.GetHashCode();
                if (this.ChainId != null)
                    hashCode = hashCode * 59 + this.ChainId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Gas != null)
                    hashCode = hashCode * 59 + this.Gas.GetHashCode();
                if (this.GasPrice != null)
                    hashCode = hashCode * 59 + this.GasPrice.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.MaxFeePerGas != null)
                    hashCode = hashCode * 59 + this.MaxFeePerGas.GetHashCode();
                if (this.MaxPriorityFeePerGas != null)
                    hashCode = hashCode * 59 + this.MaxPriorityFeePerGas.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.S != null)
                    hashCode = hashCode * 59 + this.S.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.TransactionIndex != null)
                    hashCode = hashCode * 59 + this.TransactionIndex.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.BlockTime != null)
                    hashCode = hashCode * 59 + this.BlockTime.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Slot != null)
                    hashCode = hashCode * 59 + this.Slot.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
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
