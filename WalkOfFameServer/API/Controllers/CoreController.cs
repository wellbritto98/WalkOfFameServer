using Microsoft.AspNetCore.Mvc;

namespace WalkOfFameServer.API.Controllers
{
    public class CoreController : ControllerBase
    {
        protected int GetCurrentUserId()
        {
            return (int)HttpContext.Items["CurrentUserId"];
        }
    }
}
