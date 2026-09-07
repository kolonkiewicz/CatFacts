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

        public async Task<IActionResult> History(
            string? keyword,
            DateTime? from,
            DateTime? to,
            int page = 1)
        {
            const int pageSize = 5;

            var history = await _repostory.GetHistoryAsync(
                keyword,
                from,
                to,
                page,
                pageSize
            );

            return View(history);
        }

        public async Task<IActionResult> Details(int id)
        {
            var fact = await _repostory.GetByIdAsync(id);

            if ( fact is null)
            {
                return NotFound();
            }

            return Json(fact);
        }

        public async Task<IActionResult> Statistics()
        {
            var statistics = await _repostory.GetStatisticsAsync();

            return View(statistics);
        }
    }
}