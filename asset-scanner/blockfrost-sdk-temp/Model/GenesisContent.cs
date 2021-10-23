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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// GenesisContent
    /// </summary>
    [DataContract]
        public partial class GenesisContent :  IEquatable<GenesisContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenesisContent" /> class.
        /// </summary>
        /// <param name="activeSlotsCoefficient">The proportion of slots in which blocks should be issued (required).</param>
        /// <param name="updateQuorum">Determines the quorum needed for votes on the protocol parameter updates (required).</param>
        /// <param name="maxLovelaceSupply">The total number of lovelace in the system (required).</param>
        /// <param name="networkMagic">Network identifier (required).</param>
        /// <param name="epochLength">Number of slots in an epoch (required).</param>
        /// <param name="systemStart">Time of slot 0 in UNIX time (required).</param>
        /// <param name="slotsPerKesPeriod">Number of slots in an KES period (required).</param>
        /// <param name="slotLength">Duration of one slot in seconds (required).</param>
        /// <param name="maxKesEvolutions">The maximum number of time a KES key can be evolved before a pool operator must create a new operational certificate (required).</param>
        /// <param name="securityParam">Security parameter k (required).</param>
        public GenesisContent(decimal? activeSlotsCoefficient = default(decimal?), int? updateQuorum = default(int?), string maxLovelaceSupply = default(string), int? networkMagic = default(int?), int? epochLength = default(int?), int? systemStart = default(int?), int? slotsPerKesPeriod = default(int?), int? slotLength = default(int?), int? maxKesEvolutions = default(int?), int? securityParam = default(int?))
        {
            // to ensure "activeSlotsCoefficient" is required (not null)
            if (activeSlotsCoefficient == null)
            {
                throw new InvalidDataException("activeSlotsCoefficient is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.ActiveSlotsCoefficient = activeSlotsCoefficient;
            }
            // to ensure "updateQuorum" is required (not null)
            if (updateQuorum == null)
            {
                throw new InvalidDataException("updateQuorum is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.UpdateQuorum = updateQuorum;
            }
            // to ensure "maxLovelaceSupply" is required (not null)
            if (maxLovelaceSupply == null)
            {
                throw new InvalidDataException("maxLovelaceSupply is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.MaxLovelaceSupply = maxLovelaceSupply;
            }
            // to ensure "networkMagic" is required (not null)
            if (networkMagic == null)
            {
                throw new InvalidDataException("networkMagic is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.NetworkMagic = networkMagic;
            }
            // to ensure "epochLength" is required (not null)
            if (epochLength == null)
            {
                throw new InvalidDataException("epochLength is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.EpochLength = epochLength;
            }
            // to ensure "systemStart" is required (not null)
            if (systemStart == null)
            {
                throw new InvalidDataException("systemStart is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.SystemStart = systemStart;
            }
            // to ensure "slotsPerKesPeriod" is required (not null)
            if (slotsPerKesPeriod == null)
            {
                throw new InvalidDataException("slotsPerKesPeriod is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.SlotsPerKesPeriod = slotsPerKesPeriod;
            }
            // to ensure "slotLength" is required (not null)
            if (slotLength == null)
            {
                throw new InvalidDataException("slotLength is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.SlotLength = slotLength;
            }
            // to ensure "maxKesEvolutions" is required (not null)
            if (maxKesEvolutions == null)
            {
                throw new InvalidDataException("maxKesEvolutions is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.MaxKesEvolutions = maxKesEvolutions;
            }
            // to ensure "securityParam" is required (not null)
            if (securityParam == null)
            {
                throw new InvalidDataException("securityParam is a required property for GenesisContent and cannot be null");
            }
            else
            {
                this.SecurityParam = securityParam;
            }
        }
        
        /// <summary>
        /// The proportion of slots in which blocks should be issued
        /// </summary>
        /// <value>The proportion of slots in which blocks should be issued</value>
        [DataMember(Name="active_slots_coefficient", EmitDefaultValue=false)]
        public decimal? ActiveSlotsCoefficient { get; set; }

        /// <summary>
        /// Determines the quorum needed for votes on the protocol parameter updates
        /// </summary>
        /// <value>Determines the quorum needed for votes on the protocol parameter updates</value>
        [DataMember(Name="update_quorum", EmitDefaultValue=false)]
        public int? UpdateQuorum { get; set; }

        /// <summary>
        /// The total number of lovelace in the system
        /// </summary>
        /// <value>The total number of lovelace in the system</value>
        [DataMember(Name="max_lovelace_supply", EmitDefaultValue=false)]
        public string MaxLovelaceSupply { get; set; }

        /// <summary>
        /// Network identifier
        /// </summary>
        /// <value>Network identifier</value>
        [DataMember(Name="network_magic", EmitDefaultValue=false)]
        public int? NetworkMagic { get; set; }

        /// <summary>
        /// Number of slots in an epoch
        /// </summary>
        /// <value>Number of slots in an epoch</value>
        [DataMember(Name="epoch_length", EmitDefaultValue=false)]
        public int? EpochLength { get; set; }

        /// <summary>
        /// Time of slot 0 in UNIX time
        /// </summary>
        /// <value>Time of slot 0 in UNIX time</value>
        [DataMember(Name="system_start", EmitDefaultValue=false)]
        public int? SystemStart { get; set; }

        /// <summary>
        /// Number of slots in an KES period
        /// </summary>
        /// <value>Number of slots in an KES period</value>
        [DataMember(Name="slots_per_kes_period", EmitDefaultValue=false)]
        public int? SlotsPerKesPeriod { get; set; }

        /// <summary>
        /// Duration of one slot in seconds
        /// </summary>
        /// <value>Duration of one slot in seconds</value>
        [DataMember(Name="slot_length", EmitDefaultValue=false)]
        public int? SlotLength { get; set; }

        /// <summary>
        /// The maximum number of time a KES key can be evolved before a pool operator must create a new operational certificate
        /// </summary>
        /// <value>The maximum number of time a KES key can be evolved before a pool operator must create a new operational certificate</value>
        [DataMember(Name="max_kes_evolutions", EmitDefaultValue=false)]
        public int? MaxKesEvolutions { get; set; }

        /// <summary>
        /// Security parameter k
        /// </summary>
        /// <value>Security parameter k</value>
        [DataMember(Name="security_param", EmitDefaultValue=false)]
        public int? SecurityParam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenesisContent {\n");
            sb.Append("  ActiveSlotsCoefficient: ").Append(ActiveSlotsCoefficient).Append("\n");
            sb.Append("  UpdateQuorum: ").Append(UpdateQuorum).Append("\n");
            sb.Append("  MaxLovelaceSupply: ").Append(MaxLovelaceSupply).Append("\n");
            sb.Append("  NetworkMagic: ").Append(NetworkMagic).Append("\n");
            sb.Append("  EpochLength: ").Append(EpochLength).Append("\n");
            sb.Append("  SystemStart: ").Append(SystemStart).Append("\n");
            sb.Append("  SlotsPerKesPeriod: ").Append(SlotsPerKesPeriod).Append("\n");
            sb.Append("  SlotLength: ").Append(SlotLength).Append("\n");
            sb.Append("  MaxKesEvolutions: ").Append(MaxKesEvolutions).Append("\n");
            sb.Append("  SecurityParam: ").Append(SecurityParam).Append("\n");
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
            return this.Equals(input as GenesisContent);
        }

        /// <summary>
        /// Returns true if GenesisContent instances are equal
        /// </summary>
        /// <param name="input">Instance of GenesisContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenesisContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveSlotsCoefficient == input.ActiveSlotsCoefficient ||
                    (this.ActiveSlotsCoefficient != null &&
                    this.ActiveSlotsCoefficient.Equals(input.ActiveSlotsCoefficient))
                ) && 
                (
                    this.UpdateQuorum == input.UpdateQuorum ||
                    (this.UpdateQuorum != null &&
                    this.UpdateQuorum.Equals(input.UpdateQuorum))
                ) && 
                (
                    this.MaxLovelaceSupply == input.MaxLovelaceSupply ||
                    (this.MaxLovelaceSupply != null &&
                    this.MaxLovelaceSupply.Equals(input.MaxLovelaceSupply))
                ) && 
                (
                    this.NetworkMagic == input.NetworkMagic ||
                    (this.NetworkMagic != null &&
                    this.NetworkMagic.Equals(input.NetworkMagic))
                ) && 
                (
                    this.EpochLength == input.EpochLength ||
                    (this.EpochLength != null &&
                    this.EpochLength.Equals(input.EpochLength))
                ) && 
                (
                    this.SystemStart == input.SystemStart ||
                    (this.SystemStart != null &&
                    this.SystemStart.Equals(input.SystemStart))
                ) && 
                (
                    this.SlotsPerKesPeriod == input.SlotsPerKesPeriod ||
                    (this.SlotsPerKesPeriod != null &&
                    this.SlotsPerKesPeriod.Equals(input.SlotsPerKesPeriod))
                ) && 
                (
                    this.SlotLength == input.SlotLength ||
                    (this.SlotLength != null &&
                    this.SlotLength.Equals(input.SlotLength))
                ) && 
                (
                    this.MaxKesEvolutions == input.MaxKesEvolutions ||
                    (this.MaxKesEvolutions != null &&
                    this.MaxKesEvolutions.Equals(input.MaxKesEvolutions))
                ) && 
                (
                    this.SecurityParam == input.SecurityParam ||
                    (this.SecurityParam != null &&
                    this.SecurityParam.Equals(input.SecurityParam))
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
                if (this.ActiveSlotsCoefficient != null)
                    hashCode = hashCode * 59 + this.ActiveSlotsCoefficient.GetHashCode();
                if (this.UpdateQuorum != null)
                    hashCode = hashCode * 59 + this.UpdateQuorum.GetHashCode();
                if (this.MaxLovelaceSupply != null)
                    hashCode = hashCode * 59 + this.MaxLovelaceSupply.GetHashCode();
                if (this.NetworkMagic != null)
                    hashCode = hashCode * 59 + this.NetworkMagic.GetHashCode();
                if (this.EpochLength != null)
                    hashCode = hashCode * 59 + this.EpochLength.GetHashCode();
                if (this.SystemStart != null)
                    hashCode = hashCode * 59 + this.SystemStart.GetHashCode();
                if (this.SlotsPerKesPeriod != null)
                    hashCode = hashCode * 59 + this.SlotsPerKesPeriod.GetHashCode();
                if (this.SlotLength != null)
                    hashCode = hashCode * 59 + this.SlotLength.GetHashCode();
                if (this.MaxKesEvolutions != null)
                    hashCode = hashCode * 59 + this.MaxKesEvolutions.GetHashCode();
                if (this.SecurityParam != null)
                    hashCode = hashCode * 59 + this.SecurityParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
