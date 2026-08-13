using FirstApp_MVC__C_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApp_MVC__C_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult Produto()
        {
            return View();
        }

        public IActionResult Medico()
        {
            return View();
        }

        public IActionResult Paciente()
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
