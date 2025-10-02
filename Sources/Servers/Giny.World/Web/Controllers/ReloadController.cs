using Giny.World.Managers.Items;
using Giny.World.Managers.Maps.Npcs;
using Microsoft.AspNetCore.Mvc;

namespace Giny.World.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ReloadController : ControllerBase
{
    [Route("npcs")]
    public bool ReloadNpcs()
    {
        try
        {
            NpcsManager.Instance.Reload();
            return true;
        }
        catch
        {
            return false;
        }
    }
    [Route("items")]
    public bool ReloadItems()
    {
        try
        {
            ItemsManager.Instance.Reload();
            return true;
        }
        catch
        {
            return false;
        }
    }
}