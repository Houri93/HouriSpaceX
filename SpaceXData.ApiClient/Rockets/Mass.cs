using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Mass
{
    [JsonPropertyName("kg")]
    public int Kg { get; set; }

    [JsonPropertyName("lb")]
    public int Lb { get; set; }
}

