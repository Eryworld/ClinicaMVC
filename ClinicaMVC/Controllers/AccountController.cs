using Microsoft.AspNetCore.Mvc;

namespace ClinicaMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            // Temporal para pruebas

            if (usuario == "admin" && password == "1234")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";

            return View();
        }
    }
}