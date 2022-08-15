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
    /// CCPayment
    /// </summary>
    [DataContract]
    public partial class CCPayment :  IEquatable<CCPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CCPayment" /> class.
        /// </summary>
        /// <param name="projectId">The ID of the project .</param>
        /// <param name="productId">The ID of the associated product .</param>
        /// <param name="planId">The ID of the respective plan .</param>
        /// <param name="paymentId">The unique ID of the payment .</param>
        /// <param name="blockchainIdentifier">The unique identifier of the wallet from which the payment was made. .</param>
        /// <param name="blockchainPaymentDetails">blockchainPaymentDetails.</param>
        /// <param name="customerId">The ID of the customer .</param>
        /// <param name="paymentValidationCode">The validation code shown to the customer. This is only visible to the customer who paid. They can use this code to redeem their subscription to their product. .</param>
        /// <param name="periodEnd">A UNIX time stamp, in seconds, that identifies the end of the period of the subscription .</param>
        /// <param name="periodStart">A UNIX time stamp, in seconds, that identifies the start of the period of the subscription .</param>
        /// <param name="transactionBlockchainIdentifier">The string that uniquely identifies the blockchain transaction .</param>
        public CCPayment(string projectId = default(string), string productId = default(string), string planId = default(string), string paymentId = default(string), string blockchainIdentifier = default(string), CCPaymentBlockchainPaymentDetails blockchainPaymentDetails = default(CCPaymentBlockchainPaymentDetails), string customerId = default(string), string paymentValidationCode = default(string), decimal periodEnd = default(decimal), decimal periodStart = default(decimal), string transactionBlockchainIdentifier = default(string))
        {
            this.ProjectId = projectId;
            this.ProductId = productId;
            this.PlanId = planId;
            this.PaymentId = paymentId;
            this.BlockchainIdentifier = blockchainIdentifier;
            this.BlockchainPaymentDetails = blockchainPaymentDetails;
            this.CustomerId = customerId;
            this.PaymentValidationCode = paymentValidationCode;
            this.PeriodEnd = periodEnd;
            this.PeriodStart = periodStart;
            this.TransactionBlockchainIdentifier = transactionBlockchainIdentifier;
        }

        /// <summary>
        /// The ID of the project 
        /// </summary>
        /// <value>The ID of the project </value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The ID of the associated product 
        /// </summary>
        /// <value>The ID of the associated product </value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The ID of the respective plan 
        /// </summary>
        /// <value>The ID of the respective plan </value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// The unique ID of the payment 
        /// </summary>
        /// <value>The unique ID of the payment </value>
        [DataMember(Name="payment_id", EmitDefaultValue=false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// The unique identifier of the wallet from which the payment was made. 
        /// </summary>
        /// <value>The unique identifier of the wallet from which the payment was made. </value>
        [DataMember(Name="blockchain_identifier", EmitDefaultValue=false)]
        public string BlockchainIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets BlockchainPaymentDetails
        /// </summary>
        [DataMember(Name="blockchain_payment_details", EmitDefaultValue=false)]
        public CCPaymentBlockchainPaymentDetails BlockchainPaymentDetails { get; set; }

        /// <summary>
        /// The ID of the customer 
        /// </summary>
        /// <value>The ID of the customer </value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The validation code shown to the customer. This is only visible to the customer who paid. They can use this code to redeem their subscription to their product. 
        /// </summary>
        /// <value>The validation code shown to the customer. This is only visible to the customer who paid. They can use this code to redeem their subscription to their product. </value>
        [DataMember(Name="payment_validation_code", EmitDefaultValue=false)]
        public string PaymentValidationCode { get; set; }

        /// <summary>
        /// A UNIX time stamp, in seconds, that identifies the end of the period of the subscription 
        /// </summary>
        /// <value>A UNIX time stamp, in seconds, that identifies the end of the period of the subscription </value>
        [DataMember(Name="period_end", EmitDefaultValue=false)]
        public decimal PeriodEnd { get; set; }

        /// <summary>
        /// A UNIX time stamp, in seconds, that identifies the start of the period of the subscription 
        /// </summary>
        /// <value>A UNIX time stamp, in seconds, that identifies the start of the period of the subscription </value>
        [DataMember(Name="period_start", EmitDefaultValue=false)]
        public decimal PeriodStart { get; set; }

        /// <summary>
        /// The string that uniquely identifies the blockchain transaction 
        /// </summary>
        /// <value>The string that uniquely identifies the blockchain transaction </value>
        [DataMember(Name="transaction_blockchain_identifier", EmitDefaultValue=false)]
        public string TransactionBlockchainIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CCPayment {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  BlockchainIdentifier: ").Append(BlockchainIdentifier).Append("\n");
            sb.Append("  BlockchainPaymentDetails: ").Append(BlockchainPaymentDetails).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  PaymentValidationCode: ").Append(PaymentValidationCode).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  TransactionBlockchainIdentifier: ").Append(TransactionBlockchainIdentifier).Append("\n");
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
            return this.Equals(input as CCPayment);
        }

        /// <summary>
        /// Returns true if CCPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CCPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CCPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.BlockchainIdentifier == input.BlockchainIdentifier ||
                    (this.BlockchainIdentifier != null &&
                    this.BlockchainIdentifier.Equals(input.BlockchainIdentifier))
                ) && 
                (
                    this.BlockchainPaymentDetails == input.BlockchainPaymentDetails ||
                    (this.BlockchainPaymentDetails != null &&
                    this.BlockchainPaymentDetails.Equals(input.BlockchainPaymentDetails))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.PaymentValidationCode == input.PaymentValidationCode ||
                    (this.PaymentValidationCode != null &&
                    this.PaymentValidationCode.Equals(input.PaymentValidationCode))
                ) && 
                (
                    this.PeriodEnd == input.PeriodEnd ||
                    (this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(input.PeriodEnd))
                ) && 
                (
                    this.PeriodStart == input.PeriodStart ||
                    (this.PeriodStart != null &&
                    this.PeriodStart.Equals(input.PeriodStart))
                ) && 
                (
                    this.TransactionBlockchainIdentifier == input.TransactionBlockchainIdentifier ||
                    (this.TransactionBlockchainIdentifier != null &&
                    this.TransactionBlockchainIdentifier.Equals(input.TransactionBlockchainIdentifier))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.BlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.BlockchainIdentifier.GetHashCode();
                if (this.BlockchainPaymentDetails != null)
                    hashCode = hashCode * 59 + this.BlockchainPaymentDetails.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.PaymentValidationCode != null)
                    hashCode = hashCode * 59 + this.PaymentValidationCode.GetHashCode();
                if (this.PeriodEnd != null)
                    hashCode = hashCode * 59 + this.PeriodEnd.GetHashCode();
                if (this.PeriodStart != null)
                    hashCode = hashCode * 59 + this.PeriodStart.GetHashCode();
                if (this.TransactionBlockchainIdentifier != null)
                    hashCode = hashCode * 59 + this.TransactionBlockchainIdentifier.GetHashCode();
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
