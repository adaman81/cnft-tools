using Newtonsoft.Json;

namespace blockfrost.Model
{
    public partial class AssetOnchainMetadata___
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("nullable")]
        public bool Nullable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("oneOf")]
        public OneOf[] OneOf { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
    }

    public partial class OneOf
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
    }
}
