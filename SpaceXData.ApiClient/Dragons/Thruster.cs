using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Thruster
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("pods")]
    public int Pods { get; set; }

    [JsonPropertyName("fuel_1")]
    public string Fuel1 { get; set; }

    [JsonPropertyName("fuel_2")]
    public string Fuel2 { get; set; }

    [JsonPropertyName("isp")]
    public int Isp { get; set; }

    [JsonPropertyName("thrust")]
    public Thrust Thrust { get; set; }
}
