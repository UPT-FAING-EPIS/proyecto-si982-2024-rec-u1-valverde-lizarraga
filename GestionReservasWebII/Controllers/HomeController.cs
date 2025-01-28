using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GestionReservasWebII.Models;

namespace GestionReservasWebII.Controllers
{
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

        [HttpPost]
        public IActionResult RedirigirPorRol(string role)
        {
            if (role == "Estudiante")
            {
                return RedirectToAction("DashboardUsuario", "Usuario");
            }
            else if (role == "Docente")
            {
                return RedirectToAction("DashboardDocente", "Docente");
            }
            else if (role == "Administrador")
            {
                return RedirectToAction("DashboardAdministrador", "Administrador");
            }

            TempData["Error"] = "Por favor, selecciona un rol válido.";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
