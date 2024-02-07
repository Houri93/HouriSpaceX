using HouriSpaceX.Dtos;
using HouriSpaceX.Server.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Controllers;

[ApiController]
[Route("api/v1/company")]
//[Authorize]
public sealed class CompanyController(CompanyService companyService) : ControllerBase
{
    [HttpGet]
    public async Task<CompanyDto> Get()
    {
        return await companyService.GetAsync();
    }
}
