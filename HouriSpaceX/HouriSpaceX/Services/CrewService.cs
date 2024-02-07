using HouriSpaceX.Dtos;

using SpaceXData.ApiClient;

namespace HouriSpaceX.Server.Services;

public sealed class CrewService(ILogger<CrewService> logger, SpaceXDataApiClient apiClient, CrewMapper crewMapper)
{
    public async Task<CrewDto[]> GetAllAsync()
    {
        var crew = await apiClient.GetAllCrewAsync();
        return crew.Select(crewMapper.ToDto).ToArray();
    }
}
