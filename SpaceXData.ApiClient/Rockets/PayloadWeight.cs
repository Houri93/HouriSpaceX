using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class PayloadWeight
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("kg")]
    public int Kg { get; set; }

    [JsonPropertyName("lb")]
    public int Lb { get; set; }
}

