using Microsoft.AspNetCore.Mvc;

namespace FirstApp_MVC__C_.Controllers
{
    public class MedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
