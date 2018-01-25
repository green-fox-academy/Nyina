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

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody]Arrays arrays)
        {
            if (arrays.What.Equals("sum"))
            {
                int result = 0;
                foreach (var element in arrays.Numbers)
                {
                    result += element;
                }
                return Json(new { result = result });
            }
            if (arrays.What.Equals("multiply"))
            {
                int result = 1;
                foreach (var element in arrays.Numbers)
                {
                    result *= element;
                }
                //a received = arrays nem kell, csak ha az objectet és what és annak értékét is ki akarom írni
                //return Json(new { received = arrays, result = result });
                return Json(new { result = result });
            }
            if (arrays.What.Equals("double"))
            {
                for (int i = 0; i < arrays.Numbers.Count(); i++)
                {
                    arrays.Numbers[i] = arrays.Numbers[i] * 2;
                }
                return Json(new { result = arrays.Numbers });
            }
            return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("/translate")]
        public IActionResult CamelIzer([FromBody]Camel camel)
        {
            if (camel.Text != null)
            {
                string[] sentence = camel.Text.Split(' ');

                foreach (var word in sentence)
                {
                    string temp =  "" ;
                    for (int i = 0; i < word.Length; i++)
                    {
                        temp += word[i];

                        if (word[i].Equals("a"))
                        {
                            string first = string.Concat(word[i], "va");
                            temp = first;
                        }
                        if (word[i].Equals("á"))
                        {
                            string second = string.Concat(word[i], "vá");
                            temp = second;
                        }
                        if (word[i].Equals("e"))
                        {
                            //string third = string.Concat(word[i], "ve");
                            string third = word[i] + "ve";
                            temp = third;
                        }
                        if (word[i].Equals("é"))
                        {
                            string fourth = string.Concat(word[i], "vé");
                            temp = fourth;
                        }
                        //else
                        //{
                        //    temp += word[i];
                        //}

                    }
                    return Json(new { translated = temp, lang = "teve" });
                }
            }
            return Json(new { error = "Avadj evegy movondavatovot!" });
        }
    }
}
