using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.API.Dtos.Incoming.Character;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class CharacterController : CoreController
    {
        private readonly CityService _cityService;
        public CharacterController(UserService service, CityService cityService) : base(service)
        {
            _cityService = cityService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCharacterRequest request)
        {
            var cityCheck = await _cityService.GetById(request.CityId);
            
            //if (cityCheck == null) 
            return Ok();
        }
    }
}
