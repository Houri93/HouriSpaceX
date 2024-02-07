using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Rockets;
public sealed class GetAllRocketsResponse
{
    public Rocket[]  Rockets { get; set; }
}