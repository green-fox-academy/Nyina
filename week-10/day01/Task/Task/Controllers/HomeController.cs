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
        public IActionResult Doubling(int? id)
        {
            if (id == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { recieved = id, result = id * 2 });
            }
        }
    }
}
