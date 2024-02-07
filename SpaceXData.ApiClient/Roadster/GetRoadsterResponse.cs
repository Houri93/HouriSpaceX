using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Roadster;
public sealed class GetRoadsterResponse
{
    [JsonPropertyName("flickr_images")]
    public string[] FlickrImages { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("launch_date_utc")]
    public DateTime LaunchDateUtc { get; set; }

    [JsonPropertyName("launch_date_unix")]
    public int LaunchDateUnix { get; set; }

    [JsonPropertyName("launch_mass_kg")]
    public int LaunchMassKg { get; set; }

    [JsonPropertyName("launch_mass_lbs")]
    public int LaunchMassLbs { get; set; }

    [JsonPropertyName("norad_id")]
    public int NoradId { get; set; }

    [JsonPropertyName("epoch_jd")]
    public double EpochJd { get; set; }

    [JsonPropertyName("orbit_type")]
    public string OrbitType { get; set; }

    [JsonPropertyName("apoapsis_au")]
    public double ApoapsisAu { get; set; }

    [JsonPropertyName("periapsis_au")]
    public double PeriapsisAu { get; set; }

    [JsonPropertyName("semi_major_axis_au")]
    public double SemiMajorAxisAu { get; set; }

    [JsonPropertyName("eccentricity")]
    public double Eccentricity { get; set; }

    [JsonPropertyName("inclination")]
    public double Inclination { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("periapsis_arg")]
    public double PeriapsisArg { get; set; }

    [JsonPropertyName("period_days")]
    public double PeriodDays { get; set; }

    [JsonPropertyName("speed_kph")]
    public double SpeedKph { get; set; }

    [JsonPropertyName("speed_mph")]
    public double SpeedMph { get; set; }

    [JsonPropertyName("earth_distance_km")]
    public double EarthDistanceKm { get; set; }

    [JsonPropertyName("earth_distance_mi")]
    public double EarthDistanceMi { get; set; }

    [JsonPropertyName("mars_distance_km")]
    public double MarsDistanceKm { get; set; }

    [JsonPropertyName("mars_distance_mi")]
    public double MarsDistanceMi { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }

    [JsonPropertyName("video")]
    public string Video { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

