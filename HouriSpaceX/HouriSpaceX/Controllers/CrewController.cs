using HouriSpaceX.Dtos;
using HouriSpaceX.Server.Services;

using Microsoft.AspNetCore.Mvc;

namespace HouriSpaceX.Server.Controllers;

[ApiController]
[Route("api/v1/crew")]
//[Authorize]
public sealed class CrewController(CrewService crewService) : ControllerBase
{
    [HttpGet]
    public async Task<CrewDto[]> GetAll()
    {
        return await crewService.GetAllAsync();
    }
}
