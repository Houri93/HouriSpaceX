using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Cargo
{
    [JsonPropertyName("solar_array")]
    public int SolarArray { get; set; }

    [JsonPropertyName("unpressurized_cargo")]
    public bool UnpressurizedCargo { get; set; }
}
