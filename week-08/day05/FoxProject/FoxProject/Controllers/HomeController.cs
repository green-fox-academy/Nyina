using Microsoft.AspNetCore.Mvc;
using FoxProject.Viewmodels;
using System.Linq;

namespace FoxProject.Controllers
{
    [Route("/home/{foxName}")]
    public class HomeController : Controller
    {
        private FoxViewModel foxVM;

        public HomeController(FoxViewModel foxVM)
        {
            this.foxVM = foxVM;
        }

        [Route("")]
        public IActionResult Index(string foxName)
        {
            var fox = foxVM.FoxList.First(x => x.Name == foxName);
            return View("home");
            //return View("home");
        }
    }
}


