using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouriSpaceX.Dtos;
public sealed class HeadquartersDto
{
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}
