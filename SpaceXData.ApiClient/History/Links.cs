using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.History;

public sealed class Links
{
    [JsonPropertyName("article")]
    public string Article { get; set; }
}
