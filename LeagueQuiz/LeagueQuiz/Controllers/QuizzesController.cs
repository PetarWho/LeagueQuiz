using Microsoft.AspNetCore.Mvc;

namespace LeagueQuiz.Controllers
{
    public class QuizzesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
