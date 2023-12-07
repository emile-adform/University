using Microsoft.AspNetCore.Mvc;
using University.Interfaces;

namespace University.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PaskaitaController : Controller
    {
        private readonly IPaskaitaService _paskaitaService;
        public PaskaitaController(IPaskaitaService paskaitaService)
        {
            _paskaitaService = paskaitaService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLectureAndAddToDepartment(string pavadinimas, int departamentas_id)
        {
            return Ok(_paskaitaService.CreateLectureAndAddToDepartment(pavadinimas, departamentas_id));
        }
        
        [HttpPost]
        public async Task<IActionResult> AddLectureToDepartment(int paskaita_id, int departamentas_id)
        {
            return Ok(_paskaitaService.AddLectureToDepartment(paskaita_id, departamentas_id));
        }

    }
}
