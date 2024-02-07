using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Company;

public sealed class Headquarters
{
    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }
}

