using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Launchpads;
public sealed class GetAllLaunchpadsResponse
{
    public Launchpad[] Launchpads { get; set; }
}

