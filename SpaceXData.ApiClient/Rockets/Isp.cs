using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Isp
{
    [JsonPropertyName("sea_level")]
    public int SeaLevel { get; set; }

    [JsonPropertyName("vacuum")]
    public int Vacuum { get; set; }
}

