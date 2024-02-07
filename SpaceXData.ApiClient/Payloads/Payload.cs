using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Payloads;

public sealed class Payload
{
    [JsonPropertyName("dragon")]
    public Dragon Dragon { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("reused")]
    public bool Reused { get; set; }

    [JsonPropertyName("launch")]
    public string Launch { get; set; }

    [JsonPropertyName("customers")]
    public string[] Customers { get; set; }

    [JsonPropertyName("norad_ids")]
    public int[] NoradIds { get; set; }

    [JsonPropertyName("nationalities")]
    public string[] Nationalities { get; set; }

    [JsonPropertyName("manufacturers")]
    public string[] Manufacturers { get; set; }

    [JsonPropertyName("mass_kg")]
    public int MassKg { get; set; }

    [JsonPropertyName("mass_lbs")]
    public double MassLbs { get; set; }

    [JsonPropertyName("orbit")]
    public string Orbit { get; set; }

    [JsonPropertyName("reference_system")]
    public string ReferenceSystem { get; set; }

    [JsonPropertyName("regime")]
    public string Regime { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("semi_major_axis_km")]
    public double SemiMajorAxisKm { get; set; }

    [JsonPropertyName("eccentricity")]
    public double Eccentricity { get; set; }

    [JsonPropertyName("periapsis_km")]
    public double PeriapsisKm { get; set; }

    [JsonPropertyName("apoapsis_km")]
    public double ApoapsisKm { get; set; }

    [JsonPropertyName("inclination_deg")]
    public double InclinationDeg { get; set; }

    [JsonPropertyName("period_min")]
    public double PeriodMin { get; set; }

    [JsonPropertyName("lifespan_years")]
    public int LifespanYears { get; set; }

    [JsonPropertyName("epoch")]
    public DateTime Epoch { get; set; }

    [JsonPropertyName("mean_motion")]
    public double MeanMotion { get; set; }

    [JsonPropertyName("raan")]
    public double Raan { get; set; }

    [JsonPropertyName("arg_of_pericenter")]
    public double ArgOfPericenter { get; set; }

    [JsonPropertyName("mean_anomaly")]
    public double MeanAnomaly { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

