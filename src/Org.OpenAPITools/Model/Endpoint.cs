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
    /// Endpoint
    /// </summary>
    [DataContract]
    public partial class Endpoint :  IEquatable<Endpoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Endpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="projectId">The ID of the project. This is auto-generated upon project creation and cannot currently be changed.  (required).</param>
        /// <param name="version">The project version under which the endpoint exists  (required).</param>
        /// <param name="path">The path of the endpoint  (required).</param>
        /// <param name="operationId">The operation ID of the endpoint.  (required).</param>
        /// <param name="readableName">The name of the endpoint formatted in a readable way (e.g., Get Endpoint Metadata).  (required).</param>
        /// <param name="summary">The summary of the endpoint to be displayed in the sidebar on the left of the mini-API&#39;s documentation .</param>
        /// <param name="description">A description of what the endpoint does. This will be shown in the mini-API documentation. .</param>
        /// <param name="credits">The price of the endpoint. Valid values are integers from 1 to 100.  (required).</param>
        /// <param name="groupName">The name of the group of endpoints that the endpoint comes from .</param>
        /// <param name="inputSpecification">A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter. (required).</param>
        /// <param name="inputExamples">An example of the JSON input that a user might send. Limited to one example currently.  (required).</param>
        /// <param name="outputSpecification">A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter. (required).</param>
        /// <param name="outputExamples">An example of the JSON output that a user might send. Limited to one example currently.  (required).</param>
        public Endpoint(string projectId = default(string), string version = default(string), string path = default(string), string operationId = default(string), string readableName = default(string), string summary = default(string), string description = default(string), decimal credits = default(decimal), string groupName = default(string), List<ParameterSpecification> inputSpecification = default(List<ParameterSpecification>), Object inputExamples = default(Object), List<ParameterSpecification> outputSpecification = default(List<ParameterSpecification>), Object outputExamples = default(Object))
        {
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new InvalidDataException("projectId is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.ProjectId = projectId;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for Endpoint and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.Path = path;
            }

            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new InvalidDataException("operationId is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.OperationId = operationId;
            }

            // to ensure "readableName" is required (not null)
            if (readableName == null)
            {
                throw new InvalidDataException("readableName is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.ReadableName = readableName;
            }

            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new InvalidDataException("credits is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.Credits = credits;
            }

            // to ensure "inputSpecification" is required (not null)
            if (inputSpecification == null)
            {
                throw new InvalidDataException("inputSpecification is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.InputSpecification = inputSpecification;
            }

            // to ensure "inputExamples" is required (not null)
            if (inputExamples == null)
            {
                throw new InvalidDataException("inputExamples is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.InputExamples = inputExamples;
            }

            // to ensure "outputSpecification" is required (not null)
            if (outputSpecification == null)
            {
                throw new InvalidDataException("outputSpecification is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.OutputSpecification = outputSpecification;
            }

            // to ensure "outputExamples" is required (not null)
            if (outputExamples == null)
            {
                throw new InvalidDataException("outputExamples is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.OutputExamples = outputExamples;
            }

            this.Summary = summary;
            this.Description = description;
            this.GroupName = groupName;
        }

        /// <summary>
        /// The ID of the project. This is auto-generated upon project creation and cannot currently be changed. 
        /// </summary>
        /// <value>The ID of the project. This is auto-generated upon project creation and cannot currently be changed. </value>
        [DataMember(Name="project_id", EmitDefaultValue=true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The project version under which the endpoint exists 
        /// </summary>
        /// <value>The project version under which the endpoint exists </value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string _Version { get; set; }

        /// <summary>
        /// The path of the endpoint 
        /// </summary>
        /// <value>The path of the endpoint </value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// The operation ID of the endpoint. 
        /// </summary>
        /// <value>The operation ID of the endpoint. </value>
        [DataMember(Name="operation_id", EmitDefaultValue=true)]
        public string OperationId { get; set; }

        /// <summary>
        /// The name of the endpoint formatted in a readable way (e.g., Get Endpoint Metadata). 
        /// </summary>
        /// <value>The name of the endpoint formatted in a readable way (e.g., Get Endpoint Metadata). </value>
        [DataMember(Name="readable_name", EmitDefaultValue=true)]
        public string ReadableName { get; set; }

        /// <summary>
        /// The summary of the endpoint to be displayed in the sidebar on the left of the mini-API&#39;s documentation 
        /// </summary>
        /// <value>The summary of the endpoint to be displayed in the sidebar on the left of the mini-API&#39;s documentation </value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// A description of what the endpoint does. This will be shown in the mini-API documentation. 
        /// </summary>
        /// <value>A description of what the endpoint does. This will be shown in the mini-API documentation. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The price of the endpoint. Valid values are integers from 1 to 100. 
        /// </summary>
        /// <value>The price of the endpoint. Valid values are integers from 1 to 100. </value>
        [DataMember(Name="credits", EmitDefaultValue=true)]
        public decimal Credits { get; set; }

        /// <summary>
        /// The name of the group of endpoints that the endpoint comes from 
        /// </summary>
        /// <value>The name of the group of endpoints that the endpoint comes from </value>
        [DataMember(Name="group_name", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter.
        /// </summary>
        /// <value>A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter.</value>
        [DataMember(Name="input_specification", EmitDefaultValue=true)]
        public List<ParameterSpecification> InputSpecification { get; set; }

        /// <summary>
        /// An example of the JSON input that a user might send. Limited to one example currently. 
        /// </summary>
        /// <value>An example of the JSON input that a user might send. Limited to one example currently. </value>
        [DataMember(Name="input_examples", EmitDefaultValue=true)]
        public Object InputExamples { get; set; }

        /// <summary>
        /// A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter.
        /// </summary>
        /// <value>A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter.</value>
        [DataMember(Name="output_specification", EmitDefaultValue=true)]
        public List<ParameterSpecification> OutputSpecification { get; set; }

        /// <summary>
        /// An example of the JSON output that a user might send. Limited to one example currently. 
        /// </summary>
        /// <value>An example of the JSON output that a user might send. Limited to one example currently. </value>
        [DataMember(Name="output_examples", EmitDefaultValue=true)]
        public Object OutputExamples { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  ReadableName: ").Append(ReadableName).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  InputSpecification: ").Append(InputSpecification).Append("\n");
            sb.Append("  InputExamples: ").Append(InputExamples).Append("\n");
            sb.Append("  OutputSpecification: ").Append(OutputSpecification).Append("\n");
            sb.Append("  OutputExamples: ").Append(OutputExamples).Append("\n");
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
            return this.Equals(input as Endpoint);
        }

        /// <summary>
        /// Returns true if Endpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Endpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endpoint input)
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
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.ReadableName == input.ReadableName ||
                    (this.ReadableName != null &&
                    this.ReadableName.Equals(input.ReadableName))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Credits == input.Credits ||
                    (this.Credits != null &&
                    this.Credits.Equals(input.Credits))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.InputSpecification == input.InputSpecification ||
                    this.InputSpecification != null &&
                    input.InputSpecification != null &&
                    this.InputSpecification.SequenceEqual(input.InputSpecification)
                ) && 
                (
                    this.InputExamples == input.InputExamples ||
                    (this.InputExamples != null &&
                    this.InputExamples.Equals(input.InputExamples))
                ) && 
                (
                    this.OutputSpecification == input.OutputSpecification ||
                    this.OutputSpecification != null &&
                    input.OutputSpecification != null &&
                    this.OutputSpecification.SequenceEqual(input.OutputSpecification)
                ) && 
                (
                    this.OutputExamples == input.OutputExamples ||
                    (this.OutputExamples != null &&
                    this.OutputExamples.Equals(input.OutputExamples))
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
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.ReadableName != null)
                    hashCode = hashCode * 59 + this.ReadableName.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Credits != null)
                    hashCode = hashCode * 59 + this.Credits.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.InputSpecification != null)
                    hashCode = hashCode * 59 + this.InputSpecification.GetHashCode();
                if (this.InputExamples != null)
                    hashCode = hashCode * 59 + this.InputExamples.GetHashCode();
                if (this.OutputSpecification != null)
                    hashCode = hashCode * 59 + this.OutputSpecification.GetHashCode();
                if (this.OutputExamples != null)
                    hashCode = hashCode * 59 + this.OutputExamples.GetHashCode();
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
