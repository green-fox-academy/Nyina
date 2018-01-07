using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        // Itt az URL ez lesz: HelloWorld/ --> mert a Controller neve HelloWorld és nem kell az Index-et odaírni, mert az default
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // GET: /HelloWorld/Welcome/ 
        //Tehát ha fent az Index helyett HelloWorld-öt írtam volna, akkor ott /HelloWorld/HelloWorld/ lenne az URL 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        public string Welcome(string name, string secondName, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes + ", Second name is: " + secondName);
        }

        public ActionResult ViewResult()
        {
            return View();
        }
    }
}