using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.Payloads;
public sealed class GetAllPayloadsResponse
{
    public Payload[] Payloads { get; set; }
}

