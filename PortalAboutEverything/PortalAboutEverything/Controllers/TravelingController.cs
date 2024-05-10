﻿using Microsoft.AspNetCore.Mvc;
using PortalAboutEverything.Data.Model;
using PortalAboutEverything.Data.Repositories;
using PortalAboutEverything.Models.Game;
using PortalAboutEverything.Models.Traveling;


namespace PortalAboutEverything.Controllers
{
    public class TravelingController : Controller
    {
        private TravelingRepositories _travelingRepositories;

        public TravelingController(TravelingRepositories travelingRepositories)
        {
            _travelingRepositories = travelingRepositories;
        }

        public IActionResult Index()
        {
            var month = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("en-US"));
            var year = DateTime.Now.Year;
            var day = DateTime.Now.Day;

            var model = new TravelingIndexViewModel
            {
                Month = month,
                Year = year,
                Day = day,
                When = $"{month} {day} {year}"
            };

            return View(model);
        }

        public IActionResult TravelingPosts()
        {
            var travelingPostsViewModel = _travelingRepositories
                .GetAll()
                .Select(BuildTravelingShowPostsViewModel)
                .ToList();

            return View(travelingPostsViewModel);
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(TravelingCreateViewModel createTravelingViewModel)
        {
            var traveling = new Traveling
            {
                Name = createTravelingViewModel.Name,
                Desc = createTravelingViewModel.Desc,

            };

            _travelingRepositories.Create(traveling);

            return RedirectToAction("TravelingPosts");
        }
        public IActionResult DeletePost(int id)
        {
            _travelingRepositories.Delete(id);
            return RedirectToAction("TravelingPosts");
        }

        private TravelingShowPostsViewModel BuildTravelingShowPostsViewModel(Traveling traveling)
           => new TravelingShowPostsViewModel
           {
               Id = traveling.Id,
               Desc = traveling.Desc,
               Name = traveling.Name,

           };

    }
}
