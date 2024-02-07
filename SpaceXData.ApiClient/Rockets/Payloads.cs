using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Payloads
{
    [JsonPropertyName("composite_fairing")]
    public CompositeFairing CompositeFairing { get; set; }

    [JsonPropertyName("option_1")]
    public string Option1 { get; set; }
}

