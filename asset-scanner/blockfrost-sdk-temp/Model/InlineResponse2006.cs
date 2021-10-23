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
    /// InlineResponse2006
    /// </summary>
    [DataContract]
        public partial class InlineResponse2006 :  IEquatable<InlineResponse2006>
    {
        /// <summary>
        /// State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin. 
        /// </summary>
        /// <value>State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Queuedpinnedunpinnedfailedgc for value: queued|pinned|unpinned|failed|gc
            /// </summary>
            [EnumMember(Value = "queued|pinned|unpinned|failed|gc")]
            Queuedpinnedunpinnedfailedgc = 1        }
        /// <summary>
        /// State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin. 
        /// </summary>
        /// <value>State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006" /> class.
        /// </summary>
        /// <param name="timeCreated">Creation time of the IPFS object on our backends (required).</param>
        /// <param name="timePinned">Pin time of the IPFS object on our backends (required).</param>
        /// <param name="ipfsHash">IPFS hash of the pinned object (required).</param>
        /// <param name="size">Size of the object in Bytes (required).</param>
        /// <param name="state">State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin.  (required).</param>
        public InlineResponse2006(int? timeCreated = default(int?), int? timePinned = default(int?), string ipfsHash = default(string), string size = default(string), StateEnum state = default(StateEnum))
        {
            // to ensure "timeCreated" is required (not null)
            if (timeCreated == null)
            {
                throw new InvalidDataException("timeCreated is a required property for InlineResponse2006 and cannot be null");
            }
            else
            {
                this.TimeCreated = timeCreated;
            }
            // to ensure "timePinned" is required (not null)
            if (timePinned == null)
            {
                throw new InvalidDataException("timePinned is a required property for InlineResponse2006 and cannot be null");
            }
            else
            {
                this.TimePinned = timePinned;
            }
            // to ensure "ipfsHash" is required (not null)
            if (ipfsHash == null)
            {
                throw new InvalidDataException("ipfsHash is a required property for InlineResponse2006 and cannot be null");
            }
            else
            {
                this.IpfsHash = ipfsHash;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for InlineResponse2006 and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for InlineResponse2006 and cannot be null");
            }
            else
            {
                this.State = state;
            }
        }
        
        /// <summary>
        /// Creation time of the IPFS object on our backends
        /// </summary>
        /// <value>Creation time of the IPFS object on our backends</value>
        [DataMember(Name="time_created", EmitDefaultValue=false)]
        public int? TimeCreated { get; set; }

        /// <summary>
        /// Pin time of the IPFS object on our backends
        /// </summary>
        /// <value>Pin time of the IPFS object on our backends</value>
        [DataMember(Name="time_pinned", EmitDefaultValue=false)]
        public int? TimePinned { get; set; }

        /// <summary>
        /// IPFS hash of the pinned object
        /// </summary>
        /// <value>IPFS hash of the pinned object</value>
        [DataMember(Name="ipfs_hash", EmitDefaultValue=false)]
        public string IpfsHash { get; set; }

        /// <summary>
        /// Size of the object in Bytes
        /// </summary>
        /// <value>Size of the object in Bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006 {\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimePinned: ").Append(TimePinned).Append("\n");
            sb.Append("  IpfsHash: ").Append(IpfsHash).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as InlineResponse2006);
        }

        /// <summary>
        /// Returns true if InlineResponse2006 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2006 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeCreated == input.TimeCreated ||
                    (this.TimeCreated != null &&
                    this.TimeCreated.Equals(input.TimeCreated))
                ) && 
                (
                    this.TimePinned == input.TimePinned ||
                    (this.TimePinned != null &&
                    this.TimePinned.Equals(input.TimePinned))
                ) && 
                (
                    this.IpfsHash == input.IpfsHash ||
                    (this.IpfsHash != null &&
                    this.IpfsHash.Equals(input.IpfsHash))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.TimeCreated != null)
                    hashCode = hashCode * 59 + this.TimeCreated.GetHashCode();
                if (this.TimePinned != null)
                    hashCode = hashCode * 59 + this.TimePinned.GetHashCode();
                if (this.IpfsHash != null)
                    hashCode = hashCode * 59 + this.IpfsHash.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
