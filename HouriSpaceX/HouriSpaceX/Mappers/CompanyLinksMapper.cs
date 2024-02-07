using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class CompanyLinksMapper
{
    public partial LinksDto ToDto(Links  company);

}