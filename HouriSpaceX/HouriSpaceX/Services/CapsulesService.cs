using HouriSpaceX.Dtos;

using Riok.Mapperly.Abstractions;

using SpaceXData.ApiClient;
using SpaceXData.ApiClient.Capsules;

namespace HouriSpaceX.Server.Services;

public sealed class CapsulesService(ILogger<CapsulesService> logger, SpaceXDataApiClient apiClient, CapsuleMapper capsuleMapper)
{
    public async Task<CapsuleDto[]> GetAllAsync()
    {
        var response = await apiClient.GetAllCapsulesAsync();
        return response.Capsules.Select(capsuleMapper.ToDto).ToArray();
    }
}

[Mapper]
public partial class CapsuleMapper
{
    public partial CapsuleDto ToDto(Capsule capsule);

}