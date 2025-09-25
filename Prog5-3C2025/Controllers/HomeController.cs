using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prog5_3C2025.Models;

namespace Prog5_3C2025.Controllers
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
            var estudiante = new Estudiante(1, "Juan Pérez", 95);
            return View(estudiante);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        #region Suma2
        public IActionResult Suma2()
        {
            return View();
        }

        public IActionResult add2()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["tx1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["tx2"].ToString());
            int result = num1 + num2;
            ViewBag.SumResult2 = result.ToString();
            return View("Suma2");
        }

        #endregion Suma2


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
