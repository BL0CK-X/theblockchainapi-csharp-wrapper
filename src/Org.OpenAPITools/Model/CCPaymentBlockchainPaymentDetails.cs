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
    /// The information necessary to verify the payment.  
    /// </summary>
    [DataContract]
    public partial class CCPaymentBlockchainPaymentDetails :  IEquatable<CCPaymentBlockchainPaymentDetails>, IValidatableObject
    {
        /// <summary>
        /// The chain on which the payment was made. 
        /// </summary>
        /// <value>The chain on which the payment was made. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum Solana for value: solana
            /// </summary>
            [EnumMember(Value = "solana")]
            Solana = 1

        }

        /// <summary>
        /// The chain on which the payment was made. 
        /// </summary>
        /// <value>The chain on which the payment was made. </value>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public ChainEnum? Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CCPaymentBlockchainPaymentDetails" /> class.
        /// </summary>
        /// <param name="chain">The chain on which the payment was made. .</param>
        /// <param name="feeAmount">The fee taken by the blockchain API. This is shown in integer form. .</param>
        /// <param name="payoutAmount">The amount paid to the project&#39;s payout wallet (the recipient of the payment). This is shown in integer form. .</param>
        /// <param name="tokenBlockchainIdentifier">The blockchain identifier of the token used to pay. Currently, we only support payments in USDC. .</param>
        /// <param name="totalPaid">The total paid by the user when making the payment. This should match the amount set in the respective plan. .</param>
        /// <param name="transactionSignature">The transaction signature which you can use to manually or automatically verify the transaction on the blockchain. .</param>
        public CCPaymentBlockchainPaymentDetails(ChainEnum? chain = default(ChainEnum?), string feeAmount = default(string), string payoutAmount = default(string), string tokenBlockchainIdentifier = default(string), string totalPaid = default(string), string transactionSignature = default(string))
        {
            this.Chain = chain;
            this.FeeAmount = feeAmount;
            this.PayoutAmount = payoutAmount;
            this.TokenBlockchainIdentifier = tokenBlockchainIdentifier;
            this.TotalPaid = totalPaid;
            this.TransactionSignature = transactionSignature;
        }


        /// <summary>
        /// The fee taken by the blockchain API. This is shown in integer form. 
        /// </summary>
        /// <value>The fee taken by the blockchain API. This is shown in integer form. </value>
        [DataMember(Name="fee_amount", EmitDefaultValue=false)]
        public string FeeAmount { get; set; }

        /// <summary>
        /// The amount paid to the project&#39;s payout wallet (the recipient of the payment). This is shown in integer form. 
        /// </summary>
        /// <value>The amount paid to the project&#39;s payout wallet (the recipient of the payment). This is shown in integer form. </value>
        [DataMember(Name="payout_amount", EmitDefaultValue=false)]
        public string PayoutAmount { get; set; }

        /// <summary>
        /// The blockchain identifier of the token used to pay. Currently, we only support payments in USDC. 
        /// </summary>
        /// <value>The blockchain identifier of the token used to pay. Currently, we only support payments in USDC. </value>
        [DataMember(Name="token_blockchain_identifier", EmitDefaultValue=false)]
        public string TokenBlockchainIdentifier { get; set; }

        /// <summary>
        /// The total paid by the user when making the payment. This should match the amount set in the respective plan. 
        /// </summary>
        /// <value>The total paid by the user when making the payment. This should match the amount set in the respective plan. </value>
        [DataMember(Name="total_paid", EmitDefaultValue=false)]
        public string TotalPaid { get; set; }

        /// <summary>
        /// The transaction signature which you can use to manually or automatically verify the transaction on the blockchain. 
        /// </summary>
        /// <value>The transaction signature which you can use to manually or automatically verify the transaction on the blockchain. </value>
        [DataMember(Name="transaction_signature", EmitDefaultValue=false)]
        public string TransactionSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CCPaymentBlockchainPaymentDetails {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  PayoutAmount: ").Append(PayoutAmount).Append("\n");
            sb.Append("  TokenBlockchainIdentifier: ").Append(TokenBlockchainIdentifier).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
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
            return this.Equals(input as CCPaymentBlockchainPaymentDetails);
        }

        /// <summary>
        /// Returns true if CCPaymentBlockchainPaymentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CCPaymentBlockchainPaymentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CCPaymentBlockchainPaymentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) && 
                (
                    this.PayoutAmount == input.PayoutAmount ||
                    (this.PayoutAmount != null &&
                    this.PayoutAmount.Equals(input.PayoutAmount))
                ) && 
                (
                    this.TokenBlockchainIdentifier == input.TokenBlockchainIdentifier ||
                    (this.TokenBlockchainIdentifier != null &&
                    this.TokenBlockchainIdentifier.Equals(input.TokenBlockchainIdentifier))
                ) && 
                (
                    this.TotalPaid == input.TotalPaid ||
                    (this.TotalPaid != null &&
                    this.TotalPaid.Equals(input.TotalPaid))
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
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.PayoutAmount != null)
                    hashCode = hashCode * 59 + this.PayoutAmount.GetHashCode();
                if (this.TokenBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.TokenBlockchainIdentifier.GetHashCode();
                if (this.TotalPaid != null)
                    hashCode = hashCode * 59 + this.TotalPaid.GetHashCode();
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
