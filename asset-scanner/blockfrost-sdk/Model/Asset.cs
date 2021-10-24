/* 
 * Blockfrost.io ~ API Documentation
 *
 * Blockfrost is an API as a service that allows users to interact with the Cardano blockchain and parts of its ecosystem.  ## Tokens  After signing up on https://blockfrost.io, a `project_id` token is automatically generated for each project. HTTP header of your request MUST include this `project_id` in order to authenticate against Blockfrost servers.  ## Available networks  At the moment, you can use the following networks. Please, note that each network has its own `project_id`.  <table>   <tr><td><b>Network</b></td><td><b>Endpoint</b></td></tr>   <tr><td>Cardano mainnet</td><td><tt>https://cardano-mainnet.blockfrost.io/api/v0</td></tt></tr>   <tr><td>Cardano testnet</td><td><tt>https://cardano-testnet.blockfrost.io/api/v0</tt></td></tr>   <tr><td>InterPlanetary File System</td><td><tt>https://ipfs.blockfrost.io/api/v0</tt></td></tr> </table>  ## Concepts  * All endpoints return either a JSON object or an array. * Data is returned in *ascending* (oldest first, newest last) order.   * You might use the `?order=desc` query parameter to reverse this order. * By default, we return 100 results at a time. You have to use `?page=2` to list through the results. * All time and timestamp related fields (except `server_time`) are in seconds of UNIX time. * All amounts are returned in Lovelaces, where 1 ADA = 1 000 000 Lovelaces. * Addresses, accounts and pool IDs are in Bech32 format. * All values are case sensitive. * All hex encoded values are lower case. * Examples are not based on real data. Any resemblance to actual events is purely coincidental. * We allow to upload files up to 100MB of size to IPFS. This might increase in the future.  ## Errors  ### HTTP Status codes  The following are HTTP status code your application might receive when reaching Blockfrost endpoints and it should handle all of these cases.  * HTTP `400` return code is used when the request is not valid. * HTTP `402` return code is used when the projects exceed their daily request limit. * HTTP `403` return code is used when the request is not authenticated. * HTTP `404` return code is used when the resource doesn't exist. * HTTP `418` return code is used when the user has been auto-banned for flooding too much after previously receiving error code `402` or `429`. * HTTP `425` return code is used when the user has submitted a transaction when the mempool is already full, not accepting new txs straight away. * HTTP `429` return code is used when the user has sent too many requests in a given amount of time and therefore has been rate-limited. * HTTP `500` return code is used when our endpoints are having a problem.  ### Error codes  An internal error code number is used for better indication of the error in question. It is passed using the following payload.  ```json {   \"status_code\": 403,   \"error\": \"Forbidden\",   \"message\": \"Invalid project token.\" } ``` ## Limits   There are two types of limits we are enforcing:   The first depends on your plan and is the number of request we allow per day. We defined the day from midnight to midnight of UTC time.   The second is rate limiting. We limit an end user, distinguished by IP address, to 10 requests per second. On top of that, we allow  each user to send burst of 500 requests, which cools off at rate of 10 requests per second. In essence, a user is allowed to make another  whole burst after (currently) 500/10 = 50 seconds. E.g. if a user attemtps to make a call 3 seconds after whole burst, 30 requests will be processed.  We believe this should be sufficient for most of the use cases. If it is not and you have a specific use case, please get in touch with us, and  we will make sure to take it into account as much as we can.   ## SDKs  We support a number of SDKs that will help you in developing your application on top of Blockfrost.  <table>   <tr><td><b>Programming language</b></td><td><b>SDK</b></td></tr>   <tr><td>JavaScript</td><td><a href=\"https://github.com/blockfrost/blockfrost-js\">blockfrost-js</a></tr>   <tr><td>Haskell</td><td><a href=\"https://github.com/blockfrost/blockfrost-haskell\">blockfrost-haskell</a></tr>   <tr><td>Java</td><td><a href=\"https://github.com/blockfrost/blockfrost-java\">blockfrost-java</a></tr>   <tr><td>Python</td><td><a href=\"https://github.com/blockfrost/blockfrost-python\">blockfrost-python</a></tr>   <tr><td>Ruby</td><td><a href=\"https://github.com/blockfrost/blockfrost-ruby\">blockfrost-ruby</a></tr>   <tr><td>Swift</td><td><a href=\"https://github.com/blockfrost/blockfrost-swift\">blockfrost-swift</a></tr>   <tr><td>Kotlin</td><td><a href=\"https://github.com/blockfrost/blockfrost-kotlin\">blockfrost-kotlin</a></tr>   <tr><td>Scala</td><td><a href=\"https://github.com/blockfrost/blockfrost-scala\">blockfrost-scala</a></tr>   <tr><td>Elixir</td><td><a href=\"https://github.com/blockfrost/blockfrost-elixir\">blockfrost-elixir</a></tr> </table>  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * OpenAPI spec version: 0.1.30
 * Contact: contact@blockfrost.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = blockfrost.Client.SwaggerDateConverter;
using System.Dynamic;

namespace blockfrost.Model
{
    /// <summary>
    /// Asset
    /// </summary>
    [DataContract]
        public partial class Asset :  IEquatable<Asset>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="asset">Hex-encoded asset full name (required).</param>
        /// <param name="policyId">Policy ID of the asset (required).</param>
        /// <param name="assetName">Hex-encoded asset name of the asset (required).</param>
        /// <param name="fingerprint">CIP14 based user-facing fingerprint (required).</param>
        /// <param name="quantity">Current asset quantity (required).</param>
        /// <param name="initialMintTxHash">ID of the initial minting transaction (required).</param>
        /// <param name="mintOrBurnCount">Count of mint and burn transactions (required).</param>
        /// <param name="onchainMetadata">onchainMetadata (required).</param>
        /// <param name="metadata">metadata (required).</param>
        public Asset(string asset = default(string), string policyId = default(string), string assetName = default(string), string fingerprint = default(string), string quantity = default(string), string initialMintTxHash = default(string), int? mintOrBurnCount = default(int?), dynamic onchainMetadata = default, AssetMetadata metadata = default(AssetMetadata))
        {
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new InvalidDataException("asset is a required property for Asset and cannot be null");
            }
            else
            {
                this._Asset = asset;
            }
            // to ensure "policyId" is required (not null)
            if (policyId == null)
            {
                throw new InvalidDataException("policyId is a required property for Asset and cannot be null");
            }
            else
            {
                this.PolicyId = policyId;
            }
            // to ensure "assetName" is required (not null)
            if (assetName == null)
            {
                throw new InvalidDataException("assetName is a required property for Asset and cannot be null");
            }
            else
            {
                this.AssetName = assetName;
            }
            // to ensure "fingerprint" is required (not null)
            if (fingerprint == null)
            {
                throw new InvalidDataException("fingerprint is a required property for Asset and cannot be null");
            }
            else
            {
                this.Fingerprint = fingerprint;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for Asset and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "initialMintTxHash" is required (not null)
            if (initialMintTxHash == null)
            {
                throw new InvalidDataException("initialMintTxHash is a required property for Asset and cannot be null");
            }
            else
            {
                this.InitialMintTxHash = initialMintTxHash;
            }
            // to ensure "mintOrBurnCount" is required (not null)
            if (mintOrBurnCount == null)
            {
                throw new InvalidDataException("mintOrBurnCount is a required property for Asset and cannot be null");
            }
            else
            {
                this.MintOrBurnCount = mintOrBurnCount;
            }
            // to ensure "onchainMetadata" is required (not null)
            if (onchainMetadata == null)
            {
                throw new InvalidDataException("onchainMetadata is a required property for Asset and cannot be null");
            }
            else
            {
                this.OnchainMetadata = onchainMetadata;
            }
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                // don't throw exception here - not available on Hornnie's NFT
                //throw new InvalidDataException("metadata is a required property for Asset and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
        }
        
        /// <summary>
        /// Hex-encoded asset full name
        /// </summary>
        /// <value>Hex-encoded asset full name</value>
        [DataMember(Name="asset", EmitDefaultValue=false)]
        public string _Asset { get; set; }

        /// <summary>
        /// Policy ID of the asset
        /// </summary>
        /// <value>Policy ID of the asset</value>
        [DataMember(Name="policy_id", EmitDefaultValue=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Hex-encoded asset name of the asset
        /// </summary>
        /// <value>Hex-encoded asset name of the asset</value>
        [DataMember(Name="asset_name", EmitDefaultValue=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// CIP14 based user-facing fingerprint
        /// </summary>
        /// <value>CIP14 based user-facing fingerprint</value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Current asset quantity
        /// </summary>
        /// <value>Current asset quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }

        /// <summary>
        /// ID of the initial minting transaction
        /// </summary>
        /// <value>ID of the initial minting transaction</value>
        [DataMember(Name="initial_mint_tx_hash", EmitDefaultValue=false)]
        public string InitialMintTxHash { get; set; }

        /// <summary>
        /// Count of mint and burn transactions
        /// </summary>
        /// <value>Count of mint and burn transactions</value>
        [DataMember(Name="mint_or_burn_count", EmitDefaultValue=false)]
        public int? MintOrBurnCount { get; set; }

        /// <summary>
        /// Gets or Sets OnchainMetadata
        /// </summary>
        [DataMember(Name="onchain_metadata", EmitDefaultValue=false)]
        public ExpandoObject OnchainMetadata { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public AssetMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  _Asset: ").Append(_Asset).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  InitialMintTxHash: ").Append(InitialMintTxHash).Append("\n");
            sb.Append("  MintOrBurnCount: ").Append(MintOrBurnCount).Append("\n");
            sb.Append("  OnchainMetadata: ").Append(OnchainMetadata).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Asset == input._Asset ||
                    (this._Asset != null &&
                    this._Asset.Equals(input._Asset))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.InitialMintTxHash == input.InitialMintTxHash ||
                    (this.InitialMintTxHash != null &&
                    this.InitialMintTxHash.Equals(input.InitialMintTxHash))
                ) && 
                (
                    this.MintOrBurnCount == input.MintOrBurnCount ||
                    (this.MintOrBurnCount != null &&
                    this.MintOrBurnCount.Equals(input.MintOrBurnCount))
                ) && 
                (
                    this.OnchainMetadata == input.OnchainMetadata ||
                    (this.OnchainMetadata != null &&
                    this.OnchainMetadata.Equals(input.OnchainMetadata))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this._Asset != null)
                    hashCode = hashCode * 59 + this._Asset.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.InitialMintTxHash != null)
                    hashCode = hashCode * 59 + this.InitialMintTxHash.GetHashCode();
                if (this.MintOrBurnCount != null)
                    hashCode = hashCode * 59 + this.MintOrBurnCount.GetHashCode();
                if (this.OnchainMetadata != null)
                    hashCode = hashCode * 59 + this.OnchainMetadata.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
