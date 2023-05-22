using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WalkOfFameServer.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class UserController : CoreController
    {
        [HttpGet, Authorize]
        public async Task<IActionResult> Test()
        {
            return Ok();
        }
    }
}
