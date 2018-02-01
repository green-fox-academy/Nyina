using Microsoft.AspNetCore.Mvc;
using PracticeWebshop.Repositories;

namespace PracticeWebshop.Controllers
{
    [Route("")]
    public class WebshopController : Controller
    {
        private WebshopRepository webshopRepository;

        public WebshopController(WebshopRepository webshopRepository)
        {
            this.webshopRepository = webshopRepository;
        }

        [HttpGet("warehouse")]
        public IActionResult Index()
        {
            return View(webshopRepository.CreateAViewmodel());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary(string product, string size, int amount)
        {
            return View(webshopRepository.ShowSummary(product, size, amount));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query([FromQuery]double price, string type)
        {
            return Json(new { result = "ok", clothes = webshopRepository.GetItemsFromQuery(price, type) });
        }
    }
}
