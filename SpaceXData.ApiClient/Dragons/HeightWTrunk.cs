using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class HeightWTrunk
{
    [JsonPropertyName("meters")]
    public double Meters { get; set; }

    [JsonPropertyName("feet")]
    public double Feet { get; set; }
}
