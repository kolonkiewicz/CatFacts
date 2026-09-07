using CatFacts.Models;
using CatFacts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatFacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatFactService _catFactService;

        public HomeController( ICatFactService catFactService)
        {
            _catFactService = catFactService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetFact()
        {
            var catFact = await _catFactService.GetRandomFactAsync();

            return View("Index", catFact);
        }
    }
}