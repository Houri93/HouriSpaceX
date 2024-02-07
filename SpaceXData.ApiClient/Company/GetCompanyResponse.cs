using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Company;

public sealed class GetCompanyResponse
{
    [JsonPropertyName("headquarters")]
    public Headquarters Headquarters { get; set; }

    [JsonPropertyName("links")]
    public Links Links { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("founder")]
    public string Founder { get; set; }

    [JsonPropertyName("founded")]
    public int Founded { get; set; }

    [JsonPropertyName("employees")]
    public int Employees { get; set; }

    [JsonPropertyName("vehicles")]
    public int Vehicles { get; set; }

    [JsonPropertyName("launch_sites")]
    public int LaunchSites { get; set; }

    [JsonPropertyName("test_sites")]
    public int TestSites { get; set; }

    [JsonPropertyName("ceo")]
    public string Ceo { get; set; }

    [JsonPropertyName("cto")]
    public string Cto { get; set; }

    [JsonPropertyName("coo")]
    public string Coo { get; set; }

    [JsonPropertyName("cto_propulsion")]
    public string CtoPropulsion { get; set; }

    [JsonPropertyName("valuation")]
    public long Valuation { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

