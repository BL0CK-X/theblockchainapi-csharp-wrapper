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
    /// NFTMintRequest
    /// </summary>
    [DataContract]
    public partial class NFTMintRequest :  IEquatable<NFTMintRequest>, IValidatableObject
    {
        /// <summary>
        /// When you choose &#x60;S3&#x60;, all of the &#x60;name&#x60;, &#x60;description&#x60;, &#x60;symbol&#x60;, &#x60;uri_metadata&#x60;, and &#x60;image_url&#x60; are put into a JSON dictionary and uploaded to S3 as a JSON file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored in the NFT&#39;s account on the blockchain. Learn more  &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  When you choose &#x60;URI&#x60;, the &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.
        /// </summary>
        /// <value>When you choose &#x60;S3&#x60;, all of the &#x60;name&#x60;, &#x60;description&#x60;, &#x60;symbol&#x60;, &#x60;uri_metadata&#x60;, and &#x60;image_url&#x60; are put into a JSON dictionary and uploaded to S3 as a JSON file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored in the NFT&#39;s account on the blockchain. Learn more  &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  When you choose &#x60;URI&#x60;, the &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UploadMethodEnum
        {
            /// <summary>
            /// Enum S3 for value: S3
            /// </summary>
            [EnumMember(Value = "S3")]
            S3 = 1,

            /// <summary>
            /// Enum URI for value: URI
            /// </summary>
            [EnumMember(Value = "URI")]
            URI = 2

        }

        /// <summary>
        /// When you choose &#x60;S3&#x60;, all of the &#x60;name&#x60;, &#x60;description&#x60;, &#x60;symbol&#x60;, &#x60;uri_metadata&#x60;, and &#x60;image_url&#x60; are put into a JSON dictionary and uploaded to S3 as a JSON file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored in the NFT&#39;s account on the blockchain. Learn more  &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  When you choose &#x60;URI&#x60;, the &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.
        /// </summary>
        /// <value>When you choose &#x60;S3&#x60;, all of the &#x60;name&#x60;, &#x60;description&#x60;, &#x60;symbol&#x60;, &#x60;uri_metadata&#x60;, and &#x60;image_url&#x60; are put into a JSON dictionary and uploaded to S3 as a JSON file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored in the NFT&#39;s account on the blockchain. Learn more  &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  When you choose &#x60;URI&#x60;, the &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.</value>
        [DataMember(Name="upload_method", EmitDefaultValue=false)]
        public UploadMethodEnum? UploadMethod { get; set; }
        /// <summary>
        /// This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar). 
        /// </summary>
        /// <value>This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar). </value>
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
        /// This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar). 
        /// </summary>
        /// <value>This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar). </value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public NetworkEnum? Network { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NFTMintRequest" /> class.
        /// </summary>
        /// <param name="wallet">wallet.</param>
        /// <param name="returnCompiledTransaction">If &#x60;true&#x60;, the transaction to mint the NFT will not be submitted or signed. It will be returned to you in a raw form that you can then sign with a wallet (e.g., Phantom) or code. No &#x60;wallet&#x60; authentication information is required (thus, you do you have to supply a seed phrase or private key). See a Python example [here](https://github.com/BL0CK-X/blockchain-api/blob/main/third-party-api-examples/me-buy-sell.py). If &#x60;false&#x60; (the default option), then &#x60;wallet&#x60; is required. We sign and submit the transaction for you, which uses your wallet to mint the NFT. No further action is required on your part, and the NFT is minted. Read more on security [here](#section/Security).  (default to false).</param>
        /// <param name="name">The name of the token. Limited to 32 characters. Stored on the blockchain. (default to &quot;&quot;).</param>
        /// <param name="symbol">The symbol of the token. Limited to 10 characters. Stored on the blockchain. (default to &quot;&quot;).</param>
        /// <param name="description">The description of the NFT. Limited to 2000 characters. Not stored on the blockchain.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no description.  Only provide a value for &#x60;description&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above). (default to &quot;&quot;).</param>
        /// <param name="uploadMethod">When you choose &#x60;S3&#x60;, all of the &#x60;name&#x60;, &#x60;description&#x60;, &#x60;symbol&#x60;, &#x60;uri_metadata&#x60;, and &#x60;image_url&#x60; are put into a JSON dictionary and uploaded to S3 as a JSON file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored in the NFT&#39;s account on the blockchain. Learn more  &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  When you choose &#x60;URI&#x60;, the &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;. (default to UploadMethodEnum.S3).</param>
        /// <param name="uri">The &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   Read more &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.  Only provide a value for &#x60;uri&#x60; if the &#x60;upload_method&#x60; is set to &#x60;URI&#x60; (see the description for &#x60;upload_method&#x60; above). (default to &quot;&quot;).</param>
        /// <param name="imageUrl">The URL of the image of the NFT.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;image_url&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above). (default to &quot;&quot;).</param>
        /// <param name="uriMetadata">The off-chain metadata.        If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;uri_metadata&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).  Learn more about how to format this metadata &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;..</param>
        /// <param name="isMutable">Indicates whether or not the NFT created is mutable. If mutable, the NFT can be updated later. Once set to immutable, the NFT is unable to be changed.  (default to true).</param>
        /// <param name="isMasterEdition">Whether or not the NFT is a master edition NFT. Saves about 0.001 SOL in transaction costs when set to false.  (default to true).</param>
        /// <param name="sellerFeeBasisPoints">Valid values from 0 to 10000. Must be an integer.  Represents the number of basis points that the seller receives as a fee upon sale.  E.g., 100 indicates a 1% seller fee. Seller does not receive a fee when \&quot;primary_sale_has_happened\&quot; is set to true.  Will be set to false after first sale has occurred.  (default to 0M).</param>
        /// <param name="creators">A JSON encoded string representing an array / list.  The designated creators of the NFT. Length of the creator list must match length of the list of share.  Valid lengths of the list range from 1 to 5. Each item in the list must be a valid public key address.    Only the public key corresponding to the seed phrase provided will be marked as verified. Any other creators supplied will be marked as unverified. .</param>
        /// <param name="share">A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100. Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. .</param>
        /// <param name="mintToPublicKey">Assign ownership of the NFT to the public key address given by &#x60;mint_to_public_key&#x60;  (default to &quot;The public key of the wallet provided&quot;).</param>
        /// <param name="network">This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar).  (default to NetworkEnum.Devnet).</param>
        public NFTMintRequest(Wallet wallet = default(Wallet), bool returnCompiledTransaction = false, string name = "", string symbol = "", string description = "", UploadMethodEnum? uploadMethod = UploadMethodEnum.S3, string uri = "", string imageUrl = "", Object uriMetadata = default(Object), bool isMutable = true, bool isMasterEdition = true, decimal sellerFeeBasisPoints = 0M, List<string> creators = default(List<string>), List<int> share = default(List<int>), string mintToPublicKey = "The public key of the wallet provided", NetworkEnum? network = NetworkEnum.Devnet)
        {
            this.Wallet = wallet;
            // use default value if no "returnCompiledTransaction" provided
            if (returnCompiledTransaction == null)
            {
                this.ReturnCompiledTransaction = false;
            }
            else
            {
                this.ReturnCompiledTransaction = returnCompiledTransaction;
            }
            // use default value if no "name" provided
            if (name == null)
            {
                this.Name = "";
            }
            else
            {
                this.Name = name;
            }
            // use default value if no "symbol" provided
            if (symbol == null)
            {
                this.Symbol = "";
            }
            else
            {
                this.Symbol = symbol;
            }
            // use default value if no "description" provided
            if (description == null)
            {
                this.Description = "";
            }
            else
            {
                this.Description = description;
            }
            // use default value if no "uploadMethod" provided
            if (uploadMethod == null)
            {
                this.UploadMethod = UploadMethodEnum.S3;
            }
            else
            {
                this.UploadMethod = uploadMethod;
            }
            // use default value if no "uri" provided
            if (uri == null)
            {
                this.Uri = "";
            }
            else
            {
                this.Uri = uri;
            }
            // use default value if no "imageUrl" provided
            if (imageUrl == null)
            {
                this.ImageUrl = "";
            }
            else
            {
                this.ImageUrl = imageUrl;
            }
            this.UriMetadata = uriMetadata;
            // use default value if no "isMutable" provided
            if (isMutable == null)
            {
                this.IsMutable = true;
            }
            else
            {
                this.IsMutable = isMutable;
            }
            // use default value if no "isMasterEdition" provided
            if (isMasterEdition == null)
            {
                this.IsMasterEdition = true;
            }
            else
            {
                this.IsMasterEdition = isMasterEdition;
            }
            // use default value if no "sellerFeeBasisPoints" provided
            if (sellerFeeBasisPoints == null)
            {
                this.SellerFeeBasisPoints = 0M;
            }
            else
            {
                this.SellerFeeBasisPoints = sellerFeeBasisPoints;
            }
            this.Creators = creators;
            this.Share = share;
            // use default value if no "mintToPublicKey" provided
            if (mintToPublicKey == null)
            {
                this.MintToPublicKey = "The public key of the wallet provided";
            }
            else
            {
                this.MintToPublicKey = mintToPublicKey;
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
        }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public Wallet Wallet { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, the transaction to mint the NFT will not be submitted or signed. It will be returned to you in a raw form that you can then sign with a wallet (e.g., Phantom) or code. No &#x60;wallet&#x60; authentication information is required (thus, you do you have to supply a seed phrase or private key). See a Python example [here](https://github.com/BL0CK-X/blockchain-api/blob/main/third-party-api-examples/me-buy-sell.py). If &#x60;false&#x60; (the default option), then &#x60;wallet&#x60; is required. We sign and submit the transaction for you, which uses your wallet to mint the NFT. No further action is required on your part, and the NFT is minted. Read more on security [here](#section/Security). 
        /// </summary>
        /// <value>If &#x60;true&#x60;, the transaction to mint the NFT will not be submitted or signed. It will be returned to you in a raw form that you can then sign with a wallet (e.g., Phantom) or code. No &#x60;wallet&#x60; authentication information is required (thus, you do you have to supply a seed phrase or private key). See a Python example [here](https://github.com/BL0CK-X/blockchain-api/blob/main/third-party-api-examples/me-buy-sell.py). If &#x60;false&#x60; (the default option), then &#x60;wallet&#x60; is required. We sign and submit the transaction for you, which uses your wallet to mint the NFT. No further action is required on your part, and the NFT is minted. Read more on security [here](#section/Security). </value>
        [DataMember(Name="return_compiled_transaction", EmitDefaultValue=false)]
        public bool ReturnCompiledTransaction { get; set; }

        /// <summary>
        /// The name of the token. Limited to 32 characters. Stored on the blockchain.
        /// </summary>
        /// <value>The name of the token. Limited to 32 characters. Stored on the blockchain.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The symbol of the token. Limited to 10 characters. Stored on the blockchain.
        /// </summary>
        /// <value>The symbol of the token. Limited to 10 characters. Stored on the blockchain.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The description of the NFT. Limited to 2000 characters. Not stored on the blockchain.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no description.  Only provide a value for &#x60;description&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).
        /// </summary>
        /// <value>The description of the NFT. Limited to 2000 characters. Not stored on the blockchain.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no description.  Only provide a value for &#x60;description&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   Read more &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.  Only provide a value for &#x60;uri&#x60; if the &#x60;upload_method&#x60; is set to &#x60;URI&#x60; (see the description for &#x60;upload_method&#x60; above).
        /// </summary>
        /// <value>The &#x60;uri&#x60; you provide is stored on the blockchain, and the &#x60;uri_metadata&#x60;, &#x60;description&#x60;, and &#x60;image_url&#x60; are ignored and not stored anywhere. &#x60;S3&#x60; is NOT involved in this case.   Read more &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  An example of a &#x60;uri&#x60; you would provide is an Arweave URL, like this: &#x60;https://arweave.net/_Y8tETU3FbAFZSM1wXNeWPweWwrW9K6oSF1SYi_bH9A&#x60;.  Only provide a value for &#x60;uri&#x60; if the &#x60;upload_method&#x60; is set to &#x60;URI&#x60; (see the description for &#x60;upload_method&#x60; above).</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The URL of the image of the NFT.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;image_url&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).
        /// </summary>
        /// <value>The URL of the image of the NFT.         If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;image_url&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The off-chain metadata.        If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;uri_metadata&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).  Learn more about how to format this metadata &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.
        /// </summary>
        /// <value>The off-chain metadata.        If you are providing your own &#x60;uri&#x60; (see above), then you do not need to provide this.  If you are not providing your own &#x60;uri&#x60; and you do not provide this, then there wills simply be no image.  Only provide a value for &#x60;uri_metadata&#x60; if the &#x60;upload_method&#x60; is set to &#x60;S3&#x60; (see the description for &#x60;upload_method&#x60; above).  Learn more about how to format this metadata &lt;a href&#x3D;\&quot;https://blockchainapi.com/2022/01/18/how-to-format-off-chain-nft-metadata.html\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.</value>
        [DataMember(Name="uri_metadata", EmitDefaultValue=false)]
        public Object UriMetadata { get; set; }

        /// <summary>
        /// Indicates whether or not the NFT created is mutable. If mutable, the NFT can be updated later. Once set to immutable, the NFT is unable to be changed. 
        /// </summary>
        /// <value>Indicates whether or not the NFT created is mutable. If mutable, the NFT can be updated later. Once set to immutable, the NFT is unable to be changed. </value>
        [DataMember(Name="is_mutable", EmitDefaultValue=false)]
        public bool IsMutable { get; set; }

        /// <summary>
        /// Whether or not the NFT is a master edition NFT. Saves about 0.001 SOL in transaction costs when set to false. 
        /// </summary>
        /// <value>Whether or not the NFT is a master edition NFT. Saves about 0.001 SOL in transaction costs when set to false. </value>
        [DataMember(Name="is_master_edition", EmitDefaultValue=false)]
        public bool IsMasterEdition { get; set; }

        /// <summary>
        /// Valid values from 0 to 10000. Must be an integer.  Represents the number of basis points that the seller receives as a fee upon sale.  E.g., 100 indicates a 1% seller fee. Seller does not receive a fee when \&quot;primary_sale_has_happened\&quot; is set to true.  Will be set to false after first sale has occurred. 
        /// </summary>
        /// <value>Valid values from 0 to 10000. Must be an integer.  Represents the number of basis points that the seller receives as a fee upon sale.  E.g., 100 indicates a 1% seller fee. Seller does not receive a fee when \&quot;primary_sale_has_happened\&quot; is set to true.  Will be set to false after first sale has occurred. </value>
        [DataMember(Name="seller_fee_basis_points", EmitDefaultValue=false)]
        public decimal SellerFeeBasisPoints { get; set; }

        /// <summary>
        /// A JSON encoded string representing an array / list.  The designated creators of the NFT. Length of the creator list must match length of the list of share.  Valid lengths of the list range from 1 to 5. Each item in the list must be a valid public key address.    Only the public key corresponding to the seed phrase provided will be marked as verified. Any other creators supplied will be marked as unverified. 
        /// </summary>
        /// <value>A JSON encoded string representing an array / list.  The designated creators of the NFT. Length of the creator list must match length of the list of share.  Valid lengths of the list range from 1 to 5. Each item in the list must be a valid public key address.    Only the public key corresponding to the seed phrase provided will be marked as verified. Any other creators supplied will be marked as unverified. </value>
        [DataMember(Name="creators", EmitDefaultValue=false)]
        public List<string> Creators { get; set; }

        /// <summary>
        /// A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100. Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. 
        /// </summary>
        /// <value>A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100. Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. </value>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public List<int> Share { get; set; }

        /// <summary>
        /// Assign ownership of the NFT to the public key address given by &#x60;mint_to_public_key&#x60; 
        /// </summary>
        /// <value>Assign ownership of the NFT to the public key address given by &#x60;mint_to_public_key&#x60; </value>
        [DataMember(Name="mint_to_public_key", EmitDefaultValue=false)]
        public string MintToPublicKey { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NFTMintRequest {\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  ReturnCompiledTransaction: ").Append(ReturnCompiledTransaction).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UploadMethod: ").Append(UploadMethod).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  UriMetadata: ").Append(UriMetadata).Append("\n");
            sb.Append("  IsMutable: ").Append(IsMutable).Append("\n");
            sb.Append("  IsMasterEdition: ").Append(IsMasterEdition).Append("\n");
            sb.Append("  SellerFeeBasisPoints: ").Append(SellerFeeBasisPoints).Append("\n");
            sb.Append("  Creators: ").Append(Creators).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  MintToPublicKey: ").Append(MintToPublicKey).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(input as NFTMintRequest);
        }

        /// <summary>
        /// Returns true if NFTMintRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NFTMintRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NFTMintRequest input)
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
                    this.ReturnCompiledTransaction == input.ReturnCompiledTransaction ||
                    (this.ReturnCompiledTransaction != null &&
                    this.ReturnCompiledTransaction.Equals(input.ReturnCompiledTransaction))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UploadMethod == input.UploadMethod ||
                    (this.UploadMethod != null &&
                    this.UploadMethod.Equals(input.UploadMethod))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.UriMetadata == input.UriMetadata ||
                    (this.UriMetadata != null &&
                    this.UriMetadata.Equals(input.UriMetadata))
                ) && 
                (
                    this.IsMutable == input.IsMutable ||
                    (this.IsMutable != null &&
                    this.IsMutable.Equals(input.IsMutable))
                ) && 
                (
                    this.IsMasterEdition == input.IsMasterEdition ||
                    (this.IsMasterEdition != null &&
                    this.IsMasterEdition.Equals(input.IsMasterEdition))
                ) && 
                (
                    this.SellerFeeBasisPoints == input.SellerFeeBasisPoints ||
                    (this.SellerFeeBasisPoints != null &&
                    this.SellerFeeBasisPoints.Equals(input.SellerFeeBasisPoints))
                ) && 
                (
                    this.Creators == input.Creators ||
                    this.Creators != null &&
                    input.Creators != null &&
                    this.Creators.SequenceEqual(input.Creators)
                ) && 
                (
                    this.Share == input.Share ||
                    this.Share != null &&
                    input.Share != null &&
                    this.Share.SequenceEqual(input.Share)
                ) && 
                (
                    this.MintToPublicKey == input.MintToPublicKey ||
                    (this.MintToPublicKey != null &&
                    this.MintToPublicKey.Equals(input.MintToPublicKey))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
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
                if (this.ReturnCompiledTransaction != null)
                    hashCode = hashCode * 59 + this.ReturnCompiledTransaction.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UploadMethod != null)
                    hashCode = hashCode * 59 + this.UploadMethod.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.UriMetadata != null)
                    hashCode = hashCode * 59 + this.UriMetadata.GetHashCode();
                if (this.IsMutable != null)
                    hashCode = hashCode * 59 + this.IsMutable.GetHashCode();
                if (this.IsMasterEdition != null)
                    hashCode = hashCode * 59 + this.IsMasterEdition.GetHashCode();
                if (this.SellerFeeBasisPoints != null)
                    hashCode = hashCode * 59 + this.SellerFeeBasisPoints.GetHashCode();
                if (this.Creators != null)
                    hashCode = hashCode * 59 + this.Creators.GetHashCode();
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.MintToPublicKey != null)
                    hashCode = hashCode * 59 + this.MintToPublicKey.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
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
