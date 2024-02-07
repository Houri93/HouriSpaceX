using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.History;

public sealed class History
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("event_date_utc")]
    public DateTime EventDateUtc { get; set; }

    [JsonPropertyName("event_date_unix")]
    public int EventDateUnix { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("links")]
    public Links Links { get; set; }
}
