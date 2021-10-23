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
    /// EpochParamContent
    /// </summary>
    [DataContract]
        public partial class EpochParamContent :  IEquatable<EpochParamContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpochParamContent" /> class.
        /// </summary>
        /// <param name="epoch">Epoch number (required).</param>
        /// <param name="minFeeA">The linear factor for the minimum fee calculation for given epoch (required).</param>
        /// <param name="minFeeB">The constant factor for the minimum fee calculation (required).</param>
        /// <param name="maxBlockSize">Maximum block body size in Bytes (required).</param>
        /// <param name="maxTxSize">Maximum transaction size (required).</param>
        /// <param name="maxBlockHeaderSize">Maximum block header size (required).</param>
        /// <param name="keyDeposit">The amount of a key registration deposit in Lovelaces (required).</param>
        /// <param name="poolDeposit">The amount of a pool registration deposit in Lovelaces (required).</param>
        /// <param name="eMax">Epoch bound on pool retirement (required).</param>
        /// <param name="nOpt">Desired number of pools (required).</param>
        /// <param name="a0">Pool pledge influence (required).</param>
        /// <param name="rho">Monetary expansion (required).</param>
        /// <param name="tau">Treasury expansion (required).</param>
        /// <param name="decentralisationParam">Percentage of blocks produced by federated nodes (required).</param>
        /// <param name="extraEntropy">Seed for extra entropy (required).</param>
        /// <param name="protocolMajorVer">Accepted protocol major version (required).</param>
        /// <param name="protocolMinorVer">Accepted protocol minor version (required).</param>
        /// <param name="minUtxo">Minimum UTXO value (required).</param>
        /// <param name="minPoolCost">Minimum stake cost forced on the pool (required).</param>
        /// <param name="nonce">Epoch number only used once (required).</param>
        /// <param name="priceMem">The per word cost of script memory usage (required).</param>
        /// <param name="priceStep">The cost of script execution step usage (required).</param>
        /// <param name="maxTxExMem">The maximum number of execution memory allowed to be used in a single transaction (required).</param>
        /// <param name="maxTxExSteps">The maximum number of execution steps allowed to be used in a single transaction (required).</param>
        /// <param name="maxBlockExMem">The maximum number of execution memory allowed to be used in a single block (required).</param>
        /// <param name="maxBlockExSteps">The maximum number of execution steps allowed to be used in a single block (required).</param>
        /// <param name="maxValSize">The maximum Val size (required).</param>
        /// <param name="collateralPercent">The percentage of the transactions fee which must be provided as collateral when including non-native scripts (required).</param>
        /// <param name="maxCollateralInputs">The maximum number of collateral inputs allowed in a transaction (required).</param>
        /// <param name="coinsPerUtxoWord">The cost per UTxO word (required).</param>
        public EpochParamContent(int? epoch = default(int?), int? minFeeA = default(int?), int? minFeeB = default(int?), int? maxBlockSize = default(int?), int? maxTxSize = default(int?), int? maxBlockHeaderSize = default(int?), string keyDeposit = default(string), string poolDeposit = default(string), int? eMax = default(int?), int? nOpt = default(int?), decimal? a0 = default(decimal?), decimal? rho = default(decimal?), decimal? tau = default(decimal?), decimal? decentralisationParam = default(decimal?), Object extraEntropy = default(Object), int? protocolMajorVer = default(int?), int? protocolMinorVer = default(int?), string minUtxo = default(string), string minPoolCost = default(string), string nonce = default(string), decimal? priceMem = default(decimal?), decimal? priceStep = default(decimal?), string maxTxExMem = default(string), string maxTxExSteps = default(string), string maxBlockExMem = default(string), string maxBlockExSteps = default(string), string maxValSize = default(string), int? collateralPercent = default(int?), int? maxCollateralInputs = default(int?), string coinsPerUtxoWord = default(string))
        {
            // to ensure "epoch" is required (not null)
            if (epoch == null)
            {
                throw new InvalidDataException("epoch is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.Epoch = epoch;
            }
            // to ensure "minFeeA" is required (not null)
            if (minFeeA == null)
            {
                throw new InvalidDataException("minFeeA is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MinFeeA = minFeeA;
            }
            // to ensure "minFeeB" is required (not null)
            if (minFeeB == null)
            {
                throw new InvalidDataException("minFeeB is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MinFeeB = minFeeB;
            }
            // to ensure "maxBlockSize" is required (not null)
            if (maxBlockSize == null)
            {
                throw new InvalidDataException("maxBlockSize is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxBlockSize = maxBlockSize;
            }
            // to ensure "maxTxSize" is required (not null)
            if (maxTxSize == null)
            {
                throw new InvalidDataException("maxTxSize is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxTxSize = maxTxSize;
            }
            // to ensure "maxBlockHeaderSize" is required (not null)
            if (maxBlockHeaderSize == null)
            {
                throw new InvalidDataException("maxBlockHeaderSize is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxBlockHeaderSize = maxBlockHeaderSize;
            }
            // to ensure "keyDeposit" is required (not null)
            if (keyDeposit == null)
            {
                throw new InvalidDataException("keyDeposit is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.KeyDeposit = keyDeposit;
            }
            // to ensure "poolDeposit" is required (not null)
            if (poolDeposit == null)
            {
                throw new InvalidDataException("poolDeposit is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.PoolDeposit = poolDeposit;
            }
            // to ensure "eMax" is required (not null)
            if (eMax == null)
            {
                throw new InvalidDataException("eMax is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.EMax = eMax;
            }
            // to ensure "nOpt" is required (not null)
            if (nOpt == null)
            {
                throw new InvalidDataException("nOpt is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.NOpt = nOpt;
            }
            // to ensure "a0" is required (not null)
            if (a0 == null)
            {
                throw new InvalidDataException("a0 is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.A0 = a0;
            }
            // to ensure "rho" is required (not null)
            if (rho == null)
            {
                throw new InvalidDataException("rho is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.Rho = rho;
            }
            // to ensure "tau" is required (not null)
            if (tau == null)
            {
                throw new InvalidDataException("tau is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.Tau = tau;
            }
            // to ensure "decentralisationParam" is required (not null)
            if (decentralisationParam == null)
            {
                throw new InvalidDataException("decentralisationParam is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.DecentralisationParam = decentralisationParam;
            }
            // to ensure "extraEntropy" is required (not null)
            if (extraEntropy == null)
            {
                throw new InvalidDataException("extraEntropy is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.ExtraEntropy = extraEntropy;
            }
            // to ensure "protocolMajorVer" is required (not null)
            if (protocolMajorVer == null)
            {
                throw new InvalidDataException("protocolMajorVer is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.ProtocolMajorVer = protocolMajorVer;
            }
            // to ensure "protocolMinorVer" is required (not null)
            if (protocolMinorVer == null)
            {
                throw new InvalidDataException("protocolMinorVer is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.ProtocolMinorVer = protocolMinorVer;
            }
            // to ensure "minUtxo" is required (not null)
            if (minUtxo == null)
            {
                throw new InvalidDataException("minUtxo is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MinUtxo = minUtxo;
            }
            // to ensure "minPoolCost" is required (not null)
            if (minPoolCost == null)
            {
                throw new InvalidDataException("minPoolCost is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MinPoolCost = minPoolCost;
            }
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new InvalidDataException("nonce is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.Nonce = nonce;
            }
            // to ensure "priceMem" is required (not null)
            if (priceMem == null)
            {
                throw new InvalidDataException("priceMem is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.PriceMem = priceMem;
            }
            // to ensure "priceStep" is required (not null)
            if (priceStep == null)
            {
                throw new InvalidDataException("priceStep is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.PriceStep = priceStep;
            }
            // to ensure "maxTxExMem" is required (not null)
            if (maxTxExMem == null)
            {
                throw new InvalidDataException("maxTxExMem is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxTxExMem = maxTxExMem;
            }
            // to ensure "maxTxExSteps" is required (not null)
            if (maxTxExSteps == null)
            {
                throw new InvalidDataException("maxTxExSteps is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxTxExSteps = maxTxExSteps;
            }
            // to ensure "maxBlockExMem" is required (not null)
            if (maxBlockExMem == null)
            {
                throw new InvalidDataException("maxBlockExMem is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxBlockExMem = maxBlockExMem;
            }
            // to ensure "maxBlockExSteps" is required (not null)
            if (maxBlockExSteps == null)
            {
                throw new InvalidDataException("maxBlockExSteps is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxBlockExSteps = maxBlockExSteps;
            }
            // to ensure "maxValSize" is required (not null)
            if (maxValSize == null)
            {
                throw new InvalidDataException("maxValSize is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxValSize = maxValSize;
            }
            // to ensure "collateralPercent" is required (not null)
            if (collateralPercent == null)
            {
                throw new InvalidDataException("collateralPercent is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.CollateralPercent = collateralPercent;
            }
            // to ensure "maxCollateralInputs" is required (not null)
            if (maxCollateralInputs == null)
            {
                throw new InvalidDataException("maxCollateralInputs is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.MaxCollateralInputs = maxCollateralInputs;
            }
            // to ensure "coinsPerUtxoWord" is required (not null)
            if (coinsPerUtxoWord == null)
            {
                throw new InvalidDataException("coinsPerUtxoWord is a required property for EpochParamContent and cannot be null");
            }
            else
            {
                this.CoinsPerUtxoWord = coinsPerUtxoWord;
            }
        }
        
        /// <summary>
        /// Epoch number
        /// </summary>
        /// <value>Epoch number</value>
        [DataMember(Name="epoch", EmitDefaultValue=false)]
        public int? Epoch { get; set; }

        /// <summary>
        /// The linear factor for the minimum fee calculation for given epoch
        /// </summary>
        /// <value>The linear factor for the minimum fee calculation for given epoch</value>
        [DataMember(Name="min_fee_a", EmitDefaultValue=false)]
        public int? MinFeeA { get; set; }

        /// <summary>
        /// The constant factor for the minimum fee calculation
        /// </summary>
        /// <value>The constant factor for the minimum fee calculation</value>
        [DataMember(Name="min_fee_b", EmitDefaultValue=false)]
        public int? MinFeeB { get; set; }

        /// <summary>
        /// Maximum block body size in Bytes
        /// </summary>
        /// <value>Maximum block body size in Bytes</value>
        [DataMember(Name="max_block_size", EmitDefaultValue=false)]
        public int? MaxBlockSize { get; set; }

        /// <summary>
        /// Maximum transaction size
        /// </summary>
        /// <value>Maximum transaction size</value>
        [DataMember(Name="max_tx_size", EmitDefaultValue=false)]
        public int? MaxTxSize { get; set; }

        /// <summary>
        /// Maximum block header size
        /// </summary>
        /// <value>Maximum block header size</value>
        [DataMember(Name="max_block_header_size", EmitDefaultValue=false)]
        public int? MaxBlockHeaderSize { get; set; }

        /// <summary>
        /// The amount of a key registration deposit in Lovelaces
        /// </summary>
        /// <value>The amount of a key registration deposit in Lovelaces</value>
        [DataMember(Name="key_deposit", EmitDefaultValue=false)]
        public string KeyDeposit { get; set; }

        /// <summary>
        /// The amount of a pool registration deposit in Lovelaces
        /// </summary>
        /// <value>The amount of a pool registration deposit in Lovelaces</value>
        [DataMember(Name="pool_deposit", EmitDefaultValue=false)]
        public string PoolDeposit { get; set; }

        /// <summary>
        /// Epoch bound on pool retirement
        /// </summary>
        /// <value>Epoch bound on pool retirement</value>
        [DataMember(Name="e_max", EmitDefaultValue=false)]
        public int? EMax { get; set; }

        /// <summary>
        /// Desired number of pools
        /// </summary>
        /// <value>Desired number of pools</value>
        [DataMember(Name="n_opt", EmitDefaultValue=false)]
        public int? NOpt { get; set; }

        /// <summary>
        /// Pool pledge influence
        /// </summary>
        /// <value>Pool pledge influence</value>
        [DataMember(Name="a0", EmitDefaultValue=false)]
        public decimal? A0 { get; set; }

        /// <summary>
        /// Monetary expansion
        /// </summary>
        /// <value>Monetary expansion</value>
        [DataMember(Name="rho", EmitDefaultValue=false)]
        public decimal? Rho { get; set; }

        /// <summary>
        /// Treasury expansion
        /// </summary>
        /// <value>Treasury expansion</value>
        [DataMember(Name="tau", EmitDefaultValue=false)]
        public decimal? Tau { get; set; }

        /// <summary>
        /// Percentage of blocks produced by federated nodes
        /// </summary>
        /// <value>Percentage of blocks produced by federated nodes</value>
        [DataMember(Name="decentralisation_param", EmitDefaultValue=false)]
        public decimal? DecentralisationParam { get; set; }

        /// <summary>
        /// Seed for extra entropy
        /// </summary>
        /// <value>Seed for extra entropy</value>
        [DataMember(Name="extra_entropy", EmitDefaultValue=false)]
        public Object ExtraEntropy { get; set; }

        /// <summary>
        /// Accepted protocol major version
        /// </summary>
        /// <value>Accepted protocol major version</value>
        [DataMember(Name="protocol_major_ver", EmitDefaultValue=false)]
        public int? ProtocolMajorVer { get; set; }

        /// <summary>
        /// Accepted protocol minor version
        /// </summary>
        /// <value>Accepted protocol minor version</value>
        [DataMember(Name="protocol_minor_ver", EmitDefaultValue=false)]
        public int? ProtocolMinorVer { get; set; }

        /// <summary>
        /// Minimum UTXO value
        /// </summary>
        /// <value>Minimum UTXO value</value>
        [DataMember(Name="min_utxo", EmitDefaultValue=false)]
        public string MinUtxo { get; set; }

        /// <summary>
        /// Minimum stake cost forced on the pool
        /// </summary>
        /// <value>Minimum stake cost forced on the pool</value>
        [DataMember(Name="min_pool_cost", EmitDefaultValue=false)]
        public string MinPoolCost { get; set; }

        /// <summary>
        /// Epoch number only used once
        /// </summary>
        /// <value>Epoch number only used once</value>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// The per word cost of script memory usage
        /// </summary>
        /// <value>The per word cost of script memory usage</value>
        [DataMember(Name="price_mem", EmitDefaultValue=false)]
        public decimal? PriceMem { get; set; }

        /// <summary>
        /// The cost of script execution step usage
        /// </summary>
        /// <value>The cost of script execution step usage</value>
        [DataMember(Name="price_step", EmitDefaultValue=false)]
        public decimal? PriceStep { get; set; }

        /// <summary>
        /// The maximum number of execution memory allowed to be used in a single transaction
        /// </summary>
        /// <value>The maximum number of execution memory allowed to be used in a single transaction</value>
        [DataMember(Name="max_tx_ex_mem", EmitDefaultValue=false)]
        public string MaxTxExMem { get; set; }

        /// <summary>
        /// The maximum number of execution steps allowed to be used in a single transaction
        /// </summary>
        /// <value>The maximum number of execution steps allowed to be used in a single transaction</value>
        [DataMember(Name="max_tx_ex_steps", EmitDefaultValue=false)]
        public string MaxTxExSteps { get; set; }

        /// <summary>
        /// The maximum number of execution memory allowed to be used in a single block
        /// </summary>
        /// <value>The maximum number of execution memory allowed to be used in a single block</value>
        [DataMember(Name="max_block_ex_mem", EmitDefaultValue=false)]
        public string MaxBlockExMem { get; set; }

        /// <summary>
        /// The maximum number of execution steps allowed to be used in a single block
        /// </summary>
        /// <value>The maximum number of execution steps allowed to be used in a single block</value>
        [DataMember(Name="max_block_ex_steps", EmitDefaultValue=false)]
        public string MaxBlockExSteps { get; set; }

        /// <summary>
        /// The maximum Val size
        /// </summary>
        /// <value>The maximum Val size</value>
        [DataMember(Name="max_val_size", EmitDefaultValue=false)]
        public string MaxValSize { get; set; }

        /// <summary>
        /// The percentage of the transactions fee which must be provided as collateral when including non-native scripts
        /// </summary>
        /// <value>The percentage of the transactions fee which must be provided as collateral when including non-native scripts</value>
        [DataMember(Name="collateral_percent", EmitDefaultValue=false)]
        public int? CollateralPercent { get; set; }

        /// <summary>
        /// The maximum number of collateral inputs allowed in a transaction
        /// </summary>
        /// <value>The maximum number of collateral inputs allowed in a transaction</value>
        [DataMember(Name="max_collateral_inputs", EmitDefaultValue=false)]
        public int? MaxCollateralInputs { get; set; }

        /// <summary>
        /// The cost per UTxO word
        /// </summary>
        /// <value>The cost per UTxO word</value>
        [DataMember(Name="coins_per_utxo_word", EmitDefaultValue=false)]
        public string CoinsPerUtxoWord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpochParamContent {\n");
            sb.Append("  Epoch: ").Append(Epoch).Append("\n");
            sb.Append("  MinFeeA: ").Append(MinFeeA).Append("\n");
            sb.Append("  MinFeeB: ").Append(MinFeeB).Append("\n");
            sb.Append("  MaxBlockSize: ").Append(MaxBlockSize).Append("\n");
            sb.Append("  MaxTxSize: ").Append(MaxTxSize).Append("\n");
            sb.Append("  MaxBlockHeaderSize: ").Append(MaxBlockHeaderSize).Append("\n");
            sb.Append("  KeyDeposit: ").Append(KeyDeposit).Append("\n");
            sb.Append("  PoolDeposit: ").Append(PoolDeposit).Append("\n");
            sb.Append("  EMax: ").Append(EMax).Append("\n");
            sb.Append("  NOpt: ").Append(NOpt).Append("\n");
            sb.Append("  A0: ").Append(A0).Append("\n");
            sb.Append("  Rho: ").Append(Rho).Append("\n");
            sb.Append("  Tau: ").Append(Tau).Append("\n");
            sb.Append("  DecentralisationParam: ").Append(DecentralisationParam).Append("\n");
            sb.Append("  ExtraEntropy: ").Append(ExtraEntropy).Append("\n");
            sb.Append("  ProtocolMajorVer: ").Append(ProtocolMajorVer).Append("\n");
            sb.Append("  ProtocolMinorVer: ").Append(ProtocolMinorVer).Append("\n");
            sb.Append("  MinUtxo: ").Append(MinUtxo).Append("\n");
            sb.Append("  MinPoolCost: ").Append(MinPoolCost).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  PriceMem: ").Append(PriceMem).Append("\n");
            sb.Append("  PriceStep: ").Append(PriceStep).Append("\n");
            sb.Append("  MaxTxExMem: ").Append(MaxTxExMem).Append("\n");
            sb.Append("  MaxTxExSteps: ").Append(MaxTxExSteps).Append("\n");
            sb.Append("  MaxBlockExMem: ").Append(MaxBlockExMem).Append("\n");
            sb.Append("  MaxBlockExSteps: ").Append(MaxBlockExSteps).Append("\n");
            sb.Append("  MaxValSize: ").Append(MaxValSize).Append("\n");
            sb.Append("  CollateralPercent: ").Append(CollateralPercent).Append("\n");
            sb.Append("  MaxCollateralInputs: ").Append(MaxCollateralInputs).Append("\n");
            sb.Append("  CoinsPerUtxoWord: ").Append(CoinsPerUtxoWord).Append("\n");
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
            return this.Equals(input as EpochParamContent);
        }

        /// <summary>
        /// Returns true if EpochParamContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EpochParamContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EpochParamContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Epoch == input.Epoch ||
                    (this.Epoch != null &&
                    this.Epoch.Equals(input.Epoch))
                ) && 
                (
                    this.MinFeeA == input.MinFeeA ||
                    (this.MinFeeA != null &&
                    this.MinFeeA.Equals(input.MinFeeA))
                ) && 
                (
                    this.MinFeeB == input.MinFeeB ||
                    (this.MinFeeB != null &&
                    this.MinFeeB.Equals(input.MinFeeB))
                ) && 
                (
                    this.MaxBlockSize == input.MaxBlockSize ||
                    (this.MaxBlockSize != null &&
                    this.MaxBlockSize.Equals(input.MaxBlockSize))
                ) && 
                (
                    this.MaxTxSize == input.MaxTxSize ||
                    (this.MaxTxSize != null &&
                    this.MaxTxSize.Equals(input.MaxTxSize))
                ) && 
                (
                    this.MaxBlockHeaderSize == input.MaxBlockHeaderSize ||
                    (this.MaxBlockHeaderSize != null &&
                    this.MaxBlockHeaderSize.Equals(input.MaxBlockHeaderSize))
                ) && 
                (
                    this.KeyDeposit == input.KeyDeposit ||
                    (this.KeyDeposit != null &&
                    this.KeyDeposit.Equals(input.KeyDeposit))
                ) && 
                (
                    this.PoolDeposit == input.PoolDeposit ||
                    (this.PoolDeposit != null &&
                    this.PoolDeposit.Equals(input.PoolDeposit))
                ) && 
                (
                    this.EMax == input.EMax ||
                    (this.EMax != null &&
                    this.EMax.Equals(input.EMax))
                ) && 
                (
                    this.NOpt == input.NOpt ||
                    (this.NOpt != null &&
                    this.NOpt.Equals(input.NOpt))
                ) && 
                (
                    this.A0 == input.A0 ||
                    (this.A0 != null &&
                    this.A0.Equals(input.A0))
                ) && 
                (
                    this.Rho == input.Rho ||
                    (this.Rho != null &&
                    this.Rho.Equals(input.Rho))
                ) && 
                (
                    this.Tau == input.Tau ||
                    (this.Tau != null &&
                    this.Tau.Equals(input.Tau))
                ) && 
                (
                    this.DecentralisationParam == input.DecentralisationParam ||
                    (this.DecentralisationParam != null &&
                    this.DecentralisationParam.Equals(input.DecentralisationParam))
                ) && 
                (
                    this.ExtraEntropy == input.ExtraEntropy ||
                    (this.ExtraEntropy != null &&
                    this.ExtraEntropy.Equals(input.ExtraEntropy))
                ) && 
                (
                    this.ProtocolMajorVer == input.ProtocolMajorVer ||
                    (this.ProtocolMajorVer != null &&
                    this.ProtocolMajorVer.Equals(input.ProtocolMajorVer))
                ) && 
                (
                    this.ProtocolMinorVer == input.ProtocolMinorVer ||
                    (this.ProtocolMinorVer != null &&
                    this.ProtocolMinorVer.Equals(input.ProtocolMinorVer))
                ) && 
                (
                    this.MinUtxo == input.MinUtxo ||
                    (this.MinUtxo != null &&
                    this.MinUtxo.Equals(input.MinUtxo))
                ) && 
                (
                    this.MinPoolCost == input.MinPoolCost ||
                    (this.MinPoolCost != null &&
                    this.MinPoolCost.Equals(input.MinPoolCost))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.PriceMem == input.PriceMem ||
                    (this.PriceMem != null &&
                    this.PriceMem.Equals(input.PriceMem))
                ) && 
                (
                    this.PriceStep == input.PriceStep ||
                    (this.PriceStep != null &&
                    this.PriceStep.Equals(input.PriceStep))
                ) && 
                (
                    this.MaxTxExMem == input.MaxTxExMem ||
                    (this.MaxTxExMem != null &&
                    this.MaxTxExMem.Equals(input.MaxTxExMem))
                ) && 
                (
                    this.MaxTxExSteps == input.MaxTxExSteps ||
                    (this.MaxTxExSteps != null &&
                    this.MaxTxExSteps.Equals(input.MaxTxExSteps))
                ) && 
                (
                    this.MaxBlockExMem == input.MaxBlockExMem ||
                    (this.MaxBlockExMem != null &&
                    this.MaxBlockExMem.Equals(input.MaxBlockExMem))
                ) && 
                (
                    this.MaxBlockExSteps == input.MaxBlockExSteps ||
                    (this.MaxBlockExSteps != null &&
                    this.MaxBlockExSteps.Equals(input.MaxBlockExSteps))
                ) && 
                (
                    this.MaxValSize == input.MaxValSize ||
                    (this.MaxValSize != null &&
                    this.MaxValSize.Equals(input.MaxValSize))
                ) && 
                (
                    this.CollateralPercent == input.CollateralPercent ||
                    (this.CollateralPercent != null &&
                    this.CollateralPercent.Equals(input.CollateralPercent))
                ) && 
                (
                    this.MaxCollateralInputs == input.MaxCollateralInputs ||
                    (this.MaxCollateralInputs != null &&
                    this.MaxCollateralInputs.Equals(input.MaxCollateralInputs))
                ) && 
                (
                    this.CoinsPerUtxoWord == input.CoinsPerUtxoWord ||
                    (this.CoinsPerUtxoWord != null &&
                    this.CoinsPerUtxoWord.Equals(input.CoinsPerUtxoWord))
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
                if (this.Epoch != null)
                    hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.MinFeeA != null)
                    hashCode = hashCode * 59 + this.MinFeeA.GetHashCode();
                if (this.MinFeeB != null)
                    hashCode = hashCode * 59 + this.MinFeeB.GetHashCode();
                if (this.MaxBlockSize != null)
                    hashCode = hashCode * 59 + this.MaxBlockSize.GetHashCode();
                if (this.MaxTxSize != null)
                    hashCode = hashCode * 59 + this.MaxTxSize.GetHashCode();
                if (this.MaxBlockHeaderSize != null)
                    hashCode = hashCode * 59 + this.MaxBlockHeaderSize.GetHashCode();
                if (this.KeyDeposit != null)
                    hashCode = hashCode * 59 + this.KeyDeposit.GetHashCode();
                if (this.PoolDeposit != null)
                    hashCode = hashCode * 59 + this.PoolDeposit.GetHashCode();
                if (this.EMax != null)
                    hashCode = hashCode * 59 + this.EMax.GetHashCode();
                if (this.NOpt != null)
                    hashCode = hashCode * 59 + this.NOpt.GetHashCode();
                if (this.A0 != null)
                    hashCode = hashCode * 59 + this.A0.GetHashCode();
                if (this.Rho != null)
                    hashCode = hashCode * 59 + this.Rho.GetHashCode();
                if (this.Tau != null)
                    hashCode = hashCode * 59 + this.Tau.GetHashCode();
                if (this.DecentralisationParam != null)
                    hashCode = hashCode * 59 + this.DecentralisationParam.GetHashCode();
                if (this.ExtraEntropy != null)
                    hashCode = hashCode * 59 + this.ExtraEntropy.GetHashCode();
                if (this.ProtocolMajorVer != null)
                    hashCode = hashCode * 59 + this.ProtocolMajorVer.GetHashCode();
                if (this.ProtocolMinorVer != null)
                    hashCode = hashCode * 59 + this.ProtocolMinorVer.GetHashCode();
                if (this.MinUtxo != null)
                    hashCode = hashCode * 59 + this.MinUtxo.GetHashCode();
                if (this.MinPoolCost != null)
                    hashCode = hashCode * 59 + this.MinPoolCost.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.PriceMem != null)
                    hashCode = hashCode * 59 + this.PriceMem.GetHashCode();
                if (this.PriceStep != null)
                    hashCode = hashCode * 59 + this.PriceStep.GetHashCode();
                if (this.MaxTxExMem != null)
                    hashCode = hashCode * 59 + this.MaxTxExMem.GetHashCode();
                if (this.MaxTxExSteps != null)
                    hashCode = hashCode * 59 + this.MaxTxExSteps.GetHashCode();
                if (this.MaxBlockExMem != null)
                    hashCode = hashCode * 59 + this.MaxBlockExMem.GetHashCode();
                if (this.MaxBlockExSteps != null)
                    hashCode = hashCode * 59 + this.MaxBlockExSteps.GetHashCode();
                if (this.MaxValSize != null)
                    hashCode = hashCode * 59 + this.MaxValSize.GetHashCode();
                if (this.CollateralPercent != null)
                    hashCode = hashCode * 59 + this.CollateralPercent.GetHashCode();
                if (this.MaxCollateralInputs != null)
                    hashCode = hashCode * 59 + this.MaxCollateralInputs.GetHashCode();
                if (this.CoinsPerUtxoWord != null)
                    hashCode = hashCode * 59 + this.CoinsPerUtxoWord.GetHashCode();
                return hashCode;
            }
        }
    }
}
