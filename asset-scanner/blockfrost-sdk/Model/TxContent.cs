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
    /// TxContent
    /// </summary>
    [DataContract]
        public partial class TxContent :  IEquatable<TxContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxContent" /> class.
        /// </summary>
        /// <param name="hash">Transaction hash (required).</param>
        /// <param name="block">Block hash (required).</param>
        /// <param name="blockHeight">Block number (required).</param>
        /// <param name="slot">Slot number (required).</param>
        /// <param name="index">Transaction index within the block (required).</param>
        /// <param name="outputAmount">outputAmount (required).</param>
        /// <param name="fees">Fees of the transaction in Lovelaces (required).</param>
        /// <param name="deposit">Deposit within the transaction in Lovelaces (required).</param>
        /// <param name="size">Size of the transaction in Bytes (required).</param>
        /// <param name="invalidBefore">Left (included) endpoint of the timelock validity intervals (required).</param>
        /// <param name="invalidHereafter">Right (excluded) endpoint of the timelock validity intervals (required).</param>
        /// <param name="utxoCount">Count of UTXOs within the transaction (required).</param>
        /// <param name="withdrawalCount">Count of the withdrawals within the transaction (required).</param>
        /// <param name="mirCertCount">Count of the MIR certificates within the transaction (required).</param>
        /// <param name="delegationCount">Count of the delegations within the transaction (required).</param>
        /// <param name="stakeCertCount">Count of the stake keys (de)registration within the transaction (required).</param>
        /// <param name="poolUpdateCount">Count of the stake pool registration and update certificates within the transaction (required).</param>
        /// <param name="poolRetireCount">Count of the stake pool retirement certificates within the transaction (required).</param>
        /// <param name="assetMintOrBurnCount">Count of asset mints and burns within the transaction (required).</param>
        /// <param name="redeemerCount">Count of redeemers within the transaction (required).</param>
        /// <param name="validContract">True if contract script passed validation (required).</param>
        public TxContent(string hash = default(string), string block = default(string), int? blockHeight = default(int?), int? slot = default(int?), int? index = default(int?), List<TxContentOutputAmount> outputAmount = default(List<TxContentOutputAmount>), string fees = default(string), string deposit = default(string), int? size = default(int?), string invalidBefore = default(string), string invalidHereafter = default(string), int? utxoCount = default(int?), int? withdrawalCount = default(int?), int? mirCertCount = default(int?), int? delegationCount = default(int?), int? stakeCertCount = default(int?), int? poolUpdateCount = default(int?), int? poolRetireCount = default(int?), int? assetMintOrBurnCount = default(int?), int? redeemerCount = default(int?), bool? validContract = default(bool?))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new InvalidDataException("hash is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Hash = hash;
            }
            // to ensure "block" is required (not null)
            if (block == null)
            {
                throw new InvalidDataException("block is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Block = block;
            }
            // to ensure "blockHeight" is required (not null)
            if (blockHeight == null)
            {
                throw new InvalidDataException("blockHeight is a required property for TxContent and cannot be null");
            }
            else
            {
                this.BlockHeight = blockHeight;
            }
            // to ensure "slot" is required (not null)
            if (slot == null)
            {
                throw new InvalidDataException("slot is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Slot = slot;
            }
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            // to ensure "outputAmount" is required (not null)
            if (outputAmount == null)
            {
                throw new InvalidDataException("outputAmount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.OutputAmount = outputAmount;
            }
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new InvalidDataException("fees is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Fees = fees;
            }
            // to ensure "deposit" is required (not null)
            if (deposit == null)
            {
                throw new InvalidDataException("deposit is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Deposit = deposit;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for TxContent and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "invalidBefore" is required (not null)
            if (invalidBefore == null)
            {
                throw new InvalidDataException("invalidBefore is a required property for TxContent and cannot be null");
            }
            else
            {
                this.InvalidBefore = invalidBefore;
            }
            // to ensure "invalidHereafter" is required (not null)
            if (invalidHereafter == null)
            {
                throw new InvalidDataException("invalidHereafter is a required property for TxContent and cannot be null");
            }
            else
            {
                this.InvalidHereafter = invalidHereafter;
            }
            // to ensure "utxoCount" is required (not null)
            if (utxoCount == null)
            {
                throw new InvalidDataException("utxoCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.UtxoCount = utxoCount;
            }
            // to ensure "withdrawalCount" is required (not null)
            if (withdrawalCount == null)
            {
                throw new InvalidDataException("withdrawalCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.WithdrawalCount = withdrawalCount;
            }
            // to ensure "mirCertCount" is required (not null)
            if (mirCertCount == null)
            {
                throw new InvalidDataException("mirCertCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.MirCertCount = mirCertCount;
            }
            // to ensure "delegationCount" is required (not null)
            if (delegationCount == null)
            {
                throw new InvalidDataException("delegationCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.DelegationCount = delegationCount;
            }
            // to ensure "stakeCertCount" is required (not null)
            if (stakeCertCount == null)
            {
                throw new InvalidDataException("stakeCertCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.StakeCertCount = stakeCertCount;
            }
            // to ensure "poolUpdateCount" is required (not null)
            if (poolUpdateCount == null)
            {
                throw new InvalidDataException("poolUpdateCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.PoolUpdateCount = poolUpdateCount;
            }
            // to ensure "poolRetireCount" is required (not null)
            if (poolRetireCount == null)
            {
                throw new InvalidDataException("poolRetireCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.PoolRetireCount = poolRetireCount;
            }
            // to ensure "assetMintOrBurnCount" is required (not null)
            if (assetMintOrBurnCount == null)
            {
                throw new InvalidDataException("assetMintOrBurnCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.AssetMintOrBurnCount = assetMintOrBurnCount;
            }
            // to ensure "redeemerCount" is required (not null)
            if (redeemerCount == null)
            {
                throw new InvalidDataException("redeemerCount is a required property for TxContent and cannot be null");
            }
            else
            {
                this.RedeemerCount = redeemerCount;
            }
            // to ensure "validContract" is required (not null)
            if (validContract == null)
            {
                throw new InvalidDataException("validContract is a required property for TxContent and cannot be null");
            }
            else
            {
                this.ValidContract = validContract;
            }
        }
        
        /// <summary>
        /// Transaction hash
        /// </summary>
        /// <value>Transaction hash</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Block hash
        /// </summary>
        /// <value>Block hash</value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public string Block { get; set; }

        /// <summary>
        /// Block number
        /// </summary>
        /// <value>Block number</value>
        [DataMember(Name="block_height", EmitDefaultValue=false)]
        public int? BlockHeight { get; set; }

        /// <summary>
        /// Slot number
        /// </summary>
        /// <value>Slot number</value>
        [DataMember(Name="slot", EmitDefaultValue=false)]
        public int? Slot { get; set; }

        /// <summary>
        /// Transaction index within the block
        /// </summary>
        /// <value>Transaction index within the block</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets OutputAmount
        /// </summary>
        [DataMember(Name="output_amount", EmitDefaultValue=false)]
        public List<TxContentOutputAmount> OutputAmount { get; set; }

        /// <summary>
        /// Fees of the transaction in Lovelaces
        /// </summary>
        /// <value>Fees of the transaction in Lovelaces</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public string Fees { get; set; }

        /// <summary>
        /// Deposit within the transaction in Lovelaces
        /// </summary>
        /// <value>Deposit within the transaction in Lovelaces</value>
        [DataMember(Name="deposit", EmitDefaultValue=false)]
        public string Deposit { get; set; }

        /// <summary>
        /// Size of the transaction in Bytes
        /// </summary>
        /// <value>Size of the transaction in Bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Left (included) endpoint of the timelock validity intervals
        /// </summary>
        /// <value>Left (included) endpoint of the timelock validity intervals</value>
        [DataMember(Name="invalid_before", EmitDefaultValue=false)]
        public string InvalidBefore { get; set; }

        /// <summary>
        /// Right (excluded) endpoint of the timelock validity intervals
        /// </summary>
        /// <value>Right (excluded) endpoint of the timelock validity intervals</value>
        [DataMember(Name="invalid_hereafter", EmitDefaultValue=false)]
        public string InvalidHereafter { get; set; }

        /// <summary>
        /// Count of UTXOs within the transaction
        /// </summary>
        /// <value>Count of UTXOs within the transaction</value>
        [DataMember(Name="utxo_count", EmitDefaultValue=false)]
        public int? UtxoCount { get; set; }

        /// <summary>
        /// Count of the withdrawals within the transaction
        /// </summary>
        /// <value>Count of the withdrawals within the transaction</value>
        [DataMember(Name="withdrawal_count", EmitDefaultValue=false)]
        public int? WithdrawalCount { get; set; }

        /// <summary>
        /// Count of the MIR certificates within the transaction
        /// </summary>
        /// <value>Count of the MIR certificates within the transaction</value>
        [DataMember(Name="mir_cert_count", EmitDefaultValue=false)]
        public int? MirCertCount { get; set; }

        /// <summary>
        /// Count of the delegations within the transaction
        /// </summary>
        /// <value>Count of the delegations within the transaction</value>
        [DataMember(Name="delegation_count", EmitDefaultValue=false)]
        public int? DelegationCount { get; set; }

        /// <summary>
        /// Count of the stake keys (de)registration within the transaction
        /// </summary>
        /// <value>Count of the stake keys (de)registration within the transaction</value>
        [DataMember(Name="stake_cert_count", EmitDefaultValue=false)]
        public int? StakeCertCount { get; set; }

        /// <summary>
        /// Count of the stake pool registration and update certificates within the transaction
        /// </summary>
        /// <value>Count of the stake pool registration and update certificates within the transaction</value>
        [DataMember(Name="pool_update_count", EmitDefaultValue=false)]
        public int? PoolUpdateCount { get; set; }

        /// <summary>
        /// Count of the stake pool retirement certificates within the transaction
        /// </summary>
        /// <value>Count of the stake pool retirement certificates within the transaction</value>
        [DataMember(Name="pool_retire_count", EmitDefaultValue=false)]
        public int? PoolRetireCount { get; set; }

        /// <summary>
        /// Count of asset mints and burns within the transaction
        /// </summary>
        /// <value>Count of asset mints and burns within the transaction</value>
        [DataMember(Name="asset_mint_or_burn_count", EmitDefaultValue=false)]
        public int? AssetMintOrBurnCount { get; set; }

        /// <summary>
        /// Count of redeemers within the transaction
        /// </summary>
        /// <value>Count of redeemers within the transaction</value>
        [DataMember(Name="redeemer_count", EmitDefaultValue=false)]
        public int? RedeemerCount { get; set; }

        /// <summary>
        /// True if contract script passed validation
        /// </summary>
        /// <value>True if contract script passed validation</value>
        [DataMember(Name="valid_contract", EmitDefaultValue=false)]
        public bool? ValidContract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxContent {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  BlockHeight: ").Append(BlockHeight).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  OutputAmount: ").Append(OutputAmount).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Deposit: ").Append(Deposit).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  InvalidBefore: ").Append(InvalidBefore).Append("\n");
            sb.Append("  InvalidHereafter: ").Append(InvalidHereafter).Append("\n");
            sb.Append("  UtxoCount: ").Append(UtxoCount).Append("\n");
            sb.Append("  WithdrawalCount: ").Append(WithdrawalCount).Append("\n");
            sb.Append("  MirCertCount: ").Append(MirCertCount).Append("\n");
            sb.Append("  DelegationCount: ").Append(DelegationCount).Append("\n");
            sb.Append("  StakeCertCount: ").Append(StakeCertCount).Append("\n");
            sb.Append("  PoolUpdateCount: ").Append(PoolUpdateCount).Append("\n");
            sb.Append("  PoolRetireCount: ").Append(PoolRetireCount).Append("\n");
            sb.Append("  AssetMintOrBurnCount: ").Append(AssetMintOrBurnCount).Append("\n");
            sb.Append("  RedeemerCount: ").Append(RedeemerCount).Append("\n");
            sb.Append("  ValidContract: ").Append(ValidContract).Append("\n");
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
            return this.Equals(input as TxContent);
        }

        /// <summary>
        /// Returns true if TxContent instances are equal
        /// </summary>
        /// <param name="input">Instance of TxContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TxContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.BlockHeight == input.BlockHeight ||
                    (this.BlockHeight != null &&
                    this.BlockHeight.Equals(input.BlockHeight))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.OutputAmount == input.OutputAmount ||
                    this.OutputAmount != null &&
                    input.OutputAmount != null &&
                    this.OutputAmount.SequenceEqual(input.OutputAmount)
                ) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.Deposit == input.Deposit ||
                    (this.Deposit != null &&
                    this.Deposit.Equals(input.Deposit))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.InvalidBefore == input.InvalidBefore ||
                    (this.InvalidBefore != null &&
                    this.InvalidBefore.Equals(input.InvalidBefore))
                ) && 
                (
                    this.InvalidHereafter == input.InvalidHereafter ||
                    (this.InvalidHereafter != null &&
                    this.InvalidHereafter.Equals(input.InvalidHereafter))
                ) && 
                (
                    this.UtxoCount == input.UtxoCount ||
                    (this.UtxoCount != null &&
                    this.UtxoCount.Equals(input.UtxoCount))
                ) && 
                (
                    this.WithdrawalCount == input.WithdrawalCount ||
                    (this.WithdrawalCount != null &&
                    this.WithdrawalCount.Equals(input.WithdrawalCount))
                ) && 
                (
                    this.MirCertCount == input.MirCertCount ||
                    (this.MirCertCount != null &&
                    this.MirCertCount.Equals(input.MirCertCount))
                ) && 
                (
                    this.DelegationCount == input.DelegationCount ||
                    (this.DelegationCount != null &&
                    this.DelegationCount.Equals(input.DelegationCount))
                ) && 
                (
                    this.StakeCertCount == input.StakeCertCount ||
                    (this.StakeCertCount != null &&
                    this.StakeCertCount.Equals(input.StakeCertCount))
                ) && 
                (
                    this.PoolUpdateCount == input.PoolUpdateCount ||
                    (this.PoolUpdateCount != null &&
                    this.PoolUpdateCount.Equals(input.PoolUpdateCount))
                ) && 
                (
                    this.PoolRetireCount == input.PoolRetireCount ||
                    (this.PoolRetireCount != null &&
                    this.PoolRetireCount.Equals(input.PoolRetireCount))
                ) && 
                (
                    this.AssetMintOrBurnCount == input.AssetMintOrBurnCount ||
                    (this.AssetMintOrBurnCount != null &&
                    this.AssetMintOrBurnCount.Equals(input.AssetMintOrBurnCount))
                ) && 
                (
                    this.RedeemerCount == input.RedeemerCount ||
                    (this.RedeemerCount != null &&
                    this.RedeemerCount.Equals(input.RedeemerCount))
                ) && 
                (
                    this.ValidContract == input.ValidContract ||
                    (this.ValidContract != null &&
                    this.ValidContract.Equals(input.ValidContract))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.BlockHeight != null)
                    hashCode = hashCode * 59 + this.BlockHeight.GetHashCode();
                if (this.Slot != null)
                    hashCode = hashCode * 59 + this.Slot.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.OutputAmount != null)
                    hashCode = hashCode * 59 + this.OutputAmount.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.Deposit != null)
                    hashCode = hashCode * 59 + this.Deposit.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.InvalidBefore != null)
                    hashCode = hashCode * 59 + this.InvalidBefore.GetHashCode();
                if (this.InvalidHereafter != null)
                    hashCode = hashCode * 59 + this.InvalidHereafter.GetHashCode();
                if (this.UtxoCount != null)
                    hashCode = hashCode * 59 + this.UtxoCount.GetHashCode();
                if (this.WithdrawalCount != null)
                    hashCode = hashCode * 59 + this.WithdrawalCount.GetHashCode();
                if (this.MirCertCount != null)
                    hashCode = hashCode * 59 + this.MirCertCount.GetHashCode();
                if (this.DelegationCount != null)
                    hashCode = hashCode * 59 + this.DelegationCount.GetHashCode();
                if (this.StakeCertCount != null)
                    hashCode = hashCode * 59 + this.StakeCertCount.GetHashCode();
                if (this.PoolUpdateCount != null)
                    hashCode = hashCode * 59 + this.PoolUpdateCount.GetHashCode();
                if (this.PoolRetireCount != null)
                    hashCode = hashCode * 59 + this.PoolRetireCount.GetHashCode();
                if (this.AssetMintOrBurnCount != null)
                    hashCode = hashCode * 59 + this.AssetMintOrBurnCount.GetHashCode();
                if (this.RedeemerCount != null)
                    hashCode = hashCode * 59 + this.RedeemerCount.GetHashCode();
                if (this.ValidContract != null)
                    hashCode = hashCode * 59 + this.ValidContract.GetHashCode();
                return hashCode;
            }
        }
    }
}
