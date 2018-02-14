using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spaceship.Viewmodels;
using Spaceship.Repositories;

namespace Spaceship.Controllers
{
    [Route("")]
    public class SpaceshipController : Controller
    {
        private SpaceshipRepository spaceshipRepository;

        public SpaceshipController(SpaceshipRepository spaceshipRepository)
        {
            this.spaceshipRepository = spaceshipRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index", spaceshipRepository.GetAllPlanetsAndShip());
        }

        [HttpPost("movehere/{id}")]
        public IActionResult Add([FromRoute]int id)
        {
            spaceshipRepository.AddNewPlanet(id);
            return RedirectToAction("Index");
        }

        [HttpGet("toship/{id}")]
        public IActionResult MoveShip([FromRoute]int id)
        {
            spaceshipRepository.MoveToTheShip(id);
            return RedirectToAction("Index");
        }

        [HttpGet("toplanet/{id}")]
        public IActionResult MovePlanet([FromRoute]int id)
        {
            spaceshipRepository.MoveToPlanet(id);
            return RedirectToAction("Index");
        }
    }
}
