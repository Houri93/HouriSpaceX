using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouriSpaceX.Dtos;
public sealed class LinksDto
{
    public string Website { get; set; }
    public string Flickr { get; set; }
    public string Twitter { get; set; }
    public string ElonTwitter { get; set; }
}
