using Microsoft.AspNetCore.Mvc;
using University.Interfaces;
using University.Models.DTOs;
using University.Models.Entities;

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
            IEnumerable<Studentas> studentai = new List<Studentas>(_departamentasService.GetAllStudentsFromDepartment(departamentas_id));
            if(studentai.Count() == 0)
            {
                return NotFound();
            }
            return Ok(studentai);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLecturesFromDepartment(int departamentas_id)
        {
            IEnumerable<Paskaita> paskaitos = new List<Paskaita>(_departamentasService.GetAllLecturesFromDepartment(departamentas_id));
            if (paskaitos.Count() == 0)
            {
                return NotFound();
            }
            return Ok(_departamentasService.GetAllLecturesFromDepartment(departamentas_id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartmentWithStudentsAndLectures([FromBody] CreateDepartmentRequest request)
        {
            
            return Ok(_departamentasService.CreateDepartmentWithStudentsAndLectures(request));
        }

    }
}
