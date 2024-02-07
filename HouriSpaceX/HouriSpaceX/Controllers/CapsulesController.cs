using HouriSpaceX.Server.Services;

using Microsoft.AspNetCore.Mvc;

namespace HouriSpaceX.Server.Controllers;

[ApiController]
[Route("{controller}/{action}")]
public sealed class CapsulesController(CapsulesService capsulesService) : ControllerBase
{

}
