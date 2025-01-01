using Gestion_voiture_BackOffice.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Gestion_voiture_BackOffice.Models;
using Gestion_voiture_BackOffice.Services;
using GestionVoitureFrontOffice.Services;
using System.ComponentModel.DataAnnotations;

namespace Gestion_voiture_BackOffice.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly JwtTokenService _jwtTokenService;

        public LoginController(IUserService userService, JwtTokenService jwtTokenService)
        {
            _userService = userService;
            _jwtTokenService = jwtTokenService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            try
            {
                Console.WriteLine("Login");
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    ViewData["ErrorMessage"] = "L'email et le mot de passe sont requis.";
                    Console.WriteLine("L'email et le mot de passe sont requis.");
                    return RedirectToAction("");
                }

                var emailIsValid = new EmailAddressAttribute().IsValid(email);
                if (!emailIsValid)
                {
                    ViewData["ErrorMessage"] = "L'email fourni n'est pas valide.";
                    Console.WriteLine("L'email fourni n'est pas valide.");
                    return RedirectToAction("");
                }

                var user = await _userService.LoginAsync(email, password);

                if (user != null)
                {
                    if (user.RoleUser.Name == "Admin")
                    {
                        var token = _jwtTokenService.GenerateToken(user.Id, email, user.RoleUser.Name);
                        HttpContext.Session.SetString("JwtToken", token);
                        Console.WriteLine("token == " + token);
                        return RedirectToAction("Index", "Vehicle");
                    }
                    else
                    {
                        Console.WriteLine("No Token");
                        return RedirectToAction("");
                    }
                }
                else
                {
                    Console.WriteLine("Email ou mot de passe incorrect");
                    ViewData["ErrorMessage"] = "Email ou mot de passe incorrect";
                    return RedirectToAction("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors de la tentative de connexion. Veuillez réessayer plus tard.", ex);
                ViewData["ErrorMessage"] = "Une erreur s'est produite lors de la tentative de connexion. Veuillez réessayer plus tard.";
                return Unauthorized(new { message = "Données invalides. Veuillez vérifier les champs.", ex });
            }
        }
    }
}
