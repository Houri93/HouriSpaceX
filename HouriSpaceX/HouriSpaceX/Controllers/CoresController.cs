using HouriSpaceX.Dtos;
using HouriSpaceX.Server.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SpaceXData.ApiClient.Company;

namespace HouriSpaceX.Server.Controllers;

[ApiController]
[Route("api/v1/cores")]
//[Authorize]
public sealed class CoresController(CoresService coresService) : ControllerBase
{
    [HttpGet]
    public async Task<CoresDto[]> Get()
    {
        return await coresService.GetAllAsync();
    }
}
