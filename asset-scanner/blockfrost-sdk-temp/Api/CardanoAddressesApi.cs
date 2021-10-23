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
        public interface ICardanoAddressesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Specific address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>AddressContent</returns>
        AddressContent AddressesAddressGet (string address);

        /// <summary>
        /// Specific address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>ApiResponse of AddressContent</returns>
        ApiResponse<AddressContent> AddressesAddressGetWithHttpInfo (string address);
        /// <summary>
        /// Address details
        /// </summary>
        /// <remarks>
        /// Obtain details about an address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>AddressContentTotal</returns>
        AddressContentTotal AddressesAddressTotalGet (string address);

        /// <summary>
        /// Address details
        /// </summary>
        /// <remarks>
        /// Obtain details about an address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>ApiResponse of AddressContentTotal</returns>
        ApiResponse<AddressContentTotal> AddressesAddressTotalGetWithHttpInfo (string address);
        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>AddressTransactionsContent</returns>
        AddressTransactionsContent AddressesAddressTransactionsGet (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null);

        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>ApiResponse of AddressTransactionsContent</returns>
        ApiResponse<AddressTransactionsContent> AddressesAddressTransactionsGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null);
        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressTxsContent</returns>
        AddressTxsContent AddressesAddressTxsGet (string address, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressTxsContent</returns>
        ApiResponse<AddressTxsContent> AddressesAddressTxsGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Address UTXOs of a given asset
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressUtxoContent</returns>
        AddressUtxoContent AddressesAddressUtxosAssetGet (string address, string asset, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address UTXOs of a given asset
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressUtxoContent</returns>
        ApiResponse<AddressUtxoContent> AddressesAddressUtxosAssetGetWithHttpInfo (string address, string asset, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Address UTXOs
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressUtxoContent</returns>
        AddressUtxoContent AddressesAddressUtxosGet (string address, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address UTXOs
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressUtxoContent</returns>
        ApiResponse<AddressUtxoContent> AddressesAddressUtxosGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Specific address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of AddressContent</returns>
        System.Threading.Tasks.Task<AddressContent> AddressesAddressGetAsync (string address);

        /// <summary>
        /// Specific address
        /// </summary>
        /// <remarks>
        /// Obtain information about a specific address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of ApiResponse (AddressContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressContent>> AddressesAddressGetAsyncWithHttpInfo (string address);
        /// <summary>
        /// Address details
        /// </summary>
        /// <remarks>
        /// Obtain details about an address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of AddressContentTotal</returns>
        System.Threading.Tasks.Task<AddressContentTotal> AddressesAddressTotalGetAsync (string address);

        /// <summary>
        /// Address details
        /// </summary>
        /// <remarks>
        /// Obtain details about an address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of ApiResponse (AddressContentTotal)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressContentTotal>> AddressesAddressTotalGetAsyncWithHttpInfo (string address);
        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>Task of AddressTransactionsContent</returns>
        System.Threading.Tasks.Task<AddressTransactionsContent> AddressesAddressTransactionsGetAsync (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null);

        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>Task of ApiResponse (AddressTransactionsContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressTransactionsContent>> AddressesAddressTransactionsGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null);
        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressTxsContent</returns>
        System.Threading.Tasks.Task<AddressTxsContent> AddressesAddressTxsGetAsync (string address, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address transactions
        /// </summary>
        /// <remarks>
        /// Transactions on the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressTxsContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressTxsContent>> AddressesAddressTxsGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Address UTXOs of a given asset
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressUtxoContent</returns>
        System.Threading.Tasks.Task<AddressUtxoContent> AddressesAddressUtxosAssetGetAsync (string address, string asset, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address UTXOs of a given asset
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressUtxoContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressUtxoContent>> AddressesAddressUtxosAssetGetAsyncWithHttpInfo (string address, string asset, int? count = null, int? page = null, string order = null);
        /// <summary>
        /// Address UTXOs
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressUtxoContent</returns>
        System.Threading.Tasks.Task<AddressUtxoContent> AddressesAddressUtxosGetAsync (string address, int? count = null, int? page = null, string order = null);

        /// <summary>
        /// Address UTXOs
        /// </summary>
        /// <remarks>
        /// UTXOs of the address.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressUtxoContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressUtxoContent>> AddressesAddressUtxosGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CardanoAddressesApi : ICardanoAddressesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAddressesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardanoAddressesApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAddressesApi"/> class
        /// </summary>
        /// <returns></returns>
        public CardanoAddressesApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardanoAddressesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardanoAddressesApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Specific address Obtain information about a specific address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>AddressContent</returns>
        public AddressContent AddressesAddressGet (string address)
        {
             ApiResponse<AddressContent> localVarResponse = AddressesAddressGetWithHttpInfo(address);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Specific address Obtain information about a specific address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>ApiResponse of AddressContent</returns>
        public ApiResponse< AddressContent > AddressesAddressGetWithHttpInfo (string address)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressGet");

            var localVarPath = "./addresses/{address}";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressContent)));
        }

        /// <summary>
        /// Specific address Obtain information about a specific address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of AddressContent</returns>
        public async System.Threading.Tasks.Task<AddressContent> AddressesAddressGetAsync (string address)
        {
             ApiResponse<AddressContent> localVarResponse = await AddressesAddressGetAsyncWithHttpInfo(address);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Specific address Obtain information about a specific address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of ApiResponse (AddressContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressContent>> AddressesAddressGetAsyncWithHttpInfo (string address)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressGet");

            var localVarPath = "./addresses/{address}";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressContent)));
        }

        /// <summary>
        /// Address details Obtain details about an address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>AddressContentTotal</returns>
        public AddressContentTotal AddressesAddressTotalGet (string address)
        {
             ApiResponse<AddressContentTotal> localVarResponse = AddressesAddressTotalGetWithHttpInfo(address);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Address details Obtain details about an address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>ApiResponse of AddressContentTotal</returns>
        public ApiResponse< AddressContentTotal > AddressesAddressTotalGetWithHttpInfo (string address)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTotalGet");

            var localVarPath = "./addresses/{address}/total";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTotalGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressContentTotal>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressContentTotal) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressContentTotal)));
        }

        /// <summary>
        /// Address details Obtain details about an address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of AddressContentTotal</returns>
        public async System.Threading.Tasks.Task<AddressContentTotal> AddressesAddressTotalGetAsync (string address)
        {
             ApiResponse<AddressContentTotal> localVarResponse = await AddressesAddressTotalGetAsyncWithHttpInfo(address);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Address details Obtain details about an address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <returns>Task of ApiResponse (AddressContentTotal)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressContentTotal>> AddressesAddressTotalGetAsyncWithHttpInfo (string address)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTotalGet");

            var localVarPath = "./addresses/{address}/total";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTotalGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressContentTotal>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressContentTotal) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressContentTotal)));
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>AddressTransactionsContent</returns>
        public AddressTransactionsContent AddressesAddressTransactionsGet (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null)
        {
             ApiResponse<AddressTransactionsContent> localVarResponse = AddressesAddressTransactionsGetWithHttpInfo(address, count, page, order, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>ApiResponse of AddressTransactionsContent</returns>
        public ApiResponse< AddressTransactionsContent > AddressesAddressTransactionsGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTransactionsGet");

            var localVarPath = "./addresses/{address}/transactions";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (from != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from)); // query parameter
            if (to != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to", to)); // query parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTransactionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressTransactionsContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressTransactionsContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressTransactionsContent)));
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>Task of AddressTransactionsContent</returns>
        public async System.Threading.Tasks.Task<AddressTransactionsContent> AddressesAddressTransactionsGetAsync (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null)
        {
             ApiResponse<AddressTransactionsContent> localVarResponse = await AddressesAddressTransactionsGetAsyncWithHttpInfo(address, count, page, order, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The numbers of pools per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <param name="from">The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  (optional)</param>
        /// <param name="to">The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  (optional)</param>
        /// <returns>Task of ApiResponse (AddressTransactionsContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressTransactionsContent>> AddressesAddressTransactionsGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTransactionsGet");

            var localVarPath = "./addresses/{address}/transactions";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (from != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from)); // query parameter
            if (to != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to", to)); // query parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTransactionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressTransactionsContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressTransactionsContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressTransactionsContent)));
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressTxsContent</returns>
        public AddressTxsContent AddressesAddressTxsGet (string address, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressTxsContent> localVarResponse = AddressesAddressTxsGetWithHttpInfo(address, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressTxsContent</returns>
        public ApiResponse< AddressTxsContent > AddressesAddressTxsGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTxsGet");

            var localVarPath = "./addresses/{address}/txs";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressTxsContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressTxsContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressTxsContent)));
        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressTxsContent</returns>
        public async System.Threading.Tasks.Task<AddressTxsContent> AddressesAddressTxsGetAsync (string address, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressTxsContent> localVarResponse = await AddressesAddressTxsGetAsyncWithHttpInfo(address, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Address transactions Transactions on the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of transactions per page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressTxsContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressTxsContent>> AddressesAddressTxsGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressTxsGet");

            var localVarPath = "./addresses/{address}/txs";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressTxsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressTxsContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressTxsContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressTxsContent)));
        }

        /// <summary>
        /// Address UTXOs of a given asset UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressUtxoContent</returns>
        public AddressUtxoContent AddressesAddressUtxosAssetGet (string address, string asset, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressUtxoContent> localVarResponse = AddressesAddressUtxosAssetGetWithHttpInfo(address, asset, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Address UTXOs of a given asset UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressUtxoContent</returns>
        public ApiResponse< AddressUtxoContent > AddressesAddressUtxosAssetGetWithHttpInfo (string address, string asset, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressUtxosAssetGet");
            // verify the required parameter 'asset' is set
            if (asset == null)
                throw new ApiException(400, "Missing required parameter 'asset' when calling CardanoAddressesApi->AddressesAddressUtxosAssetGet");

            var localVarPath = "./addresses/{address}/utxos/{asset}";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
            if (asset != null) localVarPathParams.Add("asset", this.Configuration.ApiClient.ParameterToString(asset)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressUtxosAssetGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressUtxoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressUtxoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressUtxoContent)));
        }

        /// <summary>
        /// Address UTXOs of a given asset UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressUtxoContent</returns>
        public async System.Threading.Tasks.Task<AddressUtxoContent> AddressesAddressUtxosAssetGetAsync (string address, string asset, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressUtxoContent> localVarResponse = await AddressesAddressUtxosAssetGetAsyncWithHttpInfo(address, asset, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Address UTXOs of a given asset UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="asset">Concatenation of the policy_id and hex-encoded asset_name</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressUtxoContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressUtxoContent>> AddressesAddressUtxosAssetGetAsyncWithHttpInfo (string address, string asset, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressUtxosAssetGet");
            // verify the required parameter 'asset' is set
            if (asset == null)
                throw new ApiException(400, "Missing required parameter 'asset' when calling CardanoAddressesApi->AddressesAddressUtxosAssetGet");

            var localVarPath = "./addresses/{address}/utxos/{asset}";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
            if (asset != null) localVarPathParams.Add("asset", this.Configuration.ApiClient.ParameterToString(asset)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressUtxosAssetGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressUtxoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressUtxoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressUtxoContent)));
        }

        /// <summary>
        /// Address UTXOs UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>AddressUtxoContent</returns>
        public AddressUtxoContent AddressesAddressUtxosGet (string address, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressUtxoContent> localVarResponse = AddressesAddressUtxosGetWithHttpInfo(address, count, page, order);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Address UTXOs UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>ApiResponse of AddressUtxoContent</returns>
        public ApiResponse< AddressUtxoContent > AddressesAddressUtxosGetWithHttpInfo (string address, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressUtxosGet");

            var localVarPath = "./addresses/{address}/utxos";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressUtxosGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressUtxoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressUtxoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressUtxoContent)));
        }

        /// <summary>
        /// Address UTXOs UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of AddressUtxoContent</returns>
        public async System.Threading.Tasks.Task<AddressUtxoContent> AddressesAddressUtxosGetAsync (string address, int? count = null, int? page = null, string order = null)
        {
             ApiResponse<AddressUtxoContent> localVarResponse = await AddressesAddressUtxosGetAsyncWithHttpInfo(address, count, page, order);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Address UTXOs UTXOs of the address.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Bech32 address.</param>
        /// <param name="count">The number of results displayed on one page. (optional, default to 100)</param>
        /// <param name="page">The page number for listing the results. (optional, default to 1)</param>
        /// <param name="order">The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (AddressUtxoContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressUtxoContent>> AddressesAddressUtxosGetAsyncWithHttpInfo (string address, int? count = null, int? page = null, string order = null)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling CardanoAddressesApi->AddressesAddressUtxosGet");

            var localVarPath = "./addresses/{address}/utxos";
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

            if (address != null) localVarPathParams.Add("address", this.Configuration.ApiClient.ParameterToString(address)); // path parameter
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
                Exception exception = ExceptionFactory("AddressesAddressUtxosGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddressUtxoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AddressUtxoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddressUtxoContent)));
        }

    }
}
