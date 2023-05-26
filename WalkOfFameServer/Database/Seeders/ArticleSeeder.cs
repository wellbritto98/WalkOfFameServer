using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database.Seeds;

namespace WalkOfFameServer.Database.Seeders
{
    public class ArticleSeeder : BaseSeeder
    {
        public ArticleSeeder(ModelBuilder modelBuilder, IdGenerator idGenerator) : base(modelBuilder, idGenerator)
        {}
        
        public override void Seed()
        {}
    }
}
