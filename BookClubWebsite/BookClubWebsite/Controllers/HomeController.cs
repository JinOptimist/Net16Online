using BookClubWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookClubWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

  
    }
}
