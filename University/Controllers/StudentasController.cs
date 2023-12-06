using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class StudentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
