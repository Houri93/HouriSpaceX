using HouriSpaceX.Dtos;

using SpaceXData.ApiClient;
using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Services;

public sealed class CompanyService(ILogger<CompanyService> logger, SpaceXDataApiClient apiClient, CompanyMapper companyMapper)
{
    public async Task<CompanyDto> GetAsync()
    {
        var company = await apiClient.GetCompanyAsync();
        var dto = companyMapper.ToDto(company);
        return dto;
    }
}
