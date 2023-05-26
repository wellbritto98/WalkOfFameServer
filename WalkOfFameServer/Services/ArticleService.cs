using System.Threading.Tasks;
using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models;
using WalkOfFameServer.Models.Characters;

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

        public async Task<Article?> GetById(long id)
        {
            return await _context.Articles
                .Include(a => a.Contents)
                .SingleOrDefaultAsync(a => a.Id == id);
        }


        public async Task<Article> Create(Article article)
        {
            article.Id = _idGenerator.CreateId();
            await _context.AddAsync(article);
            await _context.SaveChangesAsync();
            return article;
        }

    }
}
