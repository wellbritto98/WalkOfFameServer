using System.Threading.Tasks;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Services
{
    public class LocationService
    {
        private readonly MainDbContext _context;
        
        public LocationService(MainDbContext context)
        {
            _context = context;
        }
        
        public async Task<Location?> GetById(long id)
        {
            return await _context.Locations.FindAsync(id);
        }
    }
}
