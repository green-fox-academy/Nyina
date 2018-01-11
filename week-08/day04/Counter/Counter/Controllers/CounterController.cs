using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Model;

namespace Counter.Controllers
{
    [Route("")]
    public class CounterController : Controller
    {
        private CounterModel counterModel;

        public CounterController (CounterModel counterModel)
        {
            this.counterModel = counterModel;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counterModel);
        }

        [HttpPost("add")]
        public IActionResult AddBalance()
        {
            counterModel.Number += 10;
            return RedirectToAction("Index");
        }
    }
}
