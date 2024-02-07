using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Crew;
public sealed class CrewMember
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("agency")]
    public string Agency { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }

    [JsonPropertyName("launches")]
    public List<string> Launches { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}
