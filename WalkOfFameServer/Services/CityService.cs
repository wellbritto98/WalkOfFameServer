using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        
        public async Task<City?> GetById(long id)
        {
            return await _context.Cities
                .Include(c => c.DefaultLocation)
                .Include(c => c.Country)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task Save(City city)
        {
            _context.Update(city);
            await _context.SaveChangesAsync();
        }
    }
}
