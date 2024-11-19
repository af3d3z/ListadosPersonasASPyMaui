using ListadoPersonasENT;
using Microsoft.AspNetCore.Mvc;
using SGT10EJ2.Models;
using System.Diagnostics;

namespace SGT10EJ2.Controllers
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

        public IActionResult Listado() {
            List<Persona> personas;
            try
            {
                personas = DALEJ1.ListadosDAL.ListadoCompletoPersonasDAL();
            }
            catch (Exception ex) {
                personas = null;
            }
            return View(personas);
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
    }
}
