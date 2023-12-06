using Microsoft.AspNetCore.Mvc;
using University.Interfaces;

namespace University.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DepartamentasController : ControllerBase
    {
        private readonly IDepartamentasService _departamentasService;
        public DepartamentasController(IDepartamentasService departamentasService)
        {
            _departamentasService = departamentasService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartamentas([FromBody] string pavadinimas)
        {
            return Ok(_departamentasService.CreateDepartamentas(pavadinimas));
        }

    }
}
