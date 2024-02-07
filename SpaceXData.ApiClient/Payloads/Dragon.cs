using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Payloads;

public sealed class Dragon
{
    [JsonPropertyName("capsule")]
    public string? Capsule { get; set; }

    [JsonPropertyName("mass_returned_kg")]
    public string? MassReturnedKg { get; set; }

    [JsonPropertyName("mass_returned_lbs")]
    public string? MassReturnedLbs { get; set; }

    [JsonPropertyName("flight_time_sec")]
    public string? FlightTimeSec { get; set; }

    [JsonPropertyName("manifest")]
    public string? Manifest { get; set; }

    [JsonPropertyName("water_landing")]
    public string? WaterLanding { get; set; }

    [JsonPropertyName("land_landing")]
    public string? LandLanding { get; set; }
}

