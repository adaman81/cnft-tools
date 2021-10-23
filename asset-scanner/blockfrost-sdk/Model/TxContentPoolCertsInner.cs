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

namespace blockfrost.Model
{
    /// <summary>
    /// TxContentPoolCertsInner
    /// </summary>
    [DataContract]
        public partial class TxContentPoolCertsInner :  IEquatable<TxContentPoolCertsInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxContentPoolCertsInner" /> class.
        /// </summary>
        /// <param name="certIndex">Index of the certificate within the transaction (required).</param>
        /// <param name="poolId">Bech32 encoded pool ID (required).</param>
        /// <param name="vrfKey">VRF key hash (required).</param>
        /// <param name="pledge">Stake pool certificate pledge in Lovelaces (required).</param>
        /// <param name="marginCost">Margin tax cost of the stake pool (required).</param>
        /// <param name="fixedCost">Fixed tax cost of the stake pool in Lovelaces (required).</param>
        /// <param name="rewardAccount">Bech32 reward account of the stake pool (required).</param>
        /// <param name="owners">owners (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="relays">relays (required).</param>
        /// <param name="activeEpoch">Epoch that the delegation becomes active (required).</param>
        public TxContentPoolCertsInner(int? certIndex = default(int?), string poolId = default(string), string vrfKey = default(string), string pledge = default(string), decimal? marginCost = default(decimal?), string fixedCost = default(string), string rewardAccount = default(string), List<string> owners = default(List<string>), Object metadata = default(Object), List<Object> relays = default(List<Object>), int? activeEpoch = default(int?))
        {
            // to ensure "certIndex" is required (not null)
            if (certIndex == null)
            {
                throw new InvalidDataException("certIndex is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.CertIndex = certIndex;
            }
            // to ensure "poolId" is required (not null)
            if (poolId == null)
            {
                throw new InvalidDataException("poolId is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.PoolId = poolId;
            }
            // to ensure "vrfKey" is required (not null)
            if (vrfKey == null)
            {
                throw new InvalidDataException("vrfKey is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.VrfKey = vrfKey;
            }
            // to ensure "pledge" is required (not null)
            if (pledge == null)
            {
                throw new InvalidDataException("pledge is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.Pledge = pledge;
            }
            // to ensure "marginCost" is required (not null)
            if (marginCost == null)
            {
                throw new InvalidDataException("marginCost is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.MarginCost = marginCost;
            }
            // to ensure "fixedCost" is required (not null)
            if (fixedCost == null)
            {
                throw new InvalidDataException("fixedCost is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.FixedCost = fixedCost;
            }
            // to ensure "rewardAccount" is required (not null)
            if (rewardAccount == null)
            {
                throw new InvalidDataException("rewardAccount is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.RewardAccount = rewardAccount;
            }
            // to ensure "owners" is required (not null)
            if (owners == null)
            {
                throw new InvalidDataException("owners is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.Owners = owners;
            }
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            // to ensure "relays" is required (not null)
            if (relays == null)
            {
                throw new InvalidDataException("relays is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.Relays = relays;
            }
            // to ensure "activeEpoch" is required (not null)
            if (activeEpoch == null)
            {
                throw new InvalidDataException("activeEpoch is a required property for TxContentPoolCertsInner and cannot be null");
            }
            else
            {
                this.ActiveEpoch = activeEpoch;
            }
        }
        
        /// <summary>
        /// Index of the certificate within the transaction
        /// </summary>
        /// <value>Index of the certificate within the transaction</value>
        [DataMember(Name="cert_index", EmitDefaultValue=false)]
        public int? CertIndex { get; set; }

        /// <summary>
        /// Bech32 encoded pool ID
        /// </summary>
        /// <value>Bech32 encoded pool ID</value>
        [DataMember(Name="pool_id", EmitDefaultValue=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// VRF key hash
        /// </summary>
        /// <value>VRF key hash</value>
        [DataMember(Name="vrf_key", EmitDefaultValue=false)]
        public string VrfKey { get; set; }

        /// <summary>
        /// Stake pool certificate pledge in Lovelaces
        /// </summary>
        /// <value>Stake pool certificate pledge in Lovelaces</value>
        [DataMember(Name="pledge", EmitDefaultValue=false)]
        public string Pledge { get; set; }

        /// <summary>
        /// Margin tax cost of the stake pool
        /// </summary>
        /// <value>Margin tax cost of the stake pool</value>
        [DataMember(Name="margin_cost", EmitDefaultValue=false)]
        public decimal? MarginCost { get; set; }

        /// <summary>
        /// Fixed tax cost of the stake pool in Lovelaces
        /// </summary>
        /// <value>Fixed tax cost of the stake pool in Lovelaces</value>
        [DataMember(Name="fixed_cost", EmitDefaultValue=false)]
        public string FixedCost { get; set; }

        /// <summary>
        /// Bech32 reward account of the stake pool
        /// </summary>
        /// <value>Bech32 reward account of the stake pool</value>
        [DataMember(Name="reward_account", EmitDefaultValue=false)]
        public string RewardAccount { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Relays
        /// </summary>
        [DataMember(Name="relays", EmitDefaultValue=false)]
        public List<Object> Relays { get; set; }

        /// <summary>
        /// Epoch that the delegation becomes active
        /// </summary>
        /// <value>Epoch that the delegation becomes active</value>
        [DataMember(Name="active_epoch", EmitDefaultValue=false)]
        public int? ActiveEpoch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxContentPoolCertsInner {\n");
            sb.Append("  CertIndex: ").Append(CertIndex).Append("\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  VrfKey: ").Append(VrfKey).Append("\n");
            sb.Append("  Pledge: ").Append(Pledge).Append("\n");
            sb.Append("  MarginCost: ").Append(MarginCost).Append("\n");
            sb.Append("  FixedCost: ").Append(FixedCost).Append("\n");
            sb.Append("  RewardAccount: ").Append(RewardAccount).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Relays: ").Append(Relays).Append("\n");
            sb.Append("  ActiveEpoch: ").Append(ActiveEpoch).Append("\n");
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
            return this.Equals(input as TxContentPoolCertsInner);
        }

        /// <summary>
        /// Returns true if TxContentPoolCertsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TxContentPoolCertsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TxContentPoolCertsInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertIndex == input.CertIndex ||
                    (this.CertIndex != null &&
                    this.CertIndex.Equals(input.CertIndex))
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.VrfKey == input.VrfKey ||
                    (this.VrfKey != null &&
                    this.VrfKey.Equals(input.VrfKey))
                ) && 
                (
                    this.Pledge == input.Pledge ||
                    (this.Pledge != null &&
                    this.Pledge.Equals(input.Pledge))
                ) && 
                (
                    this.MarginCost == input.MarginCost ||
                    (this.MarginCost != null &&
                    this.MarginCost.Equals(input.MarginCost))
                ) && 
                (
                    this.FixedCost == input.FixedCost ||
                    (this.FixedCost != null &&
                    this.FixedCost.Equals(input.FixedCost))
                ) && 
                (
                    this.RewardAccount == input.RewardAccount ||
                    (this.RewardAccount != null &&
                    this.RewardAccount.Equals(input.RewardAccount))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Relays == input.Relays ||
                    this.Relays != null &&
                    input.Relays != null &&
                    this.Relays.SequenceEqual(input.Relays)
                ) && 
                (
                    this.ActiveEpoch == input.ActiveEpoch ||
                    (this.ActiveEpoch != null &&
                    this.ActiveEpoch.Equals(input.ActiveEpoch))
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
                if (this.CertIndex != null)
                    hashCode = hashCode * 59 + this.CertIndex.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.VrfKey != null)
                    hashCode = hashCode * 59 + this.VrfKey.GetHashCode();
                if (this.Pledge != null)
                    hashCode = hashCode * 59 + this.Pledge.GetHashCode();
                if (this.MarginCost != null)
                    hashCode = hashCode * 59 + this.MarginCost.GetHashCode();
                if (this.FixedCost != null)
                    hashCode = hashCode * 59 + this.FixedCost.GetHashCode();
                if (this.RewardAccount != null)
                    hashCode = hashCode * 59 + this.RewardAccount.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Relays != null)
                    hashCode = hashCode * 59 + this.Relays.GetHashCode();
                if (this.ActiveEpoch != null)
                    hashCode = hashCode * 59 + this.ActiveEpoch.GetHashCode();
                return hashCode;
            }
        }
    }
}
