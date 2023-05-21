using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WalkOfFameServer.Models;

namespace WalkOfFameServer.Database
{
    public class MainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        
        public DbSet<User> Users { get; set; }
    }
}
