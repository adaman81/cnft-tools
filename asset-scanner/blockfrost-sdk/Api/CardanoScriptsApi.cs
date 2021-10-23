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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using blockfrost.Client;
using blockfrost.Model;

namespace blockfrost.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ICardanoScriptsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Datum value
        /// </summary>
        /// <remarks>
        /// Query JSON value of a datum by its hash
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>ScriptDatum</returns>
        ScriptDatum ScriptsDatumDatumHashGet (string datumHash);

        /// <summary>
        /// Datum value
        /// </summary>
        /// <remarks>
        /// Query JSON value of a datum by its hash
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>ApiResponse of ScriptDatum</returns>
        ApiResponse<ScriptDatum> ScriptsDatumDatumHashGetWithHttpInfo (string datumHash);
        /// <summary>
        /// Scripts
        /// </summary>
        /// <remarks>
        /// List of scripts.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Scripts</returns>
        Scripts ScriptsGet (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Scripts
        /// </summary>
        /// <remarks>
        /// List of scripts.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of Scripts</returns>
        ApiResponse<Scripts> ScriptsGetWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Script CBOR
        /// </summary>
        /// <remarks>
        /// CBOR representation of a &#x60;plutus&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ScriptCbor</returns>
        ScriptCbor ScriptsScriptHashCborGet (string scriptHash);

        /// <summary>
        /// Script CBOR
        /// </summary>
        /// <remarks>
        /// CBOR representation of a &#x60;plutus&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of ScriptCbor</returns>
        ApiResponse<ScriptCbor> ScriptsScriptHashCborGetWithHttpInfo (string scriptHash);
        /// <summary>
        /// Specific script
        /// </summary>
        /// <remarks>
        /// Information about a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Script</returns>
        Script ScriptsScriptHashGet (string scriptHash);

        /// <summary>
        /// Specific script
        /// </summary>
        /// <remarks>
        /// Information about a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsScriptHashGetWithHttpInfo (string scriptHash);
        /// <summary>
        /// Script JSON
        /// </summary>
        /// <remarks>
        /// JSON representation of a &#x60;timelock&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ScriptJson</returns>
        ScriptJson ScriptsScriptHashJsonGet (string scriptHash);

        /// <summary>
        /// Script JSON
        /// </summary>
        /// <remarks>
        /// JSON representation of a &#x60;timelock&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of ScriptJson</returns>
        ApiResponse<ScriptJson> ScriptsScriptHashJsonGetWithHttpInfo (string scriptHash);
        /// <summary>
        /// Redeemers of a specific script
        /// </summary>
        /// <remarks>
        /// List of redeemers of a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ScriptRedeemers</returns>
        ScriptRedeemers ScriptsScriptHashRedeemersGet (string scriptHash, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Redeemers of a specific script
        /// </summary>
        /// <remarks>
        /// List of redeemers of a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of ScriptRedeemers</returns>
        ApiResponse<ScriptRedeemers> ScriptsScriptHashRedeemersGetWithHttpInfo (string scriptHash, int? count = null, int? page = null, string order = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Datum value
        /// </summary>
        /// <remarks>
        /// Query JSON value of a datum by its hash
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>Task of ScriptDatum</returns>
        System.Threading.Tasks.Task<ScriptDatum> ScriptsDatumDatumHashGetAsync (string datumHash);

        /// <summary>
        /// Datum value
        /// </summary>
        /// <remarks>
        /// Query JSON value of a datum by its hash
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>Task of ApiResponse (ScriptDatum)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptDatum>> ScriptsDatumDatumHashGetAsyncWithHttpInfo (string datumHash);
        /// <summary>
        /// Scripts
        /// </summary>
        /// <remarks>
        /// List of scripts.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of Scripts</returns>
        System.Threading.Tasks.Task<Scripts> ScriptsGetAsync (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Scripts
        /// </summary>
        /// <remarks>
        /// List of scripts.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (Scripts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scripts>> ScriptsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Script CBOR
        /// </summary>
        /// <remarks>
        /// CBOR representation of a &#x60;plutus&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ScriptCbor</returns>
        System.Threading.Tasks.Task<ScriptCbor> ScriptsScriptHashCborGetAsync (string scriptHash);

        /// <summary>
        /// Script CBOR
        /// </summary>
        /// <remarks>
        /// CBOR representation of a &#x60;plutus&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (ScriptCbor)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptCbor>> ScriptsScriptHashCborGetAsyncWithHttpInfo (string scriptHash);
        /// <summary>
        /// Specific script
        /// </summary>
        /// <remarks>
        /// Information about a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsScriptHashGetAsync (string scriptHash);

        /// <summary>
        /// Specific script
        /// </summary>
        /// <remarks>
        /// Information about a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptHashGetAsyncWithHttpInfo (string scriptHash);
        /// <summary>
        /// Script JSON
        /// </summary>
        /// <remarks>
        /// JSON representation of a &#x60;timelock&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ScriptJson</returns>
        System.Threading.Tasks.Task<ScriptJson> ScriptsScriptHashJsonGetAsync (string scriptHash);

        /// <summary>
        /// Script JSON
        /// </summary>
        /// <remarks>
        /// JSON representation of a &#x60;timelock&#x60; script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (ScriptJson)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptJson>> ScriptsScriptHashJsonGetAsyncWithHttpInfo (string scriptHash);
        /// <summary>
        /// Redeemers of a specific script
        /// </summary>
        /// <remarks>
        /// List of redeemers of a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ScriptRedeemers</returns>
        System.Threading.Tasks.Task<ScriptRedeemers> ScriptsScriptHashRedeemersGetAsync (string scriptHash, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Redeemers of a specific script
        /// </summary>
        /// <remarks>
        /// List of redeemers of a specific script
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (ScriptRedeemers)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptRedeemers>> ScriptsScriptHashRedeemersGetAsyncWithHttpInfo (string scriptHash, int? count = null, int? page = null, string order = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoScriptsApi : ICardanoScriptsApi
    {
        private blockfrost.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoScriptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoScriptsApi(String basePath)
        {
            this.Configuration = new blockfrost.Client.Configuration { BasePath = basePath };

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoScriptsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoScriptsApi()
        {
            this.Configuration = blockfrost.Client.Configuration.Default;

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoScriptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoScriptsApi(blockfrost.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = blockfrost.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public blockfrost.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public blockfrost.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Datum value Query JSON value of a datum by its hash
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>ScriptDatum</returns>
        public ScriptDatum ScriptsDatumDatumHashGet (string datumHash)
        {
             ApiResponse<ScriptDatum> localVarResponse = ScriptsDatumDatumHashGetWithHttpInfo(datumHash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Datum value Query JSON value of a datum by its hash
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>ApiResponse of ScriptDatum</returns>
        public ApiResponse< ScriptDatum > ScriptsDatumDatumHashGetWithHttpInfo (string datumHash)
        {
            // verify the required parameter 'datumHash' is set
            if (datumHash == null)
                throw new ApiException(400, "Missing required parameter 'datumHash' when calling CardanoScriptsApi->ScriptsDatumDatumHashGet");

            var localVarPath = "./scripts/datum/{datum_hash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datumHash != null) localVarPathParams.Add("datum_hash", this.Configuration.ApiClient.ParameterToString(datumHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsDatumDatumHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptDatum>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptDatum) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptDatum)));
        }

        /// <summary>
        /// Datum value Query JSON value of a datum by its hash
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>Task of ScriptDatum</returns>
        public async System.Threading.Tasks.Task<ScriptDatum> ScriptsDatumDatumHashGetAsync (string datumHash)
        {
             ApiResponse<ScriptDatum> localVarResponse = await ScriptsDatumDatumHashGetAsyncWithHttpInfo(datumHash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Datum value Query JSON value of a datum by its hash
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datumHash">Hash of the datum</param>
        /// <returns>Task of ApiResponse (ScriptDatum)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptDatum>> ScriptsDatumDatumHashGetAsyncWithHttpInfo (string datumHash)
        {
            // verify the required parameter 'datumHash' is set
            if (datumHash == null)
                throw new ApiException(400, "Missing required parameter 'datumHash' when calling CardanoScriptsApi->ScriptsDatumDatumHashGet");

            var localVarPath = "./scripts/datum/{datum_hash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datumHash != null) localVarPathParams.Add("datum_hash", this.Configuration.ApiClient.ParameterToString(datumHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsDatumDatumHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptDatum>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptDatum) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptDatum)));
        }

        /// <summary>
        /// Scripts List of scripts.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Scripts</returns>
        public Scripts ScriptsGet (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<Scripts> localVarResponse = ScriptsGetWithHttpInfo(count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scripts List of scripts.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of Scripts</returns>
        public ApiResponse< Scripts > ScriptsGetWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./scripts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Scripts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Scripts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Scripts)));
        }

        /// <summary>
        /// Scripts List of scripts.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of Scripts</returns>
        public async System.Threading.Tasks.Task<Scripts> ScriptsGetAsync (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<Scripts> localVarResponse = await ScriptsGetAsyncWithHttpInfo(count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scripts List of scripts.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (Scripts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Scripts>> ScriptsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./scripts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Scripts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Scripts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Scripts)));
        }

        /// <summary>
        /// Script CBOR CBOR representation of a &#x60;plutus&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ScriptCbor</returns>
        public ScriptCbor ScriptsScriptHashCborGet (string scriptHash)
        {
             ApiResponse<ScriptCbor> localVarResponse = ScriptsScriptHashCborGetWithHttpInfo(scriptHash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Script CBOR CBOR representation of a &#x60;plutus&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of ScriptCbor</returns>
        public ApiResponse< ScriptCbor > ScriptsScriptHashCborGetWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashCborGet");

            var localVarPath = "./scripts/{script_hash}/cbor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashCborGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptCbor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptCbor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptCbor)));
        }

        /// <summary>
        /// Script CBOR CBOR representation of a &#x60;plutus&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ScriptCbor</returns>
        public async System.Threading.Tasks.Task<ScriptCbor> ScriptsScriptHashCborGetAsync (string scriptHash)
        {
             ApiResponse<ScriptCbor> localVarResponse = await ScriptsScriptHashCborGetAsyncWithHttpInfo(scriptHash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Script CBOR CBOR representation of a &#x60;plutus&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (ScriptCbor)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptCbor>> ScriptsScriptHashCborGetAsyncWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashCborGet");

            var localVarPath = "./scripts/{script_hash}/cbor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashCborGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptCbor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptCbor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptCbor)));
        }

        /// <summary>
        /// Specific script Information about a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Script</returns>
        public Script ScriptsScriptHashGet (string scriptHash)
        {
             ApiResponse<Script> localVarResponse = ScriptsScriptHashGetWithHttpInfo(scriptHash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific script Information about a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsScriptHashGetWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashGet");

            var localVarPath = "./scripts/{script_hash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Script) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
        }

        /// <summary>
        /// Specific script Information about a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsScriptHashGetAsync (string scriptHash)
        {
             ApiResponse<Script> localVarResponse = await ScriptsScriptHashGetAsyncWithHttpInfo(scriptHash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific script Information about a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptHashGetAsyncWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashGet");

            var localVarPath = "./scripts/{script_hash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Script) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
        }

        /// <summary>
        /// Script JSON JSON representation of a &#x60;timelock&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ScriptJson</returns>
        public ScriptJson ScriptsScriptHashJsonGet (string scriptHash)
        {
             ApiResponse<ScriptJson> localVarResponse = ScriptsScriptHashJsonGetWithHttpInfo(scriptHash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Script JSON JSON representation of a &#x60;timelock&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>ApiResponse of ScriptJson</returns>
        public ApiResponse< ScriptJson > ScriptsScriptHashJsonGetWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashJsonGet");

            var localVarPath = "./scripts/{script_hash}/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashJsonGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptJson>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptJson) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptJson)));
        }

        /// <summary>
        /// Script JSON JSON representation of a &#x60;timelock&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ScriptJson</returns>
        public async System.Threading.Tasks.Task<ScriptJson> ScriptsScriptHashJsonGetAsync (string scriptHash)
        {
             ApiResponse<ScriptJson> localVarResponse = await ScriptsScriptHashJsonGetAsyncWithHttpInfo(scriptHash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Script JSON JSON representation of a &#x60;timelock&#x60; script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <returns>Task of ApiResponse (ScriptJson)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptJson>> ScriptsScriptHashJsonGetAsyncWithHttpInfo (string scriptHash)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashJsonGet");

            var localVarPath = "./scripts/{script_hash}/json";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashJsonGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptJson>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptJson) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptJson)));
        }

        /// <summary>
        /// Redeemers of a specific script List of redeemers of a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ScriptRedeemers</returns>
        public ScriptRedeemers ScriptsScriptHashRedeemersGet (string scriptHash, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<ScriptRedeemers> localVarResponse = ScriptsScriptHashRedeemersGetWithHttpInfo(scriptHash, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Redeemers of a specific script List of redeemers of a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of ScriptRedeemers</returns>
        public ApiResponse< ScriptRedeemers > ScriptsScriptHashRedeemersGetWithHttpInfo (string scriptHash, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashRedeemersGet");

            var localVarPath = "./scripts/{script_hash}/redeemers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashRedeemersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptRedeemers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptRedeemers) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptRedeemers)));
        }

        /// <summary>
        /// Redeemers of a specific script List of redeemers of a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ScriptRedeemers</returns>
        public async System.Threading.Tasks.Task<ScriptRedeemers> ScriptsScriptHashRedeemersGetAsync (string scriptHash, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<ScriptRedeemers> localVarResponse = await ScriptsScriptHashRedeemersGetAsyncWithHttpInfo(scriptHash, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Redeemers of a specific script List of redeemers of a specific script
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scriptHash">Hash of the script</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (ScriptRedeemers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptRedeemers>> ScriptsScriptHashRedeemersGetAsyncWithHttpInfo (string scriptHash, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'scriptHash' is set
            if (scriptHash == null)
                throw new ApiException(400, "Missing required parameter 'scriptHash' when calling CardanoScriptsApi->ScriptsScriptHashRedeemersGet");

            var localVarPath = "./scripts/{script_hash}/redeemers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (scriptHash != null) localVarPathParams.Add("script_hash", this.Configuration.ApiClient.ParameterToString(scriptHash)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScriptsScriptHashRedeemersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ScriptRedeemers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ScriptRedeemers) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptRedeemers)));
        }

    }
}
