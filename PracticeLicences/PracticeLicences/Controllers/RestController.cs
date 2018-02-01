using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeLicences.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PracticeLicences.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private LicencesRepository licencesRepository;

        public RestController(LicencesRepository licencesRepository)
        {
            this.licencesRepository = licencesRepository;
        }

        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = licencesRepository.GetBrand(brand) });
        }
    }
}
