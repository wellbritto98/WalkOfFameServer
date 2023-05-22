using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.API.Dtos.Outgoing.User;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class UserController : CoreController
    {
        private readonly UserService _service;
        private readonly IMapper _mapper;

        public UserController(UserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet, Authorize]
        public async Task<IActionResult> GetCurrentUser()
        {
            var currentId = GetCurrentUserId();
            
            if (!currentId.HasValue) return Unauthorized();
            
            var user = await _service.GetById(currentId.Value);

            if (user == null) return Unauthorized();
            
            return Ok(new {
                data = _mapper.Map<UserDto>(user)
            });
        }
    }
}
