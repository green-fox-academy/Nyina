using Microsoft.AspNetCore.Mvc;
using FoxProject.Models;
using FoxProject.Viewmodels;

namespace FoxProject.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private Fox fox;

        public HomeController (Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(fox);
        }

    }
}
