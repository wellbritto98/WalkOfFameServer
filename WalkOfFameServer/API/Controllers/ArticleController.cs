using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class ArticleController : CoreController
    {
        private ArticleService _articleService;

        public ArticleController(UserService service, ArticleService articleService) : base(service)
        {
            _articleService = articleService;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok();
        }
    }
}
