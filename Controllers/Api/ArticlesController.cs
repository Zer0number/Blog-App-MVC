using BlogApp.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        private readonly BlogContext context;
        public ArticlesController(BlogContext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<IEnumerable<Article>>> Get()
        {
            return await context.Articles.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            Article article = await context.Articles.FirstOrDefaultAsync(x => x.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }
            return article;
        }
        [HttpPost]
        public async Task<ActionResult<Article>> Post(Article article)
        {
            context.Articles.Add(article);
            await context.SaveChangesAsync();
            return Ok(article);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Article>> Delete(int id)
        {
            Article article = await context.Articles.FirstOrDefaultAsync(x => x.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }
            context.Articles.Remove(article);
            await context.SaveChangesAsync();
            return Ok(article);
        }
    }
}
