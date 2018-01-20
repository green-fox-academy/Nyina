using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayHelloToAllTheWorld.Models;

namespace SayHelloToAllTheWorld.Controllers
{
    [Route("/")]
    public class SayHelloController : Controller
    {
        private SayHelloModel sayHelloModel;

        public SayHelloController(SayHelloModel sayHelloModel)
        {
            this.sayHelloModel = sayHelloModel;
        }

        public IActionResult Hello()
        {
            //mivel a Hello mehod név és a View neve nem egyezik, ezért a return View ()-be
            //meg kell adni stringként a View nevét
            //a dinamikus adatokat is meg kell adni
            return View("SayHelloView", sayHelloModel);
        }
    }
}
