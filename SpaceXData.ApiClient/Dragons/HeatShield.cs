using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class HeatShield
{
    [JsonPropertyName("material")]
    public string Material { get; set; }

    [JsonPropertyName("size_meters")]
    public double SizeMeters { get; set; }

    [JsonPropertyName("temp_degrees")]
    public int TempDegrees { get; set; }

    [JsonPropertyName("dev_partner")]
    public string DevPartner { get; set; }
}
