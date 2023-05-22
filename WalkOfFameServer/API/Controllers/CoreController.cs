using System;
using Microsoft.AspNetCore.Mvc;

namespace WalkOfFameServer.API.Controllers
{
    public class CoreController : ControllerBase
    {
        protected Guid? GetCurrentUserId()
        {
            return new Guid(HttpContext.Items["CurrentUserId"]?.ToString());
        }
    }
}
