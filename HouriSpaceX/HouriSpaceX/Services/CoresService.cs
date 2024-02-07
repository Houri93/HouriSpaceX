using HouriSpaceX.Dtos;

using SpaceXData.ApiClient;

namespace HouriSpaceX.Server.Services;

public sealed class CoresService(ILogger<CapsulesService> logger, SpaceXDataApiClient apiClient, CoresMapper coresMapper)
{
    public async Task<CoresDto[]> GetAllAsync()
    {
        var cores = await apiClient.GetAllCoresAsync();
        return cores.Select(coresMapper.ToDto).ToArray();
    }
}
