using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouriSpaceX.Dtos;
public sealed class CrewDto
{
    public string Name { get; set; }

    public string Agency { get; set; }

    public string Image { get; set; }

    public string Wikipedia { get; set; }

    public string[] Launches { get; set; }

    public string Status { get; set; }

}
