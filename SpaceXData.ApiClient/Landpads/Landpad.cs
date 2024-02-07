using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Landpads;

public sealed class Landpad
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("locality")]
    public string Locality { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("landing_attempts")]
    public int LandingAttempts { get; set; }

    [JsonPropertyName("landing_successes")]
    public int LandingSuccesses { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("launches")]
    public List<string> Launches { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

