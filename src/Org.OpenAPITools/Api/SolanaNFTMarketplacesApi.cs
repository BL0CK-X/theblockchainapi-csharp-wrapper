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
    public interface ISolanaNFTMarketplacesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Buy
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <returns>BuyResponse</returns>
        BuyResponse SolanaBuyNFT (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest));

        /// <summary>
        /// Buy
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <returns>ApiResponse of BuyResponse</returns>
        ApiResponse<BuyResponse> SolanaBuyNFTWithHttpInfo (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest));
        /// <summary>
        /// Delist
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <returns>DelistResponse</returns>
        DelistResponse SolanaDelistNFT (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest));

        /// <summary>
        /// Delist
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <returns>ApiResponse of DelistResponse</returns>
        ApiResponse<DelistResponse> SolanaDelistNFTWithHttpInfo (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest));
        /// <summary>
        /// Get NFT Listing
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <returns>GetNFTListingResponse</returns>
        GetNFTListingResponse SolanaGetNFTListing (string network, string mintAddress);

        /// <summary>
        /// Get NFT Listing
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <returns>ApiResponse of GetNFTListingResponse</returns>
        ApiResponse<GetNFTListingResponse> SolanaGetNFTListingWithHttpInfo (string network, string mintAddress);
        /// <summary>
        /// Get NFT Analytics
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <returns>NFTAnalyticsResponse</returns>
        NFTAnalyticsResponse SolanaGetNFTMarketplaceAnalytics (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest));

        /// <summary>
        /// Get NFT Analytics
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <returns>ApiResponse of NFTAnalyticsResponse</returns>
        ApiResponse<NFTAnalyticsResponse> SolanaGetNFTMarketplaceAnalyticsWithHttpInfo (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest));
        /// <summary>
        /// Get Marketplace Market Share
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object SolanaGetNFTMarketplaceMarketShare ();

        /// <summary>
        /// Get Marketplace Market Share
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SolanaGetNFTMarketplaceMarketShareWithHttpInfo ();
        /// <summary>
        /// Get Recent NFT Transactions
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;NFTTransaction&gt;</returns>
        List<NFTTransaction> SolanaGetNFTMarketplaceRecentTransactions ();

        /// <summary>
        /// Get Recent NFT Transactions
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;NFTTransaction&gt;</returns>
        ApiResponse<List<NFTTransaction>> SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfo ();
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <returns>ListResponse</returns>
        ListResponse SolanaListNFT (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest));

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <returns>ApiResponse of ListResponse</returns>
        ApiResponse<ListResponse> SolanaListNFTWithHttpInfo (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Buy
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of BuyResponse</returns>
        System.Threading.Tasks.Task<BuyResponse> SolanaBuyNFTAsync (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Buy
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (BuyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BuyResponse>> SolanaBuyNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delist
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DelistResponse</returns>
        System.Threading.Tasks.Task<DelistResponse> SolanaDelistNFTAsync (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delist
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DelistResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DelistResponse>> SolanaDelistNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get NFT Listing
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetNFTListingResponse</returns>
        System.Threading.Tasks.Task<GetNFTListingResponse> SolanaGetNFTListingAsync (string network, string mintAddress, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get NFT Listing
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetNFTListingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetNFTListingResponse>> SolanaGetNFTListingWithHttpInfoAsync (string network, string mintAddress, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get NFT Analytics
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of NFTAnalyticsResponse</returns>
        System.Threading.Tasks.Task<NFTAnalyticsResponse> SolanaGetNFTMarketplaceAnalyticsAsync (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get NFT Analytics
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (NFTAnalyticsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NFTAnalyticsResponse>> SolanaGetNFTMarketplaceAnalyticsWithHttpInfoAsync (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Marketplace Market Share
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SolanaGetNFTMarketplaceMarketShareAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Marketplace Market Share
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SolanaGetNFTMarketplaceMarketShareWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Recent NFT Transactions
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;NFTTransaction&gt;</returns>
        System.Threading.Tasks.Task<List<NFTTransaction>> SolanaGetNFTMarketplaceRecentTransactionsAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Recent NFT Transactions
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;NFTTransaction&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NFTTransaction>>> SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListResponse</returns>
        System.Threading.Tasks.Task<ListResponse> SolanaListNFTAsync (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListResponse>> SolanaListNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SolanaNFTMarketplacesApi : ISolanaNFTMarketplacesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaNFTMarketplacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SolanaNFTMarketplacesApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaNFTMarketplacesApi"/> class
        /// </summary>
        /// <returns></returns>
        public SolanaNFTMarketplacesApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaNFTMarketplacesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SolanaNFTMarketplacesApi(Org.OpenAPITools.Client.Configuration configuration = null)
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
        /// Buy &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <returns>BuyResponse</returns>
        public BuyResponse SolanaBuyNFT (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest))
        {
             ApiResponse<BuyResponse> localVarResponse = SolanaBuyNFTWithHttpInfo(network, exchange, mintAddress, buyRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Buy &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <returns>ApiResponse of BuyResponse</returns>
        public ApiResponse<BuyResponse> SolanaBuyNFTWithHttpInfo (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/buy/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (buyRequest != null && buyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(buyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = buyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaBuyNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BuyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BuyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BuyResponse)));
        }

        /// <summary>
        /// Buy &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of BuyResponse</returns>
        public async System.Threading.Tasks.Task<BuyResponse> SolanaBuyNFTAsync (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<BuyResponse> localVarResponse = await SolanaBuyNFTWithHttpInfoAsync(network, exchange, mintAddress, buyRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Buy &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/buy-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Buy an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Edennpm  &#x60;Cost: 25 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="buyRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (BuyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BuyResponse>> SolanaBuyNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, BuyRequest buyRequest = default(BuyRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaBuyNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/buy/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (buyRequest != null && buyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(buyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = buyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaBuyNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BuyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BuyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BuyResponse)));
        }

        /// <summary>
        /// Delist &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <returns>DelistResponse</returns>
        public DelistResponse SolanaDelistNFT (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest))
        {
             ApiResponse<DelistResponse> localVarResponse = SolanaDelistNFTWithHttpInfo(network, exchange, mintAddress, delistRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delist &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <returns>ApiResponse of DelistResponse</returns>
        public ApiResponse<DelistResponse> SolanaDelistNFTWithHttpInfo (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/delist/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (delistRequest != null && delistRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(delistRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = delistRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDelistNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DelistResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DelistResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DelistResponse)));
        }

        /// <summary>
        /// Delist &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DelistResponse</returns>
        public async System.Threading.Tasks.Task<DelistResponse> SolanaDelistNFTAsync (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<DelistResponse> localVarResponse = await SolanaDelistNFTWithHttpInfoAsync(network, exchange, mintAddress, delistRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delist &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/delist-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Delist an NFT from a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 8 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="delistRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DelistResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DelistResponse>> SolanaDelistNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, DelistRequest delistRequest = default(DelistRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaDelistNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/delist/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (delistRequest != null && delistRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(delistRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = delistRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDelistNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DelistResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DelistResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DelistResponse)));
        }

        /// <summary>
        /// Get NFT Listing &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <returns>GetNFTListingResponse</returns>
        public GetNFTListingResponse SolanaGetNFTListing (string network, string mintAddress)
        {
             ApiResponse<GetNFTListingResponse> localVarResponse = SolanaGetNFTListingWithHttpInfo(network, mintAddress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get NFT Listing &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <returns>ApiResponse of GetNFTListingResponse</returns>
        public ApiResponse<GetNFTListingResponse> SolanaGetNFTListingWithHttpInfo (string network, string mintAddress)
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaGetNFTListing");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaGetNFTListing");

            var localVarPath = "/solana/nft/marketplaces/listing/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetNFTListing", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetNFTListingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetNFTListingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetNFTListingResponse)));
        }

        /// <summary>
        /// Get NFT Listing &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetNFTListingResponse</returns>
        public async System.Threading.Tasks.Task<GetNFTListingResponse> SolanaGetNFTListingAsync (string network, string mintAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<GetNFTListingResponse> localVarResponse = await SolanaGetNFTListingWithHttpInfoAsync(network, mintAddress, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get NFT Listing &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/get-nft-listing\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 1 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetNFTListingResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetNFTListingResponse>> SolanaGetNFTListingWithHttpInfoAsync (string network, string mintAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaGetNFTListing");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaGetNFTListing");

            var localVarPath = "/solana/nft/marketplaces/listing/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetNFTListing", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetNFTListingResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetNFTListingResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetNFTListingResponse)));
        }

        /// <summary>
        /// Get NFT Analytics &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <returns>NFTAnalyticsResponse</returns>
        public NFTAnalyticsResponse SolanaGetNFTMarketplaceAnalytics (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest))
        {
             ApiResponse<NFTAnalyticsResponse> localVarResponse = SolanaGetNFTMarketplaceAnalyticsWithHttpInfo(nFTAnalyticsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get NFT Analytics &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <returns>ApiResponse of NFTAnalyticsResponse</returns>
        public ApiResponse<NFTAnalyticsResponse> SolanaGetNFTMarketplaceAnalyticsWithHttpInfo (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest))
        {

            var localVarPath = "/solana/nft/marketplaces/analytics";
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

            if (nFTAnalyticsRequest != null && nFTAnalyticsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(nFTAnalyticsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = nFTAnalyticsRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NFTAnalyticsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (NFTAnalyticsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NFTAnalyticsResponse)));
        }

        /// <summary>
        /// Get NFT Analytics &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of NFTAnalyticsResponse</returns>
        public async System.Threading.Tasks.Task<NFTAnalyticsResponse> SolanaGetNFTMarketplaceAnalyticsAsync (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<NFTAnalyticsResponse> localVarResponse = await SolanaGetNFTMarketplaceAnalyticsWithHttpInfoAsync(nFTAnalyticsRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get NFT Analytics &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/analytics\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  A collection is a list of NFTs.  Any collection can thus be defined as a list of mint addresses.  This endpoint takes in a list of mint addresses (effectively, a collection), a start time (optional), and an end time (optional) and outputs the floor for that period, the volume for that period, and the transaction history for each NFT in the list (buy, list, delist, update price) for that period.  We are currently compiling a dictionary of collection names to list of mint addresses for public use. Please contribute &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/solana-nft-collection-mint-addresses\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  Currently scans the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nFTAnalyticsRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (NFTAnalyticsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NFTAnalyticsResponse>> SolanaGetNFTMarketplaceAnalyticsWithHttpInfoAsync (NFTAnalyticsRequest nFTAnalyticsRequest = default(NFTAnalyticsRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/nft/marketplaces/analytics";
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

            if (nFTAnalyticsRequest != null && nFTAnalyticsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(nFTAnalyticsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = nFTAnalyticsRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NFTAnalyticsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (NFTAnalyticsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NFTAnalyticsResponse)));
        }

        /// <summary>
        /// Get Marketplace Market Share &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object SolanaGetNFTMarketplaceMarketShare ()
        {
             ApiResponse<Object> localVarResponse = SolanaGetNFTMarketplaceMarketShareWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Marketplace Market Share &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> SolanaGetNFTMarketplaceMarketShareWithHttpInfo ()
        {

            var localVarPath = "/solana/nft/marketplaces/analytics/market_share";
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceMarketShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get Marketplace Market Share &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SolanaGetNFTMarketplaceMarketShareAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Object> localVarResponse = await SolanaGetNFTMarketplaceMarketShareWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Marketplace Market Share &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/market-share\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get the Marketplace listing of a Solana NFT.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 3 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SolanaGetNFTMarketplaceMarketShareWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/nft/marketplaces/analytics/market_share";
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceMarketShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get Recent NFT Transactions &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;NFTTransaction&gt;</returns>
        public List<NFTTransaction> SolanaGetNFTMarketplaceRecentTransactions ()
        {
             ApiResponse<List<NFTTransaction>> localVarResponse = SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Recent NFT Transactions &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;NFTTransaction&gt;</returns>
        public ApiResponse<List<NFTTransaction>> SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfo ()
        {

            var localVarPath = "/solana/nft/marketplaces/analytics/recent_transactions";
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceRecentTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<NFTTransaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<NFTTransaction>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NFTTransaction>)));
        }

        /// <summary>
        /// Get Recent NFT Transactions &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;NFTTransaction&gt;</returns>
        public async System.Threading.Tasks.Task<List<NFTTransaction>> SolanaGetNFTMarketplaceRecentTransactionsAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<NFTTransaction>> localVarResponse = await SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Recent NFT Transactions &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/recent-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Get all NFT transactions across all major marketplaces in the last 30 minutes.  Currently checks for the following Solana NFT martketplaces: SolSea, Magic Eden, Solanart, Alpha Art, Digital Eyes, Exchange.art  &#x60;Cost: 15 Credits&#x60;, (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;NFTTransaction&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NFTTransaction>>> SolanaGetNFTMarketplaceRecentTransactionsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/nft/marketplaces/analytics/recent_transactions";
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
                Exception exception = ExceptionFactory("SolanaGetNFTMarketplaceRecentTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<NFTTransaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<NFTTransaction>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NFTTransaction>)));
        }

        /// <summary>
        /// List &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <returns>ListResponse</returns>
        public ListResponse SolanaListNFT (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest))
        {
             ApiResponse<ListResponse> localVarResponse = SolanaListNFTWithHttpInfo(network, exchange, mintAddress, listRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <returns>ApiResponse of ListResponse</returns>
        public ApiResponse<ListResponse> SolanaListNFTWithHttpInfo (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaListNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaListNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaListNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/list/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (listRequest != null && listRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(listRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = listRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaListNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListResponse)));
        }

        /// <summary>
        /// List &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListResponse</returns>
        public async System.Threading.Tasks.Task<ListResponse> SolanaListNFTAsync (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ListResponse> localVarResponse = await SolanaListNFTWithHttpInfoAsync(network, exchange, mintAddress, listRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-nft-marketplaces/list-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  List an NFT on a Solana Exchange.  Exchanges supported: SolSea, Magic Eden  &#x60;Cost: 12 Credits&#x60;, &#x60;Cost: 3 Credits on Devnet&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID</param>
        /// <param name="exchange">The NFT exchange to interact with</param>
        /// <param name="mintAddress">The mint address of the NFT you want to buy</param>
        /// <param name="listRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListResponse>> SolanaListNFTWithHttpInfoAsync (string network, string exchange, string mintAddress, ListRequest listRequest = default(ListRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaNFTMarketplacesApi->SolanaListNFT");
            // verify the required parameter 'exchange' is set
            if (exchange == null)
                throw new ApiException(400, "Missing required parameter 'exchange' when calling SolanaNFTMarketplacesApi->SolanaListNFT");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaNFTMarketplacesApi->SolanaListNFT");

            var localVarPath = "/solana/nft/marketplaces/{exchange}/list/{network}/{mint_address}";
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

            if (network != null) localVarPathParams.Add("network", this.Configuration.ApiClient.ParameterToString(network)); // path parameter
            if (exchange != null) localVarPathParams.Add("exchange", this.Configuration.ApiClient.ParameterToString(exchange)); // path parameter
            if (mintAddress != null) localVarPathParams.Add("mint_address", this.Configuration.ApiClient.ParameterToString(mintAddress)); // path parameter
            if (listRequest != null && listRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(listRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = listRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaListNFT", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListResponse)));
        }

    }
}
