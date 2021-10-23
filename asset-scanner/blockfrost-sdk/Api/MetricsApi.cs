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
        public interface IMetricsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Blockfrost endpoint usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MetricsEndpoints</returns>
        MetricsEndpoints MetricsEndpointsGet ();

        /// <summary>
        /// Blockfrost endpoint usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MetricsEndpoints</returns>
        ApiResponse<MetricsEndpoints> MetricsEndpointsGetWithHttpInfo ();
        /// <summary>
        /// Blockfrost usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics in the past 30 days.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Metrics</returns>
        Metrics MetricsGet ();

        /// <summary>
        /// Blockfrost usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics in the past 30 days.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Metrics</returns>
        ApiResponse<Metrics> MetricsGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Blockfrost endpoint usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MetricsEndpoints</returns>
        System.Threading.Tasks.Task<MetricsEndpoints> MetricsEndpointsGetAsync ();

        /// <summary>
        /// Blockfrost endpoint usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MetricsEndpoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetricsEndpoints>> MetricsEndpointsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Blockfrost usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics in the past 30 days.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Metrics</returns>
        System.Threading.Tasks.Task<Metrics> MetricsGetAsync ();

        /// <summary>
        /// Blockfrost usage metrics
        /// </summary>
        /// <remarks>
        /// History of your Blockfrost usage metrics in the past 30 days.
        /// </remarks>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Metrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metrics>> MetricsGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class MetricsApi : IMetricsApi
    {
        private blockfrost.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetricsApi(String basePath)
        {
            this.Configuration = new blockfrost.Client.Configuration { BasePath = basePath };

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class
        /// </summary>
        /// <returns></returns>
        public MetricsApi()
        {
            this.Configuration = blockfrost.Client.Configuration.Default;

            ExceptionFactory = blockfrost.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetricsApi(blockfrost.Client.Configuration configuration = null)
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
        /// Blockfrost endpoint usage metrics History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MetricsEndpoints</returns>
        public MetricsEndpoints MetricsEndpointsGet ()
        {
             ApiResponse<MetricsEndpoints> localVarResponse = MetricsEndpointsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Blockfrost endpoint usage metrics History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MetricsEndpoints</returns>
        public ApiResponse< MetricsEndpoints > MetricsEndpointsGetWithHttpInfo ()
        {

            var localVarPath = "./metrics/endpoints";
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
                Exception exception = ExceptionFactory("MetricsEndpointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetricsEndpoints>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (MetricsEndpoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricsEndpoints)));
        }

        /// <summary>
        /// Blockfrost endpoint usage metrics History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MetricsEndpoints</returns>
        public async System.Threading.Tasks.Task<MetricsEndpoints> MetricsEndpointsGetAsync ()
        {
             ApiResponse<MetricsEndpoints> localVarResponse = await MetricsEndpointsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Blockfrost endpoint usage metrics History of your Blockfrost usage metrics per endpoint in the past 30 days. 
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MetricsEndpoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetricsEndpoints>> MetricsEndpointsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "./metrics/endpoints";
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
                Exception exception = ExceptionFactory("MetricsEndpointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetricsEndpoints>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (MetricsEndpoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricsEndpoints)));
        }

        /// <summary>
        /// Blockfrost usage metrics History of your Blockfrost usage metrics in the past 30 days.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Metrics</returns>
        public Metrics MetricsGet ()
        {
             ApiResponse<Metrics> localVarResponse = MetricsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Blockfrost usage metrics History of your Blockfrost usage metrics in the past 30 days.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Metrics</returns>
        public ApiResponse< Metrics > MetricsGetWithHttpInfo ()
        {

            var localVarPath = "./metrics/";
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
                Exception exception = ExceptionFactory("MetricsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Metrics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Metrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metrics)));
        }

        /// <summary>
        /// Blockfrost usage metrics History of your Blockfrost usage metrics in the past 30 days.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Metrics</returns>
        public async System.Threading.Tasks.Task<Metrics> MetricsGetAsync ()
        {
             ApiResponse<Metrics> localVarResponse = await MetricsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Blockfrost usage metrics History of your Blockfrost usage metrics in the past 30 days.
        /// </summary>
        /// <exception cref="blockfrost.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Metrics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metrics>> MetricsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "./metrics/";
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
                Exception exception = ExceptionFactory("MetricsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Metrics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (Metrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metrics)));
        }

    }
}
