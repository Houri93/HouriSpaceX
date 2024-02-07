using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class CompositeFairing
{
    [JsonPropertyName("height")]
    public Height Height { get; set; }

    [JsonPropertyName("diameter")]
    public Diameter Diameter { get; set; }
}

