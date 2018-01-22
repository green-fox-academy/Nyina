using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Task.Model;

namespace Task.Controllers
{
    [Route("")]
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
            return Json(new { welcome_message = string.Format("Oh, hi there {0}, my dear {1}!", name, title) });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return Json(new { myword = appendable + "a" });
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]Num Num)
        {
            if (Num.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what.Equals("sum"))
            {
                int numSum = 0;

                for (int i = 0; i < Num.Until + 1; i++)
                {
                    numSum += i;
                }
                return Json(new { received = Num.Until, result = numSum });
            }
            if (what.Equals("factor"))
            {
                int factorial = 1;

                for (int i = 1; i < Num.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { received = Num.Until, result = factorial });
            }
            return NotFound();
        }

        [HttpPost("/arrays/{what}")]
        public IActionResult Arrays([FromBody]string what, [FromBody]Arrays arrays)
        {
            if (what.Equals("sum"))
            {
                int result = 0;
                foreach (var element in arrays.Numbers)
                {
                    result += element;
                }
                return Json(new { result = result });
            }
            if (what.Equals("multiply"))
            {
                int result = 1;
                foreach (var element in arrays.Numbers)
                {
                    result *= element;
                }
                return Json(new { result = result });
            }
            if (what.Equals("double"))
            {
                int[] result = { 0 };
                for (int i = 0; i < arrays.Numbers.Count(); i++)
                {
                    arrays.Numbers[i] =  arrays.Numbers[i] * 2;
                }
                return Json(new { result = arrays.Numbers });
            }
            //return NotFound();
            return Json(new { error = "Please provide a number!" });
        }
    }
}
