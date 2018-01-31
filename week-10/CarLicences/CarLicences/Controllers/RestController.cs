using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarLicences.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarLicences.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private LicencePlatesRepository licencePlatesRepository;

        public RestController(LicencePlatesRepository licencePlatesRepository)
        {
            this.licencePlatesRepository = licencePlatesRepository;
        }

        [HttpGet("search/{brand}")]
        public IActionResult Search([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = licencePlatesRepository.GetBrand(brand) });
        }

    }
}
