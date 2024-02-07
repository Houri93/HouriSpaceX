using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Height
{
    [JsonPropertyName("meters")]
    public int Meters { get; set; }

    [JsonPropertyName("feet")]
    public double Feet { get; set; }
}

