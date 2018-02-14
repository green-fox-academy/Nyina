using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spaceship.Entities;
using Spaceship.Viewmodels;
using Spaceship.Models;

namespace Spaceship.Repositories
{
    public class SpaceshipRepository
    {
        private SpaceshipContext spaceshipContext;

        public SpaceshipRepository(SpaceshipContext spaceshipContext)
        {
            this.spaceshipContext = spaceshipContext;
        }

        public SpaceshipViewmodel GetAllPlanetsAndShip()
        {
            SpaceshipViewmodel spaceTransporterViewmodel = new SpaceshipViewmodel
            {
                Planets = GetAllPlanets(),
                Spaceship = GetShip()
            };
            return spaceTransporterViewmodel;
        }

        public List<Planet> GetAllPlanets()
        {
            return spaceshipContext.Planets.ToList();
        }

        public SpaceShip GetShip()
        {
            return spaceshipContext.Spaceships.First();
        }

        public Planet GetAPlanet(long id)
        {
            return spaceshipContext.Planets.FirstOrDefault(x => x.Id == id);
        }

        public void AddNewPlanet(int id)
        {
            if (!GetShip().Planet.Equals(GetAPlanet(id).Name))
            {
                GetShip().Planet = GetAPlanet(id).Name;
                spaceshipContext.SaveChanges();
            }
        }

        public void MoveToTheShip(int id)
        {
            SpaceShip spaceship = new SpaceShip();
            var filteredPlanet = GetAPlanet(id);

            if (spaceship.MaxCapacity > spaceship.Utilization)
            {
                var Capacity = spaceship.MaxCapacity - spaceship.Utilization;
                filteredPlanet.Population = filteredPlanet.Population - Capacity;
                spaceship.Utilization = spaceship.MaxCapacity;
            }
            else
            {
                spaceship.Utilization = spaceship.MaxCapacity;
            }
            spaceshipContext.SaveChanges();
        }

        public void MoveToPlanet(int id)
        {
            SpaceShip spaceship = new SpaceShip();
            var filteredPlanet = GetAPlanet(id);

            var peopleAmount = spaceship.Utilization;
            filteredPlanet.Population += peopleAmount;
            peopleAmount = 0;
            spaceshipContext.SaveChanges();
        }
    }
}
