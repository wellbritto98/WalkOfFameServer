using IdGen;
using Microsoft.EntityFrameworkCore;

namespace WalkOfFameServer.Database.Seeds
{
    public abstract class BaseSeeder
    {
        protected readonly ModelBuilder ModelBuilder;
        protected readonly IdGenerator IdGenerator;

        protected BaseSeeder(ModelBuilder modelBuilder, IdGenerator idGenerator)
        {
            ModelBuilder = modelBuilder;
            IdGenerator = idGenerator;
        }

        public abstract void Seed();
    }
}
