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
    /// AccountContent
    /// </summary>
    [DataContract]
        public partial class AccountContent :  IEquatable<AccountContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountContent" /> class.
        /// </summary>
        /// <param name="stakeAddress">Bech32 stake address (required).</param>
        /// <param name="active">Registration state of an account (required).</param>
        /// <param name="activeEpoch">Epoch of the most recent action - registration or deregistration (required).</param>
        /// <param name="controlledAmount">Balance of the account in Lovelaces (required).</param>
        /// <param name="rewardsSum">Sum of all rewards for the account in the Lovelaces (required).</param>
        /// <param name="withdrawalsSum">Sum of all the withdrawals for the account in Lovelaces (required).</param>
        /// <param name="reservesSum">Sum of all  funds from reserves for the account in the Lovelaces (required).</param>
        /// <param name="treasurySum">Sum of all funds from treasury for the account in the Lovelaces (required).</param>
        /// <param name="withdrawableAmount">Sum of available rewards that haven&#x27;t been withdrawn yet for the account in the Lovelaces (required).</param>
        /// <param name="poolId">Bech32 pool ID that owns the account (required).</param>
        public AccountContent(string stakeAddress = default(string), bool? active = default(bool?), int? activeEpoch = default(int?), string controlledAmount = default(string), string rewardsSum = default(string), string withdrawalsSum = default(string), string reservesSum = default(string), string treasurySum = default(string), string withdrawableAmount = default(string), string poolId = default(string))
        {
            // to ensure "stakeAddress" is required (not null)
            if (stakeAddress == null)
            {
                throw new InvalidDataException("stakeAddress is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.StakeAddress = stakeAddress;
            }
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            // to ensure "activeEpoch" is required (not null)
            if (activeEpoch == null)
            {
                throw new InvalidDataException("activeEpoch is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.ActiveEpoch = activeEpoch;
            }
            // to ensure "controlledAmount" is required (not null)
            if (controlledAmount == null)
            {
                throw new InvalidDataException("controlledAmount is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.ControlledAmount = controlledAmount;
            }
            // to ensure "rewardsSum" is required (not null)
            if (rewardsSum == null)
            {
                throw new InvalidDataException("rewardsSum is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.RewardsSum = rewardsSum;
            }
            // to ensure "withdrawalsSum" is required (not null)
            if (withdrawalsSum == null)
            {
                throw new InvalidDataException("withdrawalsSum is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.WithdrawalsSum = withdrawalsSum;
            }
            // to ensure "reservesSum" is required (not null)
            if (reservesSum == null)
            {
                throw new InvalidDataException("reservesSum is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.ReservesSum = reservesSum;
            }
            // to ensure "treasurySum" is required (not null)
            if (treasurySum == null)
            {
                throw new InvalidDataException("treasurySum is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.TreasurySum = treasurySum;
            }
            // to ensure "withdrawableAmount" is required (not null)
            if (withdrawableAmount == null)
            {
                throw new InvalidDataException("withdrawableAmount is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.WithdrawableAmount = withdrawableAmount;
            }
            // to ensure "poolId" is required (not null)
            if (poolId == null)
            {
                throw new InvalidDataException("poolId is a required property for AccountContent and cannot be null");
            }
            else
            {
                this.PoolId = poolId;
            }
        }
        
        /// <summary>
        /// Bech32 stake address
        /// </summary>
        /// <value>Bech32 stake address</value>
        [DataMember(Name="stake_address", EmitDefaultValue=false)]
        public string StakeAddress { get; set; }

        /// <summary>
        /// Registration state of an account
        /// </summary>
        /// <value>Registration state of an account</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Epoch of the most recent action - registration or deregistration
        /// </summary>
        /// <value>Epoch of the most recent action - registration or deregistration</value>
        [DataMember(Name="active_epoch", EmitDefaultValue=false)]
        public int? ActiveEpoch { get; set; }

        /// <summary>
        /// Balance of the account in Lovelaces
        /// </summary>
        /// <value>Balance of the account in Lovelaces</value>
        [DataMember(Name="controlled_amount", EmitDefaultValue=false)]
        public string ControlledAmount { get; set; }

        /// <summary>
        /// Sum of all rewards for the account in the Lovelaces
        /// </summary>
        /// <value>Sum of all rewards for the account in the Lovelaces</value>
        [DataMember(Name="rewards_sum", EmitDefaultValue=false)]
        public string RewardsSum { get; set; }

        /// <summary>
        /// Sum of all the withdrawals for the account in Lovelaces
        /// </summary>
        /// <value>Sum of all the withdrawals for the account in Lovelaces</value>
        [DataMember(Name="withdrawals_sum", EmitDefaultValue=false)]
        public string WithdrawalsSum { get; set; }

        /// <summary>
        /// Sum of all  funds from reserves for the account in the Lovelaces
        /// </summary>
        /// <value>Sum of all  funds from reserves for the account in the Lovelaces</value>
        [DataMember(Name="reserves_sum", EmitDefaultValue=false)]
        public string ReservesSum { get; set; }

        /// <summary>
        /// Sum of all funds from treasury for the account in the Lovelaces
        /// </summary>
        /// <value>Sum of all funds from treasury for the account in the Lovelaces</value>
        [DataMember(Name="treasury_sum", EmitDefaultValue=false)]
        public string TreasurySum { get; set; }

        /// <summary>
        /// Sum of available rewards that haven&#x27;t been withdrawn yet for the account in the Lovelaces
        /// </summary>
        /// <value>Sum of available rewards that haven&#x27;t been withdrawn yet for the account in the Lovelaces</value>
        [DataMember(Name="withdrawable_amount", EmitDefaultValue=false)]
        public string WithdrawableAmount { get; set; }

        /// <summary>
        /// Bech32 pool ID that owns the account
        /// </summary>
        /// <value>Bech32 pool ID that owns the account</value>
        [DataMember(Name="pool_id", EmitDefaultValue=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountContent {\n");
            sb.Append("  StakeAddress: ").Append(StakeAddress).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ActiveEpoch: ").Append(ActiveEpoch).Append("\n");
            sb.Append("  ControlledAmount: ").Append(ControlledAmount).Append("\n");
            sb.Append("  RewardsSum: ").Append(RewardsSum).Append("\n");
            sb.Append("  WithdrawalsSum: ").Append(WithdrawalsSum).Append("\n");
            sb.Append("  ReservesSum: ").Append(ReservesSum).Append("\n");
            sb.Append("  TreasurySum: ").Append(TreasurySum).Append("\n");
            sb.Append("  WithdrawableAmount: ").Append(WithdrawableAmount).Append("\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
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
            return this.Equals(input as AccountContent);
        }

        /// <summary>
        /// Returns true if AccountContent instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StakeAddress == input.StakeAddress ||
                    (this.StakeAddress != null &&
                    this.StakeAddress.Equals(input.StakeAddress))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ActiveEpoch == input.ActiveEpoch ||
                    (this.ActiveEpoch != null &&
                    this.ActiveEpoch.Equals(input.ActiveEpoch))
                ) && 
                (
                    this.ControlledAmount == input.ControlledAmount ||
                    (this.ControlledAmount != null &&
                    this.ControlledAmount.Equals(input.ControlledAmount))
                ) && 
                (
                    this.RewardsSum == input.RewardsSum ||
                    (this.RewardsSum != null &&
                    this.RewardsSum.Equals(input.RewardsSum))
                ) && 
                (
                    this.WithdrawalsSum == input.WithdrawalsSum ||
                    (this.WithdrawalsSum != null &&
                    this.WithdrawalsSum.Equals(input.WithdrawalsSum))
                ) && 
                (
                    this.ReservesSum == input.ReservesSum ||
                    (this.ReservesSum != null &&
                    this.ReservesSum.Equals(input.ReservesSum))
                ) && 
                (
                    this.TreasurySum == input.TreasurySum ||
                    (this.TreasurySum != null &&
                    this.TreasurySum.Equals(input.TreasurySum))
                ) && 
                (
                    this.WithdrawableAmount == input.WithdrawableAmount ||
                    (this.WithdrawableAmount != null &&
                    this.WithdrawableAmount.Equals(input.WithdrawableAmount))
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
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
                if (this.StakeAddress != null)
                    hashCode = hashCode * 59 + this.StakeAddress.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ActiveEpoch != null)
                    hashCode = hashCode * 59 + this.ActiveEpoch.GetHashCode();
                if (this.ControlledAmount != null)
                    hashCode = hashCode * 59 + this.ControlledAmount.GetHashCode();
                if (this.RewardsSum != null)
                    hashCode = hashCode * 59 + this.RewardsSum.GetHashCode();
                if (this.WithdrawalsSum != null)
                    hashCode = hashCode * 59 + this.WithdrawalsSum.GetHashCode();
                if (this.ReservesSum != null)
                    hashCode = hashCode * 59 + this.ReservesSum.GetHashCode();
                if (this.TreasurySum != null)
                    hashCode = hashCode * 59 + this.TreasurySum.GetHashCode();
                if (this.WithdrawableAmount != null)
                    hashCode = hashCode * 59 + this.WithdrawableAmount.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                return hashCode;
            }
        }
    }
}
