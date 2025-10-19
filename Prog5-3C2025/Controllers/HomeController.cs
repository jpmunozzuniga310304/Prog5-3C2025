using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Prog5_3C2025.Controllers.ActionFilters;
using Prog5_3C2025.Models;
using System.Diagnostics;

namespace Prog5_3C2025.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

   
        public IActionResult Index()
        {
            var estudiante = new Estudiante(1, "Juan Pérez", 95);
            return View(estudiante);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult About()
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



