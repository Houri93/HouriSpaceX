using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Capsules;
using SpaceXData.ApiClient.Crew;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class CrewMapper
{
    public partial CrewDto ToDto(CrewMember crew);
}