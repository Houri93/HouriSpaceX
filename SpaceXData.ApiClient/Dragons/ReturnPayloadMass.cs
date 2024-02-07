using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class ReturnPayloadMass
{
    [JsonPropertyName("kg")]
    public int Kg { get; set; }

    [JsonPropertyName("lb")]
    public int Lb { get; set; }
}
