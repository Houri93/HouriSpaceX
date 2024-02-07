using System.Text.Json.Serialization;

namespace HouriSpaceX.Dtos;

public sealed class CapsuleDto
{
    public int ReuseCount { get; set; }
    public int WaterLandings { get; set; }
    public int LandLandings { get; set; }
    public string LastUpdate { get; set; }
    public string[] Launches { get; set; }
    public string Serial { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
}
