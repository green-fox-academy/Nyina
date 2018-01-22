using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace Task.Controllers
{
    [Route ("")]
    public class HomeController : Controller
    {
        //[HttpGet ("/")]
        //public IActionResult Index()
        //{
        //    return File("index.html", "text/html");
        //}

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null && title == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            return Json(new { welcome_message = string.Format("Oh, hi there {0}, my dear {1}!", name, title)});
            }
    }
}
