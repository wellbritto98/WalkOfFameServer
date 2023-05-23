using IdGen;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WalkOfFameServer.Database.Seeders;
using WalkOfFameServer.Models.Characters;
using WalkOfFameServer.Models.Cities;
using WalkOfFameServer.Models.Companies;
using WalkOfFameServer.Models.Users;

namespace WalkOfFameServer.Database
{
    public class MainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        protected readonly IdGenerator IdGenerator;

        public MainDbContext(IConfiguration configuration, IdGenerator idGenerator)
        {
            Configuration = configuration;
            IdGenerator = idGenerator;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CitySeeder(modelBuilder, IdGenerator).Seed();
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
