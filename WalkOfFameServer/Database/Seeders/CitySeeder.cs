using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database.Seeds;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Database.Seeders
{
    public class CitySeeder : BaseSeeder
    {
        public CitySeeder(ModelBuilder modelBuilder) : base(modelBuilder)
        {}
        
        public override void Seed()
        {
            _modelBuilder.Entity<City>().HasData(
                new City() {
                    
                }
            );
        }
    }
}
