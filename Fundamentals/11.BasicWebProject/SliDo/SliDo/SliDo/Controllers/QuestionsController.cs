using Microsoft.AspNetCore.Mvc;
using SliDo.Data;
using SliDo.Data.Migrations;
using SliDo.Models.Questions;

namespace SliDo.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public QuestionsController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var question = _dbContext.Questions.FirstOrDefault(x => x.Id == id);
            question.IsAnswered = true;

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        
        [HttpPost]
        public IActionResult Create(CreateQuestionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            this._dbContext.Questions.Add(new Question(request.Author, request.Text));
            this._dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
