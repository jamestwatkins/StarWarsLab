using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarWarsApiPractice.Models;

namespace StarWarsApiPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SwapiDal SP = new SwapiDal();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Person p = SP.GetPerson("people", 3);
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PersonSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonSearch(int Id)
        {
            Person p = SP.GetPerson("people", Id);
            return View(p);
        }

        public IActionResult StarshipSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StarshipSearch(int Id)
        {
            Starship p = SP.GetStarship("starships", Id);
            return View(p);
        }

        public IActionResult PlanetSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlanetSearch(int Id)
        {
            Planet p = SP.GetPlanet("planets", Id);
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
