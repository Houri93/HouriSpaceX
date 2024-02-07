using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Launches;

public sealed class Flickr
{
    [JsonPropertyName("small")]
    public List<object> Small { get; set; }

    [JsonPropertyName("original")]
    public List<string> Original { get; set; }
}

