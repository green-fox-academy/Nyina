using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenfoxStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GreenfoxStore.Controllers
{
    [Route("")]
    public class GreenfoxWebshopController : Controller
    {
        private GreenfoxWebshopRepository greenfoxWebshopRepository;

        public GreenfoxWebshopController(GreenfoxWebshopRepository greenfoxWebshopRepository)
        {
            this.greenfoxWebshopRepository = greenfoxWebshopRepository;
        }

        [HttpGet("warehouse")]
        public IActionResult Index()
        {
            return View(greenfoxWebshopRepository.CreateViewModel());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary(string productName, string size, int amount)
        {
            return View(greenfoxWebshopRepository.GetSummary(productName, size, amount));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query([FromQuery]double price, string type)
        {
            return Json(new { result = "ok", clothes = greenfoxWebshopRepository.GetItemsFromQuery(price, type) });
        }
    }
}
