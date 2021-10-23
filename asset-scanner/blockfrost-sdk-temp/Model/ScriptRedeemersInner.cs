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
    /// ScriptRedeemersInner
    /// </summary>
    [DataContract]
        public partial class ScriptRedeemersInner :  IEquatable<ScriptRedeemersInner>
    {
        /// <summary>
        /// Validation purpose
        /// </summary>
        /// <value>Validation purpose</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PurposeEnum
        {
            /// <summary>
            /// Enum Spend for value: spend
            /// </summary>
            [EnumMember(Value = "spend")]
            Spend = 1,
            /// <summary>
            /// Enum Mint for value: mint
            /// </summary>
            [EnumMember(Value = "mint")]
            Mint = 2,
            /// <summary>
            /// Enum Cert for value: cert
            /// </summary>
            [EnumMember(Value = "cert")]
            Cert = 3,
            /// <summary>
            /// Enum Reward for value: reward
            /// </summary>
            [EnumMember(Value = "reward")]
            Reward = 4        }
        /// <summary>
        /// Validation purpose
        /// </summary>
        /// <value>Validation purpose</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptRedeemersInner" /> class.
        /// </summary>
        /// <param name="txHash">Hash of the transaction (required).</param>
        /// <param name="txIndex">The index of the redeemer pointer in the transaction (required).</param>
        /// <param name="purpose">Validation purpose (required).</param>
        /// <param name="datumHash">Datum hash (required).</param>
        /// <param name="unitMem">The budget in Memory to run a script (required).</param>
        /// <param name="unitSteps">The budget in CPU steps to run a script (required).</param>
        /// <param name="fee">The fee consumed to run the script (required).</param>
        public ScriptRedeemersInner(string txHash = default(string), int? txIndex = default(int?), PurposeEnum purpose = default(PurposeEnum), string datumHash = default(string), string unitMem = default(string), string unitSteps = default(string), string fee = default(string))
        {
            // to ensure "txHash" is required (not null)
            if (txHash == null)
            {
                throw new InvalidDataException("txHash is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.TxHash = txHash;
            }
            // to ensure "txIndex" is required (not null)
            if (txIndex == null)
            {
                throw new InvalidDataException("txIndex is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.TxIndex = txIndex;
            }
            // to ensure "purpose" is required (not null)
            if (purpose == null)
            {
                throw new InvalidDataException("purpose is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.Purpose = purpose;
            }
            // to ensure "datumHash" is required (not null)
            if (datumHash == null)
            {
                throw new InvalidDataException("datumHash is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.DatumHash = datumHash;
            }
            // to ensure "unitMem" is required (not null)
            if (unitMem == null)
            {
                throw new InvalidDataException("unitMem is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.UnitMem = unitMem;
            }
            // to ensure "unitSteps" is required (not null)
            if (unitSteps == null)
            {
                throw new InvalidDataException("unitSteps is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.UnitSteps = unitSteps;
            }
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for ScriptRedeemersInner and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
        }
        
        /// <summary>
        /// Hash of the transaction
        /// </summary>
        /// <value>Hash of the transaction</value>
        [DataMember(Name="tx_hash", EmitDefaultValue=false)]
        public string TxHash { get; set; }

        /// <summary>
        /// The index of the redeemer pointer in the transaction
        /// </summary>
        /// <value>The index of the redeemer pointer in the transaction</value>
        [DataMember(Name="tx_index", EmitDefaultValue=false)]
        public int? TxIndex { get; set; }


        /// <summary>
        /// Datum hash
        /// </summary>
        /// <value>Datum hash</value>
        [DataMember(Name="datum_hash", EmitDefaultValue=false)]
        public string DatumHash { get; set; }

        /// <summary>
        /// The budget in Memory to run a script
        /// </summary>
        /// <value>The budget in Memory to run a script</value>
        [DataMember(Name="unit_mem", EmitDefaultValue=false)]
        public string UnitMem { get; set; }

        /// <summary>
        /// The budget in CPU steps to run a script
        /// </summary>
        /// <value>The budget in CPU steps to run a script</value>
        [DataMember(Name="unit_steps", EmitDefaultValue=false)]
        public string UnitSteps { get; set; }

        /// <summary>
        /// The fee consumed to run the script
        /// </summary>
        /// <value>The fee consumed to run the script</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptRedeemersInner {\n");
            sb.Append("  TxHash: ").Append(TxHash).Append("\n");
            sb.Append("  TxIndex: ").Append(TxIndex).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  DatumHash: ").Append(DatumHash).Append("\n");
            sb.Append("  UnitMem: ").Append(UnitMem).Append("\n");
            sb.Append("  UnitSteps: ").Append(UnitSteps).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
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
            return this.Equals(input as ScriptRedeemersInner);
        }

        /// <summary>
        /// Returns true if ScriptRedeemersInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptRedeemersInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptRedeemersInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TxHash == input.TxHash ||
                    (this.TxHash != null &&
                    this.TxHash.Equals(input.TxHash))
                ) && 
                (
                    this.TxIndex == input.TxIndex ||
                    (this.TxIndex != null &&
                    this.TxIndex.Equals(input.TxIndex))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.DatumHash == input.DatumHash ||
                    (this.DatumHash != null &&
                    this.DatumHash.Equals(input.DatumHash))
                ) && 
                (
                    this.UnitMem == input.UnitMem ||
                    (this.UnitMem != null &&
                    this.UnitMem.Equals(input.UnitMem))
                ) && 
                (
                    this.UnitSteps == input.UnitSteps ||
                    (this.UnitSteps != null &&
                    this.UnitSteps.Equals(input.UnitSteps))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
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
                if (this.TxHash != null)
                    hashCode = hashCode * 59 + this.TxHash.GetHashCode();
                if (this.TxIndex != null)
                    hashCode = hashCode * 59 + this.TxIndex.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.DatumHash != null)
                    hashCode = hashCode * 59 + this.DatumHash.GetHashCode();
                if (this.UnitMem != null)
                    hashCode = hashCode * 59 + this.UnitMem.GetHashCode();
                if (this.UnitSteps != null)
                    hashCode = hashCode * 59 + this.UnitSteps.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                return hashCode;
            }
        }
    }
}
