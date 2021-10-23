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
        public interface ICardanoTransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Submit a transaction
        /// </summary>
        /// <remarks>
        /// Submit an already serialized transaction to the network.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>string</returns>
        string TxSubmitPost (string contentType);

        /// <summary>
        /// Submit a transaction
        /// </summary>
        /// <remarks>
        /// Submit an already serialized transaction to the network.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TxSubmitPostWithHttpInfo (string contentType);
        /// <summary>
        /// Transaction delegation certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about delegation certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentDelegations</returns>
        TxContentDelegations TxsHashDelegationsGet (string hash);

        /// <summary>
        /// Transaction delegation certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about delegation certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentDelegations</returns>
        ApiResponse<TxContentDelegations> TxsHashDelegationsGetWithHttpInfo (string hash);
        /// <summary>
        /// Specific transaction
        /// </summary>
        /// <remarks>
        /// Return content of the requested transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContent</returns>
        TxContent TxsHashGet (string hash);

        /// <summary>
        /// Specific transaction
        /// </summary>
        /// <remarks>
        /// Return content of the requested transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContent</returns>
        ApiResponse<TxContent> TxsHashGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction metadata in CBOR
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata in CBOR.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentMetadataCbor</returns>
        TxContentMetadataCbor TxsHashMetadataCborGet (string hash);

        /// <summary>
        /// Transaction metadata in CBOR
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata in CBOR.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentMetadataCbor</returns>
        ApiResponse<TxContentMetadataCbor> TxsHashMetadataCborGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction metadata
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentMetadata</returns>
        TxContentMetadata TxsHashMetadataGet (string hash);

        /// <summary>
        /// Transaction metadata
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentMetadata</returns>
        ApiResponse<TxContentMetadata> TxsHashMetadataGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction MIRs
        /// </summary>
        /// <remarks>
        /// Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentMirs</returns>
        TxContentMirs TxsHashMirsGet (string hash);

        /// <summary>
        /// Transaction MIRs
        /// </summary>
        /// <remarks>
        /// Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentMirs</returns>
        ApiResponse<TxContentMirs> TxsHashMirsGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake pool retirement certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool retirements within a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentPoolRetires</returns>
        TxContentPoolRetires TxsHashPoolRetiresGet (string hash);

        /// <summary>
        /// Transaction stake pool retirement certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool retirements within a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentPoolRetires</returns>
        ApiResponse<TxContentPoolRetires> TxsHashPoolRetiresGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake pool registration and update certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentPoolCerts</returns>
        TxContentPoolCerts TxsHashPoolUpdatesGet (string hash);

        /// <summary>
        /// Transaction stake pool registration and update certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentPoolCerts</returns>
        ApiResponse<TxContentPoolCerts> TxsHashPoolUpdatesGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction redeemers
        /// </summary>
        /// <remarks>
        /// Obtain the transaction redeemers.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentRedeemers</returns>
        TxContentRedeemers TxsHashRedeemersGet (string hash);

        /// <summary>
        /// Transaction redeemers
        /// </summary>
        /// <remarks>
        /// Obtain the transaction redeemers.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentRedeemers</returns>
        ApiResponse<TxContentRedeemers> TxsHashRedeemersGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake addresses certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about (de)registration of stake addresses within a transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentStakeAddr</returns>
        TxContentStakeAddr TxsHashStakesGet (string hash);

        /// <summary>
        /// Transaction stake addresses certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about (de)registration of stake addresses within a transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentStakeAddr</returns>
        ApiResponse<TxContentStakeAddr> TxsHashStakesGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction UTXOs
        /// </summary>
        /// <remarks>
        /// Return the inputs and UTXOs of the specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentUtxo</returns>
        TxContentUtxo TxsHashUtxosGet (string hash);

        /// <summary>
        /// Transaction UTXOs
        /// </summary>
        /// <remarks>
        /// Return the inputs and UTXOs of the specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentUtxo</returns>
        ApiResponse<TxContentUtxo> TxsHashUtxosGetWithHttpInfo (string hash);
        /// <summary>
        /// Transaction withdrawal
        /// </summary>
        /// <remarks>
        /// Obtain information about withdrawals of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentWithdrawals</returns>
        TxContentWithdrawals TxsHashWithdrawalsGet (string hash);

        /// <summary>
        /// Transaction withdrawal
        /// </summary>
        /// <remarks>
        /// Obtain information about withdrawals of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentWithdrawals</returns>
        ApiResponse<TxContentWithdrawals> TxsHashWithdrawalsGetWithHttpInfo (string hash);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Submit a transaction
        /// </summary>
        /// <remarks>
        /// Submit an already serialized transaction to the network.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TxSubmitPostAsync (string contentType);

        /// <summary>
        /// Submit a transaction
        /// </summary>
        /// <remarks>
        /// Submit an already serialized transaction to the network.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TxSubmitPostAsyncWithHttpInfo (string contentType);
        /// <summary>
        /// Transaction delegation certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about delegation certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentDelegations</returns>
        System.Threading.Tasks.Task<TxContentDelegations> TxsHashDelegationsGetAsync (string hash);

        /// <summary>
        /// Transaction delegation certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about delegation certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentDelegations)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentDelegations>> TxsHashDelegationsGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Specific transaction
        /// </summary>
        /// <remarks>
        /// Return content of the requested transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContent</returns>
        System.Threading.Tasks.Task<TxContent> TxsHashGetAsync (string hash);

        /// <summary>
        /// Specific transaction
        /// </summary>
        /// <remarks>
        /// Return content of the requested transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContent>> TxsHashGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction metadata in CBOR
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata in CBOR.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentMetadataCbor</returns>
        System.Threading.Tasks.Task<TxContentMetadataCbor> TxsHashMetadataCborGetAsync (string hash);

        /// <summary>
        /// Transaction metadata in CBOR
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata in CBOR.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentMetadataCbor)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentMetadataCbor>> TxsHashMetadataCborGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction metadata
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentMetadata</returns>
        System.Threading.Tasks.Task<TxContentMetadata> TxsHashMetadataGetAsync (string hash);

        /// <summary>
        /// Transaction metadata
        /// </summary>
        /// <remarks>
        /// Obtain the transaction metadata.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentMetadata>> TxsHashMetadataGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction MIRs
        /// </summary>
        /// <remarks>
        /// Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentMirs</returns>
        System.Threading.Tasks.Task<TxContentMirs> TxsHashMirsGetAsync (string hash);

        /// <summary>
        /// Transaction MIRs
        /// </summary>
        /// <remarks>
        /// Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentMirs)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentMirs>> TxsHashMirsGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake pool retirement certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool retirements within a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentPoolRetires</returns>
        System.Threading.Tasks.Task<TxContentPoolRetires> TxsHashPoolRetiresGetAsync (string hash);

        /// <summary>
        /// Transaction stake pool retirement certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool retirements within a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentPoolRetires)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentPoolRetires>> TxsHashPoolRetiresGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake pool registration and update certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentPoolCerts</returns>
        System.Threading.Tasks.Task<TxContentPoolCerts> TxsHashPoolUpdatesGetAsync (string hash);

        /// <summary>
        /// Transaction stake pool registration and update certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentPoolCerts)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentPoolCerts>> TxsHashPoolUpdatesGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction redeemers
        /// </summary>
        /// <remarks>
        /// Obtain the transaction redeemers.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentRedeemers</returns>
        System.Threading.Tasks.Task<TxContentRedeemers> TxsHashRedeemersGetAsync (string hash);

        /// <summary>
        /// Transaction redeemers
        /// </summary>
        /// <remarks>
        /// Obtain the transaction redeemers.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentRedeemers)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentRedeemers>> TxsHashRedeemersGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction stake addresses certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about (de)registration of stake addresses within a transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentStakeAddr</returns>
        System.Threading.Tasks.Task<TxContentStakeAddr> TxsHashStakesGetAsync (string hash);

        /// <summary>
        /// Transaction stake addresses certificates
        /// </summary>
        /// <remarks>
        /// Obtain information about (de)registration of stake addresses within a transaction. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentStakeAddr)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentStakeAddr>> TxsHashStakesGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction UTXOs
        /// </summary>
        /// <remarks>
        /// Return the inputs and UTXOs of the specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentUtxo</returns>
        System.Threading.Tasks.Task<TxContentUtxo> TxsHashUtxosGetAsync (string hash);

        /// <summary>
        /// Transaction UTXOs
        /// </summary>
        /// <remarks>
        /// Return the inputs and UTXOs of the specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentUtxo)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentUtxo>> TxsHashUtxosGetAsyncWithHttpInfo (string hash);
        /// <summary>
        /// Transaction withdrawal
        /// </summary>
        /// <remarks>
        /// Obtain information about withdrawals of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentWithdrawals</returns>
        System.Threading.Tasks.Task<TxContentWithdrawals> TxsHashWithdrawalsGetAsync (string hash);

        /// <summary>
        /// Transaction withdrawal
        /// </summary>
        /// <remarks>
        /// Obtain information about withdrawals of a specific transaction.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentWithdrawals)</returns>
        System.Threading.Tasks.Task<ApiResponse<TxContentWithdrawals>> TxsHashWithdrawalsGetAsyncWithHttpInfo (string hash);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoTransactionsApi : ICardanoTransactionsApi
    {
        private blockfrost.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoTransactionsApi(String basePath)
        {
            this.Configuration = new blockfrost.Client.Configuration { BasePath = basePath };

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoTransactionsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoTransactionsApi()
        {
            this.Configuration = blockfrost.Client.Configuration.Default;

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoTransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoTransactionsApi(blockfrost.Client.Configuration configuration = null)
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
        /// Submit a transaction Submit an already serialized transaction to the network.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>string</returns>
        public string TxSubmitPost (string contentType)
        {
             ApiResponse<string> localVarResponse = TxSubmitPostWithHttpInfo(contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a transaction Submit an already serialized transaction to the network.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TxSubmitPostWithHttpInfo (string contentType)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CardanoTransactionsApi->TxSubmitPost");

            var localVarPath = "./tx/submit";
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

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TxSubmitPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Submit a transaction Submit an already serialized transaction to the network.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TxSubmitPostAsync (string contentType)
        {
             ApiResponse<string> localVarResponse = await TxSubmitPostAsyncWithHttpInfo(contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submit a transaction Submit an already serialized transaction to the network.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TxSubmitPostAsyncWithHttpInfo (string contentType)
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CardanoTransactionsApi->TxSubmitPost");

            var localVarPath = "./tx/submit";
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

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("project_id")))
            {
                localVarHeaderParams["project_id"] = this.Configuration.GetApiKeyWithPrefix("project_id");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TxSubmitPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Transaction delegation certificates Obtain information about delegation certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentDelegations</returns>
        public TxContentDelegations TxsHashDelegationsGet (string hash)
        {
             ApiResponse<TxContentDelegations> localVarResponse = TxsHashDelegationsGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction delegation certificates Obtain information about delegation certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentDelegations</returns>
        public ApiResponse< TxContentDelegations > TxsHashDelegationsGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashDelegationsGet");

            var localVarPath = "./txs/{hash}/delegations";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashDelegationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentDelegations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentDelegations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentDelegations)));
        }

        /// <summary>
        /// Transaction delegation certificates Obtain information about delegation certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentDelegations</returns>
        public async System.Threading.Tasks.Task<TxContentDelegations> TxsHashDelegationsGetAsync (string hash)
        {
             ApiResponse<TxContentDelegations> localVarResponse = await TxsHashDelegationsGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction delegation certificates Obtain information about delegation certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentDelegations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentDelegations>> TxsHashDelegationsGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashDelegationsGet");

            var localVarPath = "./txs/{hash}/delegations";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashDelegationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentDelegations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentDelegations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentDelegations)));
        }

        /// <summary>
        /// Specific transaction Return content of the requested transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContent</returns>
        public TxContent TxsHashGet (string hash)
        {
             ApiResponse<TxContent> localVarResponse = TxsHashGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific transaction Return content of the requested transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContent</returns>
        public ApiResponse< TxContent > TxsHashGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashGet");

            var localVarPath = "./txs/{hash}";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContent)));
        }

        /// <summary>
        /// Specific transaction Return content of the requested transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContent</returns>
        public async System.Threading.Tasks.Task<TxContent> TxsHashGetAsync (string hash)
        {
             ApiResponse<TxContent> localVarResponse = await TxsHashGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific transaction Return content of the requested transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContent>> TxsHashGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashGet");

            var localVarPath = "./txs/{hash}";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContent)));
        }

        /// <summary>
        /// Transaction metadata in CBOR Obtain the transaction metadata in CBOR.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentMetadataCbor</returns>
        public TxContentMetadataCbor TxsHashMetadataCborGet (string hash)
        {
             ApiResponse<TxContentMetadataCbor> localVarResponse = TxsHashMetadataCborGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction metadata in CBOR Obtain the transaction metadata in CBOR.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentMetadataCbor</returns>
        public ApiResponse< TxContentMetadataCbor > TxsHashMetadataCborGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMetadataCborGet");

            var localVarPath = "./txs/{hash}/metadata/cbor";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMetadataCborGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMetadataCbor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMetadataCbor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMetadataCbor)));
        }

        /// <summary>
        /// Transaction metadata in CBOR Obtain the transaction metadata in CBOR.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentMetadataCbor</returns>
        public async System.Threading.Tasks.Task<TxContentMetadataCbor> TxsHashMetadataCborGetAsync (string hash)
        {
             ApiResponse<TxContentMetadataCbor> localVarResponse = await TxsHashMetadataCborGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction metadata in CBOR Obtain the transaction metadata in CBOR.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentMetadataCbor)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentMetadataCbor>> TxsHashMetadataCborGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMetadataCborGet");

            var localVarPath = "./txs/{hash}/metadata/cbor";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMetadataCborGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMetadataCbor>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMetadataCbor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMetadataCbor)));
        }

        /// <summary>
        /// Transaction metadata Obtain the transaction metadata.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentMetadata</returns>
        public TxContentMetadata TxsHashMetadataGet (string hash)
        {
             ApiResponse<TxContentMetadata> localVarResponse = TxsHashMetadataGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction metadata Obtain the transaction metadata.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentMetadata</returns>
        public ApiResponse< TxContentMetadata > TxsHashMetadataGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMetadataGet");

            var localVarPath = "./txs/{hash}/metadata";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMetadataGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMetadata>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMetadata) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMetadata)));
        }

        /// <summary>
        /// Transaction metadata Obtain the transaction metadata.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentMetadata</returns>
        public async System.Threading.Tasks.Task<TxContentMetadata> TxsHashMetadataGetAsync (string hash)
        {
             ApiResponse<TxContentMetadata> localVarResponse = await TxsHashMetadataGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction metadata Obtain the transaction metadata.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentMetadata)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentMetadata>> TxsHashMetadataGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMetadataGet");

            var localVarPath = "./txs/{hash}/metadata";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMetadataGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMetadata>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMetadata) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMetadata)));
        }

        /// <summary>
        /// Transaction MIRs Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentMirs</returns>
        public TxContentMirs TxsHashMirsGet (string hash)
        {
             ApiResponse<TxContentMirs> localVarResponse = TxsHashMirsGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction MIRs Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentMirs</returns>
        public ApiResponse< TxContentMirs > TxsHashMirsGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMirsGet");

            var localVarPath = "./txs/{hash}/mirs";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMirsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMirs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMirs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMirs)));
        }

        /// <summary>
        /// Transaction MIRs Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentMirs</returns>
        public async System.Threading.Tasks.Task<TxContentMirs> TxsHashMirsGetAsync (string hash)
        {
             ApiResponse<TxContentMirs> localVarResponse = await TxsHashMirsGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction MIRs Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentMirs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentMirs>> TxsHashMirsGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashMirsGet");

            var localVarPath = "./txs/{hash}/mirs";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashMirsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentMirs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentMirs) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentMirs)));
        }

        /// <summary>
        /// Transaction stake pool retirement certificates Obtain information about stake pool retirements within a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentPoolRetires</returns>
        public TxContentPoolRetires TxsHashPoolRetiresGet (string hash)
        {
             ApiResponse<TxContentPoolRetires> localVarResponse = TxsHashPoolRetiresGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction stake pool retirement certificates Obtain information about stake pool retirements within a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentPoolRetires</returns>
        public ApiResponse< TxContentPoolRetires > TxsHashPoolRetiresGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashPoolRetiresGet");

            var localVarPath = "./txs/{hash}/pool_retires";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashPoolRetiresGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentPoolRetires>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentPoolRetires) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentPoolRetires)));
        }

        /// <summary>
        /// Transaction stake pool retirement certificates Obtain information about stake pool retirements within a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentPoolRetires</returns>
        public async System.Threading.Tasks.Task<TxContentPoolRetires> TxsHashPoolRetiresGetAsync (string hash)
        {
             ApiResponse<TxContentPoolRetires> localVarResponse = await TxsHashPoolRetiresGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction stake pool retirement certificates Obtain information about stake pool retirements within a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentPoolRetires)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentPoolRetires>> TxsHashPoolRetiresGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashPoolRetiresGet");

            var localVarPath = "./txs/{hash}/pool_retires";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashPoolRetiresGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentPoolRetires>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentPoolRetires) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentPoolRetires)));
        }

        /// <summary>
        /// Transaction stake pool registration and update certificates Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentPoolCerts</returns>
        public TxContentPoolCerts TxsHashPoolUpdatesGet (string hash)
        {
             ApiResponse<TxContentPoolCerts> localVarResponse = TxsHashPoolUpdatesGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction stake pool registration and update certificates Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentPoolCerts</returns>
        public ApiResponse< TxContentPoolCerts > TxsHashPoolUpdatesGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashPoolUpdatesGet");

            var localVarPath = "./txs/{hash}/pool_updates";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashPoolUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentPoolCerts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentPoolCerts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentPoolCerts)));
        }

        /// <summary>
        /// Transaction stake pool registration and update certificates Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentPoolCerts</returns>
        public async System.Threading.Tasks.Task<TxContentPoolCerts> TxsHashPoolUpdatesGetAsync (string hash)
        {
             ApiResponse<TxContentPoolCerts> localVarResponse = await TxsHashPoolUpdatesGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction stake pool registration and update certificates Obtain information about stake pool registration and update certificates of a specific transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentPoolCerts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentPoolCerts>> TxsHashPoolUpdatesGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashPoolUpdatesGet");

            var localVarPath = "./txs/{hash}/pool_updates";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashPoolUpdatesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentPoolCerts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentPoolCerts) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentPoolCerts)));
        }

        /// <summary>
        /// Transaction redeemers Obtain the transaction redeemers.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentRedeemers</returns>
        public TxContentRedeemers TxsHashRedeemersGet (string hash)
        {
             ApiResponse<TxContentRedeemers> localVarResponse = TxsHashRedeemersGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction redeemers Obtain the transaction redeemers.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentRedeemers</returns>
        public ApiResponse< TxContentRedeemers > TxsHashRedeemersGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashRedeemersGet");

            var localVarPath = "./txs/{hash}/redeemers";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashRedeemersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentRedeemers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentRedeemers) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentRedeemers)));
        }

        /// <summary>
        /// Transaction redeemers Obtain the transaction redeemers.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentRedeemers</returns>
        public async System.Threading.Tasks.Task<TxContentRedeemers> TxsHashRedeemersGetAsync (string hash)
        {
             ApiResponse<TxContentRedeemers> localVarResponse = await TxsHashRedeemersGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction redeemers Obtain the transaction redeemers.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentRedeemers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentRedeemers>> TxsHashRedeemersGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashRedeemersGet");

            var localVarPath = "./txs/{hash}/redeemers";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashRedeemersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentRedeemers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentRedeemers) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentRedeemers)));
        }

        /// <summary>
        /// Transaction stake addresses certificates Obtain information about (de)registration of stake addresses within a transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentStakeAddr</returns>
        public TxContentStakeAddr TxsHashStakesGet (string hash)
        {
             ApiResponse<TxContentStakeAddr> localVarResponse = TxsHashStakesGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction stake addresses certificates Obtain information about (de)registration of stake addresses within a transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentStakeAddr</returns>
        public ApiResponse< TxContentStakeAddr > TxsHashStakesGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashStakesGet");

            var localVarPath = "./txs/{hash}/stakes";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashStakesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentStakeAddr>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentStakeAddr) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentStakeAddr)));
        }

        /// <summary>
        /// Transaction stake addresses certificates Obtain information about (de)registration of stake addresses within a transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentStakeAddr</returns>
        public async System.Threading.Tasks.Task<TxContentStakeAddr> TxsHashStakesGetAsync (string hash)
        {
             ApiResponse<TxContentStakeAddr> localVarResponse = await TxsHashStakesGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction stake addresses certificates Obtain information about (de)registration of stake addresses within a transaction. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentStakeAddr)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentStakeAddr>> TxsHashStakesGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashStakesGet");

            var localVarPath = "./txs/{hash}/stakes";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashStakesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentStakeAddr>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentStakeAddr) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentStakeAddr)));
        }

        /// <summary>
        /// Transaction UTXOs Return the inputs and UTXOs of the specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>TxContentUtxo</returns>
        public TxContentUtxo TxsHashUtxosGet (string hash)
        {
             ApiResponse<TxContentUtxo> localVarResponse = TxsHashUtxosGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction UTXOs Return the inputs and UTXOs of the specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>ApiResponse of TxContentUtxo</returns>
        public ApiResponse< TxContentUtxo > TxsHashUtxosGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashUtxosGet");

            var localVarPath = "./txs/{hash}/utxos";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashUtxosGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentUtxo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentUtxo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentUtxo)));
        }

        /// <summary>
        /// Transaction UTXOs Return the inputs and UTXOs of the specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of TxContentUtxo</returns>
        public async System.Threading.Tasks.Task<TxContentUtxo> TxsHashUtxosGetAsync (string hash)
        {
             ApiResponse<TxContentUtxo> localVarResponse = await TxsHashUtxosGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction UTXOs Return the inputs and UTXOs of the specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Task of ApiResponse (TxContentUtxo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentUtxo>> TxsHashUtxosGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashUtxosGet");

            var localVarPath = "./txs/{hash}/utxos";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashUtxosGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentUtxo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentUtxo) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentUtxo)));
        }

        /// <summary>
        /// Transaction withdrawal Obtain information about withdrawals of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>TxContentWithdrawals</returns>
        public TxContentWithdrawals TxsHashWithdrawalsGet (string hash)
        {
             ApiResponse<TxContentWithdrawals> localVarResponse = TxsHashWithdrawalsGetWithHttpInfo(hash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction withdrawal Obtain information about withdrawals of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>ApiResponse of TxContentWithdrawals</returns>
        public ApiResponse< TxContentWithdrawals > TxsHashWithdrawalsGetWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashWithdrawalsGet");

            var localVarPath = "./txs/{hash}/withdrawals";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashWithdrawalsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentWithdrawals>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentWithdrawals) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentWithdrawals)));
        }

        /// <summary>
        /// Transaction withdrawal Obtain information about withdrawals of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of TxContentWithdrawals</returns>
        public async System.Threading.Tasks.Task<TxContentWithdrawals> TxsHashWithdrawalsGetAsync (string hash)
        {
             ApiResponse<TxContentWithdrawals> localVarResponse = await TxsHashWithdrawalsGetAsyncWithHttpInfo(hash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction withdrawal Obtain information about withdrawals of a specific transaction.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Task of ApiResponse (TxContentWithdrawals)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TxContentWithdrawals>> TxsHashWithdrawalsGetAsyncWithHttpInfo (string hash)
        {
            // verify the required parameter 'hash' is set
            if (hash == null)
                throw new ApiException(400, "Missing required parameter 'hash' when calling CardanoTransactionsApi->TxsHashWithdrawalsGet");

            var localVarPath = "./txs/{hash}/withdrawals";
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

            if (hash != null) localVarPathParams.Add("hash", this.Configuration.ApiClient.ParameterToString(hash)); // path parameter
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
                Exception exception = ExceptionFactory("TxsHashWithdrawalsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TxContentWithdrawals>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TxContentWithdrawals) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TxContentWithdrawals)));
        }

    }
}
