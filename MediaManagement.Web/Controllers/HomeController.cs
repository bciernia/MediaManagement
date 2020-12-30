using MediaManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Movie> list = new List<Movie>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowAllMedia()
        {
            list.Add(new Movie { Id = 1, Name = "Fast and furious",  ReleaseYear = 2010, Creator = "First", Type = "Action", IsWatched = true, IsFavourite = false });
            list.Add(new Movie { Id = 2, Name = "Killer",  ReleaseYear = 2020, Creator = "Second", Type = "Comedy", IsWatched = false, IsFavourite=false });
            list.Add(new Movie { Id = 3, Name = "Frozen",  ReleaseYear = 2015, Creator = "Third", Type = "Cartoon", IsWatched= true, IsFavourite=true});

            return View(list);
        }

        public IActionResult AddNew()
        {
            return View();
        }

        public IActionResult Edit(Movie movie)
        {
            return View(movie);
        }

        public IActionResult Details(Movie movie)
        {
            return View(movie);
        }

        public IActionResult Delete(Movie movie)
        {
            return View(movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
