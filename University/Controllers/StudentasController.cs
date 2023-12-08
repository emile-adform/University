using Microsoft.AspNetCore.Mvc;
using University.Interfaces;
using University.Models.Entities;

namespace University.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentasController : Controller
    {
        private readonly IStudentasService _studentasService;
        private readonly IPaskaitaService _paskaitaService;
        private readonly IDepartamentasService _departamentasService;

        public StudentasController(IStudentasService studentasService)
        {
            _studentasService = studentasService;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentToDepartment(int student_id, int department_id)
        {
            Departamentas dp = _departamentasService.GetDepartmentById(department_id);
            Studentas studentas = _studentasService.GetStudentById(student_id);
            if (dp == null)
            {
                return NotFound("This department does not exist");
            }
            if (studentas == null)
            {
                return NotFound("This student does not exist");
            }
            return Ok(_studentasService.AddStudentToDepartment(student_id, department_id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudentAndReferToDepartment(string vardas, string pavarde, int departamentas_id)
        {
            Departamentas dp = _departamentasService.GetDepartmentById(departamentas_id);
            if (dp == null)
            {
                return NotFound("This department does not exist");
            }
            return Ok(_studentasService.CreateStudentAndReferItToDepartment(vardas, pavarde, departamentas_id));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStudentsDepartment(int student_id, int department_id)
        {
            Departamentas dp = _departamentasService.GetDepartmentById(department_id);
            Studentas studentas = _studentasService.GetStudentById(student_id);
            if (dp == null)
            {
                return NotFound("This department does not exist");
            }
            if (studentas == null)
            {
                return NotFound("This student does not exist");
            }
            return Ok(_studentasService.UpdateStudentsDepartment(student_id, department_id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllLecturesFromStudent(int student_id)
        {
            Studentas studentas = _studentasService.GetStudentById(student_id);
            if (studentas == null)
            {
                return NotFound("This student does not exist");
            }
            return Ok(_studentasService.GetAllLecturesFromStudent(student_id));
        }
        [HttpGet]
        public async Task<IActionResult> GetStudentsDepartment(int student_id)
        {
            Studentas studentas = _studentasService.GetStudentById(student_id);
            if (studentas == null)
            {
                return NotFound("This student does not exist");
            }
            return Ok(_studentasService.GetStudentsDepartment(student_id));
        }

    }
}
