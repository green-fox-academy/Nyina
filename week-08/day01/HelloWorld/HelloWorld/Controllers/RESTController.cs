using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            //Create and pass a Greeting object when it is called 
            //like this return new JsonResult(Object)
            var hello = new Greetings(name);
            return new JsonResult(hello);
        }
    }
}
