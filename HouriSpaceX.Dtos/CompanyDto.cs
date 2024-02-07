using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HouriSpaceX.Dtos;
public sealed class CompanyDto
{
    public HeadquartersDto Headquarters { get; set; }

    public LinksDto Links { get; set; }

    public string Name { get; set; }

    public string Founder { get; set; }
    public int Founded { get; set; }

    public int Employees { get; set; }

    public int Vehicles { get; set; }

    public int LaunchSites { get; set; }

    public int TestSites { get; set; }

    public string Ceo { get; set; }

    public string Cto { get; set; }

    public string Coo { get; set; }

    public string CtoPropulsion { get; set; }

    public long Valuation { get; set; }

    public string Summary { get; set; }
}

