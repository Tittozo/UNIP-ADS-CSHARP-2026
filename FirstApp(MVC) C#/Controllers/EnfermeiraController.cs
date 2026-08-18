using Microsoft.AspNetCore.Mvc;

namespace FirstApp_MVC__C_.Controllers
{
    public class EnfermeiraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Nome { get; set; }

        public string Idade { get; set; }
    }
}
