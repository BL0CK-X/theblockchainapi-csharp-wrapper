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
    public interface IEndpointApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns></returns>
        void DeleteEndpoint (EndpointReference endpointReference = default(EndpointReference));

        /// <summary>
        /// Delete an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEndpointWithHttpInfo (EndpointReference endpointReference = default(EndpointReference));
        /// <summary>
        /// Get an endpoint&#39;s metadata 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>Endpoint</returns>
        Endpoint GetEndpoint (EndpointReference endpointReference = default(EndpointReference));

        /// <summary>
        /// Get an endpoint&#39;s metadata 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> GetEndpointWithHttpInfo (EndpointReference endpointReference = default(EndpointReference));
        /// <summary>
        /// List all endpoints 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Endpoint&gt;</returns>
        List<Endpoint> ListEndpoints ();

        /// <summary>
        /// List all endpoints 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Endpoint&gt;</returns>
        ApiResponse<List<Endpoint>> ListEndpointsWithHttpInfo ();
        /// <summary>
        /// Create / update an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <returns>Endpoint</returns>
        Endpoint SetEndpoint (Endpoint endpoint = default(Endpoint));

        /// <summary>
        /// Create / update an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> SetEndpointWithHttpInfo (Endpoint endpoint = default(Endpoint));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEndpointAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEndpointWithHttpInfoAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an endpoint&#39;s metadata 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> GetEndpointAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get an endpoint&#39;s metadata 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointWithHttpInfoAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all endpoints 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Endpoint&gt;</returns>
        System.Threading.Tasks.Task<List<Endpoint>> ListEndpointsAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all endpoints 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Endpoint&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Endpoint>>> ListEndpointsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create / update an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> SetEndpointAsync (Endpoint endpoint = default(Endpoint), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create / update an endpoint 
        /// </summary>
        /// <remarks>
        /// A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> SetEndpointWithHttpInfoAsync (Endpoint endpoint = default(Endpoint), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EndpointApi : IEndpointApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EndpointApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointApi"/> class
        /// </summary>
        /// <returns></returns>
        public EndpointApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EndpointApi(Org.OpenAPITools.Client.Configuration configuration = null)
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
        /// Delete an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns></returns>
        public void DeleteEndpoint (EndpointReference endpointReference = default(EndpointReference))
        {
             DeleteEndpointWithHttpInfo(endpointReference);
        }

        /// <summary>
        /// Delete an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEndpointWithHttpInfo (EndpointReference endpointReference = default(EndpointReference))
        {

            var localVarPath = "/endpoint/delete";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (endpointReference != null && endpointReference.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpointReference); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpointReference; // byte array
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
                Exception exception = ExceptionFactory("DeleteEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEndpointAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteEndpointWithHttpInfoAsync(endpointReference, cancellationToken);

        }

        /// <summary>
        /// Delete an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Deletes an endpoint from a project. This endpoint removes the endpoint from the project&#39;s documentation. However, this does un-deploy the endpoint. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEndpointWithHttpInfoAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/endpoint/delete";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (endpointReference != null && endpointReference.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpointReference); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpointReference; // byte array
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
                Exception exception = ExceptionFactory("DeleteEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get an endpoint&#39;s metadata  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>Endpoint</returns>
        public Endpoint GetEndpoint (EndpointReference endpointReference = default(EndpointReference))
        {
             ApiResponse<Endpoint> localVarResponse = GetEndpointWithHttpInfo(endpointReference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an endpoint&#39;s metadata  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse<Endpoint> GetEndpointWithHttpInfo (EndpointReference endpointReference = default(EndpointReference))
        {

            var localVarPath = "/endpoint/metadata";
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

            if (endpointReference != null && endpointReference.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpointReference); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpointReference; // byte array
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
                Exception exception = ExceptionFactory("GetEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Endpoint) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
        }

        /// <summary>
        /// Get an endpoint&#39;s metadata  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> GetEndpointAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Endpoint> localVarResponse = await GetEndpointWithHttpInfoAsync(endpointReference, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an endpoint&#39;s metadata  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Get an endpoint&#39;s metadata from a project.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointReference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointWithHttpInfoAsync (EndpointReference endpointReference = default(EndpointReference), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/endpoint/metadata";
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

            if (endpointReference != null && endpointReference.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpointReference); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpointReference; // byte array
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
                Exception exception = ExceptionFactory("GetEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Endpoint) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
        }

        /// <summary>
        /// List all endpoints  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Endpoint&gt;</returns>
        public List<Endpoint> ListEndpoints ()
        {
             ApiResponse<List<Endpoint>> localVarResponse = ListEndpointsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List all endpoints  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Endpoint&gt;</returns>
        public ApiResponse<List<Endpoint>> ListEndpointsWithHttpInfo ()
        {

            var localVarPath = "/endpoint/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListEndpoints", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Endpoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Endpoint>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Endpoint>)));
        }

        /// <summary>
        /// List all endpoints  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Endpoint&gt;</returns>
        public async System.Threading.Tasks.Task<List<Endpoint>> ListEndpointsAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Endpoint>> localVarResponse = await ListEndpointsWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List all endpoints  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  List all endpoints that you have added under your account.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Endpoint&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Endpoint>>> ListEndpointsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/endpoint/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListEndpoints", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Endpoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Endpoint>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Endpoint>)));
        }

        /// <summary>
        /// Create / update an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <returns>Endpoint</returns>
        public Endpoint SetEndpoint (Endpoint endpoint = default(Endpoint))
        {
             ApiResponse<Endpoint> localVarResponse = SetEndpointWithHttpInfo(endpoint);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create / update an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse<Endpoint> SetEndpointWithHttpInfo (Endpoint endpoint = default(Endpoint))
        {

            var localVarPath = "/endpoint";
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

            if (endpoint != null && endpoint.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpoint); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpoint; // byte array
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
                Exception exception = ExceptionFactory("SetEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Endpoint) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
        }

        /// <summary>
        /// Create / update an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> SetEndpointAsync (Endpoint endpoint = default(Endpoint), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Endpoint> localVarResponse = await SetEndpointWithHttpInfoAsync(endpoint, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create / update an endpoint  A complete example and walkthrough of the program can be found &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/api-developer-program\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Create or update an &#x60;endpoint&#x60; for a &#x60;project&#x60;.   An &#x60;endpoint&#x60; is a function that is a part of a mini-API &#x60;project&#x60;.  This endpoint adds the &#x60;endpoint&#x60; to the &#x60;project&#x60;&#39;s documentation. However, this does not deploy the &#x60;endpoint&#x60;. To do so, you must &lt;a href&#x3D;\&quot;#operation/deployProject\&quot;&gt;deploy the project&lt;/a&gt;.  All attributes except &#x60;group_name&#x60; are required if **creating** an &#x60;endpoint&#x60;.  Only &#x60;path&#x60;, &#x60;project_id&#x60;, and &#x60;version&#x60; are required if **updating** an &#x60;endpoint&#x60;.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpoint"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> SetEndpointWithHttpInfoAsync (Endpoint endpoint = default(Endpoint), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/endpoint";
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

            if (endpoint != null && endpoint.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(endpoint); // http body (model) parameter
            }
            else
            {
                localVarPostBody = endpoint; // byte array
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
                Exception exception = ExceptionFactory("SetEndpoint", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Endpoint) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
        }

    }
}
