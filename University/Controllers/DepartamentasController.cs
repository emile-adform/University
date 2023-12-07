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
        public async Task<IActionResult> CreateDepartamentas(string pavadinimas)
        {
            return Ok(_departamentasService.CreateDepartamentas(pavadinimas));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudentsFromDepartment(int departamentas_id)
        {
            return Ok(_departamentasService.GetAllStudentsFromDepartment(departamentas_id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLecturesFromDepartment(int departamentas_id)
        {
            return Ok(_departamentasService.GetAllLecturesFromDepartment(departamentas_id));
        }

    }
}
