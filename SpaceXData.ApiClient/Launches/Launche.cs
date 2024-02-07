using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Launches;

public sealed class Launche
{
    [JsonPropertyName("fairings")]
    public object Fairings { get; set; }

    [JsonPropertyName("links")]
    public Links Links { get; set; }

    [JsonPropertyName("static_fire_date_utc")]
    public DateTime StaticFireDateUtc { get; set; }

    [JsonPropertyName("static_fire_date_unix")]
    public int StaticFireDateUnix { get; set; }

    [JsonPropertyName("tdb")]
    public bool Tdb { get; set; }

    [JsonPropertyName("net")]
    public bool Net { get; set; }

    [JsonPropertyName("window")]
    public int Window { get; set; }

    [JsonPropertyName("rocket")]
    public string Rocket { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("failures")]
    public List<object> Failures { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("crew")]
    public List<object> Crew { get; set; }

    [JsonPropertyName("ships")]
    public List<object> Ships { get; set; }

    [JsonPropertyName("capsules")]
    public List<string> Capsules { get; set; }

    [JsonPropertyName("payloads")]
    public List<string> Payloads { get; set; }

    [JsonPropertyName("launchpad")]
    public string Launchpad { get; set; }

    [JsonPropertyName("auto_update")]
    public bool AutoUpdate { get; set; }

    [JsonPropertyName("flight_number")]
    public int FlightNumber { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("date_utc")]
    public DateTime DateUtc { get; set; }

    [JsonPropertyName("date_unix")]
    public int DateUnix { get; set; }

    [JsonPropertyName("date_local")]
    public DateTime DateLocal { get; set; }

    [JsonPropertyName("date_precision")]
    public string DatePrecision { get; set; }

    [JsonPropertyName("upcoming")]
    public bool Upcoming { get; set; }

    [JsonPropertyName("cores")]
    public List<Core> Cores { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

