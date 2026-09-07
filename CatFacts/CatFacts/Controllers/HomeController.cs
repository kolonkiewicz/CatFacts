using CatFacts.Models;
using CatFacts.Services;
using CatFacts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatFacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatFactService _catFactService;
        private readonly ICatFactRepository _repostory;

        public HomeController( 
            ICatFactService catFactService,
            ICatFactRepository repository)
        {
            _catFactService = catFactService;
            _repostory = repository;
        }

        public async Task<IActionResult> Index()
        {
            var recentFacts = await _repostory.GetAllAsync();

            var viewModel = new HomeViewModel
            {
                RecentFacts = recentFacts.Take(5).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GetFact()
        {
            var catFact = await _catFactService.GetRandomFactAsync();

            var recentFacts = await _repostory.GetAllAsync();

            var viewModel = new HomeViewModel
            {
                CurrentFact = catFact,
                RecentFacts = recentFacts.Take(5).ToList()
                
            };

            return View("Index", viewModel);
        }
    }
}