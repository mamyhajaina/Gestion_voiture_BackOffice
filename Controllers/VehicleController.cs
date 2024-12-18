using Microsoft.AspNetCore.Mvc;

namespace Gestion_voiture_BackOffice.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index(string name, int count)
        {
            ViewData["Name"] = name;
            ViewData["count"] = count;
            return View();
        }
    }
}
