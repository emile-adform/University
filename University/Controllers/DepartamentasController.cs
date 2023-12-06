using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class DepartamentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
