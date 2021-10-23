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
    public interface ICardanoAccountsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assets associated with the account addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountAddressesAssets</returns>
        AccountAddressesAssets AccountsStakeAddressAddressesAssetsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Assets associated with the account addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountAddressesAssets</returns>
        ApiResponse<AccountAddressesAssets> AccountsStakeAddressAddressesAssetsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account associated addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about the addresses of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountAddressesContent</returns>
        AccountAddressesContent AccountsStakeAddressAddressesGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account associated addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about the addresses of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountAddressesContent</returns>
        ApiResponse<AccountAddressesContent> AccountsStakeAddressAddressesGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account delegation history
        /// </summary>
        /// <remarks>
        /// Obtain information about the delegation of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountDelegationContent</returns>
        AccountDelegationContent AccountsStakeAddressDelegationsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account delegation history
        /// </summary>
        /// <remarks>
        /// Obtain information about the delegation of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountDelegationContent</returns>
        ApiResponse<AccountDelegationContent> AccountsStakeAddressDelegationsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific account address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific stake account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>AccountContent</returns>
        AccountContent AccountsStakeAddressGet(string stakeAddress);

        /// <summary>
        /// Specific account address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific stake account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>ApiResponse of AccountContent</returns>
        ApiResponse<AccountContent> AccountsStakeAddressGetWithHttpInfo(string stakeAddress);
        /// <summary>
        /// Account history
        /// </summary>
        /// <remarks>
        /// Obtain information about the history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountHistoryContent</returns>
        AccountHistoryContent AccountsStakeAddressHistoryGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account history
        /// </summary>
        /// <remarks>
        /// Obtain information about the history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountHistoryContent</returns>
        ApiResponse<AccountHistoryContent> AccountsStakeAddressHistoryGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account MIR history
        /// </summary>
        /// <remarks>
        /// Obtain information about the MIRs of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountMirContent</returns>
        AccountMirContent AccountsStakeAddressMirsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account MIR history
        /// </summary>
        /// <remarks>
        /// Obtain information about the MIRs of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountMirContent</returns>
        ApiResponse<AccountMirContent> AccountsStakeAddressMirsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account registration history
        /// </summary>
        /// <remarks>
        /// Obtain information about the registrations and deregistrations of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountRegistrationContent</returns>
        AccountRegistrationContent AccountsStakeAddressRegistrationsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account registration history
        /// </summary>
        /// <remarks>
        /// Obtain information about the registrations and deregistrations of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountRegistrationContent</returns>
        ApiResponse<AccountRegistrationContent> AccountsStakeAddressRegistrationsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account reward history
        /// </summary>
        /// <remarks>
        /// Obtain information about the reward history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountRewardContent</returns>
        AccountRewardContent AccountsStakeAddressRewardsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account reward history
        /// </summary>
        /// <remarks>
        /// Obtain information about the reward history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountRewardContent</returns>
        ApiResponse<AccountRewardContent> AccountsStakeAddressRewardsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account withdrawal history
        /// </summary>
        /// <remarks>
        /// Obtain information about the withdrawals of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountWithdrawalContent</returns>
        AccountWithdrawalContent AccountsStakeAddressWithdrawalsGet(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account withdrawal history
        /// </summary>
        /// <remarks>
        /// Obtain information about the withdrawals of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountWithdrawalContent</returns>
        ApiResponse<AccountWithdrawalContent> AccountsStakeAddressWithdrawalsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Assets associated with the account addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountAddressesAssets</returns>
        System.Threading.Tasks.Task<AccountAddressesAssets> AccountsStakeAddressAddressesAssetsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Assets associated with the account addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountAddressesAssets)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountAddressesAssets>> AccountsStakeAddressAddressesAssetsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account associated addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about the addresses of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountAddressesContent</returns>
        System.Threading.Tasks.Task<AccountAddressesContent> AccountsStakeAddressAddressesGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account associated addresses
        /// </summary>
        /// <remarks>
        /// Obtain information about the addresses of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountAddressesContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountAddressesContent>> AccountsStakeAddressAddressesGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account delegation history
        /// </summary>
        /// <remarks>
        /// Obtain information about the delegation of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountDelegationContent</returns>
        System.Threading.Tasks.Task<AccountDelegationContent> AccountsStakeAddressDelegationsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account delegation history
        /// </summary>
        /// <remarks>
        /// Obtain information about the delegation of a specific account.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountDelegationContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountDelegationContent>> AccountsStakeAddressDelegationsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Specific account address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific stake account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>Task of AccountContent</returns>
        System.Threading.Tasks.Task<AccountContent> AccountsStakeAddressGetAsync(string stakeAddress);

        /// <summary>
        /// Specific account address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific stake account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>Task of ApiResponse (AccountContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountContent>> AccountsStakeAddressGetAsyncWithHttpInfo(string stakeAddress);
        /// <summary>
        /// Account history
        /// </summary>
        /// <remarks>
        /// Obtain information about the history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountHistoryContent</returns>
        System.Threading.Tasks.Task<AccountHistoryContent> AccountsStakeAddressHistoryGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account history
        /// </summary>
        /// <remarks>
        /// Obtain information about the history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountHistoryContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountHistoryContent>> AccountsStakeAddressHistoryGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account MIR history
        /// </summary>
        /// <remarks>
        /// Obtain information about the MIRs of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountMirContent</returns>
        System.Threading.Tasks.Task<AccountMirContent> AccountsStakeAddressMirsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account MIR history
        /// </summary>
        /// <remarks>
        /// Obtain information about the MIRs of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountMirContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountMirContent>> AccountsStakeAddressMirsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account registration history
        /// </summary>
        /// <remarks>
        /// Obtain information about the registrations and deregistrations of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountRegistrationContent</returns>
        System.Threading.Tasks.Task<AccountRegistrationContent> AccountsStakeAddressRegistrationsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account registration history
        /// </summary>
        /// <remarks>
        /// Obtain information about the registrations and deregistrations of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountRegistrationContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountRegistrationContent>> AccountsStakeAddressRegistrationsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account reward history
        /// </summary>
        /// <remarks>
        /// Obtain information about the reward history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountRewardContent</returns>
        System.Threading.Tasks.Task<AccountRewardContent> AccountsStakeAddressRewardsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account reward history
        /// </summary>
        /// <remarks>
        /// Obtain information about the reward history of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountRewardContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountRewardContent>> AccountsStakeAddressRewardsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Account withdrawal history
        /// </summary>
        /// <remarks>
        /// Obtain information about the withdrawals of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountWithdrawalContent</returns>
        System.Threading.Tasks.Task<AccountWithdrawalContent> AccountsStakeAddressWithdrawalsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Account withdrawal history
        /// </summary>
        /// <remarks>
        /// Obtain information about the withdrawals of a specific account. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountWithdrawalContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountWithdrawalContent>> AccountsStakeAddressWithdrawalsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardanoAccountsApi : ICardanoAccountsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoAccountsApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAccountsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoAccountsApi()
        {
            Configuration = Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoAccountsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Assets associated with the account addresses Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountAddressesAssets</returns>
        public AccountAddressesAssets AccountsStakeAddressAddressesAssetsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountAddressesAssets> localVarResponse = AccountsStakeAddressAddressesAssetsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assets associated with the account addresses Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountAddressesAssets</returns>
        public ApiResponse<AccountAddressesAssets> AccountsStakeAddressAddressesAssetsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressAddressesAssetsGet");

            var localVarPath = "./accounts/{stake_address}/addresses/assets";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressAddressesAssetsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountAddressesAssets>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountAddressesAssets)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountAddressesAssets)));
        }

        /// <summary>
        /// Assets associated with the account addresses Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountAddressesAssets</returns>
        public async System.Threading.Tasks.Task<AccountAddressesAssets> AccountsStakeAddressAddressesAssetsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountAddressesAssets> localVarResponse = await AccountsStakeAddressAddressesAssetsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Assets associated with the account addresses Obtain information about assets associated with addresses of a specific account.  &lt;b&gt;Be careful&lt;/b&gt;, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountAddressesAssets)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountAddressesAssets>> AccountsStakeAddressAddressesAssetsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressAddressesAssetsGet");

            var localVarPath = "./accounts/{stake_address}/addresses/assets";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressAddressesAssetsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountAddressesAssets>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountAddressesAssets)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountAddressesAssets)));
        }

        /// <summary>
        /// Account associated addresses Obtain information about the addresses of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountAddressesContent</returns>
        public AccountAddressesContent AccountsStakeAddressAddressesGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountAddressesContent> localVarResponse = AccountsStakeAddressAddressesGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account associated addresses Obtain information about the addresses of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountAddressesContent</returns>
        public ApiResponse<AccountAddressesContent> AccountsStakeAddressAddressesGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressAddressesGet");

            var localVarPath = "./accounts/{stake_address}/addresses";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressAddressesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountAddressesContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountAddressesContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountAddressesContent)));
        }

        /// <summary>
        /// Account associated addresses Obtain information about the addresses of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountAddressesContent</returns>
        public async System.Threading.Tasks.Task<AccountAddressesContent> AccountsStakeAddressAddressesGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountAddressesContent> localVarResponse = await AccountsStakeAddressAddressesGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account associated addresses Obtain information about the addresses of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountAddressesContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountAddressesContent>> AccountsStakeAddressAddressesGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressAddressesGet");

            var localVarPath = "./accounts/{stake_address}/addresses";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressAddressesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountAddressesContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountAddressesContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountAddressesContent)));
        }

        /// <summary>
        /// Account delegation history Obtain information about the delegation of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountDelegationContent</returns>
        public AccountDelegationContent AccountsStakeAddressDelegationsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountDelegationContent> localVarResponse = AccountsStakeAddressDelegationsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account delegation history Obtain information about the delegation of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountDelegationContent</returns>
        public ApiResponse<AccountDelegationContent> AccountsStakeAddressDelegationsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressDelegationsGet");

            var localVarPath = "./accounts/{stake_address}/delegations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressDelegationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountDelegationContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountDelegationContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountDelegationContent)));
        }

        /// <summary>
        /// Account delegation history Obtain information about the delegation of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountDelegationContent</returns>
        public async System.Threading.Tasks.Task<AccountDelegationContent> AccountsStakeAddressDelegationsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountDelegationContent> localVarResponse = await AccountsStakeAddressDelegationsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account delegation history Obtain information about the delegation of a specific account.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountDelegationContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountDelegationContent>> AccountsStakeAddressDelegationsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressDelegationsGet");

            var localVarPath = "./accounts/{stake_address}/delegations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressDelegationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountDelegationContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountDelegationContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountDelegationContent)));
        }

        /// <summary>
        /// Specific account address Obtain information about a specific stake account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>AccountContent</returns>
        public AccountContent AccountsStakeAddressGet(string stakeAddress)
        {
            ApiResponse<AccountContent> localVarResponse = AccountsStakeAddressGetWithHttpInfo(stakeAddress);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Specific account address Obtain information about a specific stake account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>ApiResponse of AccountContent</returns>
        public ApiResponse<AccountContent> AccountsStakeAddressGetWithHttpInfo(string stakeAddress)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressGet");

            var localVarPath = "./accounts/{stake_address}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountContent)));
        }

        /// <summary>
        /// Specific account address Obtain information about a specific stake account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>Task of AccountContent</returns>
        public async System.Threading.Tasks.Task<AccountContent> AccountsStakeAddressGetAsync(string stakeAddress)
        {
            ApiResponse<AccountContent> localVarResponse = await AccountsStakeAddressGetAsyncWithHttpInfo(stakeAddress);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Specific account address Obtain information about a specific stake account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <returns>Task of ApiResponse (AccountContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountContent>> AccountsStakeAddressGetAsyncWithHttpInfo(string stakeAddress)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressGet");

            var localVarPath = "./accounts/{stake_address}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountContent)));
        }

        /// <summary>
        /// Account history Obtain information about the history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountHistoryContent</returns>
        public AccountHistoryContent AccountsStakeAddressHistoryGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountHistoryContent> localVarResponse = AccountsStakeAddressHistoryGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account history Obtain information about the history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountHistoryContent</returns>
        public ApiResponse<AccountHistoryContent> AccountsStakeAddressHistoryGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressHistoryGet");

            var localVarPath = "./accounts/{stake_address}/history";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountHistoryContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountHistoryContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountHistoryContent)));
        }

        /// <summary>
        /// Account history Obtain information about the history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountHistoryContent</returns>
        public async System.Threading.Tasks.Task<AccountHistoryContent> AccountsStakeAddressHistoryGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountHistoryContent> localVarResponse = await AccountsStakeAddressHistoryGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account history Obtain information about the history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountHistoryContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountHistoryContent>> AccountsStakeAddressHistoryGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressHistoryGet");

            var localVarPath = "./accounts/{stake_address}/history";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountHistoryContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountHistoryContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountHistoryContent)));
        }

        /// <summary>
        /// Account MIR history Obtain information about the MIRs of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountMirContent</returns>
        public AccountMirContent AccountsStakeAddressMirsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountMirContent> localVarResponse = AccountsStakeAddressMirsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account MIR history Obtain information about the MIRs of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountMirContent</returns>
        public ApiResponse<AccountMirContent> AccountsStakeAddressMirsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressMirsGet");

            var localVarPath = "./accounts/{stake_address}/mirs";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressMirsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountMirContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountMirContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountMirContent)));
        }

        /// <summary>
        /// Account MIR history Obtain information about the MIRs of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountMirContent</returns>
        public async System.Threading.Tasks.Task<AccountMirContent> AccountsStakeAddressMirsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountMirContent> localVarResponse = await AccountsStakeAddressMirsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account MIR history Obtain information about the MIRs of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountMirContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountMirContent>> AccountsStakeAddressMirsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressMirsGet");

            var localVarPath = "./accounts/{stake_address}/mirs";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressMirsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountMirContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountMirContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountMirContent)));
        }

        /// <summary>
        /// Account registration history Obtain information about the registrations and deregistrations of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountRegistrationContent</returns>
        public AccountRegistrationContent AccountsStakeAddressRegistrationsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountRegistrationContent> localVarResponse = AccountsStakeAddressRegistrationsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account registration history Obtain information about the registrations and deregistrations of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountRegistrationContent</returns>
        public ApiResponse<AccountRegistrationContent> AccountsStakeAddressRegistrationsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressRegistrationsGet");

            var localVarPath = "./accounts/{stake_address}/registrations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressRegistrationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountRegistrationContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountRegistrationContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountRegistrationContent)));
        }

        /// <summary>
        /// Account registration history Obtain information about the registrations and deregistrations of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountRegistrationContent</returns>
        public async System.Threading.Tasks.Task<AccountRegistrationContent> AccountsStakeAddressRegistrationsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountRegistrationContent> localVarResponse = await AccountsStakeAddressRegistrationsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account registration history Obtain information about the registrations and deregistrations of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountRegistrationContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountRegistrationContent>> AccountsStakeAddressRegistrationsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressRegistrationsGet");

            var localVarPath = "./accounts/{stake_address}/registrations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressRegistrationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountRegistrationContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountRegistrationContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountRegistrationContent)));
        }

        /// <summary>
        /// Account reward history Obtain information about the reward history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountRewardContent</returns>
        public AccountRewardContent AccountsStakeAddressRewardsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountRewardContent> localVarResponse = AccountsStakeAddressRewardsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account reward history Obtain information about the reward history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountRewardContent</returns>
        public ApiResponse<AccountRewardContent> AccountsStakeAddressRewardsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressRewardsGet");

            var localVarPath = "./accounts/{stake_address}/rewards";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressRewardsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountRewardContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountRewardContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountRewardContent)));
        }

        /// <summary>
        /// Account reward history Obtain information about the reward history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountRewardContent</returns>
        public async System.Threading.Tasks.Task<AccountRewardContent> AccountsStakeAddressRewardsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountRewardContent> localVarResponse = await AccountsStakeAddressRewardsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account reward history Obtain information about the reward history of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountRewardContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountRewardContent>> AccountsStakeAddressRewardsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressRewardsGet");

            var localVarPath = "./accounts/{stake_address}/rewards";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressRewardsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountRewardContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountRewardContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountRewardContent)));
        }

        /// <summary>
        /// Account withdrawal history Obtain information about the withdrawals of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AccountWithdrawalContent</returns>
        public AccountWithdrawalContent AccountsStakeAddressWithdrawalsGet(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountWithdrawalContent> localVarResponse = AccountsStakeAddressWithdrawalsGetWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Account withdrawal history Obtain information about the withdrawals of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AccountWithdrawalContent</returns>
        public ApiResponse<AccountWithdrawalContent> AccountsStakeAddressWithdrawalsGetWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressWithdrawalsGet");

            var localVarPath = "./accounts/{stake_address}/withdrawals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressWithdrawalsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountWithdrawalContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountWithdrawalContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountWithdrawalContent)));
        }

        /// <summary>
        /// Account withdrawal history Obtain information about the withdrawals of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AccountWithdrawalContent</returns>
        public async System.Threading.Tasks.Task<AccountWithdrawalContent> AccountsStakeAddressWithdrawalsGetAsync(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            ApiResponse<AccountWithdrawalContent> localVarResponse = await AccountsStakeAddressWithdrawalsGetAsyncWithHttpInfo(stakeAddress, count, page, order);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Account withdrawal history Obtain information about the withdrawals of a specific account. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stakeAddress">Bech32 stake address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AccountWithdrawalContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountWithdrawalContent>> AccountsStakeAddressWithdrawalsGetAsyncWithHttpInfo(string stakeAddress, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'stakeAddress' is set
            if (stakeAddress == null)
                throw new ApiException(400, "Missing required parameter 'stakeAddress' when calling CardanoAccountsApi->AccountsStakeAddressWithdrawalsGet");

            var localVarPath = "./accounts/{stake_address}/withdrawals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stakeAddress != null) localVarPathParams.Add("stake_address", Configuration.ApiClient.ParameterToString(stakeAddress)); // path parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountsStakeAddressWithdrawalsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountWithdrawalContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AccountWithdrawalContent)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountWithdrawalContent)));
        }

    }
}
