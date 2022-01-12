/*
 * The Blockchain API
 *
 * # About  Our vision is to make it super easy to interact with the decentralized web. We want you to be able to do this in any coding language and do it easily and quickly.   You're a key part of our vision. We love feature requests! <a href=\"#section/Feature-Requests\">Make one!</a>  # How to Use the API  To use the API, you simply need to create an API key pair.  Doing so takes less than a minute. Simply go to <a target=\"_blank\" href=\"https://dashboard.blockchainapi.com\">the dashboard</a>, create an account, and generate a key pair. You can now use this pair to make API requests. You must create your first pair via the dashboard.  # Feature Requests  Got a feature request? Submit it as an issue on <a target=\"_blank\" href=\"https://github.com/BL0CK-X/the-blockchain-api/issues/new/choose\">our GitHub repo</a> or [email us](mailto:info@blockchainapi.com).  # Contact  <figure>     <img          width=\"40px\"         height=\"40px\"          src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/phone.svg\"     />     <figcaption style=\"textAlign:center;\">Text / Call: +1 (415) 888 4745 </figcaption> </figure> <a href=\"mailto:info@blockchainapi.com\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/email.svg\"         />         <figcaption style=\"textAlign:center;\">Email us: info@blockchainapi.com</figcaption>     </figure> </a> <a href=\"https://discord.gg/d49yzrZRAF\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/discord.svg\"         />         <figcaption style=\"textAlign:center;\">Join our Discord</figcaption>     </figure> </a> <a href=\"https://twitter.com/_BlockX_\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/twitter.svg\"         />          <figcaption style=\"textAlign:center;\">Follow us on Twitter</figcaption>     </figure> </a> <a href=\"https://github.com/BL0CK-X/the-blockchain-api\" target=\"_blank\">     <figure>         <img              width=\"40px\"             height=\"40px\"              src=\"https://theblockchainapi-docs.s3.amazonaws.com/icons/github.svg\"         />         <figcaption style=\"textAlign:center;\">Star us on Github</figcaption>     </figure> </a>  # Security  Common dogma is to never give out your seed phrase. We agree. It's a matter of security, and anyone who has your seed phrase can irreversibly empty your wallet.   <b>When using an API endpoint that requires a seed phrase, we highly recommend that users use or create a wallet that they do not use as their primary wallet.</b>   How you make this work depends on what you're doing. If you're minting an NFT for example, we recommend creating a new wallet and then transferring just enough SOL to that wallet to mint the NFT. This is possible on Solana because such transactions cost less than a penny. We will have more tutorials in the future that make it easier for you to be secure when using our API.  We have easy-to-use endpoints for <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1secret_recovery_phrase/post\">creating a new seed phrase</a> and then <a href=\"#tag/Solana-Wallet/paths/~1solana~1wallet~1public_key/post\">deriving a public key</a> to enable you to transfer to that new wallet.  Let's have a constructive dialog about this. Feel free to <a href=\"#section/Contact\">contact us</a>. I made a video discussing this matter <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.  Note: We have had a couple of individuals harrass and threaten us. These individuals did <b>not</b> try our API or speak to anyone who has used it. They simply saw that we require a seed phrase for certain endpoints and figured that the proper response was to attack us. (I explain why we do <a target=\"_blank\" href=\"https://youtu.be/m9unUb8Z9qU\">here</a>.) Such harrassment and threats are not only harmful, but they are also illegal, and we will report offenders. Do not harrass us. Rather, feel free to discuss your concerns with us and we will be more than happy to work with you to come up with a solution.  # Pricing  <b>Each user receives 500 free credits.</b>  You can learn more about our pricing <a href=\"https://dashboard.blockchainapi.com/billing\" target=\"_blank\">here</a>.   We frequently do custom plans. If our pricing doesn't work for you, <a href=\"#section/Contact\">contact us</a>.  If you have questions, concerns, feedback, or ideas, <a href=\"#section/Contact\">contact us</a>.  # SDKs / API Wrappers  We have examples using both our <a href=\"https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples\" target=\"_blank\">Python wrapper and our JavaScript wrapper here</a>.  We have built a custom <a href=\"https://github.com/BL0CK-X/the-blockchain-api-python-wrapper\" target=\"_blank\">Python wrapper</a>.  `pip install theblockchainapi`  We also have published a <a href=\"https://github.com/BL0CK-X/theblockchainapi-javascript-wrapper\" target=\"_blank\">JavaScript Wrapper</a>.  `npm install theblockchainapi`  We also have auto-generated wrappers for the following languages: - <a href=\"https://github.com/BL0CK-X/theblockchainapi-go-wrapper\" target = \"_blank\">Go</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-java-wrapper\" target = \"_blank\">Java</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-kotlin-wrapper\" target = \"_blank\">Kotlin</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-php-wrapper\" target = \"_blank\">PHP</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-swift-wrapper\" target = \"_blank\">Swift5</a> - <a href=\"https://github.com/BL0CK-X/theblockchainapi-typescript-wrapper\" target = \"_blank\">TypeScript</a>  If you would like a different language as well, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.  If you run into any bugs with the wrappers, submit an issue <a href=\"https://github.com/BL0CK-X/theblockchainapi-wrappers/issues/new\" target=\"_blank\">here</a>.
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
        /// When you choose S3, all of the nft_description, nft_name, nft_symbol, nft_metadata, and nft_url are put into a json dictionary and uploaded to S3 as a text file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored on the NFT on the blockchain.   When you choose LINK, the nft_url you provide is stored on the blockchain, and the nft_metadata and nft_description are ignored and not stored anywhere. S3 is then NOT used. 
        /// </summary>
        /// <value>When you choose S3, all of the nft_description, nft_name, nft_symbol, nft_metadata, and nft_url are put into a json dictionary and uploaded to S3 as a text file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored on the NFT on the blockchain.   When you choose LINK, the nft_url you provide is stored on the blockchain, and the nft_metadata and nft_description are ignored and not stored anywhere. S3 is then NOT used. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NftUploadMethodEnum
        {
            /// <summary>
            /// Enum S3 for value: S3
            /// </summary>
            [EnumMember(Value = "S3")]
            S3 = 1,

            /// <summary>
            /// Enum LINK for value: LINK
            /// </summary>
            [EnumMember(Value = "LINK")]
            LINK = 2

        }

        /// <summary>
        /// When you choose S3, all of the nft_description, nft_name, nft_symbol, nft_metadata, and nft_url are put into a json dictionary and uploaded to S3 as a text file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored on the NFT on the blockchain.   When you choose LINK, the nft_url you provide is stored on the blockchain, and the nft_metadata and nft_description are ignored and not stored anywhere. S3 is then NOT used. 
        /// </summary>
        /// <value>When you choose S3, all of the nft_description, nft_name, nft_symbol, nft_metadata, and nft_url are put into a json dictionary and uploaded to S3 as a text file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored on the NFT on the blockchain.   When you choose LINK, the nft_url you provide is stored on the blockchain, and the nft_metadata and nft_description are ignored and not stored anywhere. S3 is then NOT used. </value>
        [DataMember(Name="nft_upload_method", EmitDefaultValue=false)]
        public NftUploadMethodEnum? NftUploadMethod { get; set; }
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
        [JsonConstructorAttribute]
        protected NFTMintRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NFTMintRequest" /> class.
        /// </summary>
        /// <param name="wallet">wallet (required).</param>
        /// <param name="nftName">The name of the token. Limited to 32 characters. Stored on the blockchain. (default to &quot;&quot;).</param>
        /// <param name="nftSymbol">The symbol of the token. Limited to 10 characters. Stored on the blockchain. (default to &quot;&quot;).</param>
        /// <param name="nftDescription">The description of the token. Limited to 2000 characters. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_description is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL.  (default to &quot;&quot;).</param>
        /// <param name="nftUrl">The URL you provided. Limited to 200 characters. This does not need to be a valid URL. Whether or not this is  stored on the blockchain depends on which upload method you choose. If you choose LINK, then this is stored on the  blockchain directly. If you choose S3, then this link is embedded in a public S3 text file that also contains the metadata, the name,  the symbol, and the description of the NFT.  (default to &quot;&quot;).</param>
        /// <param name="nftMetadata">Any data you provide. Must be a string and properly encoded json. Will be viewable on S3. Limited to 2000 bytes. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_metadata is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL.  (default to &quot;{}&quot;).</param>
        /// <param name="nftUploadMethod">When you choose S3, all of the nft_description, nft_name, nft_symbol, nft_metadata, and nft_url are put into a json dictionary and uploaded to S3 as a text file.  This is uploaded to an AWS S3 bucket we own, and is an option we provide at no charge. The S3 link to this file is stored on the NFT on the blockchain.   When you choose LINK, the nft_url you provide is stored on the blockchain, and the nft_metadata and nft_description are ignored and not stored anywhere. S3 is then NOT used.  (default to NftUploadMethodEnum.S3).</param>
        /// <param name="isMutable">Indicates whether or not the NFT created is mutable. If mutable, the NFT can be updated later. Once set to immutable, the NFT is unable to be changed.  (default to true).</param>
        /// <param name="isMasterEdition">Whether or not the NFT is a master edition NFT. Saves about 0.001 SOL in transaction costs when set to false.  (default to true).</param>
        /// <param name="sellerFeeBasisPoints">Valid values from 0 to 10000. Must be an integer.  Represents the number of basis points that the seller receives as a fee upon sale.  E.g., 100 indicates a 1% seller fee. Seller does not receive a fee when \&quot;primary_sale_has_happened\&quot; is set to true.  Will be set to false after first sale has occurred.  (default to 0M).</param>
        /// <param name="creators">A JSON encoded string representing an array / list.  The designated creators of the NFT. Length of the creator list must match length of the list of share.  Valid lengths of the list range from 1 to 5. Each item in the list must be a valid public key address.    Only the public key corresponding to the seed phrase provided will be marked as verified. Any other creators supplied will be marked as unverified. .</param>
        /// <param name="share">A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100.  Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. .</param>
        /// <param name="mintToPublicKey">Assign ownership of the NFT to the public key address given by &#x60;mint_to_public_key&#x60;  (default to &quot;The public key of the wallet provided&quot;).</param>
        /// <param name="network">This determines which network you choose to run the API calls on. We recommend first testing on the devnet, because minting an NFT costs a little above 0.01 SOL, which is about $1.60 at the time of this writing.  When you run on the mainnet-beta, each successful call will deduct approximately that much. When you run on the devnet, that amount is deducted from a simulated amount, so you are not paying with real SOL. To get SOL on the devnet,   airdrop SOL to this address using the CLI. Keep in mind that you can only do this every so often. If you are rate-limited, consider using a VPN and trying again, or just waiting. To get SOL on the mainnet-beta, you    must transfer real SOL to this account from another wallet (e.g., from another wallet you own, from an exchange, etc.). We hope to make this process easier in the future, and if you have any suggestions, please add them    as an issue on our &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api\&quot; target&#x3D;\&quot;_blank\&quot;&gt;GitHub repository&lt;/a&gt; for the API. To get a fee estimate, make a GET requests to the &lt;a href&#x3D;\&quot;#tag/Solana-NFT/paths/~1solana~1nft~1mint~1fee/get\&quot;&gt;v1/solana/nft/mint/fee endpoint&lt;/a&gt; (details in sidebar).  (default to NetworkEnum.Devnet).</param>
        public NFTMintRequest(Wallet wallet = default(Wallet), string nftName = "", string nftSymbol = "", string nftDescription = "", string nftUrl = "", string nftMetadata = "{}", NftUploadMethodEnum? nftUploadMethod = NftUploadMethodEnum.S3, bool isMutable = true, bool isMasterEdition = true, decimal sellerFeeBasisPoints = 0M, List<string> creators = default(List<string>), List<int> share = default(List<int>), string mintToPublicKey = "The public key of the wallet provided", NetworkEnum? network = NetworkEnum.Devnet)
        {
            // to ensure "wallet" is required (not null)
            if (wallet == null)
            {
                throw new InvalidDataException("wallet is a required property for NFTMintRequest and cannot be null");
            }
            else
            {
                this.Wallet = wallet;
            }

            // use default value if no "nftName" provided
            if (nftName == null)
            {
                this.NftName = "";
            }
            else
            {
                this.NftName = nftName;
            }
            // use default value if no "nftSymbol" provided
            if (nftSymbol == null)
            {
                this.NftSymbol = "";
            }
            else
            {
                this.NftSymbol = nftSymbol;
            }
            // use default value if no "nftDescription" provided
            if (nftDescription == null)
            {
                this.NftDescription = "";
            }
            else
            {
                this.NftDescription = nftDescription;
            }
            // use default value if no "nftUrl" provided
            if (nftUrl == null)
            {
                this.NftUrl = "";
            }
            else
            {
                this.NftUrl = nftUrl;
            }
            // use default value if no "nftMetadata" provided
            if (nftMetadata == null)
            {
                this.NftMetadata = "{}";
            }
            else
            {
                this.NftMetadata = nftMetadata;
            }
            // use default value if no "nftUploadMethod" provided
            if (nftUploadMethod == null)
            {
                this.NftUploadMethod = NftUploadMethodEnum.S3;
            }
            else
            {
                this.NftUploadMethod = nftUploadMethod;
            }
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
        [DataMember(Name="wallet", EmitDefaultValue=true)]
        public Wallet Wallet { get; set; }

        /// <summary>
        /// The name of the token. Limited to 32 characters. Stored on the blockchain.
        /// </summary>
        /// <value>The name of the token. Limited to 32 characters. Stored on the blockchain.</value>
        [DataMember(Name="nft_name", EmitDefaultValue=false)]
        public string NftName { get; set; }

        /// <summary>
        /// The symbol of the token. Limited to 10 characters. Stored on the blockchain.
        /// </summary>
        /// <value>The symbol of the token. Limited to 10 characters. Stored on the blockchain.</value>
        [DataMember(Name="nft_symbol", EmitDefaultValue=false)]
        public string NftSymbol { get; set; }

        /// <summary>
        /// The description of the token. Limited to 2000 characters. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_description is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL. 
        /// </summary>
        /// <value>The description of the token. Limited to 2000 characters. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_description is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL. </value>
        [DataMember(Name="nft_description", EmitDefaultValue=false)]
        public string NftDescription { get; set; }

        /// <summary>
        /// The URL you provided. Limited to 200 characters. This does not need to be a valid URL. Whether or not this is  stored on the blockchain depends on which upload method you choose. If you choose LINK, then this is stored on the  blockchain directly. If you choose S3, then this link is embedded in a public S3 text file that also contains the metadata, the name,  the symbol, and the description of the NFT. 
        /// </summary>
        /// <value>The URL you provided. Limited to 200 characters. This does not need to be a valid URL. Whether or not this is  stored on the blockchain depends on which upload method you choose. If you choose LINK, then this is stored on the  blockchain directly. If you choose S3, then this link is embedded in a public S3 text file that also contains the metadata, the name,  the symbol, and the description of the NFT. </value>
        [DataMember(Name="nft_url", EmitDefaultValue=false)]
        public string NftUrl { get; set; }

        /// <summary>
        /// Any data you provide. Must be a string and properly encoded json. Will be viewable on S3. Limited to 2000 bytes. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_metadata is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL. 
        /// </summary>
        /// <value>Any data you provide. Must be a string and properly encoded json. Will be viewable on S3. Limited to 2000 bytes. Not stored on the blockchain.  This is stored in S3 in a bucket we own, and the link to that file is stored on the blockchain.  If you provide your own link, the link is also stored in that S3 file, which is publicly accessible. However, if you choose the NFT upload method \&quot;LINK\&quot; instead of \&quot;S3\&quot;, then we upload the link you  provide for nft_url directly to the blockchain, and S3 is not used at all. Thus, when you provide the \&quot;LINK\&quot; option, the value nft_metadata is ignored and not used. The Metaplex API does not provide functionality to store any data about your NFT besides a URL. </value>
        [DataMember(Name="nft_metadata", EmitDefaultValue=false)]
        public string NftMetadata { get; set; }


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
        /// A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100.  Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. 
        /// </summary>
        /// <value>A JSON encoded string representing an array / list.  The share of the royalty that each creator gets. Valid values range from 0 to 100.  Sum of the values must equal 100.  Only integer value accepted. Length of the share list must match length of the list of creators. </value>
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
            sb.Append("  NftName: ").Append(NftName).Append("\n");
            sb.Append("  NftSymbol: ").Append(NftSymbol).Append("\n");
            sb.Append("  NftDescription: ").Append(NftDescription).Append("\n");
            sb.Append("  NftUrl: ").Append(NftUrl).Append("\n");
            sb.Append("  NftMetadata: ").Append(NftMetadata).Append("\n");
            sb.Append("  NftUploadMethod: ").Append(NftUploadMethod).Append("\n");
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
                    this.NftName == input.NftName ||
                    (this.NftName != null &&
                    this.NftName.Equals(input.NftName))
                ) && 
                (
                    this.NftSymbol == input.NftSymbol ||
                    (this.NftSymbol != null &&
                    this.NftSymbol.Equals(input.NftSymbol))
                ) && 
                (
                    this.NftDescription == input.NftDescription ||
                    (this.NftDescription != null &&
                    this.NftDescription.Equals(input.NftDescription))
                ) && 
                (
                    this.NftUrl == input.NftUrl ||
                    (this.NftUrl != null &&
                    this.NftUrl.Equals(input.NftUrl))
                ) && 
                (
                    this.NftMetadata == input.NftMetadata ||
                    (this.NftMetadata != null &&
                    this.NftMetadata.Equals(input.NftMetadata))
                ) && 
                (
                    this.NftUploadMethod == input.NftUploadMethod ||
                    (this.NftUploadMethod != null &&
                    this.NftUploadMethod.Equals(input.NftUploadMethod))
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
                if (this.NftName != null)
                    hashCode = hashCode * 59 + this.NftName.GetHashCode();
                if (this.NftSymbol != null)
                    hashCode = hashCode * 59 + this.NftSymbol.GetHashCode();
                if (this.NftDescription != null)
                    hashCode = hashCode * 59 + this.NftDescription.GetHashCode();
                if (this.NftUrl != null)
                    hashCode = hashCode * 59 + this.NftUrl.GetHashCode();
                if (this.NftMetadata != null)
                    hashCode = hashCode * 59 + this.NftMetadata.GetHashCode();
                if (this.NftUploadMethod != null)
                    hashCode = hashCode * 59 + this.NftUploadMethod.GetHashCode();
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
