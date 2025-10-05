using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Prog5_3C2025.Models;
using System.Diagnostics;

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

        [OutputCache(Duration = 10)]
        public string IndexII()
        {
            return DateTime.Now.ToString("T"); //muestra el mismo resultado durante 10 segundos

        }
        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public IActionResult ActionName()
        {
            return View();
        }
        public IActionResult NonAction()
        {
            return View();
        }
        public IActionResult ActionVerbs()
        {
            return View();
        }

        [ActionName("Sumar")]
        public IActionResult Sum()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["tx1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["tx2"].ToString());
            ViewBag.Result = (num1 + num2).ToString();
            return View("ActionName");
        }
        public string SumTemp()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["tx1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["tx2"].ToString());
            return (num1 + num2).ToString();
        }

        [HttpPost]
        public IActionResult add3()
        {
            int num1 = Convert.ToInt32(HttpContext.Request.Form["tx1"].ToString());
            int num2 = Convert.ToInt32(HttpContext.Request.Form["tx2"].ToString());
            ViewBag.Result = (num1 + num2).ToString();
            return View("ActionVerbs");
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

        #region Calculadora basica
        public IActionResult bCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suma()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["n1"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["n2"].ToString());
                ViewBag.Result = "Resultado de la suma: " + (num1 + num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }

        [HttpPost]
        public IActionResult Resta()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["n1"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["n2"].ToString());
                ViewBag.Result = "Resultado de la resta: " + (num1 - num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }
        [HttpPost]
        public IActionResult Multiplicacion()
        {
            try
            {
                int num1 = Convert.ToInt32(HttpContext.Request.Form["n1"].ToString());
                int num2 = Convert.ToInt32(HttpContext.Request.Form["n2"].ToString());
                ViewBag.Result = "Resultado de la multiplicación: " + (num1 * num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }
        [HttpPost]
        public IActionResult Division()
        {
            try
            {
                decimal num1 = Convert.ToDecimal(HttpContext.Request.Form["n1"].ToString());
                decimal num2 = Convert.ToDecimal(HttpContext.Request.Form["n2"].ToString());
                decimal f = num1 / num2;
                ViewBag.Result = "Resultado de la división: " + f.ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }

        public IActionResult Modulo()
        {
            try
            {
                decimal num1 = Convert.ToDecimal(HttpContext.Request.Form["n1"].ToString());
                decimal num2 = Convert.ToDecimal(HttpContext.Request.Form["n2"].ToString());
                decimal result = num1 % num2; // operador mod en C#
                ViewBag.Result = "Resultado del modulo: " + result.ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }

        public IActionResult RaizCuadrada()
        {
            try
            {
                decimal num = Convert.ToDecimal(HttpContext.Request.Form["n1"].ToString());
                if (num < 0)
                {
                    ViewBag.Result = "No se puede calcular la raíz cuadrada de un número negativo."; 
                }
                else
                {
                    double result = Math.Sqrt((double)num); // convertimos decimal a double
                    ViewBag.Result = "Resultado de la raíz cuadrada: " + result.ToString();
                }
            }
            catch (Exception)
            {
                ViewBag.Result = "Datos erroneos ingresados.";
            }
            return View("bCalc");
        }



        #endregion Calculadora basica

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}



