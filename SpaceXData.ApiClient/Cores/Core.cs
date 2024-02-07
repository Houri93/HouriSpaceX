using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Cores;

public sealed class Core
{
    [JsonPropertyName("block")]
    public int? Block { get; set; }

    [JsonPropertyName("reuse_count")]
    public int? ReuseCount { get; set; }

    [JsonPropertyName("rtls_attempts")]
    public int? RtlsAttempts { get; set; }

    [JsonPropertyName("rtls_landings")]
    public int? RtlsLandings { get; set; }

    [JsonPropertyName("asds_attempts")]
    public int? AsdsAttempts { get; set; }

    [JsonPropertyName("asds_landings")]
    public int? AsdsLandings { get; set; }

    [JsonPropertyName("last_update")]
    public string LastUpdate { get; set; }

    [JsonPropertyName("launches")]
    public List<string> Launches { get; set; }

    [JsonPropertyName("serial")]
    public string Serial { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

