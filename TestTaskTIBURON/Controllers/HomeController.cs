using Microsoft.AspNetCore.Mvc;
using TestTaskTIBURON.DB;

namespace TestTaskTIBURON.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        SurveyDbContext db;

        public HomeController(SurveyDbContext Db)
        {
            db = Db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
