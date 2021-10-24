using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockfrost.Api;
using blockfrost.Client;
using blockfrost.Model;
using LiteDB;
using Newtonsoft.Json;

namespace asset_scanner
{
    class Program
    {
        private static CardanoAssetsApi _assetsApi;

        static async Task Main(string[] args)
        {
            // Hornnies NFT
            var policyId = "c805f32096ccb75be6b9d155ba8250b6a23ac9dffd95948551f57eeb";

            // Phase 1 - Gather static data

            // Step 1: store all assets of a policy in a local data store (LiteDB)
            // Download disabled - only needed first time for new assets
            //await DownloadAssets(policyId);

            // Step 2: lookup rarity -> cnft.tools -> update data store with rarity

            // Phase 2 - Gather price data

            // Step 1: for specific selection of assets (eg. with rarity rank between X and Y) lookup SALE and SOLD data
            // Step 2: nicely put this on the screen

            Console.WriteLine("done");
            Console.ReadLine();
        }

        private static async Task DownloadAssets(string policyId)
        {
            Console.WriteLine("Setup");

            var apiKey = new Dictionary<string, string>();
            apiKey.Add("project_id", "<REDACTED>");
            _assetsApi = new CardanoAssetsApi(new Configuration { ApiKey = apiKey });

            Console.WriteLine("Start");

            // Get all assets of a policy
            var assets = await GetAssetsForPolicy(policyId);
            Console.WriteLine($"Number of assets: {assets?.Count ?? 0}");

            // Get details for all assets
            List<Asset> assetsWithDetails = new List<Asset>();

            // Too Many requests :-)
            //Parallel.ForEach(assets, async asset =>
            //{
            //    var assetDetails = await GetAsset(asset);
            //    assetsWithDetails.Add(assetDetails);
            //});

            foreach (var asset in assets)
            {
                var assetDetails = await GetAsset(asset);
                assetsWithDetails.Add(assetDetails);

                await Task.Delay(150);
            }

            Console.WriteLine($"Number of asset details: {assetsWithDetails?.Count ?? 0}");

            // Get details of first asset
            //var asset = await GetAsset(assets.First());
            //Console.WriteLine(JsonConvert.SerializeObject(asset, Formatting.Indented));
            //Console.WriteLine(asset.OnchainMetadata.traits.ears);

            // Store details
            await StoreAssetsInDatabase(assetsWithDetails);
        }

        private static async Task StoreAssetsInDatabase(List<Asset> assets)
        {
            using (var db = new LiteDatabase("assets.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Asset>("assets");

                col.DeleteAll();

                col.InsertBulk(assets);
            }

            await Task.CompletedTask;
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
