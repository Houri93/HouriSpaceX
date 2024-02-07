using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class PressurizedCapsule
{
    [JsonPropertyName("payload_volume")]
    public PayloadVolume PayloadVolume { get; set; }
}
