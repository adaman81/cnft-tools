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
    /// EpochContent
    /// </summary>
    [DataContract]
        public partial class EpochContent :  IEquatable<EpochContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpochContent" /> class.
        /// </summary>
        /// <param name="epoch">Epoch number (required).</param>
        /// <param name="startTime">Unix time of the start of the epoch (required).</param>
        /// <param name="endTime">Unix time of the end of the epoch (required).</param>
        /// <param name="firstBlockTime">Unix time of the first block of the epoch (required).</param>
        /// <param name="lastBlockTime">Unix time of the last block of the epoch (required).</param>
        /// <param name="blockCount">Number of blocks within the epoch (required).</param>
        /// <param name="txCount">Number of transactions within the epoch (required).</param>
        /// <param name="output">Sum of all the transactions within the epoch in Lovelaces (required).</param>
        /// <param name="fees">Sum of all the fees within the epoch in Lovelaces (required).</param>
        /// <param name="activeStake">Sum of all the active stakes within the epoch in Lovelaces (required).</param>
        public EpochContent(int? epoch = default(int?), int? startTime = default(int?), int? endTime = default(int?), int? firstBlockTime = default(int?), int? lastBlockTime = default(int?), int? blockCount = default(int?), int? txCount = default(int?), string output = default(string), string fees = default(string), string activeStake = default(string))
        {
            // to ensure "epoch" is required (not null)
            if (epoch == null)
            {
                throw new InvalidDataException("epoch is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.Epoch = epoch;
            }
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new InvalidDataException("endTime is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.EndTime = endTime;
            }
            // to ensure "firstBlockTime" is required (not null)
            if (firstBlockTime == null)
            {
                throw new InvalidDataException("firstBlockTime is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.FirstBlockTime = firstBlockTime;
            }
            // to ensure "lastBlockTime" is required (not null)
            if (lastBlockTime == null)
            {
                throw new InvalidDataException("lastBlockTime is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.LastBlockTime = lastBlockTime;
            }
            // to ensure "blockCount" is required (not null)
            if (blockCount == null)
            {
                throw new InvalidDataException("blockCount is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.BlockCount = blockCount;
            }
            // to ensure "txCount" is required (not null)
            if (txCount == null)
            {
                throw new InvalidDataException("txCount is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.TxCount = txCount;
            }
            // to ensure "output" is required (not null)
            if (output == null)
            {
                throw new InvalidDataException("output is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.Output = output;
            }
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new InvalidDataException("fees is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.Fees = fees;
            }
            // to ensure "activeStake" is required (not null)
            if (activeStake == null)
            {
                throw new InvalidDataException("activeStake is a required property for EpochContent and cannot be null");
            }
            else
            {
                this.ActiveStake = activeStake;
            }
        }
        
        /// <summary>
        /// Epoch number
        /// </summary>
        /// <value>Epoch number</value>
        [DataMember(Name="epoch", EmitDefaultValue=false)]
        public int? Epoch { get; set; }

        /// <summary>
        /// Unix time of the start of the epoch
        /// </summary>
        /// <value>Unix time of the start of the epoch</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// Unix time of the end of the epoch
        /// </summary>
        /// <value>Unix time of the end of the epoch</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// Unix time of the first block of the epoch
        /// </summary>
        /// <value>Unix time of the first block of the epoch</value>
        [DataMember(Name="first_block_time", EmitDefaultValue=false)]
        public int? FirstBlockTime { get; set; }

        /// <summary>
        /// Unix time of the last block of the epoch
        /// </summary>
        /// <value>Unix time of the last block of the epoch</value>
        [DataMember(Name="last_block_time", EmitDefaultValue=false)]
        public int? LastBlockTime { get; set; }

        /// <summary>
        /// Number of blocks within the epoch
        /// </summary>
        /// <value>Number of blocks within the epoch</value>
        [DataMember(Name="block_count", EmitDefaultValue=false)]
        public int? BlockCount { get; set; }

        /// <summary>
        /// Number of transactions within the epoch
        /// </summary>
        /// <value>Number of transactions within the epoch</value>
        [DataMember(Name="tx_count", EmitDefaultValue=false)]
        public int? TxCount { get; set; }

        /// <summary>
        /// Sum of all the transactions within the epoch in Lovelaces
        /// </summary>
        /// <value>Sum of all the transactions within the epoch in Lovelaces</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }

        /// <summary>
        /// Sum of all the fees within the epoch in Lovelaces
        /// </summary>
        /// <value>Sum of all the fees within the epoch in Lovelaces</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public string Fees { get; set; }

        /// <summary>
        /// Sum of all the active stakes within the epoch in Lovelaces
        /// </summary>
        /// <value>Sum of all the active stakes within the epoch in Lovelaces</value>
        [DataMember(Name="active_stake", EmitDefaultValue=false)]
        public string ActiveStake { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpochContent {\n");
            sb.Append("  Epoch: ").Append(Epoch).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  FirstBlockTime: ").Append(FirstBlockTime).Append("\n");
            sb.Append("  LastBlockTime: ").Append(LastBlockTime).Append("\n");
            sb.Append("  BlockCount: ").Append(BlockCount).Append("\n");
            sb.Append("  TxCount: ").Append(TxCount).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  ActiveStake: ").Append(ActiveStake).Append("\n");
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
            return this.Equals(input as EpochContent);
        }

        /// <summary>
        /// Returns true if EpochContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EpochContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EpochContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Epoch == input.Epoch ||
                    (this.Epoch != null &&
                    this.Epoch.Equals(input.Epoch))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.FirstBlockTime == input.FirstBlockTime ||
                    (this.FirstBlockTime != null &&
                    this.FirstBlockTime.Equals(input.FirstBlockTime))
                ) && 
                (
                    this.LastBlockTime == input.LastBlockTime ||
                    (this.LastBlockTime != null &&
                    this.LastBlockTime.Equals(input.LastBlockTime))
                ) && 
                (
                    this.BlockCount == input.BlockCount ||
                    (this.BlockCount != null &&
                    this.BlockCount.Equals(input.BlockCount))
                ) && 
                (
                    this.TxCount == input.TxCount ||
                    (this.TxCount != null &&
                    this.TxCount.Equals(input.TxCount))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.ActiveStake == input.ActiveStake ||
                    (this.ActiveStake != null &&
                    this.ActiveStake.Equals(input.ActiveStake))
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
                if (this.Epoch != null)
                    hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.FirstBlockTime != null)
                    hashCode = hashCode * 59 + this.FirstBlockTime.GetHashCode();
                if (this.LastBlockTime != null)
                    hashCode = hashCode * 59 + this.LastBlockTime.GetHashCode();
                if (this.BlockCount != null)
                    hashCode = hashCode * 59 + this.BlockCount.GetHashCode();
                if (this.TxCount != null)
                    hashCode = hashCode * 59 + this.TxCount.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.ActiveStake != null)
                    hashCode = hashCode * 59 + this.ActiveStake.GetHashCode();
                return hashCode;
            }
        }
    }
}
