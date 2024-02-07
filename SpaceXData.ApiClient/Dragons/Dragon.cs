using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Dragons;

public sealed class Dragon
{
    [JsonPropertyName("heat_shield")]
    public HeatShield HeatShield { get; set; }

    [JsonPropertyName("launch_payload_mass")]
    public LaunchPayloadMass LaunchPayloadMass { get; set; }

    [JsonPropertyName("launch_payload_vol")]
    public LaunchPayloadVol LaunchPayloadVol { get; set; }

    [JsonPropertyName("return_payload_mass")]
    public ReturnPayloadMass ReturnPayloadMass { get; set; }

    [JsonPropertyName("return_payload_vol")]
    public ReturnPayloadVol ReturnPayloadVol { get; set; }

    [JsonPropertyName("pressurized_capsule")]
    public PressurizedCapsule PressurizedCapsule { get; set; }

    [JsonPropertyName("trunk")]
    public Trunk Trunk { get; set; }

    [JsonPropertyName("height_w_trunk")]
    public HeightWTrunk HeightWTrunk { get; set; }

    [JsonPropertyName("diameter")]
    public Diameter Diameter { get; set; }

    [JsonPropertyName("first_flight")]
    public string FirstFlight { get; set; }

    [JsonPropertyName("flickr_images")]
    public List<string> FlickrImages { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("crew_capacity")]
    public int CrewCapacity { get; set; }

    [JsonPropertyName("sidewall_angle_deg")]
    public int SidewallAngleDeg { get; set; }

    [JsonPropertyName("orbit_duration_yr")]
    public int OrbitDurationYr { get; set; }

    [JsonPropertyName("dry_mass_kg")]
    public int DryMassKg { get; set; }

    [JsonPropertyName("dry_mass_lb")]
    public int DryMassLb { get; set; }

    [JsonPropertyName("thrusters")]
    public List<Thruster> Thrusters { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}
