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
    /// BlockContent
    /// </summary>
    [DataContract]
        public partial class BlockContent :  IEquatable<BlockContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockContent" /> class.
        /// </summary>
        /// <param name="time">Block creation time in UNIX time (required).</param>
        /// <param name="height">Block number (required).</param>
        /// <param name="hash">Hash of the block (required).</param>
        /// <param name="slot">Slot number (required).</param>
        /// <param name="epoch">Epoch number (required).</param>
        /// <param name="epochSlot">Slot within the epoch (required).</param>
        /// <param name="slotLeader">Bech32 ID of the slot leader or specific block description in case there is no slot leader (required).</param>
        /// <param name="size">Block size in Bytes (required).</param>
        /// <param name="txCount">Number of transactions in the block (required).</param>
        /// <param name="output">Total output within the block in Lovelaces (required).</param>
        /// <param name="fees">Total fees within the block in Lovelaces (required).</param>
        /// <param name="blockVrf">VRF key of the block (required).</param>
        /// <param name="previousBlock">Hash of the previous block (required).</param>
        /// <param name="nextBlock">Hash of the next block (required).</param>
        /// <param name="confirmations">Number of block confirmations (required).</param>
        public BlockContent(int? time = default(int?), int? height = default(int?), string hash = default(string), int? slot = default(int?), int? epoch = default(int?), int? epochSlot = default(int?), string slotLeader = default(string), int? size = default(int?), int? txCount = default(int?), string output = default(string), string fees = default(string), string blockVrf = default(string), string previousBlock = default(string), string nextBlock = default(string), int? confirmations = default(int?))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Height = height;
            }
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new InvalidDataException("hash is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Hash = hash;
            }
            // to ensure "slot" is required (not null)
            if (slot == null)
            {
                throw new InvalidDataException("slot is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Slot = slot;
            }
            // to ensure "epoch" is required (not null)
            if (epoch == null)
            {
                throw new InvalidDataException("epoch is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Epoch = epoch;
            }
            // to ensure "epochSlot" is required (not null)
            if (epochSlot == null)
            {
                throw new InvalidDataException("epochSlot is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.EpochSlot = epochSlot;
            }
            // to ensure "slotLeader" is required (not null)
            if (slotLeader == null)
            {
                throw new InvalidDataException("slotLeader is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.SlotLeader = slotLeader;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "txCount" is required (not null)
            if (txCount == null)
            {
                throw new InvalidDataException("txCount is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.TxCount = txCount;
            }
            // to ensure "output" is required (not null)
            if (output == null)
            {
                throw new InvalidDataException("output is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Output = output;
            }
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new InvalidDataException("fees is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Fees = fees;
            }
            // to ensure "blockVrf" is required (not null)
            if (blockVrf == null)
            {
                throw new InvalidDataException("blockVrf is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.BlockVrf = blockVrf;
            }
            // to ensure "previousBlock" is required (not null)
            if (previousBlock == null)
            {
                throw new InvalidDataException("previousBlock is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.PreviousBlock = previousBlock;
            }
            // to ensure "nextBlock" is required (not null)
            if (nextBlock == null)
            {
                throw new InvalidDataException("nextBlock is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.NextBlock = nextBlock;
            }
            // to ensure "confirmations" is required (not null)
            if (confirmations == null)
            {
                throw new InvalidDataException("confirmations is a required property for BlockContent and cannot be null");
            }
            else
            {
                this.Confirmations = confirmations;
            }
        }
        
        /// <summary>
        /// Block creation time in UNIX time
        /// </summary>
        /// <value>Block creation time in UNIX time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public int? Time { get; set; }

        /// <summary>
        /// Block number
        /// </summary>
        /// <value>Block number</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Hash of the block
        /// </summary>
        /// <value>Hash of the block</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Slot number
        /// </summary>
        /// <value>Slot number</value>
        [DataMember(Name="slot", EmitDefaultValue=false)]
        public int? Slot { get; set; }

        /// <summary>
        /// Epoch number
        /// </summary>
        /// <value>Epoch number</value>
        [DataMember(Name="epoch", EmitDefaultValue=false)]
        public int? Epoch { get; set; }

        /// <summary>
        /// Slot within the epoch
        /// </summary>
        /// <value>Slot within the epoch</value>
        [DataMember(Name="epoch_slot", EmitDefaultValue=false)]
        public int? EpochSlot { get; set; }

        /// <summary>
        /// Bech32 ID of the slot leader or specific block description in case there is no slot leader
        /// </summary>
        /// <value>Bech32 ID of the slot leader or specific block description in case there is no slot leader</value>
        [DataMember(Name="slot_leader", EmitDefaultValue=false)]
        public string SlotLeader { get; set; }

        /// <summary>
        /// Block size in Bytes
        /// </summary>
        /// <value>Block size in Bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Number of transactions in the block
        /// </summary>
        /// <value>Number of transactions in the block</value>
        [DataMember(Name="tx_count", EmitDefaultValue=false)]
        public int? TxCount { get; set; }

        /// <summary>
        /// Total output within the block in Lovelaces
        /// </summary>
        /// <value>Total output within the block in Lovelaces</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }

        /// <summary>
        /// Total fees within the block in Lovelaces
        /// </summary>
        /// <value>Total fees within the block in Lovelaces</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public string Fees { get; set; }

        /// <summary>
        /// VRF key of the block
        /// </summary>
        /// <value>VRF key of the block</value>
        [DataMember(Name="block_vrf", EmitDefaultValue=false)]
        public string BlockVrf { get; set; }

        /// <summary>
        /// Hash of the previous block
        /// </summary>
        /// <value>Hash of the previous block</value>
        [DataMember(Name="previous_block", EmitDefaultValue=false)]
        public string PreviousBlock { get; set; }

        /// <summary>
        /// Hash of the next block
        /// </summary>
        /// <value>Hash of the next block</value>
        [DataMember(Name="next_block", EmitDefaultValue=false)]
        public string NextBlock { get; set; }

        /// <summary>
        /// Number of block confirmations
        /// </summary>
        /// <value>Number of block confirmations</value>
        [DataMember(Name="confirmations", EmitDefaultValue=false)]
        public int? Confirmations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockContent {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  Epoch: ").Append(Epoch).Append("\n");
            sb.Append("  EpochSlot: ").Append(EpochSlot).Append("\n");
            sb.Append("  SlotLeader: ").Append(SlotLeader).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TxCount: ").Append(TxCount).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  BlockVrf: ").Append(BlockVrf).Append("\n");
            sb.Append("  PreviousBlock: ").Append(PreviousBlock).Append("\n");
            sb.Append("  NextBlock: ").Append(NextBlock).Append("\n");
            sb.Append("  Confirmations: ").Append(Confirmations).Append("\n");
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
            return this.Equals(input as BlockContent);
        }

        /// <summary>
        /// Returns true if BlockContent instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
                ) && 
                (
                    this.Epoch == input.Epoch ||
                    (this.Epoch != null &&
                    this.Epoch.Equals(input.Epoch))
                ) && 
                (
                    this.EpochSlot == input.EpochSlot ||
                    (this.EpochSlot != null &&
                    this.EpochSlot.Equals(input.EpochSlot))
                ) && 
                (
                    this.SlotLeader == input.SlotLeader ||
                    (this.SlotLeader != null &&
                    this.SlotLeader.Equals(input.SlotLeader))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                    this.BlockVrf == input.BlockVrf ||
                    (this.BlockVrf != null &&
                    this.BlockVrf.Equals(input.BlockVrf))
                ) && 
                (
                    this.PreviousBlock == input.PreviousBlock ||
                    (this.PreviousBlock != null &&
                    this.PreviousBlock.Equals(input.PreviousBlock))
                ) && 
                (
                    this.NextBlock == input.NextBlock ||
                    (this.NextBlock != null &&
                    this.NextBlock.Equals(input.NextBlock))
                ) && 
                (
                    this.Confirmations == input.Confirmations ||
                    (this.Confirmations != null &&
                    this.Confirmations.Equals(input.Confirmations))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Slot != null)
                    hashCode = hashCode * 59 + this.Slot.GetHashCode();
                if (this.Epoch != null)
                    hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.EpochSlot != null)
                    hashCode = hashCode * 59 + this.EpochSlot.GetHashCode();
                if (this.SlotLeader != null)
                    hashCode = hashCode * 59 + this.SlotLeader.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TxCount != null)
                    hashCode = hashCode * 59 + this.TxCount.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.BlockVrf != null)
                    hashCode = hashCode * 59 + this.BlockVrf.GetHashCode();
                if (this.PreviousBlock != null)
                    hashCode = hashCode * 59 + this.PreviousBlock.GetHashCode();
                if (this.NextBlock != null)
                    hashCode = hashCode * 59 + this.NextBlock.GetHashCode();
                if (this.Confirmations != null)
                    hashCode = hashCode * 59 + this.Confirmations.GetHashCode();
                return hashCode;
            }
        }
    }
}
