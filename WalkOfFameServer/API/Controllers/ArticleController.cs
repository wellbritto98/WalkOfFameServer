using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WalkOfFameServer.Models;
using WalkOfFameServer.Services;

namespace WalkOfFameServer.API.Controllers
{
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var article = await _articleService.GetById(id);
            if (article == null)
                return NotFound();

            return Ok(new { data = article });
        }
    }
}
