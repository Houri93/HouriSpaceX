using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Launches;
public sealed class GetAllLaunchesResponse
{
    public Launche[] Launches { get; set; }
}

