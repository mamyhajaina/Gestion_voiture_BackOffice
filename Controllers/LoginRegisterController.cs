using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Gestion_voiture_BackOffice.Models;

namespace Gestion_voiture_BackOffice.Controllers
{
    public class LoginRegisterController : Controller
    {
        public readonly IUserService _userService;
        public LoginRegisterController(IUserService userService) {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                // Logique d'authentification ici
                if (model.Email == "test@email.com" && model.PasswordHash == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            return View(model);
            //if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            //{
            //    ModelState.AddModelError("", "Email et mot de passe sont requis.");
            //}
            //var qUser = await _userService.GetByEmailPassWordAsync(email, password);
            //Console.WriteLine("Le résultat est : " + qUser);
            //if (qUser != null)
            //{
            //    return RedirectToAction("Index", "Vehicle");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Email ou mot de passe incorrect.");
            //    return RedirectToAction("Index", "LoginRegister");
            //}
        }
    }
}
