using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarLicences.Repositories;
using CarLicences.Models;

namespace CarLicences.Controllers
{
    [Route("")]
    public class LicencePlatesController : Controller
    {
        private LicencePlatesRepository licencePlatesRepository;

        public LicencePlatesController(LicencePlatesRepository licencePlatesRepository)
        {
            this.licencePlatesRepository = licencePlatesRepository;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]SearchModel searchModel)
        {
            return View(licencePlatesRepository.GetFilteredItems(searchModel));
        }

        [HttpGet ("search/{brand}")]
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return View("Search", licencePlatesRepository.GetBrand(brand));
        }

    }
}

