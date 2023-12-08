using Microsoft.AspNetCore.Mvc;
using University.Interfaces;
using University.Models.Entities;

namespace University.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PaskaitaController : Controller
    {
        private readonly IPaskaitaService _paskaitaService;
        private readonly IDepartamentasService _departamentasService;

        public PaskaitaController(IPaskaitaService paskaitaService)
        {
            _paskaitaService = paskaitaService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLectureAndAddToDepartment(string pavadinimas, int departamentas_id)
        {
            Departamentas dp = _departamentasService.GetDepartmentById(departamentas_id);
            if(dp == null)
            {
                return NotFound("This department does not exist");
            }
            return Ok(_paskaitaService.CreateLectureAndAddToDepartment(pavadinimas, departamentas_id));
        }
        
        [HttpPost]
        public async Task<IActionResult> AddLectureToDepartment(int paskaita_id, int departamentas_id)
        {
            Departamentas dp = _departamentasService.GetDepartmentById(departamentas_id);
            Paskaita paskaita = _paskaitaService.GetLectureById(paskaita_id);
            if (dp == null)
            {
                return NotFound("This department does not exist");
            }
            if (paskaita == null)
            {
                return NotFound("This lecture does not exist");
            }

            return Ok(_paskaitaService.AddLectureToDepartment(paskaita_id, departamentas_id));
        }

    }
}
