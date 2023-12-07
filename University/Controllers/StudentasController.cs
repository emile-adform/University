using Microsoft.AspNetCore.Mvc;
using University.Interfaces;

namespace University.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentasController : Controller
    {
        private readonly IStudentasService _studentasService;

        public StudentasController(IStudentasService studentasService)
        {
            _studentasService = studentasService;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentToDepartment(int student_id, int department_id)
        {
            return Ok(_studentasService.AddStudentToDepartment(student_id, department_id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudentAndReferToDepartment(string vardas, string pavarde, int departamentas_id)
        {
            return Ok(_studentasService.CreateStudentAndReferItToDepartment(vardas, pavarde, departamentas_id));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStudentsDepartment(int student_id, int department_)
        {
            return Ok(_studentasService.UpdateStudentsDepartment(student_id, department_));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllLecturesFromStudent(int student_id)
        {
            return Ok(_studentasService.GetAllLecturesFromStudent(student_id));
        }
        [HttpGet]
        public async Task<IActionResult> GetStudentsDepartment(int student_id)
        {
            return Ok(_studentasService.GetStudentsDepartment(student_id));
        }

    }
}
