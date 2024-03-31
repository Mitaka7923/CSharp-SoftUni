using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>()
            {
                new Question("Will this be on the exam?", "Georgi123"),
                new Question("How am I doing with coding so far?", "Dimitrichko"),
                new Question("Am I stupid?", "Ivancho57"),
                new Question("Will this be on the exam?", "dsideriss")
            };

            return View(questions); 
        }
    }
}
