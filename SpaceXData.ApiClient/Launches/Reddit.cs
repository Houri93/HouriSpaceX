using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Launches;

public sealed class Reddit
{
    [JsonPropertyName("campaign")]
    public string Campaign { get; set; }

    [JsonPropertyName("launch")]
    public string Launch { get; set; }

    [JsonPropertyName("media")]
    public string Media { get; set; }

    [JsonPropertyName("recovery")]
    public object Recovery { get; set; }
}

