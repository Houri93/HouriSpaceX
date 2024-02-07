using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class SecondStage
{
    [JsonPropertyName("thrust")]
    public Thrust Thrust { get; set; }

    [JsonPropertyName("payloads")]
    public Payloads Payloads { get; set; }

    [JsonPropertyName("reusable")]
    public bool Reusable { get; set; }

    [JsonPropertyName("engines")]
    public int Engines { get; set; }

    [JsonPropertyName("fuel_amount_tons")]
    public int FuelAmountTons { get; set; }

    [JsonPropertyName("burn_time_sec")]
    public int BurnTimeSec { get; set; }
}

