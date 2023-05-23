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
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var character = await _characterService.GetById(id);

            if (character == null) return NotFound();

            return Ok(new { data = character });
        }
        
        [HttpPost, Authorize]
        public async Task<IActionResult> Create([FromBody] CreateCharacterRequest request)
        {
            var cityCheck = await _cityService.GetById(request.CityId);

            if (cityCheck == null) return NotFound();

            var character = await _characterService.Create(new Character {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Gender = request.Gender,
                BirthCity = cityCheck,
                CurrentLocation = cityCheck.DefaultLocation,
                User = await GetCurrentUser()
            });

            return Ok(new { data = character });
        }
        
        [HttpGet, Authorize]
        public async Task<IActionResult> GetCurrentUserCharacters()
        {
            var currentUserId = GetCurrentUserId();

            if (!currentUserId.HasValue) return Unauthorized();
            
            var characters = await _characterService.GetAllByUserId(currentUserId.Value);

            return Ok(new { data = characters });
        }
    }
}
