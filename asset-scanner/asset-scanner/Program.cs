using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockfrost.Api;
using blockfrost.Client;
using blockfrost.Model;
using Newtonsoft.Json;

namespace asset_scanner
{
    class Program
    {
        private static CardanoAssetsApi _assetsApi;

        static async Task Main(string[] args)
        {
            // Phase 1 - Gather static data

            // Step 1: store all assets of a policy in a local data store (LiteDB)
            // Step 2: lookup rarity -> cnft.tools -> update data store with rarity

            // Phase 2 - Gather price data

            // Step 1: for specific selection of assets (eg. with rarity rank between X and Y) lookup SALE and SOLD data
            // Step 2: nicely put this on the screen

            Console.WriteLine("Setup");

            var apiKey = new Dictionary<string, string>();
            apiKey.Add("project_id", "<REDACTED>");
            _assetsApi = new CardanoAssetsApi(new Configuration { ApiKey = apiKey });

            Console.WriteLine("Start");

            // Get all assets of a policy
            var assets = await GetAssetsForPolicy("c805f32096ccb75be6b9d155ba8250b6a23ac9dffd95948551f57eeb");
            Console.WriteLine($"Number of assets: {assets?.Count ?? 0}");

            // Get details of first asset
            var asset = await GetAsset(assets.First());
            Console.WriteLine(JsonConvert.SerializeObject(asset, Formatting.Indented));

            Console.WriteLine(asset.OnchainMetadata.traits.ears);

            Console.WriteLine("done");
            Console.ReadLine();
        }

        private static async Task<Asset> GetAsset(AssetPolicyInner asset)
        {
            return await _assetsApi.AssetsAssetGetAsync(asset.Asset);
        }

        private static async Task<List<AssetPolicyInner>> GetAssetsForPolicy(string policyId)
        {
            var assets = new List<AssetPolicyInner>();

            int page = 1;
            while (true)
            {
                var pagedAssets = await _assetsApi.AssetsPolicyPolicyIdGetAsync(policyId, count: 100, page: page);

                if (pagedAssets.Count == 0)
                {
                    break;
                }
                
                assets.AddRange(pagedAssets);

                page++;
            };            

            return assets;
        }
    }
}
