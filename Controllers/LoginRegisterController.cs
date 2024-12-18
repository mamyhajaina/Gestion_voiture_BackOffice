using Microsoft.AspNetCore.Mvc;

namespace Gestion_voiture_BackOffice.Controllers
{
    public class LoginRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }
        
        public String testParme(String name)
        {
            return "Name: " + name;
        }
    }
}
