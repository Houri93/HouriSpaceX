using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Capsules;
public sealed class GetAllCapsulesResponse
{
    public Capsule[] Capsules { get; set; }
}
