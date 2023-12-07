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
        public async Task<IActionResult> AddStudentToDepartment([FromBody] int student_id, int department_id)
        {
            return Ok(_studentasService.AddStudentToDepartment(student_id, department_id));
        }
    }
}
