using Microsoft.AspNetCore.Mvc;
using FoxProject.Viewmodels;


namespace FoxProject.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        private FoxViewModel foxVM;

        public LoginController(FoxViewModel foxVM)
        {
            this.foxVM = foxVM;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult RecieveName(string foxName)
        {
            foreach (var oneFox in foxVM.FoxList)
            {
                oneFox.Name = foxName;
            }
            return Redirect($"/home/{foxName}");
            //return name.Equals("Laci") ? Redirect("/game") : Redirect("/");
        }
    }
}
