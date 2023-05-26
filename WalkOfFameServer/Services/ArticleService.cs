using IdGen;
using WalkOfFameServer.Database;

namespace WalkOfFameServer.Services
{
    public class ArticleService
    {
        private readonly MainDbContext _context;
        private readonly IdGenerator _idGenerator;
        
        public ArticleService(MainDbContext context, IdGenerator idGenerator)
        {
            _context = context;
            _idGenerator = idGenerator;
        }
    }
}
