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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INameServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the identifier
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <returns>InputBlockchainIdentifier</returns>
        InputBlockchainIdentifier GetBlockchainIdentifierFromName (string blockchain, string network, InputName inputName = default(InputName));

        /// <summary>
        /// Get the identifier
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <returns>ApiResponse of InputBlockchainIdentifier</returns>
        ApiResponse<InputBlockchainIdentifier> GetBlockchainIdentifierFromNameWithHttpInfo (string blockchain, string network, InputName inputName = default(InputName));
        /// <summary>
        /// Get the name
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <returns>InputName</returns>
        InputName GetNameForBlockchainIdentifier (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier));

        /// <summary>
        /// Get the name
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <returns>ApiResponse of InputName</returns>
        ApiResponse<InputName> GetNameForBlockchainIdentifierWithHttpInfo (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the identifier
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InputBlockchainIdentifier</returns>
        System.Threading.Tasks.Task<InputBlockchainIdentifier> GetBlockchainIdentifierFromNameAsync (string blockchain, string network, InputName inputName = default(InputName), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the identifier
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InputBlockchainIdentifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<InputBlockchainIdentifier>> GetBlockchainIdentifierFromNameWithHttpInfoAsync (string blockchain, string network, InputName inputName = default(InputName), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the name
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InputName</returns>
        System.Threading.Tasks.Task<InputName> GetNameForBlockchainIdentifierAsync (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the name
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InputName)</returns>
        System.Threading.Tasks.Task<ApiResponse<InputName>> GetNameForBlockchainIdentifierWithHttpInfoAsync (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NameServiceApi : INameServiceApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NameServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NameServiceApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public NameServiceApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NameServiceApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get the identifier &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <returns>InputBlockchainIdentifier</returns>
        public InputBlockchainIdentifier GetBlockchainIdentifierFromName (string blockchain, string network, InputName inputName = default(InputName))
        {
             ApiResponse<InputBlockchainIdentifier> localVarResponse = GetBlockchainIdentifierFromNameWithHttpInfo(blockchain, network, inputName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the identifier &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <returns>ApiResponse of InputBlockchainIdentifier</returns>
        public ApiResponse<InputBlockchainIdentifier> GetBlockchainIdentifierFromNameWithHttpInfo (string blockchain, string network, InputName inputName = default(InputName))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new ApiException(400, "Missing required parameter 'blockchain' when calling NameServiceApi->GetBlockchainIdentifierFromName");
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling NameServiceApi->GetBlockchainIdentifierFromName");

            var localVarPath = "/{blockchain}/{network}/name_service/name_to_blockchain_identifier";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (blockchain != null) localVarPathParams.Add("blockchain", this.Configuration.ApiClient.ParameterToString(blockchain)); // path parameter
            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (inputName != null && inputName.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputName); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputName; // byte array
            }

            // authentication (APIKeyID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APIKeyID")))
            {
                localVarHeaderParams["APIKeyID"] = this.Configuration.GetApiKeyWithPrefix("APIKeyID");
            }
            // authentication (APISecretKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APISecretKey")))
            {
                localVarHeaderParams["APISecretKey"] = this.Configuration.GetApiKeyWithPrefix("APISecretKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBlockchainIdentifierFromName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InputBlockchainIdentifier>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InputBlockchainIdentifier) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InputBlockchainIdentifier)));
        }

        /// <summary>
        /// Get the identifier &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InputBlockchainIdentifier</returns>
        public async System.Threading.Tasks.Task<InputBlockchainIdentifier> GetBlockchainIdentifierFromNameAsync (string blockchain, string network, InputName inputName = default(InputName), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InputBlockchainIdentifier> localVarResponse = await GetBlockchainIdentifierFromNameWithHttpInfoAsync(blockchain, network, inputName, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the identifier &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/name-to-blockchain-identifier\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the blockchain identifier from a name.  e.g., Input &#x60;vitalik.eth&#x60; and output &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputName"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InputBlockchainIdentifier)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InputBlockchainIdentifier>> GetBlockchainIdentifierFromNameWithHttpInfoAsync (string blockchain, string network, InputName inputName = default(InputName), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new ApiException(400, "Missing required parameter 'blockchain' when calling NameServiceApi->GetBlockchainIdentifierFromName");
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling NameServiceApi->GetBlockchainIdentifierFromName");

            var localVarPath = "/{blockchain}/{network}/name_service/name_to_blockchain_identifier";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (blockchain != null) localVarPathParams.Add("blockchain", this.Configuration.ApiClient.ParameterToString(blockchain)); // path parameter
            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (inputName != null && inputName.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputName); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputName; // byte array
            }

            // authentication (APIKeyID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APIKeyID")))
            {
                localVarHeaderParams["APIKeyID"] = this.Configuration.GetApiKeyWithPrefix("APIKeyID");
            }
            // authentication (APISecretKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APISecretKey")))
            {
                localVarHeaderParams["APISecretKey"] = this.Configuration.GetApiKeyWithPrefix("APISecretKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBlockchainIdentifierFromName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InputBlockchainIdentifier>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InputBlockchainIdentifier) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InputBlockchainIdentifier)));
        }

        /// <summary>
        /// Get the name &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <returns>InputName</returns>
        public InputName GetNameForBlockchainIdentifier (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier))
        {
             ApiResponse<InputName> localVarResponse = GetNameForBlockchainIdentifierWithHttpInfo(blockchain, network, inputBlockchainIdentifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the name &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <returns>ApiResponse of InputName</returns>
        public ApiResponse<InputName> GetNameForBlockchainIdentifierWithHttpInfo (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new ApiException(400, "Missing required parameter 'blockchain' when calling NameServiceApi->GetNameForBlockchainIdentifier");
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling NameServiceApi->GetNameForBlockchainIdentifier");

            var localVarPath = "/{blockchain}/{network}/name_service/blockchain_identifier_to_name";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (blockchain != null) localVarPathParams.Add("blockchain", this.Configuration.ApiClient.ParameterToString(blockchain)); // path parameter
            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (inputBlockchainIdentifier != null && inputBlockchainIdentifier.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputBlockchainIdentifier); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputBlockchainIdentifier; // byte array
            }

            // authentication (APIKeyID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APIKeyID")))
            {
                localVarHeaderParams["APIKeyID"] = this.Configuration.GetApiKeyWithPrefix("APIKeyID");
            }
            // authentication (APISecretKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APISecretKey")))
            {
                localVarHeaderParams["APISecretKey"] = this.Configuration.GetApiKeyWithPrefix("APISecretKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNameForBlockchainIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InputName>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InputName) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InputName)));
        }

        /// <summary>
        /// Get the name &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InputName</returns>
        public async System.Threading.Tasks.Task<InputName> GetNameForBlockchainIdentifierAsync (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InputName> localVarResponse = await GetNameForBlockchainIdentifierWithHttpInfoAsync(blockchain, network, inputBlockchainIdentifier, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the name &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/name-service/blockchain-identifier-to-name\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript) [Coming Soon]&lt;/a&gt;.      Get the name from a blockchain identifier.  e.g., Input &#x60;0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045&#x60; and output &#x60;vitalik.eth&#x60;  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">The blockchain you want to use </param>
        /// <param name="network">The network of the blockchain you selected  - Solana: &#x60;devnet&#x60;, &#x60;mainnet-beta&#x60; - Ethereum: &#x60;ropsten&#x60;, &#x60;mainnet&#x60;  Defaults when not provided (not applicable to path parameters): - Solana: &#x60;devnet&#x60; - Ethereum: &#x60;ropsten&#x60;</param>
        /// <param name="inputBlockchainIdentifier"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InputName)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InputName>> GetNameForBlockchainIdentifierWithHttpInfoAsync (string blockchain, string network, InputBlockchainIdentifier inputBlockchainIdentifier = default(InputBlockchainIdentifier), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new ApiException(400, "Missing required parameter 'blockchain' when calling NameServiceApi->GetNameForBlockchainIdentifier");
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling NameServiceApi->GetNameForBlockchainIdentifier");

            var localVarPath = "/{blockchain}/{network}/name_service/blockchain_identifier_to_name";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (blockchain != null) localVarPathParams.Add("blockchain", this.Configuration.ApiClient.ParameterToString(blockchain)); // path parameter
            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (inputBlockchainIdentifier != null && inputBlockchainIdentifier.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputBlockchainIdentifier); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputBlockchainIdentifier; // byte array
            }

            // authentication (APIKeyID) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APIKeyID")))
            {
                localVarHeaderParams["APIKeyID"] = this.Configuration.GetApiKeyWithPrefix("APIKeyID");
            }
            // authentication (APISecretKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("APISecretKey")))
            {
                localVarHeaderParams["APISecretKey"] = this.Configuration.GetApiKeyWithPrefix("APISecretKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNameForBlockchainIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InputName>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InputName) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InputName)));
        }

    }
}
