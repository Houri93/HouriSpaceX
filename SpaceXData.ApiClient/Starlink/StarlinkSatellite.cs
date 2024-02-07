using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Starlink;

public sealed class StarlinkSatellite
{
    [JsonPropertyName("spaceTrack")]
    public SpaceTrack SpaceTrack { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("launch")]
    public string Launch { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("height_km")]
    public double HeightKm { get; set; }

    [JsonPropertyName("velocity_kms")]
    public double VelocityKms { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}


