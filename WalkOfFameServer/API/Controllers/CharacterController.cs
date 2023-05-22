using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.API.Dtos.Incoming.Character;
using WalkOfFameServer.Models.Characters;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class CharacterController : CoreController
    {
        private readonly CityService _cityService;
        private readonly CharacterService _characterService;
        public CharacterController(UserService service, CityService cityService, CharacterService characterService) : base(service)
        {
            _cityService = cityService;
            _characterService = characterService;
        }
        
        [HttpPost, Authorize]
        public async Task<IActionResult> Create([FromBody] CreateCharacterRequest request)
        {
            var cityCheck = await _cityService.GetById(request.CityId);

            if (cityCheck == null) return NotFound();

            var character = _characterService.Create(new Character {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                BirthCity = cityCheck,
                User = await GetCurrentUser()
            });

            return Ok();
        }
    }
}
