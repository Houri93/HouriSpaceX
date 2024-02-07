using HouriSpaceX.Dtos;
using HouriSpaceX.Server.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouriSpaceX.Server.Controllers;

[ApiController]
[Route("api/v1/capsules")]
[Authorize]
public sealed class CapsulesController(CapsulesService capsulesService) : ControllerBase
{
    [HttpGet]
    public async Task<CapsuleDto[]> GetAll()
    {
        return await capsulesService.GetAllAsync();
    }
}
