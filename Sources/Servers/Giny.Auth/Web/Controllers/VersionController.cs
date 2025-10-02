using Microsoft.AspNetCore.Mvc;

namespace Giny.Auth.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet]
    [Route("launcher")]
    public string GetLauncherVersion()
    {
        return "1.0.0";
    }
}