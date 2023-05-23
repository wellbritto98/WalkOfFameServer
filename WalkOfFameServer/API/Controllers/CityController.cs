using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class CityController : CoreController
    {
        private CityService _cityService;
        private ZoneService _zoneService;

        public CityController(UserService service, CityService cityService, ZoneService zoneService) : base(service)
        {
            _cityService = cityService;
            _zoneService = zoneService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var city = await _cityService.GetById(id);

            if (city == null) return NotFound();

            return Ok(new { data = city });
        }
        
        [HttpGet("{id}/Zones")]
        public async Task<IActionResult> GetZonesById(long id)
        {
            var zones = await _zoneService.GetAllByCityId(id);

            return Ok(new { data = zones });
        }
    }
}
