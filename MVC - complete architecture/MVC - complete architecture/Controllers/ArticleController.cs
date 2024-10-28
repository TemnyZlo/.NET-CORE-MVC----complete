using Microsoft.AspNetCore.Mvc;
using MVC___complete_architecture.Models;
using MVC___complete_architecture.Repository;

namespace MVC___complete_architecture.Controllers
{
    public class ArticleController : Controller
    {

        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplayArticles(int id)
        {
            IEnumerable<Article> articles = _articleRepository.GetArticlesByTutorialId(id);
            return View(articles);
        }
    }
}
