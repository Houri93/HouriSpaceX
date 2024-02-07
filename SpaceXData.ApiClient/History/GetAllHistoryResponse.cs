using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXData.ApiClient.History;
public sealed class GetAllHistoryResponse
{
    public History[] HistoryItems { get; set; }
}
