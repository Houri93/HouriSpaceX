using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient.Capsules;

namespace HouriSpaceX.Server.Services;

[Mapper]
public partial class CapsuleMapper
{
    public partial CapsuleDto ToDto(Capsule capsule);
}