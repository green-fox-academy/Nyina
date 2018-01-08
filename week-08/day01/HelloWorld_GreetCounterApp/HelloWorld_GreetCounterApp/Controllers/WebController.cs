using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld_GreetCounterApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greetings()
            {
                Id = 1,
                Content = "World"
            };

            return View(greeting);
        }

    }
}
