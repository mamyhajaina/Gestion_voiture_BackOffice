using System.Diagnostics;
using Gestion_voiture_BackOffice.Configurations;
using Gestion_voiture_BackOffice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_voiture_BackOffice.Controllers
{
    [ServiceFilter(typeof(AuthorizeFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotFound()
        {
            return View("_404"); // Assurez-vous que la vue s'appelle "404.cshtml"
        }
    }
}
