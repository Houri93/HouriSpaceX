using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouriSpaceX.Dtos;
public sealed class CoresDto
{
    public int Block { get; set; }

    public int ReuseCount { get; set; }

    public int RtlsAttempts { get; set; }

    public int RtlsLandings { get; set; }

    public int AsdsAttempts { get; set; }

    public int AsdsLandings { get; set; }

    public string LastUpdate { get; set; }

    public string[] Launches { get; set; }

    public string Serial { get; set; }

    public string Status { get; set; }
}
