using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Trunk
{
    [JsonPropertyName("trunk_volume")]
    public TrunkVolume TrunkVolume { get; set; }

    [JsonPropertyName("cargo")]
    public Cargo Cargo { get; set; }
}
