using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Launches;

public sealed class Patch
{
    [JsonPropertyName("small")]
    public string Small { get; set; }

    [JsonPropertyName("large")]
    public string Large { get; set; }
}

