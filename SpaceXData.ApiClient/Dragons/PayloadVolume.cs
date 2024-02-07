using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class PayloadVolume
{
    [JsonPropertyName("cubic_meters")]
    public int CubicMeters { get; set; }

    [JsonPropertyName("cubic_feet")]
    public int CubicFeet { get; set; }
}
