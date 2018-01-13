using Microsoft.AspNetCore.Mvc;
using FoxProject.Viewmodels;
using System.Linq;

namespace FoxProject.Controllers
{
    [Route("/home{foxName}")]
    public class HomeController : Controller
    {
        private FoxViewModel foxVM;

        public HomeController(FoxViewModel foxVM)
        {
            this.foxVM = foxVM;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(foxVM);
        }
    }
}


