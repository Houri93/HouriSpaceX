using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Capsules;
using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class CompanyMapper
{
    public partial CompanyDto ToDto(Company  company);

}
