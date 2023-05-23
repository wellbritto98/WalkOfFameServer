using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Services
{
    public class ZoneService
    {
        private readonly MainDbContext _context;
        
        public ZoneService(MainDbContext context)
        {
            _context = context;
        }
        
        public async Task<Zone?> GetById(long id)
        {
            return await _context.Zones.FindAsync(id);
        }
        
        public async Task<List<Zone>> GetAllByCityId(long cityId)
        {
            return await _context.Zones.Where(z => z.CityId == cityId).ToListAsync();
        }
    }
}
