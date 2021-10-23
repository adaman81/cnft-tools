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
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ICardanoBlocksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Specific block in a slot in an epoch
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot in an epoch. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>BlockContent</returns>
        BlockContent BlocksEpochEpochNumberSlotSlotNumberGet (int? epochNumber, int? slotNumber);

        /// <summary>
        /// Specific block in a slot in an epoch
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot in an epoch. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        ApiResponse<BlockContent> BlocksEpochEpochNumberSlotSlotNumberGetWithHttpInfo (int? epochNumber, int? slotNumber);
        /// <summary>
        /// Specific block
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>BlockContent</returns>
        BlockContent BlocksHashOrNumberGet (string hashOrNumber);

        /// <summary>
        /// Specific block
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        ApiResponse<BlockContent> BlocksHashOrNumberGetWithHttpInfo (string hashOrNumber);
        /// <summary>
        /// Listing of next blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks following a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>BlockContentArray</returns>
        BlockContentArray BlocksHashOrNumberNextGet (string hashOrNumber, int? count = null, int? page = null);

        /// <summary>
        /// Listing of next blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks following a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of BlockContentArray</returns>
        ApiResponse<BlockContentArray> BlocksHashOrNumberNextGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null);
        /// <summary>
        /// Listing of previous blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks preceding a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>BlockContentArray</returns>
        BlockContentArray BlocksHashOrNumberPreviousGet (string hashOrNumber, int? count = null, int? page = null);

        /// <summary>
        /// Listing of previous blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks preceding a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of BlockContentArray</returns>
        ApiResponse<BlockContentArray> BlocksHashOrNumberPreviousGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null);
        /// <summary>
        /// Block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>BlockContentTxs</returns>
        BlockContentTxs BlocksHashOrNumberTxsGet (string hashOrNumber, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of BlockContentTxs</returns>
        ApiResponse<BlockContentTxs> BlocksHashOrNumberTxsGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Latest block
        /// </summary>
        /// <remarks>
        /// Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BlockContent</returns>
        BlockContent BlocksLatestGet ();

        /// <summary>
        /// Latest block
        /// </summary>
        /// <remarks>
        /// Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BlockContent</returns>
        ApiResponse<BlockContent> BlocksLatestGetWithHttpInfo ();
        /// <summary>
        /// Latest block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the latest block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>BlockContentTxs</returns>
        BlockContentTxs BlocksLatestTxsGet (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Latest block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the latest block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of BlockContentTxs</returns>
        ApiResponse<BlockContentTxs> BlocksLatestTxsGetWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific block in a slot
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>BlockContent</returns>
        BlockContent BlocksSlotSlotNumberGet (int? slotNumber);

        /// <summary>
        /// Specific block in a slot
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        ApiResponse<BlockContent> BlocksSlotSlotNumberGetWithHttpInfo (int? slotNumber);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Specific block in a slot in an epoch
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot in an epoch. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of BlockContent</returns>
        System.Threading.Tasks.Task<BlockContent> BlocksEpochEpochNumberSlotSlotNumberGetAsync (int? epochNumber, int? slotNumber);

        /// <summary>
        /// Specific block in a slot in an epoch
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot in an epoch. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksEpochEpochNumberSlotSlotNumberGetAsyncWithHttpInfo (int? epochNumber, int? slotNumber);
        /// <summary>
        /// Specific block
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>Task of BlockContent</returns>
        System.Threading.Tasks.Task<BlockContent> BlocksHashOrNumberGetAsync (string hashOrNumber);

        /// <summary>
        /// Specific block
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksHashOrNumberGetAsyncWithHttpInfo (string hashOrNumber);
        /// <summary>
        /// Listing of next blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks following a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of BlockContentArray</returns>
        System.Threading.Tasks.Task<BlockContentArray> BlocksHashOrNumberNextGetAsync (string hashOrNumber, int? count = null, int? page = null);

        /// <summary>
        /// Listing of next blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks following a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (BlockContentArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContentArray>> BlocksHashOrNumberNextGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null);
        /// <summary>
        /// Listing of previous blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks preceding a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of BlockContentArray</returns>
        System.Threading.Tasks.Task<BlockContentArray> BlocksHashOrNumberPreviousGetAsync (string hashOrNumber, int? count = null, int? page = null);

        /// <summary>
        /// Listing of previous blocks
        /// </summary>
        /// <remarks>
        /// Return the list of blocks preceding a specific block. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (BlockContentArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContentArray>> BlocksHashOrNumberPreviousGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null);
        /// <summary>
        /// Block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of BlockContentTxs</returns>
        System.Threading.Tasks.Task<BlockContentTxs> BlocksHashOrNumberTxsGetAsync (string hashOrNumber, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (BlockContentTxs)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContentTxs>> BlocksHashOrNumberTxsGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Latest block
        /// </summary>
        /// <remarks>
        /// Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BlockContent</returns>
        System.Threading.Tasks.Task<BlockContent> BlocksLatestGetAsync ();

        /// <summary>
        /// Latest block
        /// </summary>
        /// <remarks>
        /// Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksLatestGetAsyncWithHttpInfo ();
        /// <summary>
        /// Latest block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the latest block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of BlockContentTxs</returns>
        System.Threading.Tasks.Task<BlockContentTxs> BlocksLatestTxsGetAsync (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Latest block transactions
        /// </summary>
        /// <remarks>
        /// Return the transactions within the latest block.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (BlockContentTxs)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContentTxs>> BlocksLatestTxsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific block in a slot
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of BlockContent</returns>
        System.Threading.Tasks.Task<BlockContent> BlocksSlotSlotNumberGetAsync (int? slotNumber);

        /// <summary>
        /// Specific block in a slot
        /// </summary>
        /// <remarks>
        /// Return the content of a requested block for a specific slot. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksSlotSlotNumberGetAsyncWithHttpInfo (int? slotNumber);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoBlocksApi : ICardanoBlocksApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoBlocksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoBlocksApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoBlocksApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoBlocksApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoBlocksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoBlocksApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Specific block in a slot in an epoch Return the content of a requested block for a specific slot in an epoch. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>BlockContent</returns>
        public BlockContent BlocksEpochEpochNumberSlotSlotNumberGet (int? epochNumber, int? slotNumber)
        {
             ApiResponse<BlockContent> localVarResponse = BlocksEpochEpochNumberSlotSlotNumberGetWithHttpInfo(epochNumber, slotNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific block in a slot in an epoch Return the content of a requested block for a specific slot in an epoch. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        public ApiResponse< BlockContent > BlocksEpochEpochNumberSlotSlotNumberGetWithHttpInfo (int? epochNumber, int? slotNumber)
        {
            // verify the required parameter 'epochNumber' is set
            if (epochNumber == null)
                throw new ApiException(400, "Missing required parameter 'epochNumber' when calling CardanoBlocksApi->BlocksEpochEpochNumberSlotSlotNumberGet");
            // verify the required parameter 'slotNumber' is set
            if (slotNumber == null)
                throw new ApiException(400, "Missing required parameter 'slotNumber' when calling CardanoBlocksApi->BlocksEpochEpochNumberSlotSlotNumberGet");

            var localVarPath = "./blocks/epoch/{epoch_number}/slot/{slot_number}";
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

            if (epochNumber != null) localVarPathParams.Add("epoch_number", this.Configuration.ApiClient.ParameterToString(epochNumber)); // path parameter
            if (slotNumber != null) localVarPathParams.Add("slot_number", this.Configuration.ApiClient.ParameterToString(slotNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksEpochEpochNumberSlotSlotNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Specific block in a slot in an epoch Return the content of a requested block for a specific slot in an epoch. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of BlockContent</returns>
        public async System.Threading.Tasks.Task<BlockContent> BlocksEpochEpochNumberSlotSlotNumberGetAsync (int? epochNumber, int? slotNumber)
        {
             ApiResponse<BlockContent> localVarResponse = await BlocksEpochEpochNumberSlotSlotNumberGetAsyncWithHttpInfo(epochNumber, slotNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific block in a slot in an epoch Return the content of a requested block for a specific slot in an epoch. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="epochNumber">Epoch for specific epoch slot.</param>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksEpochEpochNumberSlotSlotNumberGetAsyncWithHttpInfo (int? epochNumber, int? slotNumber)
        {
            // verify the required parameter 'epochNumber' is set
            if (epochNumber == null)
                throw new ApiException(400, "Missing required parameter 'epochNumber' when calling CardanoBlocksApi->BlocksEpochEpochNumberSlotSlotNumberGet");
            // verify the required parameter 'slotNumber' is set
            if (slotNumber == null)
                throw new ApiException(400, "Missing required parameter 'slotNumber' when calling CardanoBlocksApi->BlocksEpochEpochNumberSlotSlotNumberGet");

            var localVarPath = "./blocks/epoch/{epoch_number}/slot/{slot_number}";
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

            if (epochNumber != null) localVarPathParams.Add("epoch_number", this.Configuration.ApiClient.ParameterToString(epochNumber)); // path parameter
            if (slotNumber != null) localVarPathParams.Add("slot_number", this.Configuration.ApiClient.ParameterToString(slotNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksEpochEpochNumberSlotSlotNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Specific block Return the content of a requested block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>BlockContent</returns>
        public BlockContent BlocksHashOrNumberGet (string hashOrNumber)
        {
             ApiResponse<BlockContent> localVarResponse = BlocksHashOrNumberGetWithHttpInfo(hashOrNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific block Return the content of a requested block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        public ApiResponse< BlockContent > BlocksHashOrNumberGetWithHttpInfo (string hashOrNumber)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberGet");

            var localVarPath = "./blocks/{hash_or_number}";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Specific block Return the content of a requested block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>Task of BlockContent</returns>
        public async System.Threading.Tasks.Task<BlockContent> BlocksHashOrNumberGetAsync (string hashOrNumber)
        {
             ApiResponse<BlockContent> localVarResponse = await BlocksHashOrNumberGetAsyncWithHttpInfo(hashOrNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific block Return the content of a requested block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash or number of the requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksHashOrNumberGetAsyncWithHttpInfo (string hashOrNumber)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberGet");

            var localVarPath = "./blocks/{hash_or_number}";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Listing of next blocks Return the list of blocks following a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>BlockContentArray</returns>
        public BlockContentArray BlocksHashOrNumberNextGet (string hashOrNumber, int? count = null, int? page = null)
        {
             ApiResponse<BlockContentArray> localVarResponse = BlocksHashOrNumberNextGetWithHttpInfo(hashOrNumber, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing of next blocks Return the list of blocks following a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of BlockContentArray</returns>
        public ApiResponse< BlockContentArray > BlocksHashOrNumberNextGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberNextGet");

            var localVarPath = "./blocks/{hash_or_number}/next";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberNextGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentArray)));
        }

        /// <summary>
        /// Listing of next blocks Return the list of blocks following a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of BlockContentArray</returns>
        public async System.Threading.Tasks.Task<BlockContentArray> BlocksHashOrNumberNextGetAsync (string hashOrNumber, int? count = null, int? page = null)
        {
             ApiResponse<BlockContentArray> localVarResponse = await BlocksHashOrNumberNextGetAsyncWithHttpInfo(hashOrNumber, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing of next blocks Return the list of blocks following a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (BlockContentArray)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContentArray>> BlocksHashOrNumberNextGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberNextGet");

            var localVarPath = "./blocks/{hash_or_number}/next";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberNextGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentArray)));
        }

        /// <summary>
        /// Listing of previous blocks Return the list of blocks preceding a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>BlockContentArray</returns>
        public BlockContentArray BlocksHashOrNumberPreviousGet (string hashOrNumber, int? count = null, int? page = null)
        {
             ApiResponse<BlockContentArray> localVarResponse = BlocksHashOrNumberPreviousGetWithHttpInfo(hashOrNumber, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing of previous blocks Return the list of blocks preceding a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of BlockContentArray</returns>
        public ApiResponse< BlockContentArray > BlocksHashOrNumberPreviousGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberPreviousGet");

            var localVarPath = "./blocks/{hash_or_number}/previous";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberPreviousGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentArray)));
        }

        /// <summary>
        /// Listing of previous blocks Return the list of blocks preceding a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of BlockContentArray</returns>
        public async System.Threading.Tasks.Task<BlockContentArray> BlocksHashOrNumberPreviousGetAsync (string hashOrNumber, int? count = null, int? page = null)
        {
             ApiResponse<BlockContentArray> localVarResponse = await BlocksHashOrNumberPreviousGetAsyncWithHttpInfo(hashOrNumber, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing of previous blocks Return the list of blocks preceding a specific block. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (BlockContentArray)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContentArray>> BlocksHashOrNumberPreviousGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberPreviousGet");

            var localVarPath = "./blocks/{hash_or_number}/previous";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberPreviousGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentArray)));
        }

        /// <summary>
        /// Block transactions Return the transactions within the block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>BlockContentTxs</returns>
        public BlockContentTxs BlocksHashOrNumberTxsGet (string hashOrNumber, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<BlockContentTxs> localVarResponse = BlocksHashOrNumberTxsGetWithHttpInfo(hashOrNumber, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Block transactions Return the transactions within the block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of BlockContentTxs</returns>
        public ApiResponse< BlockContentTxs > BlocksHashOrNumberTxsGetWithHttpInfo (string hashOrNumber, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberTxsGet");

            var localVarPath = "./blocks/{hash_or_number}/txs";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentTxs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentTxs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentTxs)));
        }

        /// <summary>
        /// Block transactions Return the transactions within the block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of BlockContentTxs</returns>
        public async System.Threading.Tasks.Task<BlockContentTxs> BlocksHashOrNumberTxsGetAsync (string hashOrNumber, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<BlockContentTxs> localVarResponse = await BlocksHashOrNumberTxsGetAsyncWithHttpInfo(hashOrNumber, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Block transactions Return the transactions within the block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hashOrNumber">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (BlockContentTxs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContentTxs>> BlocksHashOrNumberTxsGetAsyncWithHttpInfo (string hashOrNumber, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'hashOrNumber' is set
            if (hashOrNumber == null)
                throw new ApiException(400, "Missing required parameter 'hashOrNumber' when calling CardanoBlocksApi->BlocksHashOrNumberTxsGet");

            var localVarPath = "./blocks/{hash_or_number}/txs";
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

            if (hashOrNumber != null) localVarPathParams.Add("hash_or_number", this.Configuration.ApiClient.ParameterToString(hashOrNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksHashOrNumberTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentTxs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentTxs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentTxs)));
        }

        /// <summary>
        /// Latest block Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>BlockContent</returns>
        public BlockContent BlocksLatestGet ()
        {
             ApiResponse<BlockContent> localVarResponse = BlocksLatestGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Latest block Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of BlockContent</returns>
        public ApiResponse< BlockContent > BlocksLatestGetWithHttpInfo ()
        {

            var localVarPath = "./blocks/latest";
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
                Exception exception = ExceptionFactory("BlocksLatestGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Latest block Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BlockContent</returns>
        public async System.Threading.Tasks.Task<BlockContent> BlocksLatestGetAsync ()
        {
             ApiResponse<BlockContent> localVarResponse = await BlocksLatestGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Latest block Return the latest block available to the backends, also known as the tip of the blockchain. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksLatestGetAsyncWithHttpInfo ()
        {

            var localVarPath = "./blocks/latest";
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
                Exception exception = ExceptionFactory("BlocksLatestGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Latest block transactions Return the transactions within the latest block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>BlockContentTxs</returns>
        public BlockContentTxs BlocksLatestTxsGet (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<BlockContentTxs> localVarResponse = BlocksLatestTxsGetWithHttpInfo(count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Latest block transactions Return the transactions within the latest block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of BlockContentTxs</returns>
        public ApiResponse< BlockContentTxs > BlocksLatestTxsGetWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./blocks/latest/txs";
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
                Exception exception = ExceptionFactory("BlocksLatestTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentTxs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentTxs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentTxs)));
        }

        /// <summary>
        /// Latest block transactions Return the transactions within the latest block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of BlockContentTxs</returns>
        public async System.Threading.Tasks.Task<BlockContentTxs> BlocksLatestTxsGetAsync (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<BlockContentTxs> localVarResponse = await BlocksLatestTxsGetAsyncWithHttpInfo(count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Latest block transactions Return the transactions within the latest block.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (BlockContentTxs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContentTxs>> BlocksLatestTxsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./blocks/latest/txs";
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
                Exception exception = ExceptionFactory("BlocksLatestTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContentTxs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContentTxs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContentTxs)));
        }

        /// <summary>
        /// Specific block in a slot Return the content of a requested block for a specific slot. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>BlockContent</returns>
        public BlockContent BlocksSlotSlotNumberGet (int? slotNumber)
        {
             ApiResponse<BlockContent> localVarResponse = BlocksSlotSlotNumberGetWithHttpInfo(slotNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific block in a slot Return the content of a requested block for a specific slot. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>ApiResponse of BlockContent</returns>
        public ApiResponse< BlockContent > BlocksSlotSlotNumberGetWithHttpInfo (int? slotNumber)
        {
            // verify the required parameter 'slotNumber' is set
            if (slotNumber == null)
                throw new ApiException(400, "Missing required parameter 'slotNumber' when calling CardanoBlocksApi->BlocksSlotSlotNumberGet");

            var localVarPath = "./blocks/slot/{slot_number}";
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

            if (slotNumber != null) localVarPathParams.Add("slot_number", this.Configuration.ApiClient.ParameterToString(slotNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksSlotSlotNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

        /// <summary>
        /// Specific block in a slot Return the content of a requested block for a specific slot. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of BlockContent</returns>
        public async System.Threading.Tasks.Task<BlockContent> BlocksSlotSlotNumberGetAsync (int? slotNumber)
        {
             ApiResponse<BlockContent> localVarResponse = await BlocksSlotSlotNumberGetAsyncWithHttpInfo(slotNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific block in a slot Return the content of a requested block for a specific slot. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="slotNumber">Slot position for requested block.</param>
        /// <returns>Task of ApiResponse (BlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BlockContent>> BlocksSlotSlotNumberGetAsyncWithHttpInfo (int? slotNumber)
        {
            // verify the required parameter 'slotNumber' is set
            if (slotNumber == null)
                throw new ApiException(400, "Missing required parameter 'slotNumber' when calling CardanoBlocksApi->BlocksSlotSlotNumberGet");

            var localVarPath = "./blocks/slot/{slot_number}";
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

            if (slotNumber != null) localVarPathParams.Add("slot_number", this.Configuration.ApiClient.ParameterToString(slotNumber)); // path parameter
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
                Exception exception = ExceptionFactory("BlocksSlotSlotNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (BlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BlockContent)));
        }

    }
}
