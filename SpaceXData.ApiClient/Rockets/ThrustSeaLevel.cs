using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class ThrustSeaLevel
{
    [JsonPropertyName("kN")]
    public int KN { get; set; }

    [JsonPropertyName("lbf")]
    public int Lbf { get; set; }
}

