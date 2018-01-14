using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxProject.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace FoxProject.Controllers
{
    [Route("/nutritionStore")]
    public class FoxController : Controller
    {
        
            private FoxViewModel foxVM;

            public FoxController(FoxViewModel foxVM)
            {
                this.foxVM = foxVM;
            }

            [HttpGet("{foxName}")]
            public IActionResult Index(string foxName)
            {
                var fox = foxVM.FoxList.FirstOrDefault(c => c.Name == foxName);
                return View(fox);
            }

            [HttpPost("changenutrition/{foxName}")]
            public ActionResult ChangeNutrition(string food, string drink, string foxName)
            {
                foreach (var Item in foxVM.FoxList)
                {
                    if (Item.Name.Equals(foxName))
                    {
                        Item.Drink = drink;
                        Item.Food = food;
                    }
                }
                return Redirect($"/home/{foxName}");
            }
    }
}
