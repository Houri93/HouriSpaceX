using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Ships;

// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
public sealed class Ship
{
    [JsonPropertyName("legacy_id")]
    public string LegacyId { get; set; }

    [JsonPropertyName("model")]
    public object Model { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; }

    [JsonPropertyName("imo")]
    public int Imo { get; set; }

    [JsonPropertyName("mmsi")]
    public int Mmsi { get; set; }

    [JsonPropertyName("abs")]
    public int Abs { get; set; }

    [JsonPropertyName("class")]
    public int Class { get; set; }

    [JsonPropertyName("mass_kg")]
    public int MassKg { get; set; }

    [JsonPropertyName("mass_lbs")]
    public int MassLbs { get; set; }

    [JsonPropertyName("year_built")]
    public int YearBuilt { get; set; }

    [JsonPropertyName("home_port")]
    public string HomePort { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("speed_kn")]
    public object SpeedKn { get; set; }

    [JsonPropertyName("course_deg")]
    public object CourseDeg { get; set; }

    [JsonPropertyName("latitude")]
    public object Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public object Longitude { get; set; }

    [JsonPropertyName("last_ais_update")]
    public object LastAisUpdate { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("launches")]
    public List<string> Launches { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

