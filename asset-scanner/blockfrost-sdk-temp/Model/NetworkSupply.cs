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
    /// NetworkSupply
    /// </summary>
    [DataContract]
        public partial class NetworkSupply :  IEquatable<NetworkSupply>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkSupply" /> class.
        /// </summary>
        /// <param name="max">Maximum supply in Lovelaces (required).</param>
        /// <param name="total">Current total (max supply - reserves) supply in Lovelaces (required).</param>
        /// <param name="circulating">Current circulating (UTXOs + withdrawables) supply in Lovelaces (required).</param>
        /// <param name="locked">Current supply locked by scripts in Lovelaces (required).</param>
        /// <param name="treasury">Current supply locked in treasury (required).</param>
        /// <param name="reserves">Current supply locked in reserves (required).</param>
        public NetworkSupply(string max = default(string), string total = default(string), string circulating = default(string), string locked = default(string), string treasury = default(string), string reserves = default(string))
        {
            // to ensure "max" is required (not null)
            if (max == null)
            {
                throw new InvalidDataException("max is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Max = max;
            }
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            // to ensure "circulating" is required (not null)
            if (circulating == null)
            {
                throw new InvalidDataException("circulating is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Circulating = circulating;
            }
            // to ensure "locked" is required (not null)
            if (locked == null)
            {
                throw new InvalidDataException("locked is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Locked = locked;
            }
            // to ensure "treasury" is required (not null)
            if (treasury == null)
            {
                throw new InvalidDataException("treasury is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Treasury = treasury;
            }
            // to ensure "reserves" is required (not null)
            if (reserves == null)
            {
                throw new InvalidDataException("reserves is a required property for NetworkSupply and cannot be null");
            }
            else
            {
                this.Reserves = reserves;
            }
        }
        
        /// <summary>
        /// Maximum supply in Lovelaces
        /// </summary>
        /// <value>Maximum supply in Lovelaces</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public string Max { get; set; }

        /// <summary>
        /// Current total (max supply - reserves) supply in Lovelaces
        /// </summary>
        /// <value>Current total (max supply - reserves) supply in Lovelaces</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public string Total { get; set; }

        /// <summary>
        /// Current circulating (UTXOs + withdrawables) supply in Lovelaces
        /// </summary>
        /// <value>Current circulating (UTXOs + withdrawables) supply in Lovelaces</value>
        [DataMember(Name="circulating", EmitDefaultValue=false)]
        public string Circulating { get; set; }

        /// <summary>
        /// Current supply locked by scripts in Lovelaces
        /// </summary>
        /// <value>Current supply locked by scripts in Lovelaces</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }

        /// <summary>
        /// Current supply locked in treasury
        /// </summary>
        /// <value>Current supply locked in treasury</value>
        [DataMember(Name="treasury", EmitDefaultValue=false)]
        public string Treasury { get; set; }

        /// <summary>
        /// Current supply locked in reserves
        /// </summary>
        /// <value>Current supply locked in reserves</value>
        [DataMember(Name="reserves", EmitDefaultValue=false)]
        public string Reserves { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkSupply {\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Circulating: ").Append(Circulating).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Treasury: ").Append(Treasury).Append("\n");
            sb.Append("  Reserves: ").Append(Reserves).Append("\n");
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
            return this.Equals(input as NetworkSupply);
        }

        /// <summary>
        /// Returns true if NetworkSupply instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkSupply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkSupply input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Circulating == input.Circulating ||
                    (this.Circulating != null &&
                    this.Circulating.Equals(input.Circulating))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Treasury == input.Treasury ||
                    (this.Treasury != null &&
                    this.Treasury.Equals(input.Treasury))
                ) && 
                (
                    this.Reserves == input.Reserves ||
                    (this.Reserves != null &&
                    this.Reserves.Equals(input.Reserves))
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
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Circulating != null)
                    hashCode = hashCode * 59 + this.Circulating.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Treasury != null)
                    hashCode = hashCode * 59 + this.Treasury.GetHashCode();
                if (this.Reserves != null)
                    hashCode = hashCode * 59 + this.Reserves.GetHashCode();
                return hashCode;
            }
        }
    }
}
