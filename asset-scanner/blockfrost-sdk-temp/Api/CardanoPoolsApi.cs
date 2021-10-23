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
        public interface ICardanoPoolsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List of stake pools
        /// </summary>
        /// <remarks>
        /// List of registered stake pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolList</returns>
        PoolList PoolsGet (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of stake pools
        /// </summary>
        /// <remarks>
        /// List of registered stake pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolList</returns>
        ApiResponse<PoolList> PoolsGetWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool blocks
        /// </summary>
        /// <remarks>
        /// List of stake pools blocks.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolBlocks</returns>
        PoolBlocks PoolsPoolIdBlocksGet (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool blocks
        /// </summary>
        /// <remarks>
        /// List of stake pools blocks.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolBlocks</returns>
        ApiResponse<PoolBlocks> PoolsPoolIdBlocksGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool delegators
        /// </summary>
        /// <remarks>
        /// List of current stake pools delegators.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolDelegators</returns>
        PoolDelegators PoolsPoolIdDelegatorsGet (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool delegators
        /// </summary>
        /// <remarks>
        /// List of current stake pools delegators.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolDelegators</returns>
        ApiResponse<PoolDelegators> PoolsPoolIdDelegatorsGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific stake pool
        /// </summary>
        /// <remarks>
        /// Pool information.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Pool</returns>
        Pool PoolsPoolIdGet (string poolId);

        /// <summary>
        /// Specific stake pool
        /// </summary>
        /// <remarks>
        /// Pool information.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of Pool</returns>
        ApiResponse<Pool> PoolsPoolIdGetWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool history
        /// </summary>
        /// <remarks>
        /// History of stake pool parameters over epochs. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolHistory</returns>
        PoolHistory PoolsPoolIdHistoryGet (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool history
        /// </summary>
        /// <remarks>
        /// History of stake pool parameters over epochs. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolHistory</returns>
        ApiResponse<PoolHistory> PoolsPoolIdHistoryGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool metadata
        /// </summary>
        /// <remarks>
        /// Stake pool registration metadata. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 PoolsPoolIdMetadataGet (string poolId);

        /// <summary>
        /// Stake pool metadata
        /// </summary>
        /// <remarks>
        /// Stake pool registration metadata. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> PoolsPoolIdMetadataGetWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool relays
        /// </summary>
        /// <remarks>
        /// Relays of a stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>PoolRelays</returns>
        PoolRelays PoolsPoolIdRelaysGet (string poolId);

        /// <summary>
        /// Stake pool relays
        /// </summary>
        /// <remarks>
        /// Relays of a stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of PoolRelays</returns>
        ApiResponse<PoolRelays> PoolsPoolIdRelaysGetWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool updates
        /// </summary>
        /// <remarks>
        /// List of certificate updates to the stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolUpdates</returns>
        PoolUpdates PoolsPoolIdUpdatesGet (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool updates
        /// </summary>
        /// <remarks>
        /// List of certificate updates to the stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolUpdates</returns>
        ApiResponse<PoolUpdates> PoolsPoolIdUpdatesGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// List of retired stake pools
        /// </summary>
        /// <remarks>
        /// List of already retired pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolListRetire</returns>
        PoolListRetire PoolsRetiredGet (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of retired stake pools
        /// </summary>
        /// <remarks>
        /// List of already retired pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolListRetire</returns>
        ApiResponse<PoolListRetire> PoolsRetiredGetWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// List of retiring stake pools
        /// </summary>
        /// <remarks>
        /// List of stake pools retiring in the upcoming epochs
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolListRetire</returns>
        PoolListRetire PoolsRetiringGet (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of retiring stake pools
        /// </summary>
        /// <remarks>
        /// List of stake pools retiring in the upcoming epochs
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolListRetire</returns>
        ApiResponse<PoolListRetire> PoolsRetiringGetWithHttpInfo (int? count = null, int? page = null, string order = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List of stake pools
        /// </summary>
        /// <remarks>
        /// List of registered stake pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolList</returns>
        System.Threading.Tasks.Task<PoolList> PoolsGetAsync (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of stake pools
        /// </summary>
        /// <remarks>
        /// List of registered stake pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolList>> PoolsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool blocks
        /// </summary>
        /// <remarks>
        /// List of stake pools blocks.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolBlocks</returns>
        System.Threading.Tasks.Task<PoolBlocks> PoolsPoolIdBlocksGetAsync (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool blocks
        /// </summary>
        /// <remarks>
        /// List of stake pools blocks.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolBlocks)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolBlocks>> PoolsPoolIdBlocksGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool delegators
        /// </summary>
        /// <remarks>
        /// List of current stake pools delegators.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolDelegators</returns>
        System.Threading.Tasks.Task<PoolDelegators> PoolsPoolIdDelegatorsGetAsync (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool delegators
        /// </summary>
        /// <remarks>
        /// List of current stake pools delegators.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolDelegators)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolDelegators>> PoolsPoolIdDelegatorsGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific stake pool
        /// </summary>
        /// <remarks>
        /// Pool information.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of Pool</returns>
        System.Threading.Tasks.Task<Pool> PoolsPoolIdGetAsync (string poolId);

        /// <summary>
        /// Specific stake pool
        /// </summary>
        /// <remarks>
        /// Pool information.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (Pool)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pool>> PoolsPoolIdGetAsyncWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool history
        /// </summary>
        /// <remarks>
        /// History of stake pool parameters over epochs. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolHistory</returns>
        System.Threading.Tasks.Task<PoolHistory> PoolsPoolIdHistoryGetAsync (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool history
        /// </summary>
        /// <remarks>
        /// History of stake pool parameters over epochs. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolHistory>> PoolsPoolIdHistoryGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Stake pool metadata
        /// </summary>
        /// <remarks>
        /// Stake pool registration metadata. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> PoolsPoolIdMetadataGetAsync (string poolId);

        /// <summary>
        /// Stake pool metadata
        /// </summary>
        /// <remarks>
        /// Stake pool registration metadata. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> PoolsPoolIdMetadataGetAsyncWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool relays
        /// </summary>
        /// <remarks>
        /// Relays of a stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of PoolRelays</returns>
        System.Threading.Tasks.Task<PoolRelays> PoolsPoolIdRelaysGetAsync (string poolId);

        /// <summary>
        /// Stake pool relays
        /// </summary>
        /// <remarks>
        /// Relays of a stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (PoolRelays)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolRelays>> PoolsPoolIdRelaysGetAsyncWithHttpInfo (string poolId);
        /// <summary>
        /// Stake pool updates
        /// </summary>
        /// <remarks>
        /// List of certificate updates to the stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolUpdates</returns>
        System.Threading.Tasks.Task<PoolUpdates> PoolsPoolIdUpdatesGetAsync (string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Stake pool updates
        /// </summary>
        /// <remarks>
        /// List of certificate updates to the stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolUpdates)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolUpdates>> PoolsPoolIdUpdatesGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// List of retired stake pools
        /// </summary>
        /// <remarks>
        /// List of already retired pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolListRetire</returns>
        System.Threading.Tasks.Task<PoolListRetire> PoolsRetiredGetAsync (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of retired stake pools
        /// </summary>
        /// <remarks>
        /// List of already retired pools.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolListRetire)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolListRetire>> PoolsRetiredGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null);
        /// <summary>
        /// List of retiring stake pools
        /// </summary>
        /// <remarks>
        /// List of stake pools retiring in the upcoming epochs
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolListRetire</returns>
        System.Threading.Tasks.Task<PoolListRetire> PoolsRetiringGetAsync (int? count = null, int? page = null, string order = null);

        /// <summary>
        /// List of retiring stake pools
        /// </summary>
        /// <remarks>
        /// List of stake pools retiring in the upcoming epochs
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolListRetire)</returns>
        System.Threading.Tasks.Task<ApiResponse<PoolListRetire>> PoolsRetiringGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoPoolsApi : ICardanoPoolsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoPoolsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoPoolsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoPoolsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoPoolsApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoPoolsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoPoolsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// List of stake pools List of registered stake pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolList</returns>
        public PoolList PoolsGet (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolList> localVarResponse = PoolsGetWithHttpInfo(count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of stake pools List of registered stake pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolList</returns>
        public ApiResponse< PoolList > PoolsGetWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools";
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
                Exception exception = ExceptionFactory("PoolsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolList)));
        }

        /// <summary>
        /// List of stake pools List of registered stake pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolList</returns>
        public async System.Threading.Tasks.Task<PoolList> PoolsGetAsync (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolList> localVarResponse = await PoolsGetAsyncWithHttpInfo(count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of stake pools List of registered stake pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolList>> PoolsGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools";
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
                Exception exception = ExceptionFactory("PoolsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolList)));
        }

        /// <summary>
        /// Stake pool blocks List of stake pools blocks.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolBlocks</returns>
        public PoolBlocks PoolsPoolIdBlocksGet (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolBlocks> localVarResponse = PoolsPoolIdBlocksGetWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool blocks List of stake pools blocks.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolBlocks</returns>
        public ApiResponse< PoolBlocks > PoolsPoolIdBlocksGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdBlocksGet");

            var localVarPath = "./pools/{pool_id}/blocks";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdBlocksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolBlocks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolBlocks) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolBlocks)));
        }

        /// <summary>
        /// Stake pool blocks List of stake pools blocks.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolBlocks</returns>
        public async System.Threading.Tasks.Task<PoolBlocks> PoolsPoolIdBlocksGetAsync (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolBlocks> localVarResponse = await PoolsPoolIdBlocksGetAsyncWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool blocks List of stake pools blocks.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolBlocks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolBlocks>> PoolsPoolIdBlocksGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdBlocksGet");

            var localVarPath = "./pools/{pool_id}/blocks";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdBlocksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolBlocks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolBlocks) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolBlocks)));
        }

        /// <summary>
        /// Stake pool delegators List of current stake pools delegators.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolDelegators</returns>
        public PoolDelegators PoolsPoolIdDelegatorsGet (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolDelegators> localVarResponse = PoolsPoolIdDelegatorsGetWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool delegators List of current stake pools delegators.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolDelegators</returns>
        public ApiResponse< PoolDelegators > PoolsPoolIdDelegatorsGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdDelegatorsGet");

            var localVarPath = "./pools/{pool_id}/delegators";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdDelegatorsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolDelegators>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolDelegators) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolDelegators)));
        }

        /// <summary>
        /// Stake pool delegators List of current stake pools delegators.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolDelegators</returns>
        public async System.Threading.Tasks.Task<PoolDelegators> PoolsPoolIdDelegatorsGetAsync (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolDelegators> localVarResponse = await PoolsPoolIdDelegatorsGetAsyncWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool delegators List of current stake pools delegators.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolDelegators)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolDelegators>> PoolsPoolIdDelegatorsGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdDelegatorsGet");

            var localVarPath = "./pools/{pool_id}/delegators";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdDelegatorsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolDelegators>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolDelegators) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolDelegators)));
        }

        /// <summary>
        /// Specific stake pool Pool information.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Pool</returns>
        public Pool PoolsPoolIdGet (string poolId)
        {
             ApiResponse<Pool> localVarResponse = PoolsPoolIdGetWithHttpInfo(poolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific stake pool Pool information.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of Pool</returns>
        public ApiResponse< Pool > PoolsPoolIdGetWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdGet");

            var localVarPath = "./pools/{pool_id}";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Pool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Pool) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pool)));
        }

        /// <summary>
        /// Specific stake pool Pool information.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of Pool</returns>
        public async System.Threading.Tasks.Task<Pool> PoolsPoolIdGetAsync (string poolId)
        {
             ApiResponse<Pool> localVarResponse = await PoolsPoolIdGetAsyncWithHttpInfo(poolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific stake pool Pool information.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (Pool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Pool>> PoolsPoolIdGetAsyncWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdGet");

            var localVarPath = "./pools/{pool_id}";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Pool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Pool) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pool)));
        }

        /// <summary>
        /// Stake pool history History of stake pool parameters over epochs. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolHistory</returns>
        public PoolHistory PoolsPoolIdHistoryGet (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolHistory> localVarResponse = PoolsPoolIdHistoryGetWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool history History of stake pool parameters over epochs. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolHistory</returns>
        public ApiResponse< PoolHistory > PoolsPoolIdHistoryGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdHistoryGet");

            var localVarPath = "./pools/{pool_id}/history";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolHistory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolHistory)));
        }

        /// <summary>
        /// Stake pool history History of stake pool parameters over epochs. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolHistory</returns>
        public async System.Threading.Tasks.Task<PoolHistory> PoolsPoolIdHistoryGetAsync (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolHistory> localVarResponse = await PoolsPoolIdHistoryGetAsyncWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool history History of stake pool parameters over epochs. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolHistory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolHistory>> PoolsPoolIdHistoryGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdHistoryGet");

            var localVarPath = "./pools/{pool_id}/history";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolHistory) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolHistory)));
        }

        /// <summary>
        /// Stake pool metadata Stake pool registration metadata. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 PoolsPoolIdMetadataGet (string poolId)
        {
             ApiResponse<InlineResponse2003> localVarResponse = PoolsPoolIdMetadataGetWithHttpInfo(poolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool metadata Stake pool registration metadata. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > PoolsPoolIdMetadataGetWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdMetadataGet");

            var localVarPath = "./pools/{pool_id}/metadata";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdMetadataGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Stake pool metadata Stake pool registration metadata. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> PoolsPoolIdMetadataGetAsync (string poolId)
        {
             ApiResponse<InlineResponse2003> localVarResponse = await PoolsPoolIdMetadataGetAsyncWithHttpInfo(poolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool metadata Stake pool registration metadata. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> PoolsPoolIdMetadataGetAsyncWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdMetadataGet");

            var localVarPath = "./pools/{pool_id}/metadata";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdMetadataGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Stake pool relays Relays of a stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>PoolRelays</returns>
        public PoolRelays PoolsPoolIdRelaysGet (string poolId)
        {
             ApiResponse<PoolRelays> localVarResponse = PoolsPoolIdRelaysGetWithHttpInfo(poolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool relays Relays of a stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>ApiResponse of PoolRelays</returns>
        public ApiResponse< PoolRelays > PoolsPoolIdRelaysGetWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdRelaysGet");

            var localVarPath = "./pools/{pool_id}/relays";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdRelaysGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolRelays>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolRelays) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolRelays)));
        }

        /// <summary>
        /// Stake pool relays Relays of a stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of PoolRelays</returns>
        public async System.Threading.Tasks.Task<PoolRelays> PoolsPoolIdRelaysGetAsync (string poolId)
        {
             ApiResponse<PoolRelays> localVarResponse = await PoolsPoolIdRelaysGetAsyncWithHttpInfo(poolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool relays Relays of a stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <returns>Task of ApiResponse (PoolRelays)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolRelays>> PoolsPoolIdRelaysGetAsyncWithHttpInfo (string poolId)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdRelaysGet");

            var localVarPath = "./pools/{pool_id}/relays";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdRelaysGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolRelays>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolRelays) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolRelays)));
        }

        /// <summary>
        /// Stake pool updates List of certificate updates to the stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolUpdates</returns>
        public PoolUpdates PoolsPoolIdUpdatesGet (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolUpdates> localVarResponse = PoolsPoolIdUpdatesGetWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake pool updates List of certificate updates to the stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolUpdates</returns>
        public ApiResponse< PoolUpdates > PoolsPoolIdUpdatesGetWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdUpdatesGet");

            var localVarPath = "./pools/{pool_id}/updates";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolUpdates>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolUpdates) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolUpdates)));
        }

        /// <summary>
        /// Stake pool updates List of certificate updates to the stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolUpdates</returns>
        public async System.Threading.Tasks.Task<PoolUpdates> PoolsPoolIdUpdatesGetAsync (string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolUpdates> localVarResponse = await PoolsPoolIdUpdatesGetAsyncWithHttpInfo(poolId, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake pool updates List of certificate updates to the stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="poolId">Bech32 or hexadecimal pool ID.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolUpdates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolUpdates>> PoolsPoolIdUpdatesGetAsyncWithHttpInfo (string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoPoolsApi->PoolsPoolIdUpdatesGet");

            var localVarPath = "./pools/{pool_id}/updates";
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

            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("PoolsPoolIdUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolUpdates>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolUpdates) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolUpdates)));
        }

        /// <summary>
        /// List of retired stake pools List of already retired pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolListRetire</returns>
        public PoolListRetire PoolsRetiredGet (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolListRetire> localVarResponse = PoolsRetiredGetWithHttpInfo(count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of retired stake pools List of already retired pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolListRetire</returns>
        public ApiResponse< PoolListRetire > PoolsRetiredGetWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools/retired";
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
                Exception exception = ExceptionFactory("PoolsRetiredGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolListRetire>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolListRetire) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolListRetire)));
        }

        /// <summary>
        /// List of retired stake pools List of already retired pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolListRetire</returns>
        public async System.Threading.Tasks.Task<PoolListRetire> PoolsRetiredGetAsync (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolListRetire> localVarResponse = await PoolsRetiredGetAsyncWithHttpInfo(count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of retired stake pools List of already retired pools.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolListRetire)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolListRetire>> PoolsRetiredGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools/retired";
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
                Exception exception = ExceptionFactory("PoolsRetiredGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolListRetire>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolListRetire) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolListRetire)));
        }

        /// <summary>
        /// List of retiring stake pools List of stake pools retiring in the upcoming epochs
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>PoolListRetire</returns>
        public PoolListRetire PoolsRetiringGet (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolListRetire> localVarResponse = PoolsRetiringGetWithHttpInfo(count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of retiring stake pools List of stake pools retiring in the upcoming epochs
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of PoolListRetire</returns>
        public ApiResponse< PoolListRetire > PoolsRetiringGetWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools/retiring";
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
                Exception exception = ExceptionFactory("PoolsRetiringGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolListRetire>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolListRetire) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolListRetire)));
        }

        /// <summary>
        /// List of retiring stake pools List of stake pools retiring in the upcoming epochs
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of PoolListRetire</returns>
        public async System.Threading.Tasks.Task<PoolListRetire> PoolsRetiringGetAsync (int? count = null, int? page = null, string order = null)
        {
             ApiResponse<PoolListRetire> localVarResponse = await PoolsRetiringGetAsyncWithHttpInfo(count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of retiring stake pools List of stake pools retiring in the upcoming epochs
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (PoolListRetire)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PoolListRetire>> PoolsRetiringGetAsyncWithHttpInfo (int? count = null, int? page = null, string order = null)
        {

            var localVarPath = "./pools/retiring";
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
                Exception exception = ExceptionFactory("PoolsRetiringGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PoolListRetire>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PoolListRetire) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PoolListRetire)));
        }

    }
}
