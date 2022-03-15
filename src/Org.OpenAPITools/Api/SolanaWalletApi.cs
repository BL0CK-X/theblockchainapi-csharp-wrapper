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
    public interface ISolanaWalletApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Derive an associated token account address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <returns>ATAResponse</returns>
        ATAResponse SolanaDeriveAssociatedTokenAccountAddress (string publicKey, string mintAddress);

        /// <summary>
        /// Derive an associated token account address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <returns>ApiResponse of ATAResponse</returns>
        ApiResponse<ATAResponse> SolanaDeriveAssociatedTokenAccountAddressWithHttpInfo (string publicKey, string mintAddress);
        /// <summary>
        /// Derive private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>GeneratePrivateKey</returns>
        GeneratePrivateKey SolanaDerivePrivateKey (GetPublicKeyRequest getPublicKeyRequest);

        /// <summary>
        /// Derive private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>ApiResponse of GeneratePrivateKey</returns>
        ApiResponse<GeneratePrivateKey> SolanaDerivePrivateKeyWithHttpInfo (GetPublicKeyRequest getPublicKeyRequest);
        /// <summary>
        /// Derive public key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>PublicKey</returns>
        PublicKey SolanaDerivePublicKey (GetPublicKeyRequest getPublicKeyRequest);

        /// <summary>
        /// Derive public key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>ApiResponse of PublicKey</returns>
        ApiResponse<PublicKey> SolanaDerivePublicKeyWithHttpInfo (GetPublicKeyRequest getPublicKeyRequest);
        /// <summary>
        /// Generate private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GeneratePrivateKey</returns>
        GeneratePrivateKey SolanaGeneratePrivateKey ();

        /// <summary>
        /// Generate private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GeneratePrivateKey</returns>
        ApiResponse<GeneratePrivateKey> SolanaGeneratePrivateKeyWithHttpInfo ();
        /// <summary>
        /// Generate secret phrase
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecretPhrase</returns>
        SecretPhrase SolanaGenerateSecretRecoveryPhrase ();

        /// <summary>
        /// Generate secret phrase
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecretPhrase</returns>
        ApiResponse<SecretPhrase> SolanaGenerateSecretRecoveryPhraseWithHttpInfo ();
        /// <summary>
        /// Get an airdrop on devnet
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <returns>TransferResponse</returns>
        TransferResponse SolanaGetAirdrop (AirdropRequest airdropRequest = default(AirdropRequest));

        /// <summary>
        /// Get an airdrop on devnet
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <returns>ApiResponse of TransferResponse</returns>
        ApiResponse<TransferResponse> SolanaGetAirdropWithHttpInfo (AirdropRequest airdropRequest = default(AirdropRequest));
        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <returns>BalanceResponse</returns>
        BalanceResponse SolanaGetBalance (BalanceRequest balanceRequest = default(BalanceRequest));

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <returns>ApiResponse of BalanceResponse</returns>
        ApiResponse<BalanceResponse> SolanaGetBalanceWithHttpInfo (BalanceRequest balanceRequest = default(BalanceRequest));
        /// <summary>
        /// Get address&#39;s NFTs
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <returns>ListNFTsResponse</returns>
        ListNFTsResponse SolanaGetNFTsBelongingToWallet (string network, string publicKey);

        /// <summary>
        /// Get address&#39;s NFTs
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <returns>ApiResponse of ListNFTsResponse</returns>
        ApiResponse<ListNFTsResponse> SolanaGetNFTsBelongingToWalletWithHttpInfo (string network, string publicKey);
        /// <summary>
        /// Get address&#39;s tokens and respective balances
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> SolanaGetTokensBelongingToWallet (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?));

        /// <summary>
        /// Get address&#39;s tokens and respective balances
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> SolanaGetTokensBelongingToWalletWithHttpInfo (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?));
        /// <summary>
        /// Get address&#39;s associated transaction signatures
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> SolanaGetWalletTransactions (string network, string publicKey);

        /// <summary>
        /// Get address&#39;s associated transaction signatures
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> SolanaGetWalletTransactionsWithHttpInfo (string network, string publicKey);
        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <returns>DoubleTransferResponse</returns>
        DoubleTransferResponse SolanaTransfer (TransferRequest transferRequest = default(TransferRequest));

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <returns>ApiResponse of DoubleTransferResponse</returns>
        ApiResponse<DoubleTransferResponse> SolanaTransferWithHttpInfo (TransferRequest transferRequest = default(TransferRequest));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Derive an associated token account address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ATAResponse</returns>
        System.Threading.Tasks.Task<ATAResponse> SolanaDeriveAssociatedTokenAccountAddressAsync (string publicKey, string mintAddress, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Derive an associated token account address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ATAResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ATAResponse>> SolanaDeriveAssociatedTokenAccountAddressWithHttpInfoAsync (string publicKey, string mintAddress, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Derive private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GeneratePrivateKey</returns>
        System.Threading.Tasks.Task<GeneratePrivateKey> SolanaDerivePrivateKeyAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Derive private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GeneratePrivateKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeneratePrivateKey>> SolanaDerivePrivateKeyWithHttpInfoAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Derive public key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PublicKey</returns>
        System.Threading.Tasks.Task<PublicKey> SolanaDerivePublicKeyAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Derive public key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PublicKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublicKey>> SolanaDerivePublicKeyWithHttpInfoAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GeneratePrivateKey</returns>
        System.Threading.Tasks.Task<GeneratePrivateKey> SolanaGeneratePrivateKeyAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate private key
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GeneratePrivateKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeneratePrivateKey>> SolanaGeneratePrivateKeyWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate secret phrase
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SecretPhrase</returns>
        System.Threading.Tasks.Task<SecretPhrase> SolanaGenerateSecretRecoveryPhraseAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate secret phrase
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SecretPhrase)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecretPhrase>> SolanaGenerateSecretRecoveryPhraseWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an airdrop on devnet
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransferResponse</returns>
        System.Threading.Tasks.Task<TransferResponse> SolanaGetAirdropAsync (AirdropRequest airdropRequest = default(AirdropRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get an airdrop on devnet
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferResponse>> SolanaGetAirdropWithHttpInfoAsync (AirdropRequest airdropRequest = default(AirdropRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of BalanceResponse</returns>
        System.Threading.Tasks.Task<BalanceResponse> SolanaGetBalanceAsync (BalanceRequest balanceRequest = default(BalanceRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (BalanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BalanceResponse>> SolanaGetBalanceWithHttpInfoAsync (BalanceRequest balanceRequest = default(BalanceRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get address&#39;s NFTs
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListNFTsResponse</returns>
        System.Threading.Tasks.Task<ListNFTsResponse> SolanaGetNFTsBelongingToWalletAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get address&#39;s NFTs
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListNFTsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListNFTsResponse>> SolanaGetNFTsBelongingToWalletWithHttpInfoAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get address&#39;s tokens and respective balances
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> SolanaGetTokensBelongingToWalletAsync (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get address&#39;s tokens and respective balances
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> SolanaGetTokensBelongingToWalletWithHttpInfoAsync (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get address&#39;s associated transaction signatures
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> SolanaGetWalletTransactionsAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get address&#39;s associated transaction signatures
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> SolanaGetWalletTransactionsWithHttpInfoAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DoubleTransferResponse</returns>
        System.Threading.Tasks.Task<DoubleTransferResponse> SolanaTransferAsync (TransferRequest transferRequest = default(TransferRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address
        /// </summary>
        /// <remarks>
        /// &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DoubleTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoubleTransferResponse>> SolanaTransferWithHttpInfoAsync (TransferRequest transferRequest = default(TransferRequest), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SolanaWalletApi : ISolanaWalletApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaWalletApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SolanaWalletApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaWalletApi"/> class
        /// </summary>
        /// <returns></returns>
        public SolanaWalletApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaWalletApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SolanaWalletApi(Org.OpenAPITools.Client.Configuration configuration = null)
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
        /// Derive an associated token account address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <returns>ATAResponse</returns>
        public ATAResponse SolanaDeriveAssociatedTokenAccountAddress (string publicKey, string mintAddress)
        {
             ApiResponse<ATAResponse> localVarResponse = SolanaDeriveAssociatedTokenAccountAddressWithHttpInfo(publicKey, mintAddress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Derive an associated token account address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <returns>ApiResponse of ATAResponse</returns>
        public ApiResponse<ATAResponse> SolanaDeriveAssociatedTokenAccountAddressWithHttpInfo (string publicKey, string mintAddress)
        {
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaDeriveAssociatedTokenAccountAddress");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaWalletApi->SolanaDeriveAssociatedTokenAccountAddress");

            var localVarPath = "/solana/wallet/{public_key}/associated_token_account/{mint_address}";
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

            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter
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
                Exception exception = ExceptionFactory("SolanaDeriveAssociatedTokenAccountAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ATAResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ATAResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ATAResponse)));
        }

        /// <summary>
        /// Derive an associated token account address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ATAResponse</returns>
        public async System.Threading.Tasks.Task<ATAResponse> SolanaDeriveAssociatedTokenAccountAddressAsync (string publicKey, string mintAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ATAResponse> localVarResponse = await SolanaDeriveAssociatedTokenAccountAddressWithHttpInfoAsync(publicKey, mintAddress, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Derive an associated token account address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-associated-token-account-address\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See example (Python, JavaScript)&lt;/a&gt;.      *Each wallet can own tokens, but in Solana, each token is actually held by an &lt;a href&#x3D;\&quot;https://spl.solana.com/associated-token-account\&quot; target&#x3D;\&quot;_blank\&quot;&gt;associated token account&lt;/a&gt; (ATA), which is an account specific for a token owned by the wallet. When you transfer an SPL token, such as Serum, or transfer an NFT, you&#39;re transfering from an ATA you own to another person&#39;s ATA for that specific token. With this endpoint, you can derive an associated token address given a wallet and a token address.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicKey">The public key of the wallet</param>
        /// <param name="mintAddress">The mint address of the token (either SPL or NFT)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ATAResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ATAResponse>> SolanaDeriveAssociatedTokenAccountAddressWithHttpInfoAsync (string publicKey, string mintAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaDeriveAssociatedTokenAccountAddress");
            // verify the required parameter 'mintAddress' is set
            if (mintAddress == null)
                throw new ApiException(400, "Missing required parameter 'mintAddress' when calling SolanaWalletApi->SolanaDeriveAssociatedTokenAccountAddress");

            var localVarPath = "/solana/wallet/{public_key}/associated_token_account/{mint_address}";
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

            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter
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
                Exception exception = ExceptionFactory("SolanaDeriveAssociatedTokenAccountAddress", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ATAResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ATAResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ATAResponse)));
        }

        /// <summary>
        /// Derive private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>GeneratePrivateKey</returns>
        public GeneratePrivateKey SolanaDerivePrivateKey (GetPublicKeyRequest getPublicKeyRequest)
        {
             ApiResponse<GeneratePrivateKey> localVarResponse = SolanaDerivePrivateKeyWithHttpInfo(getPublicKeyRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Derive private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>ApiResponse of GeneratePrivateKey</returns>
        public ApiResponse<GeneratePrivateKey> SolanaDerivePrivateKeyWithHttpInfo (GetPublicKeyRequest getPublicKeyRequest)
        {
            // verify the required parameter 'getPublicKeyRequest' is set
            if (getPublicKeyRequest == null)
                throw new ApiException(400, "Missing required parameter 'getPublicKeyRequest' when calling SolanaWalletApi->SolanaDerivePrivateKey");

            var localVarPath = "/solana/wallet/private_key";
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

            if (getPublicKeyRequest != null && getPublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPublicKeyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDerivePrivateKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeneratePrivateKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GeneratePrivateKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneratePrivateKey)));
        }

        /// <summary>
        /// Derive private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GeneratePrivateKey</returns>
        public async System.Threading.Tasks.Task<GeneratePrivateKey> SolanaDerivePrivateKeyAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<GeneratePrivateKey> localVarResponse = await SolanaDerivePrivateKeyWithHttpInfoAsync(getPublicKeyRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Derive private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a private key array and a base58-encoded private key given wallet authentication.  A wallet is defined by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path. Thus, with a single secret recovery phrase, you can generate many public keys. If you are just starting, just supply the secret recovery phrase you generated with the Solana Wallet Secret Recovery Phrase endpoint.*  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GeneratePrivateKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeneratePrivateKey>> SolanaDerivePrivateKeyWithHttpInfoAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'getPublicKeyRequest' is set
            if (getPublicKeyRequest == null)
                throw new ApiException(400, "Missing required parameter 'getPublicKeyRequest' when calling SolanaWalletApi->SolanaDerivePrivateKey");

            var localVarPath = "/solana/wallet/private_key";
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

            if (getPublicKeyRequest != null && getPublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPublicKeyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDerivePrivateKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeneratePrivateKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GeneratePrivateKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneratePrivateKey)));
        }

        /// <summary>
        /// Derive public key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>PublicKey</returns>
        public PublicKey SolanaDerivePublicKey (GetPublicKeyRequest getPublicKeyRequest)
        {
             ApiResponse<PublicKey> localVarResponse = SolanaDerivePublicKeyWithHttpInfo(getPublicKeyRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Derive public key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <returns>ApiResponse of PublicKey</returns>
        public ApiResponse<PublicKey> SolanaDerivePublicKeyWithHttpInfo (GetPublicKeyRequest getPublicKeyRequest)
        {
            // verify the required parameter 'getPublicKeyRequest' is set
            if (getPublicKeyRequest == null)
                throw new ApiException(400, "Missing required parameter 'getPublicKeyRequest' when calling SolanaWalletApi->SolanaDerivePublicKey");

            var localVarPath = "/solana/wallet/public_key";
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

            if (getPublicKeyRequest != null && getPublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPublicKeyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDerivePublicKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PublicKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PublicKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublicKey)));
        }

        /// <summary>
        /// Derive public key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PublicKey</returns>
        public async System.Threading.Tasks.Task<PublicKey> SolanaDerivePublicKeyAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PublicKey> localVarResponse = await SolanaDerivePublicKeyWithHttpInfoAsync(getPublicKeyRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Derive public key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/derive-public-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Returns a public key given wallet authentication.  A wallet is identified by a public key. A public key is derived from a combination of seed phrase, derivation path, and passphrase. Changing any *one* of these three will change the public key output.   It can also be derived from a private key.  *You can generate a unique public key with each combination of secret recovery phrase, passphrase, and derivation path; or from a private key. Thus, with a single secret recovery phrase, you can generate many public keys; however, with a private key, you can only generate one public key. If you are just starting, generate a &lt;a href&#x3D;\&quot;#operation/solanaGenerateSecretRecoveryPhrase\&quot;&gt;secret recovery phrase&lt;/a&gt; or &lt;a href&#x3D;\&quot;#operation/solanaGeneratePrivateKey\&quot;&gt;private key&lt;/a&gt;.  *If you are trying to get a public key that already exists (e.g., created in the Phantom wallet), make sure you use the correct derivation path and passphrase; or just use the private key. To read more about that, see the descriptions of those parameters below.*  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPublicKeyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PublicKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublicKey>> SolanaDerivePublicKeyWithHttpInfoAsync (GetPublicKeyRequest getPublicKeyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'getPublicKeyRequest' is set
            if (getPublicKeyRequest == null)
                throw new ApiException(400, "Missing required parameter 'getPublicKeyRequest' when calling SolanaWalletApi->SolanaDerivePublicKey");

            var localVarPath = "/solana/wallet/public_key";
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

            if (getPublicKeyRequest != null && getPublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPublicKeyRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaDerivePublicKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PublicKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PublicKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublicKey)));
        }

        /// <summary>
        /// Generate private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GeneratePrivateKey</returns>
        public GeneratePrivateKey SolanaGeneratePrivateKey ()
        {
             ApiResponse<GeneratePrivateKey> localVarResponse = SolanaGeneratePrivateKeyWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GeneratePrivateKey</returns>
        public ApiResponse<GeneratePrivateKey> SolanaGeneratePrivateKeyWithHttpInfo ()
        {

            var localVarPath = "/solana/wallet/generate/private_key";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolanaGeneratePrivateKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeneratePrivateKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GeneratePrivateKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneratePrivateKey)));
        }

        /// <summary>
        /// Generate private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GeneratePrivateKey</returns>
        public async System.Threading.Tasks.Task<GeneratePrivateKey> SolanaGeneratePrivateKeyAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<GeneratePrivateKey> localVarResponse = await SolanaGeneratePrivateKeyWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate private key &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-private-key\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a private key for a Solana wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GeneratePrivateKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeneratePrivateKey>> SolanaGeneratePrivateKeyWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/wallet/generate/private_key";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolanaGeneratePrivateKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeneratePrivateKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GeneratePrivateKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneratePrivateKey)));
        }

        /// <summary>
        /// Generate secret phrase &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SecretPhrase</returns>
        public SecretPhrase SolanaGenerateSecretRecoveryPhrase ()
        {
             ApiResponse<SecretPhrase> localVarResponse = SolanaGenerateSecretRecoveryPhraseWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate secret phrase &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SecretPhrase</returns>
        public ApiResponse<SecretPhrase> SolanaGenerateSecretRecoveryPhraseWithHttpInfo ()
        {

            var localVarPath = "/solana/wallet/generate/secret_recovery_phrase";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolanaGenerateSecretRecoveryPhrase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecretPhrase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SecretPhrase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecretPhrase)));
        }

        /// <summary>
        /// Generate secret phrase &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SecretPhrase</returns>
        public async System.Threading.Tasks.Task<SecretPhrase> SolanaGenerateSecretRecoveryPhraseAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<SecretPhrase> localVarResponse = await SolanaGenerateSecretRecoveryPhraseWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate secret phrase &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/generate-secret-phrase\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.  Use this endpoint to securely and randomly generate a secret recovery phrase for a Solana wallet.   &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SecretPhrase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecretPhrase>> SolanaGenerateSecretRecoveryPhraseWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/wallet/generate/secret_recovery_phrase";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolanaGenerateSecretRecoveryPhrase", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecretPhrase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SecretPhrase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecretPhrase)));
        }

        /// <summary>
        /// Get an airdrop on devnet &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <returns>TransferResponse</returns>
        public TransferResponse SolanaGetAirdrop (AirdropRequest airdropRequest = default(AirdropRequest))
        {
             ApiResponse<TransferResponse> localVarResponse = SolanaGetAirdropWithHttpInfo(airdropRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an airdrop on devnet &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <returns>ApiResponse of TransferResponse</returns>
        public ApiResponse<TransferResponse> SolanaGetAirdropWithHttpInfo (AirdropRequest airdropRequest = default(AirdropRequest))
        {

            var localVarPath = "/solana/wallet/airdrop";
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

            if (airdropRequest != null && airdropRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(airdropRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = airdropRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetAirdrop", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransferResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferResponse)));
        }

        /// <summary>
        /// Get an airdrop on devnet &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransferResponse</returns>
        public async System.Threading.Tasks.Task<TransferResponse> SolanaGetAirdropAsync (AirdropRequest airdropRequest = default(AirdropRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<TransferResponse> localVarResponse = await SolanaGetAirdropWithHttpInfoAsync(airdropRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an airdrop on devnet &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-airdrop\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      Use this endpoint to get an airdrop of SOL on the devnet (not real SOL). Amount of 0.015,  which is the minimum amount of SOL you need to mint a Metaplex NFT and then transfer it to another wallet.  &#x60;Cost: 0 Credit&#x60; (Free) (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="airdropRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferResponse>> SolanaGetAirdropWithHttpInfoAsync (AirdropRequest airdropRequest = default(AirdropRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/wallet/airdrop";
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

            if (airdropRequest != null && airdropRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(airdropRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = airdropRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetAirdrop", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransferResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferResponse)));
        }

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <returns>BalanceResponse</returns>
        public BalanceResponse SolanaGetBalance (BalanceRequest balanceRequest = default(BalanceRequest))
        {
             ApiResponse<BalanceResponse> localVarResponse = SolanaGetBalanceWithHttpInfo(balanceRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <returns>ApiResponse of BalanceResponse</returns>
        public ApiResponse<BalanceResponse> SolanaGetBalanceWithHttpInfo (BalanceRequest balanceRequest = default(BalanceRequest))
        {

            var localVarPath = "/solana/wallet/balance";
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

            if (balanceRequest != null && balanceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(balanceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = balanceRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetBalance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BalanceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceResponse)));
        }

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of BalanceResponse</returns>
        public async System.Threading.Tasks.Task<BalanceResponse> SolanaGetBalanceAsync (BalanceRequest balanceRequest = default(BalanceRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<BalanceResponse> localVarResponse = await SolanaGetBalanceWithHttpInfoAsync(balanceRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get wallet&#39;s balance in SOL or any SPL &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-balance\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the balance of a wallet in SOL or any SPL token.  To get the balance of an SPL token, supply the &#x60;mint_address&#x60; of the SPL token. The list of SPL tokens can be viewed &lt;a href&#x3D;\&quot;https://raw.githubusercontent.com/solana-labs/token-list/main/src/tokens/solana.tokenlist.json\&quot; target&#x3D;\&quot;_blank\&quot;&gt;here&lt;/a&gt;.  You can also use this endpoint to see whether or not a person owns an NFT. Just supply the &#x60;mint_address&#x60; of the NFT. A balance of \&quot;1\&quot; means the person owns the NFT, and a balance of \&quot;0\&quot; means the person does not own the NFT. This works in most cases, but we are aware of one edge case where a balance of \&quot;0\&quot; will show up for a person who is actually the owner of the NFT. We just recommend using the &lt;a href&#x3D;\&quot;#operation/solanaGetNFTOwner\&quot;&gt;getNFTOwner&lt;/a&gt; endpoint and comparing that output to the expected address.  &#x60;Cost: 0.25 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="balanceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (BalanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BalanceResponse>> SolanaGetBalanceWithHttpInfoAsync (BalanceRequest balanceRequest = default(BalanceRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/wallet/balance";
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

            if (balanceRequest != null && balanceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(balanceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = balanceRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaGetBalance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BalanceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceResponse)));
        }

        /// <summary>
        /// Get address&#39;s NFTs &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <returns>ListNFTsResponse</returns>
        public ListNFTsResponse SolanaGetNFTsBelongingToWallet (string network, string publicKey)
        {
             ApiResponse<ListNFTsResponse> localVarResponse = SolanaGetNFTsBelongingToWalletWithHttpInfo(network, publicKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get address&#39;s NFTs &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <returns>ApiResponse of ListNFTsResponse</returns>
        public ApiResponse<ListNFTsResponse> SolanaGetNFTsBelongingToWalletWithHttpInfo (string network, string publicKey)
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetNFTsBelongingToWallet");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetNFTsBelongingToWallet");

            var localVarPath = "/solana/wallet/{network}/{public_key}/nfts";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetNFTsBelongingToWallet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListNFTsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListNFTsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListNFTsResponse)));
        }

        /// <summary>
        /// Get address&#39;s NFTs &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListNFTsResponse</returns>
        public async System.Threading.Tasks.Task<ListNFTsResponse> SolanaGetNFTsBelongingToWalletAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ListNFTsResponse> localVarResponse = await SolanaGetNFTsBelongingToWalletWithHttpInfoAsync(network, publicKey, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get address&#39;s NFTs &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-nfts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the NFTs that belong to a given public key address  &#x60;Cost: 3 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListNFTsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListNFTsResponse>> SolanaGetNFTsBelongingToWalletWithHttpInfoAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetNFTsBelongingToWallet");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetNFTsBelongingToWallet");

            var localVarPath = "/solana/wallet/{network}/{public_key}/nfts";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetNFTsBelongingToWallet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListNFTsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListNFTsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListNFTsResponse)));
        }

        /// <summary>
        /// Get address&#39;s tokens and respective balances &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> SolanaGetTokensBelongingToWallet (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?))
        {
             ApiResponse<List<Object>> localVarResponse = SolanaGetTokensBelongingToWalletWithHttpInfo(network, publicKey, includeNfts, includeZeroBalanceHoldings);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get address&#39;s tokens and respective balances &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse<List<Object>> SolanaGetTokensBelongingToWalletWithHttpInfo (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetTokensBelongingToWallet");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetTokensBelongingToWallet");

            var localVarPath = "/solana/wallet/{network}/{public_key}/tokens";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter
            if (includeNfts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_nfts", includeNfts)); // query parameter
            if (includeZeroBalanceHoldings != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_zero_balance_holdings", includeZeroBalanceHoldings)); // query parameter

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
                Exception exception = ExceptionFactory("SolanaGetTokensBelongingToWallet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
        }

        /// <summary>
        /// Get address&#39;s tokens and respective balances &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> SolanaGetTokensBelongingToWalletAsync (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<Object>> localVarResponse = await SolanaGetTokensBelongingToWalletWithHttpInfoAsync(network, publicKey, includeNfts, includeZeroBalanceHoldings, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get address&#39;s tokens and respective balances &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/get-wallet-token-holdings\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the token holdings of a given public key address  &#x60;Cost: 2 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of owned NFTs you want to get</param>
        /// <param name="includeNfts">Whether or not to include NFTs in the response (optional, default to false)</param>
        /// <param name="includeZeroBalanceHoldings">Whether or not to include holdings that have zero balance. This indicates that the wallet held this token or NFT in the past, but no longer holds it. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> SolanaGetTokensBelongingToWalletWithHttpInfoAsync (string network, string publicKey, bool? includeNfts = default(bool?), bool? includeZeroBalanceHoldings = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetTokensBelongingToWallet");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetTokensBelongingToWallet");

            var localVarPath = "/solana/wallet/{network}/{public_key}/tokens";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter
            if (includeNfts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_nfts", includeNfts)); // query parameter
            if (includeZeroBalanceHoldings != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_zero_balance_holdings", includeZeroBalanceHoldings)); // query parameter

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
                Exception exception = ExceptionFactory("SolanaGetTokensBelongingToWallet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
        }

        /// <summary>
        /// Get address&#39;s associated transaction signatures &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> SolanaGetWalletTransactions (string network, string publicKey)
        {
             ApiResponse<List<string>> localVarResponse = SolanaGetWalletTransactionsWithHttpInfo(network, publicKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get address&#39;s associated transaction signatures &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse<List<string>> SolanaGetWalletTransactionsWithHttpInfo (string network, string publicKey)
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetWalletTransactions");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetWalletTransactions");

            var localVarPath = "/solana/wallet/{network}/{public_key}/transactions";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetWalletTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
        }

        /// <summary>
        /// Get address&#39;s associated transaction signatures &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> SolanaGetWalletTransactionsAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<string>> localVarResponse = await SolanaGetWalletTransactionsWithHttpInfoAsync(network, publicKey, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get address&#39;s associated transaction signatures &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/blockchain-api/tree/main/examples/solana-wallet/get-wallet-transactions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See examples (Python, JavaScript)&lt;/a&gt;.      See the transaction signatures of a given public key address  &#x60;Cost: 1 Credits&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="network">The network ID (devnet, mainnet-beta)</param>
        /// <param name="publicKey">The public key of the account whose list of signatures you want to get</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> SolanaGetWalletTransactionsWithHttpInfoAsync (string network, string publicKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'network' is set
            if (network == null)
                throw new ApiException(400, "Missing required parameter 'network' when calling SolanaWalletApi->SolanaGetWalletTransactions");
            // verify the required parameter 'publicKey' is set
            if (publicKey == null)
                throw new ApiException(400, "Missing required parameter 'publicKey' when calling SolanaWalletApi->SolanaGetWalletTransactions");

            var localVarPath = "/solana/wallet/{network}/{public_key}/transactions";
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
            if (publicKey != null) localVarPathParams.Add("public_key", this.Configuration.ApiClient.ParameterToString(publicKey)); // path parameter

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
                Exception exception = ExceptionFactory("SolanaGetWalletTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
        }

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <returns>DoubleTransferResponse</returns>
        public DoubleTransferResponse SolanaTransfer (TransferRequest transferRequest = default(TransferRequest))
        {
             ApiResponse<DoubleTransferResponse> localVarResponse = SolanaTransferWithHttpInfo(transferRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <returns>ApiResponse of DoubleTransferResponse</returns>
        public ApiResponse<DoubleTransferResponse> SolanaTransferWithHttpInfo (TransferRequest transferRequest = default(TransferRequest))
        {

            var localVarPath = "/solana/wallet/transfer";
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

            if (transferRequest != null && transferRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transferRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaTransfer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DoubleTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DoubleTransferResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DoubleTransferResponse)));
        }

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of DoubleTransferResponse</returns>
        public async System.Threading.Tasks.Task<DoubleTransferResponse> SolanaTransferAsync (TransferRequest transferRequest = default(TransferRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<DoubleTransferResponse> localVarResponse = await SolanaTransferWithHttpInfoAsync(transferRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transfer SOL, a token, or an NFT to another address &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-sol\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer SOL example (Python, JavaScript)&lt;/a&gt;.  &lt;a href&#x3D;\&quot;https://github.com/BL0CK-X/the-blockchain-api/tree/main/examples/solana-wallet/transfer-nft\&quot; target&#x3D;\&quot;_blank\&quot;&gt;See transfer NFT example (can also be used for SPL token) (Python, JavaScript)&lt;/a&gt;.  This is a powerful function. It might be slightly confusing because there are several optional parameters, so take some time to review it. This function can send SOL, send an SPL token, or send an NFT. You can set the fee payer of the transaction; you can sign and submit the transaction for confirmation; and you can select to simply return the compiled transaction so that you can submit it to the user for signing (e.g., via Phantom; no private keys required in this case).  Transfer SOL, a token or an NFT to another address. If you&#39;re transferring an NFT, supply the &#x60;mint&#x60; (the address of the mint) for the &#x60;token_address&#x60;.  SENDER: Note that the wallet information is used to authorize the sending of the tokens and identifies the source of the tokens. If &#x60;return_compiled_transaction &#x3D; false&#x60;, we sign and submit the transaction (&#x60;wallet&#x60; is required in this case; do not provide a value for &#x60;sender_public_key&#x60;). If &#x60;return_compiled_transaction &#x3D; true&#x60;, we compile the transaction (one of &#x60;wallet&#x60; or &#x60;sender_public_key&#x60; is required in this case; do not provide both).  RECIPIENT: &#x60;recipient_address&#x60; identifies the receiver. This is entirely separate from the information used for the SENDER above. So, in this API call, there are two wallets involved, but only one (namely, the SENDER) is needed to authorize the transaction.  FEE_PAYER: The fee payer of the transaction defaults to &#x60;wallet&#x60; (or &#x60;sender_public_key&#x60;). To set a different fee payer, provide a value for &#x60;fee_payer_wallet&#x60;.  If you&#39;re transfering a token, supply the token address found on the explorer (e.g., see &#x60;SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt&#x60; for &lt;a href&#x3D;\&quot;https://explorer.solana.com/address/SRMuApVNdxXokk5GT7XD5cUUgXMBCoAz2LHeuAoKWRt\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Serum Token&lt;/a&gt;) for the &#x60;token_address&#x60;. If you&#39;re transferring SOL, do not supply a value for &#x60;token_address&#x60;.  &#x60;Cost: 2 Credit&#x60; (&lt;a href&#x3D;\&quot;#section/Pricing\&quot;&gt;See Pricing&lt;/a&gt;)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (DoubleTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DoubleTransferResponse>> SolanaTransferWithHttpInfoAsync (TransferRequest transferRequest = default(TransferRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/solana/wallet/transfer";
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

            if (transferRequest != null && transferRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transferRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferRequest; // byte array
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
                Exception exception = ExceptionFactory("SolanaTransfer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DoubleTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (DoubleTransferResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DoubleTransferResponse)));
        }

    }
}
