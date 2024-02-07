using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Capsules;
using SpaceXData.ApiClient.Cores;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class CoresMapper
{
    public partial CoresDto ToDto(Core core);
}