using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Diameter
{
    [JsonPropertyName("meters")]
    public double Meters { get; set; }

    [JsonPropertyName("feet")]
    public int Feet { get; set; }
}
