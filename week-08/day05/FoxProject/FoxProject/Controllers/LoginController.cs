using Microsoft.AspNetCore.Mvc;
using FoxProject.Models;
using FoxProject.Viewmodels;


namespace FoxProject.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        private Fox fox;

        public LoginController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult RecieveName(string foxName)
        {
            fox.Name = foxName;
            return Redirect("/home");
            //return name.Equals("Laci") ? Redirect("/game") : Redirect("/");
        }
    }
}
