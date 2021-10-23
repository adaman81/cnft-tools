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
    /// TxContentMirsInner
    /// </summary>
    [DataContract]
        public partial class TxContentMirsInner :  IEquatable<TxContentMirsInner>
    {
        /// <summary>
        /// Source of MIR funds
        /// </summary>
        /// <value>Source of MIR funds</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PotEnum
        {
            /// <summary>
            /// Enum Reserve for value: reserve
            /// </summary>
            [EnumMember(Value = "reserve")]
            Reserve = 1,
            /// <summary>
            /// Enum Treasury for value: treasury
            /// </summary>
            [EnumMember(Value = "treasury")]
            Treasury = 2        }
        /// <summary>
        /// Source of MIR funds
        /// </summary>
        /// <value>Source of MIR funds</value>
        [DataMember(Name="pot", EmitDefaultValue=false)]
        public PotEnum Pot { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TxContentMirsInner" /> class.
        /// </summary>
        /// <param name="pot">Source of MIR funds (required).</param>
        /// <param name="certIndex">Index of the certificate within the transaction (required).</param>
        /// <param name="address">Bech32 stake address (required).</param>
        /// <param name="amount">MIR amount in Lovelaces (required).</param>
        public TxContentMirsInner(PotEnum pot = default(PotEnum), int? certIndex = default(int?), string address = default(string), string amount = default(string))
        {
            // to ensure "pot" is required (not null)
            if (pot == null)
            {
                throw new InvalidDataException("pot is a required property for TxContentMirsInner and cannot be null");
            }
            else
            {
                this.Pot = pot;
            }
            // to ensure "certIndex" is required (not null)
            if (certIndex == null)
            {
                throw new InvalidDataException("certIndex is a required property for TxContentMirsInner and cannot be null");
            }
            else
            {
                this.CertIndex = certIndex;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for TxContentMirsInner and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TxContentMirsInner and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
        }
        

        /// <summary>
        /// Index of the certificate within the transaction
        /// </summary>
        /// <value>Index of the certificate within the transaction</value>
        [DataMember(Name="cert_index", EmitDefaultValue=false)]
        public int? CertIndex { get; set; }

        /// <summary>
        /// Bech32 stake address
        /// </summary>
        /// <value>Bech32 stake address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// MIR amount in Lovelaces
        /// </summary>
        /// <value>MIR amount in Lovelaces</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxContentMirsInner {\n");
            sb.Append("  Pot: ").Append(Pot).Append("\n");
            sb.Append("  CertIndex: ").Append(CertIndex).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as TxContentMirsInner);
        }

        /// <summary>
        /// Returns true if TxContentMirsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TxContentMirsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TxContentMirsInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pot == input.Pot ||
                    (this.Pot != null &&
                    this.Pot.Equals(input.Pot))
                ) && 
                (
                    this.CertIndex == input.CertIndex ||
                    (this.CertIndex != null &&
                    this.CertIndex.Equals(input.CertIndex))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Pot != null)
                    hashCode = hashCode * 59 + this.Pot.GetHashCode();
                if (this.CertIndex != null)
                    hashCode = hashCode * 59 + this.CertIndex.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
            }
        }
    }
}
