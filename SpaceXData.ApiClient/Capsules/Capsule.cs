using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Capsules;

public sealed class Capsule
{
    [JsonPropertyName("reuse_count")]
    public int ReuseCount { get; set; }

    [JsonPropertyName("water_landings")]
    public int WaterLandings { get; set; }

    [JsonPropertyName("land_landings")]
    public int LandLandings { get; set; }

    [JsonPropertyName("last_update")]
    public string LastUpdate { get; set; }

    [JsonPropertyName("launches")]
    public string[] Launches { get; set; }

    [JsonPropertyName("serial")]
    public string Serial { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}
