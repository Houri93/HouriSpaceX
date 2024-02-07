using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class HeadquartersMapper
{
    public partial HeadquartersDto ToDto(Headquarters  company);

}
