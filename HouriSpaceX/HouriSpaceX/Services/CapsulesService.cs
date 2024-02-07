using HouriSpaceX.Dtos;

using SpaceXData.ApiClient;

namespace HouriSpaceX.Server.Services;

public sealed class CapsulesService(ILogger<CapsulesService> logger, SpaceXDataApiClient apiClient, CapsuleMapper capsuleMapper)
{
    public async Task<CapsuleDto[]> GetAllAsync()
    {
        var capsules = await apiClient.GetAllCapsulesAsync();
        return capsules.Select(capsuleMapper.ToDto).ToArray();
    }
}
