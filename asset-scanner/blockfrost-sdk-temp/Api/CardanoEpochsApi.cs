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
        public interface ICardanoEpochsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Latest epoch
        /// </summary>
        /// <remarks>
        /// Return the information about the latest, therefore current, epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EpochContent</returns>
        EpochContent EpochsLatestGet ();

        /// <summary>
        /// Latest epoch
        /// </summary>
        /// <remarks>
        /// Return the information about the latest, therefore current, epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EpochContent</returns>
        ApiResponse<EpochContent> EpochsLatestGetWithHttpInfo ();
        /// <summary>
        /// Latest epoch protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the latest epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EpochParamContent</returns>
        EpochParamContent EpochsLatestParametersGet ();

        /// <summary>
        /// Latest epoch protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the latest epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EpochParamContent</returns>
        ApiResponse<EpochParamContent> EpochsLatestParametersGetWithHttpInfo ();
        /// <summary>
        /// Block distribution
        /// </summary>
        /// <remarks>
        /// Return the blocks minted for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>EpochBlockContent</returns>
        EpochBlockContent EpochsNumberBlocksGet (int? number, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block distribution
        /// </summary>
        /// <remarks>
        /// Return the blocks minted for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of EpochBlockContent</returns>
        ApiResponse<EpochBlockContent> EpochsNumberBlocksGetWithHttpInfo (int? number, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Block distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the block minted for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>EpochBlockContent</returns>
        EpochBlockContent EpochsNumberBlocksPoolIdGet (int? number, string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the block minted for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of EpochBlockContent</returns>
        ApiResponse<EpochBlockContent> EpochsNumberBlocksPoolIdGetWithHttpInfo (int? number, string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific epoch
        /// </summary>
        /// <remarks>
        /// Return the content of the requested epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>EpochContent</returns>
        EpochContent EpochsNumberGet (int? number);

        /// <summary>
        /// Specific epoch
        /// </summary>
        /// <remarks>
        /// Return the content of the requested epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>ApiResponse of EpochContent</returns>
        ApiResponse<EpochContent> EpochsNumberGetWithHttpInfo (int? number);
        /// <summary>
        /// Listing of next epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs following a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochContentArray</returns>
        EpochContentArray EpochsNumberNextGet (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Listing of next epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs following a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochContentArray</returns>
        ApiResponse<EpochContentArray> EpochsNumberNextGetWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>EpochParamContent</returns>
        EpochParamContent EpochsNumberParametersGet (int? number);

        /// <summary>
        /// Protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>ApiResponse of EpochParamContent</returns>
        ApiResponse<EpochParamContent> EpochsNumberParametersGetWithHttpInfo (int? number);
        /// <summary>
        /// Listing of previous epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs preceding a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>EpochContentArray</returns>
        EpochContentArray EpochsNumberPreviousGet (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Listing of previous epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs preceding a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochContentArray</returns>
        ApiResponse<EpochContentArray> EpochsNumberPreviousGetWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Stake distribution
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the specified epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochStakeContent</returns>
        EpochStakeContent EpochsNumberStakesGet (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Stake distribution
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the specified epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochStakeContent</returns>
        ApiResponse<EpochStakeContent> EpochsNumberStakesGetWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Stake distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochStakePoolContent</returns>
        EpochStakePoolContent EpochsNumberStakesPoolIdGet (int? number, string poolId, int? count = null, int? page = null);

        /// <summary>
        /// Stake distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochStakePoolContent</returns>
        ApiResponse<EpochStakePoolContent> EpochsNumberStakesPoolIdGetWithHttpInfo (int? number, string poolId, int? count = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Latest epoch
        /// </summary>
        /// <remarks>
        /// Return the information about the latest, therefore current, epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EpochContent</returns>
        System.Threading.Tasks.Task<EpochContent> EpochsLatestGetAsync ();

        /// <summary>
        /// Latest epoch
        /// </summary>
        /// <remarks>
        /// Return the information about the latest, therefore current, epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EpochContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochContent>> EpochsLatestGetAsyncWithHttpInfo ();
        /// <summary>
        /// Latest epoch protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the latest epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EpochParamContent</returns>
        System.Threading.Tasks.Task<EpochParamContent> EpochsLatestParametersGetAsync ();

        /// <summary>
        /// Latest epoch protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the latest epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EpochParamContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochParamContent>> EpochsLatestParametersGetAsyncWithHttpInfo ();
        /// <summary>
        /// Block distribution
        /// </summary>
        /// <remarks>
        /// Return the blocks minted for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of EpochBlockContent</returns>
        System.Threading.Tasks.Task<EpochBlockContent> EpochsNumberBlocksGetAsync (int? number, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block distribution
        /// </summary>
        /// <remarks>
        /// Return the blocks minted for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (EpochBlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochBlockContent>> EpochsNumberBlocksGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Block distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the block minted for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of EpochBlockContent</returns>
        System.Threading.Tasks.Task<EpochBlockContent> EpochsNumberBlocksPoolIdGetAsync (int? number, string poolId, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Block distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the block minted for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (EpochBlockContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochBlockContent>> EpochsNumberBlocksPoolIdGetAsyncWithHttpInfo (int? number, string poolId, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific epoch
        /// </summary>
        /// <remarks>
        /// Return the content of the requested epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of EpochContent</returns>
        System.Threading.Tasks.Task<EpochContent> EpochsNumberGetAsync (int? number);

        /// <summary>
        /// Specific epoch
        /// </summary>
        /// <remarks>
        /// Return the content of the requested epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of ApiResponse (EpochContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochContent>> EpochsNumberGetAsyncWithHttpInfo (int? number);
        /// <summary>
        /// Listing of next epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs following a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochContentArray</returns>
        System.Threading.Tasks.Task<EpochContentArray> EpochsNumberNextGetAsync (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Listing of next epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs following a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochContentArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochContentArray>> EpochsNumberNextGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of EpochParamContent</returns>
        System.Threading.Tasks.Task<EpochParamContent> EpochsNumberParametersGetAsync (int? number);

        /// <summary>
        /// Protocol parameters
        /// </summary>
        /// <remarks>
        /// Return the protocol parameters for the epoch specified.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of ApiResponse (EpochParamContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochParamContent>> EpochsNumberParametersGetAsyncWithHttpInfo (int? number);
        /// <summary>
        /// Listing of previous epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs preceding a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>Task of EpochContentArray</returns>
        System.Threading.Tasks.Task<EpochContentArray> EpochsNumberPreviousGetAsync (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Listing of previous epochs
        /// </summary>
        /// <remarks>
        /// Return the list of epochs preceding a specific epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochContentArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochContentArray>> EpochsNumberPreviousGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Stake distribution
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the specified epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochStakeContent</returns>
        System.Threading.Tasks.Task<EpochStakeContent> EpochsNumberStakesGetAsync (int? number, int? count = null, int? page = null);

        /// <summary>
        /// Stake distribution
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the specified epoch.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochStakeContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochStakeContent>> EpochsNumberStakesGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null);
        /// <summary>
        /// Stake distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochStakePoolContent</returns>
        System.Threading.Tasks.Task<EpochStakePoolContent> EpochsNumberStakesPoolIdGetAsync (int? number, string poolId, int? count = null, int? page = null);

        /// <summary>
        /// Stake distribution by pool
        /// </summary>
        /// <remarks>
        /// Return the active stake distribution for the epoch specified by stake pool.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochStakePoolContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<EpochStakePoolContent>> EpochsNumberStakesPoolIdGetAsyncWithHttpInfo (int? number, string poolId, int? count = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoEpochsApi : ICardanoEpochsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoEpochsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoEpochsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoEpochsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoEpochsApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoEpochsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoEpochsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Latest epoch Return the information about the latest, therefore current, epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EpochContent</returns>
        public EpochContent EpochsLatestGet ()
        {
             ApiResponse<EpochContent> localVarResponse = EpochsLatestGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Latest epoch Return the information about the latest, therefore current, epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EpochContent</returns>
        public ApiResponse< EpochContent > EpochsLatestGetWithHttpInfo ()
        {

            var localVarPath = "./epochs/latest";
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
                Exception exception = ExceptionFactory("EpochsLatestGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContent)));
        }

        /// <summary>
        /// Latest epoch Return the information about the latest, therefore current, epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EpochContent</returns>
        public async System.Threading.Tasks.Task<EpochContent> EpochsLatestGetAsync ()
        {
             ApiResponse<EpochContent> localVarResponse = await EpochsLatestGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Latest epoch Return the information about the latest, therefore current, epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EpochContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochContent>> EpochsLatestGetAsyncWithHttpInfo ()
        {

            var localVarPath = "./epochs/latest";
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
                Exception exception = ExceptionFactory("EpochsLatestGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContent)));
        }

        /// <summary>
        /// Latest epoch protocol parameters Return the protocol parameters for the latest epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EpochParamContent</returns>
        public EpochParamContent EpochsLatestParametersGet ()
        {
             ApiResponse<EpochParamContent> localVarResponse = EpochsLatestParametersGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Latest epoch protocol parameters Return the protocol parameters for the latest epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EpochParamContent</returns>
        public ApiResponse< EpochParamContent > EpochsLatestParametersGetWithHttpInfo ()
        {

            var localVarPath = "./epochs/latest/parameters";
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
                Exception exception = ExceptionFactory("EpochsLatestParametersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochParamContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochParamContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochParamContent)));
        }

        /// <summary>
        /// Latest epoch protocol parameters Return the protocol parameters for the latest epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EpochParamContent</returns>
        public async System.Threading.Tasks.Task<EpochParamContent> EpochsLatestParametersGetAsync ()
        {
             ApiResponse<EpochParamContent> localVarResponse = await EpochsLatestParametersGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Latest epoch protocol parameters Return the protocol parameters for the latest epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EpochParamContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochParamContent>> EpochsLatestParametersGetAsyncWithHttpInfo ()
        {

            var localVarPath = "./epochs/latest/parameters";
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
                Exception exception = ExceptionFactory("EpochsLatestParametersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochParamContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochParamContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochParamContent)));
        }

        /// <summary>
        /// Block distribution Return the blocks minted for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>EpochBlockContent</returns>
        public EpochBlockContent EpochsNumberBlocksGet (int? number, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<EpochBlockContent> localVarResponse = EpochsNumberBlocksGetWithHttpInfo(number, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Block distribution Return the blocks minted for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of EpochBlockContent</returns>
        public ApiResponse< EpochBlockContent > EpochsNumberBlocksGetWithHttpInfo (int? number, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberBlocksGet");

            var localVarPath = "./epochs/{number}/blocks";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberBlocksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochBlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochBlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochBlockContent)));
        }

        /// <summary>
        /// Block distribution Return the blocks minted for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of EpochBlockContent</returns>
        public async System.Threading.Tasks.Task<EpochBlockContent> EpochsNumberBlocksGetAsync (int? number, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<EpochBlockContent> localVarResponse = await EpochsNumberBlocksGetAsyncWithHttpInfo(number, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Block distribution Return the blocks minted for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (EpochBlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochBlockContent>> EpochsNumberBlocksGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberBlocksGet");

            var localVarPath = "./epochs/{number}/blocks";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberBlocksGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochBlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochBlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochBlockContent)));
        }

        /// <summary>
        /// Block distribution by pool Return the block minted for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>EpochBlockContent</returns>
        public EpochBlockContent EpochsNumberBlocksPoolIdGet (int? number, string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<EpochBlockContent> localVarResponse = EpochsNumberBlocksPoolIdGetWithHttpInfo(number, poolId, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Block distribution by pool Return the block minted for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of EpochBlockContent</returns>
        public ApiResponse< EpochBlockContent > EpochsNumberBlocksPoolIdGetWithHttpInfo (int? number, string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberBlocksPoolIdGet");
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoEpochsApi->EpochsNumberBlocksPoolIdGet");

            var localVarPath = "./epochs/{number}/blocks/{pool_id}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberBlocksPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochBlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochBlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochBlockContent)));
        }

        /// <summary>
        /// Block distribution by pool Return the block minted for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of EpochBlockContent</returns>
        public async System.Threading.Tasks.Task<EpochBlockContent> EpochsNumberBlocksPoolIdGetAsync (int? number, string poolId, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<EpochBlockContent> localVarResponse = await EpochsNumberBlocksPoolIdGetAsyncWithHttpInfo(number, poolId, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Block distribution by pool Return the block minted for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (EpochBlockContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochBlockContent>> EpochsNumberBlocksPoolIdGetAsyncWithHttpInfo (int? number, string poolId, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberBlocksPoolIdGet");
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoEpochsApi->EpochsNumberBlocksPoolIdGet");

            var localVarPath = "./epochs/{number}/blocks/{pool_id}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberBlocksPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochBlockContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochBlockContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochBlockContent)));
        }

        /// <summary>
        /// Specific epoch Return the content of the requested epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>EpochContent</returns>
        public EpochContent EpochsNumberGet (int? number)
        {
             ApiResponse<EpochContent> localVarResponse = EpochsNumberGetWithHttpInfo(number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific epoch Return the content of the requested epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>ApiResponse of EpochContent</returns>
        public ApiResponse< EpochContent > EpochsNumberGetWithHttpInfo (int? number)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberGet");

            var localVarPath = "./epochs/{number}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContent)));
        }

        /// <summary>
        /// Specific epoch Return the content of the requested epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of EpochContent</returns>
        public async System.Threading.Tasks.Task<EpochContent> EpochsNumberGetAsync (int? number)
        {
             ApiResponse<EpochContent> localVarResponse = await EpochsNumberGetAsyncWithHttpInfo(number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific epoch Return the content of the requested epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of ApiResponse (EpochContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochContent>> EpochsNumberGetAsyncWithHttpInfo (int? number)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberGet");

            var localVarPath = "./epochs/{number}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContent)));
        }

        /// <summary>
        /// Listing of next epochs Return the list of epochs following a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochContentArray</returns>
        public EpochContentArray EpochsNumberNextGet (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochContentArray> localVarResponse = EpochsNumberNextGetWithHttpInfo(number, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing of next epochs Return the list of epochs following a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochContentArray</returns>
        public ApiResponse< EpochContentArray > EpochsNumberNextGetWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberNextGet");

            var localVarPath = "./epochs/{number}/next";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberNextGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContentArray)));
        }

        /// <summary>
        /// Listing of next epochs Return the list of epochs following a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochContentArray</returns>
        public async System.Threading.Tasks.Task<EpochContentArray> EpochsNumberNextGetAsync (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochContentArray> localVarResponse = await EpochsNumberNextGetAsyncWithHttpInfo(number, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing of next epochs Return the list of epochs following a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the requested epoch.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochContentArray)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochContentArray>> EpochsNumberNextGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberNextGet");

            var localVarPath = "./epochs/{number}/next";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberNextGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContentArray)));
        }

        /// <summary>
        /// Protocol parameters Return the protocol parameters for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>EpochParamContent</returns>
        public EpochParamContent EpochsNumberParametersGet (int? number)
        {
             ApiResponse<EpochParamContent> localVarResponse = EpochsNumberParametersGetWithHttpInfo(number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Protocol parameters Return the protocol parameters for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>ApiResponse of EpochParamContent</returns>
        public ApiResponse< EpochParamContent > EpochsNumberParametersGetWithHttpInfo (int? number)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberParametersGet");

            var localVarPath = "./epochs/{number}/parameters";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberParametersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochParamContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochParamContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochParamContent)));
        }

        /// <summary>
        /// Protocol parameters Return the protocol parameters for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of EpochParamContent</returns>
        public async System.Threading.Tasks.Task<EpochParamContent> EpochsNumberParametersGetAsync (int? number)
        {
             ApiResponse<EpochParamContent> localVarResponse = await EpochsNumberParametersGetAsyncWithHttpInfo(number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Protocol parameters Return the protocol parameters for the epoch specified.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <returns>Task of ApiResponse (EpochParamContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochParamContent>> EpochsNumberParametersGetAsyncWithHttpInfo (int? number)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberParametersGet");

            var localVarPath = "./epochs/{number}/parameters";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberParametersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochParamContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochParamContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochParamContent)));
        }

        /// <summary>
        /// Listing of previous epochs Return the list of epochs preceding a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>EpochContentArray</returns>
        public EpochContentArray EpochsNumberPreviousGet (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochContentArray> localVarResponse = EpochsNumberPreviousGetWithHttpInfo(number, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing of previous epochs Return the list of epochs preceding a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochContentArray</returns>
        public ApiResponse< EpochContentArray > EpochsNumberPreviousGetWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberPreviousGet");

            var localVarPath = "./epochs/{number}/previous";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberPreviousGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContentArray)));
        }

        /// <summary>
        /// Listing of previous epochs Return the list of epochs preceding a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>Task of EpochContentArray</returns>
        public async System.Threading.Tasks.Task<EpochContentArray> EpochsNumberPreviousGetAsync (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochContentArray> localVarResponse = await EpochsNumberPreviousGetAsyncWithHttpInfo(number, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing of previous epochs Return the list of epochs preceding a specific epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochContentArray)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochContentArray>> EpochsNumberPreviousGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberPreviousGet");

            var localVarPath = "./epochs/{number}/previous";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberPreviousGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochContentArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochContentArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochContentArray)));
        }

        /// <summary>
        /// Stake distribution Return the active stake distribution for the specified epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochStakeContent</returns>
        public EpochStakeContent EpochsNumberStakesGet (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochStakeContent> localVarResponse = EpochsNumberStakesGetWithHttpInfo(number, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake distribution Return the active stake distribution for the specified epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochStakeContent</returns>
        public ApiResponse< EpochStakeContent > EpochsNumberStakesGetWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberStakesGet");

            var localVarPath = "./epochs/{number}/stakes";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberStakesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochStakeContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochStakeContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochStakeContent)));
        }

        /// <summary>
        /// Stake distribution Return the active stake distribution for the specified epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochStakeContent</returns>
        public async System.Threading.Tasks.Task<EpochStakeContent> EpochsNumberStakesGetAsync (int? number, int? count = null, int? page = null)
        {
             ApiResponse<EpochStakeContent> localVarResponse = await EpochsNumberStakesGetAsyncWithHttpInfo(number, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake distribution Return the active stake distribution for the specified epoch.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochStakeContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochStakeContent>> EpochsNumberStakesGetAsyncWithHttpInfo (int? number, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberStakesGet");

            var localVarPath = "./epochs/{number}/stakes";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberStakesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochStakeContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochStakeContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochStakeContent)));
        }

        /// <summary>
        /// Stake distribution by pool Return the active stake distribution for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>EpochStakePoolContent</returns>
        public EpochStakePoolContent EpochsNumberStakesPoolIdGet (int? number, string poolId, int? count = null, int? page = null)
        {
             ApiResponse<EpochStakePoolContent> localVarResponse = EpochsNumberStakesPoolIdGetWithHttpInfo(number, poolId, count, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stake distribution by pool Return the active stake distribution for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>ApiResponse of EpochStakePoolContent</returns>
        public ApiResponse< EpochStakePoolContent > EpochsNumberStakesPoolIdGetWithHttpInfo (int? number, string poolId, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberStakesPoolIdGet");
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoEpochsApi->EpochsNumberStakesPoolIdGet");

            var localVarPath = "./epochs/{number}/stakes/{pool_id}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberStakesPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochStakePoolContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochStakePoolContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochStakePoolContent)));
        }

        /// <summary>
        /// Stake distribution by pool Return the active stake distribution for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of EpochStakePoolContent</returns>
        public async System.Threading.Tasks.Task<EpochStakePoolContent> EpochsNumberStakesPoolIdGetAsync (int? number, string poolId, int? count = null, int? page = null)
        {
             ApiResponse<EpochStakePoolContent> localVarResponse = await EpochsNumberStakesPoolIdGetAsyncWithHttpInfo(number, poolId, count, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stake distribution by pool Return the active stake distribution for the epoch specified by stake pool.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="number">Number of the epoch</param>
        /// <param name="poolId">Stake pool ID to filter</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EpochStakePoolContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EpochStakePoolContent>> EpochsNumberStakesPoolIdGetAsyncWithHttpInfo (int? number, string poolId, int? count = null, int? page = null)
        {
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling CardanoEpochsApi->EpochsNumberStakesPoolIdGet");
            // verify the required parameter 'poolId' is set
            if (poolId == null)
                throw new ApiException(400, "Missing required parameter 'poolId' when calling CardanoEpochsApi->EpochsNumberStakesPoolIdGet");

            var localVarPath = "./epochs/{number}/stakes/{pool_id}";
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

            if (number != null) localVarPathParams.Add("number", this.Configuration.ApiClient.ParameterToString(number)); // path parameter
            if (poolId != null) localVarPathParams.Add("pool_id", this.Configuration.ApiClient.ParameterToString(poolId)); // path parameter
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
                Exception exception = ExceptionFactory("EpochsNumberStakesPoolIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EpochStakePoolContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (EpochStakePoolContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EpochStakePoolContent)));
        }

    }
}
