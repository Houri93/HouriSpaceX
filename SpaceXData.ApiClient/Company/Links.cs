using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Company;

public sealed class Links
{
    [JsonPropertyName("website")]
    public string Website { get; set; }

    [JsonPropertyName("flickr")]
    public string Flickr { get; set; }

    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    [JsonPropertyName("elon_twitter")]
    public string ElonTwitter { get; set; }
}

