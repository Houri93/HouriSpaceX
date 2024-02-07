using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Diameter
{
    [JsonPropertyName("meters")]
    public double Meters { get; set; }

    [JsonPropertyName("feet")]
    public double Feet { get; set; }
}

