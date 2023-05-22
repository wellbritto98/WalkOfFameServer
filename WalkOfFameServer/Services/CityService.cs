using System;
using System.Threading.Tasks;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Services
{
    public class CityService
    {
        private readonly MainDbContext _context;
        
        public CityService(MainDbContext context)
        {
            _context = context;
        }
        
        public async Task<City?> GetById(Guid id)
        {
            return await _context.Cities.FindAsync(id);
        }
    }
}
