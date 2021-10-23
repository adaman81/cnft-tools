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
    /// Pool
    /// </summary>
    [DataContract]
        public partial class Pool :  IEquatable<Pool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pool" /> class.
        /// </summary>
        /// <param name="poolId">Bech32 pool ID (required).</param>
        /// <param name="hex">Hexadecimal pool ID. (required).</param>
        /// <param name="vrfKey">VRF key hash (required).</param>
        /// <param name="blocksMinted">Total minted blocks (required).</param>
        /// <param name="liveStake">liveStake (required).</param>
        /// <param name="liveSize">liveSize (required).</param>
        /// <param name="liveSaturation">liveSaturation (required).</param>
        /// <param name="liveDelegators">liveDelegators (required).</param>
        /// <param name="activeStake">activeStake (required).</param>
        /// <param name="activeSize">activeSize (required).</param>
        /// <param name="declaredPledge">Stake pool certificate pledge (required).</param>
        /// <param name="livePledge">Stake pool current pledge (required).</param>
        /// <param name="marginCost">Margin tax cost of the stake pool (required).</param>
        /// <param name="fixedCost">Fixed tax cost of the stake pool (required).</param>
        /// <param name="rewardAccount">Bech32 reward account of the stake pool (required).</param>
        /// <param name="owners">owners (required).</param>
        /// <param name="registration">registration (required).</param>
        /// <param name="retirement">retirement (required).</param>
        public Pool(string poolId = default(string), string hex = default(string), string vrfKey = default(string), int? blocksMinted = default(int?), string liveStake = default(string), decimal? liveSize = default(decimal?), decimal? liveSaturation = default(decimal?), decimal? liveDelegators = default(decimal?), string activeStake = default(string), decimal? activeSize = default(decimal?), string declaredPledge = default(string), string livePledge = default(string), decimal? marginCost = default(decimal?), string fixedCost = default(string), string rewardAccount = default(string), List<string> owners = default(List<string>), List<string> registration = default(List<string>), List<string> retirement = default(List<string>))
        {
            // to ensure "poolId" is required (not null)
            if (poolId == null)
            {
                throw new InvalidDataException("poolId is a required property for Pool and cannot be null");
            }
            else
            {
                this.PoolId = poolId;
            }
            // to ensure "hex" is required (not null)
            if (hex == null)
            {
                throw new InvalidDataException("hex is a required property for Pool and cannot be null");
            }
            else
            {
                this.Hex = hex;
            }
            // to ensure "vrfKey" is required (not null)
            if (vrfKey == null)
            {
                throw new InvalidDataException("vrfKey is a required property for Pool and cannot be null");
            }
            else
            {
                this.VrfKey = vrfKey;
            }
            // to ensure "blocksMinted" is required (not null)
            if (blocksMinted == null)
            {
                throw new InvalidDataException("blocksMinted is a required property for Pool and cannot be null");
            }
            else
            {
                this.BlocksMinted = blocksMinted;
            }
            // to ensure "liveStake" is required (not null)
            if (liveStake == null)
            {
                throw new InvalidDataException("liveStake is a required property for Pool and cannot be null");
            }
            else
            {
                this.LiveStake = liveStake;
            }
            // to ensure "liveSize" is required (not null)
            if (liveSize == null)
            {
                throw new InvalidDataException("liveSize is a required property for Pool and cannot be null");
            }
            else
            {
                this.LiveSize = liveSize;
            }
            // to ensure "liveSaturation" is required (not null)
            if (liveSaturation == null)
            {
                throw new InvalidDataException("liveSaturation is a required property for Pool and cannot be null");
            }
            else
            {
                this.LiveSaturation = liveSaturation;
            }
            // to ensure "liveDelegators" is required (not null)
            if (liveDelegators == null)
            {
                throw new InvalidDataException("liveDelegators is a required property for Pool and cannot be null");
            }
            else
            {
                this.LiveDelegators = liveDelegators;
            }
            // to ensure "activeStake" is required (not null)
            if (activeStake == null)
            {
                throw new InvalidDataException("activeStake is a required property for Pool and cannot be null");
            }
            else
            {
                this.ActiveStake = activeStake;
            }
            // to ensure "activeSize" is required (not null)
            if (activeSize == null)
            {
                throw new InvalidDataException("activeSize is a required property for Pool and cannot be null");
            }
            else
            {
                this.ActiveSize = activeSize;
            }
            // to ensure "declaredPledge" is required (not null)
            if (declaredPledge == null)
            {
                throw new InvalidDataException("declaredPledge is a required property for Pool and cannot be null");
            }
            else
            {
                this.DeclaredPledge = declaredPledge;
            }
            // to ensure "livePledge" is required (not null)
            if (livePledge == null)
            {
                throw new InvalidDataException("livePledge is a required property for Pool and cannot be null");
            }
            else
            {
                this.LivePledge = livePledge;
            }
            // to ensure "marginCost" is required (not null)
            if (marginCost == null)
            {
                throw new InvalidDataException("marginCost is a required property for Pool and cannot be null");
            }
            else
            {
                this.MarginCost = marginCost;
            }
            // to ensure "fixedCost" is required (not null)
            if (fixedCost == null)
            {
                throw new InvalidDataException("fixedCost is a required property for Pool and cannot be null");
            }
            else
            {
                this.FixedCost = fixedCost;
            }
            // to ensure "rewardAccount" is required (not null)
            if (rewardAccount == null)
            {
                throw new InvalidDataException("rewardAccount is a required property for Pool and cannot be null");
            }
            else
            {
                this.RewardAccount = rewardAccount;
            }
            // to ensure "owners" is required (not null)
            if (owners == null)
            {
                throw new InvalidDataException("owners is a required property for Pool and cannot be null");
            }
            else
            {
                this.Owners = owners;
            }
            // to ensure "registration" is required (not null)
            if (registration == null)
            {
                throw new InvalidDataException("registration is a required property for Pool and cannot be null");
            }
            else
            {
                this.Registration = registration;
            }
            // to ensure "retirement" is required (not null)
            if (retirement == null)
            {
                throw new InvalidDataException("retirement is a required property for Pool and cannot be null");
            }
            else
            {
                this.Retirement = retirement;
            }
        }
        
        /// <summary>
        /// Bech32 pool ID
        /// </summary>
        /// <value>Bech32 pool ID</value>
        [DataMember(Name="pool_id", EmitDefaultValue=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// Hexadecimal pool ID.
        /// </summary>
        /// <value>Hexadecimal pool ID.</value>
        [DataMember(Name="hex", EmitDefaultValue=false)]
        public string Hex { get; set; }

        /// <summary>
        /// VRF key hash
        /// </summary>
        /// <value>VRF key hash</value>
        [DataMember(Name="vrf_key", EmitDefaultValue=false)]
        public string VrfKey { get; set; }

        /// <summary>
        /// Total minted blocks
        /// </summary>
        /// <value>Total minted blocks</value>
        [DataMember(Name="blocks_minted", EmitDefaultValue=false)]
        public int? BlocksMinted { get; set; }

        /// <summary>
        /// Gets or Sets LiveStake
        /// </summary>
        [DataMember(Name="live_stake", EmitDefaultValue=false)]
        public string LiveStake { get; set; }

        /// <summary>
        /// Gets or Sets LiveSize
        /// </summary>
        [DataMember(Name="live_size", EmitDefaultValue=false)]
        public decimal? LiveSize { get; set; }

        /// <summary>
        /// Gets or Sets LiveSaturation
        /// </summary>
        [DataMember(Name="live_saturation", EmitDefaultValue=false)]
        public decimal? LiveSaturation { get; set; }

        /// <summary>
        /// Gets or Sets LiveDelegators
        /// </summary>
        [DataMember(Name="live_delegators", EmitDefaultValue=false)]
        public decimal? LiveDelegators { get; set; }

        /// <summary>
        /// Gets or Sets ActiveStake
        /// </summary>
        [DataMember(Name="active_stake", EmitDefaultValue=false)]
        public string ActiveStake { get; set; }

        /// <summary>
        /// Gets or Sets ActiveSize
        /// </summary>
        [DataMember(Name="active_size", EmitDefaultValue=false)]
        public decimal? ActiveSize { get; set; }

        /// <summary>
        /// Stake pool certificate pledge
        /// </summary>
        /// <value>Stake pool certificate pledge</value>
        [DataMember(Name="declared_pledge", EmitDefaultValue=false)]
        public string DeclaredPledge { get; set; }

        /// <summary>
        /// Stake pool current pledge
        /// </summary>
        /// <value>Stake pool current pledge</value>
        [DataMember(Name="live_pledge", EmitDefaultValue=false)]
        public string LivePledge { get; set; }

        /// <summary>
        /// Margin tax cost of the stake pool
        /// </summary>
        /// <value>Margin tax cost of the stake pool</value>
        [DataMember(Name="margin_cost", EmitDefaultValue=false)]
        public decimal? MarginCost { get; set; }

        /// <summary>
        /// Fixed tax cost of the stake pool
        /// </summary>
        /// <value>Fixed tax cost of the stake pool</value>
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
        /// Gets or Sets Registration
        /// </summary>
        [DataMember(Name="registration", EmitDefaultValue=false)]
        public List<string> Registration { get; set; }

        /// <summary>
        /// Gets or Sets Retirement
        /// </summary>
        [DataMember(Name="retirement", EmitDefaultValue=false)]
        public List<string> Retirement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pool {\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  VrfKey: ").Append(VrfKey).Append("\n");
            sb.Append("  BlocksMinted: ").Append(BlocksMinted).Append("\n");
            sb.Append("  LiveStake: ").Append(LiveStake).Append("\n");
            sb.Append("  LiveSize: ").Append(LiveSize).Append("\n");
            sb.Append("  LiveSaturation: ").Append(LiveSaturation).Append("\n");
            sb.Append("  LiveDelegators: ").Append(LiveDelegators).Append("\n");
            sb.Append("  ActiveStake: ").Append(ActiveStake).Append("\n");
            sb.Append("  ActiveSize: ").Append(ActiveSize).Append("\n");
            sb.Append("  DeclaredPledge: ").Append(DeclaredPledge).Append("\n");
            sb.Append("  LivePledge: ").Append(LivePledge).Append("\n");
            sb.Append("  MarginCost: ").Append(MarginCost).Append("\n");
            sb.Append("  FixedCost: ").Append(FixedCost).Append("\n");
            sb.Append("  RewardAccount: ").Append(RewardAccount).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Registration: ").Append(Registration).Append("\n");
            sb.Append("  Retirement: ").Append(Retirement).Append("\n");
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
            return this.Equals(input as Pool);
        }

        /// <summary>
        /// Returns true if Pool instances are equal
        /// </summary>
        /// <param name="input">Instance of Pool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pool input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.VrfKey == input.VrfKey ||
                    (this.VrfKey != null &&
                    this.VrfKey.Equals(input.VrfKey))
                ) && 
                (
                    this.BlocksMinted == input.BlocksMinted ||
                    (this.BlocksMinted != null &&
                    this.BlocksMinted.Equals(input.BlocksMinted))
                ) && 
                (
                    this.LiveStake == input.LiveStake ||
                    (this.LiveStake != null &&
                    this.LiveStake.Equals(input.LiveStake))
                ) && 
                (
                    this.LiveSize == input.LiveSize ||
                    (this.LiveSize != null &&
                    this.LiveSize.Equals(input.LiveSize))
                ) && 
                (
                    this.LiveSaturation == input.LiveSaturation ||
                    (this.LiveSaturation != null &&
                    this.LiveSaturation.Equals(input.LiveSaturation))
                ) && 
                (
                    this.LiveDelegators == input.LiveDelegators ||
                    (this.LiveDelegators != null &&
                    this.LiveDelegators.Equals(input.LiveDelegators))
                ) && 
                (
                    this.ActiveStake == input.ActiveStake ||
                    (this.ActiveStake != null &&
                    this.ActiveStake.Equals(input.ActiveStake))
                ) && 
                (
                    this.ActiveSize == input.ActiveSize ||
                    (this.ActiveSize != null &&
                    this.ActiveSize.Equals(input.ActiveSize))
                ) && 
                (
                    this.DeclaredPledge == input.DeclaredPledge ||
                    (this.DeclaredPledge != null &&
                    this.DeclaredPledge.Equals(input.DeclaredPledge))
                ) && 
                (
                    this.LivePledge == input.LivePledge ||
                    (this.LivePledge != null &&
                    this.LivePledge.Equals(input.LivePledge))
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
                    this.Registration == input.Registration ||
                    this.Registration != null &&
                    input.Registration != null &&
                    this.Registration.SequenceEqual(input.Registration)
                ) && 
                (
                    this.Retirement == input.Retirement ||
                    this.Retirement != null &&
                    input.Retirement != null &&
                    this.Retirement.SequenceEqual(input.Retirement)
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Hex != null)
                    hashCode = hashCode * 59 + this.Hex.GetHashCode();
                if (this.VrfKey != null)
                    hashCode = hashCode * 59 + this.VrfKey.GetHashCode();
                if (this.BlocksMinted != null)
                    hashCode = hashCode * 59 + this.BlocksMinted.GetHashCode();
                if (this.LiveStake != null)
                    hashCode = hashCode * 59 + this.LiveStake.GetHashCode();
                if (this.LiveSize != null)
                    hashCode = hashCode * 59 + this.LiveSize.GetHashCode();
                if (this.LiveSaturation != null)
                    hashCode = hashCode * 59 + this.LiveSaturation.GetHashCode();
                if (this.LiveDelegators != null)
                    hashCode = hashCode * 59 + this.LiveDelegators.GetHashCode();
                if (this.ActiveStake != null)
                    hashCode = hashCode * 59 + this.ActiveStake.GetHashCode();
                if (this.ActiveSize != null)
                    hashCode = hashCode * 59 + this.ActiveSize.GetHashCode();
                if (this.DeclaredPledge != null)
                    hashCode = hashCode * 59 + this.DeclaredPledge.GetHashCode();
                if (this.LivePledge != null)
                    hashCode = hashCode * 59 + this.LivePledge.GetHashCode();
                if (this.MarginCost != null)
                    hashCode = hashCode * 59 + this.MarginCost.GetHashCode();
                if (this.FixedCost != null)
                    hashCode = hashCode * 59 + this.FixedCost.GetHashCode();
                if (this.RewardAccount != null)
                    hashCode = hashCode * 59 + this.RewardAccount.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Registration != null)
                    hashCode = hashCode * 59 + this.Registration.GetHashCode();
                if (this.Retirement != null)
                    hashCode = hashCode * 59 + this.Retirement.GetHashCode();
                return hashCode;
            }
        }
    }
}
