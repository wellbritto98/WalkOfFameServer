using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.API.Dtos.Outgoing.User;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class UserController : CoreController
    {
        private readonly IMapper _mapper;

        public UserController(UserService service, IMapper mapper) : base(service)
        {
            _mapper = mapper;
        }
        
        [HttpGet, Authorize]
        public async Task<IActionResult> Get()
        {
            var currentUser = await GetCurrentUser();

            if (currentUser == null) return Unauthorized();
            
            return Ok(new {
                data = _mapper.Map<UserDto>(currentUser)
            });
        }
    }
}
