using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Thrust
{
    [JsonPropertyName("kN")]
    public double KN { get; set; }

    [JsonPropertyName("lbf")]
    public int Lbf { get; set; }
}
