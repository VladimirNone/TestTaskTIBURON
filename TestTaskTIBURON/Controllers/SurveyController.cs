using Microsoft.AspNetCore.Mvc;
using TestTaskTIBURON.DB.Interfaces;

namespace TestTaskTIBURON.Controllers
{
    [Route("/")]
    public class SurveyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
