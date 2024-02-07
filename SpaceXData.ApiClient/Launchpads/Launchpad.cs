using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Launchpads;

public sealed class Launchpad
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("locality")]
    public string Locality { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("launch_attempts")]
    public int LaunchAttempts { get; set; }

    [JsonPropertyName("launch_successes")]
    public int LaunchSuccesses { get; set; }

    [JsonPropertyName("rockets")]
    public List<string> Rockets { get; set; }

    [JsonPropertyName("launches")]
    public List<string> Launches { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

