using Microsoft.AspNetCore.Mvc;
using SliDo.Data;
using SliDo.Models;
using SliDo.Models.Home;
using System.Diagnostics;

namespace SliDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public HomeController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var questions = this._dbContext.Questions.Where(x => !x.IsAnswered)
                .OrderBy(x => x.Created)
                .Select(x => new IndexViewModel(x.Id, x.Author, x.Text))
                .ToList();

            return View(questions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
