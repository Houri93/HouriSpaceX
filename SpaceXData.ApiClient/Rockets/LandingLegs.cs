using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class LandingLegs
{
    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("material")]
    public string Material { get; set; }
}

