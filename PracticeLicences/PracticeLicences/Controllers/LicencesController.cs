using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeLicences.Models;
using PracticeLicences.Repositories;

namespace PracticeLicences.Controllers
{
    [Route("")]
    public class LicencesController : Controller
    {
        private LicencesRepository licencesRepository;

        public LicencesController(LicencesRepository licencesRepository)
        {
            this.licencesRepository = licencesRepository;
        }

        [HttpGet("search")]
        public IActionResult SearchItems([FromQuery]Search search)
        {
            return View("Search", licencesRepository.GetSearchedItems(search));
        }

        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return View("Search", licencesRepository.GetBrand(brand));
        }
    }
}
