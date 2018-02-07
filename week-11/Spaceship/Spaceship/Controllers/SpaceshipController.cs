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

        [HttpPost("/movehere/{id}")]
        public IActionResult Add(long id)
        {
            spaceshipRepository.AddNewPlanet(id);
            return Redirect("");
        }

        [HttpGet("/toship/{id}")]
        public IActionResult MoveShip([FromRoute]long id)
        {
            spaceshipRepository.MoveToTheShip(id);
            return Redirect("");
        }

        [HttpGet("/toplanet/{id}")]
        public IActionResult MovePlanet([FromRoute]long id)
        {
            spaceshipRepository.MoveToPlanet(id);
            return Redirect("/");
        }
    }
}
