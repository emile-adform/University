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
            try
            {
                return Ok(_departamentasService.CreateDepartamentas(pavadinimas));

            }
            catch (Exception ex)
            {

                return StatusCode(500, "Unexpected error occurred.");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudentsFromDepartment(int departamentas_id)
        {
            try
            {
                IEnumerable<Studentas> studentai = new List<Studentas>(_departamentasService.GetAllStudentsFromDepartment(departamentas_id));
                if(studentai.Count() == 0)
                {
                    return NotFound();
                }
                return Ok(studentai);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Unexpected error occurred.");
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAllLecturesFromDepartment(int departamentas_id)
        {
            try
            {
                IEnumerable<Paskaita> paskaitos = new List<Paskaita>(_departamentasService.GetAllLecturesFromDepartment(departamentas_id));
                if (paskaitos.Count() == 0)
                {
                    return NotFound();
                }
                return Ok(_departamentasService.GetAllLecturesFromDepartment(departamentas_id));
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Unexpected error occurred.");
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartmentWithStudentsAndLectures([FromBody] CreateDepartmentRequest request)
        {
            try
            {
                return Ok(_departamentasService.CreateDepartmentWithStudentsAndLectures(request));

            }
            catch (Exception ex)
            {

                return StatusCode(500, "Unexpected error occurred.");
            }
        }

    }
}
