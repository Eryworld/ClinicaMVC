using Microsoft.AspNetCore.Mvc;
using ClinicaMVC.Data;
using Microsoft.EntityFrameworkCore;
namespace ClinicaMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ClinicaDbContext _context;

        public AccountController(ClinicaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            var user = _context.Usuarios
                .FirstOrDefault(u =>
                    u.NombreUsuario == usuario &&
                    u.Clave == password &&
                    u.Activo == true);

            if (user != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";

            return View();
        }
    }
}