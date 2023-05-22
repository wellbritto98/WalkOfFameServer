using Microsoft.EntityFrameworkCore;

namespace WalkOfFameServer.Database.Seeds
{
    public abstract class BaseSeeder
    {
        protected readonly ModelBuilder _modelBuilder;

        protected BaseSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public abstract void Seed();
    }
}
