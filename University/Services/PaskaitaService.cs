using University.Interfaces;
using University.Models.Entities;
using University.Repositories;

namespace University.Services
{
    public class PaskaitaService : IPaskaitaService
    {
        private readonly IPaskaitaRepository _paskaitaRepository;
        public PaskaitaService(IPaskaitaRepository paskaitaRepository)
        {
            _paskaitaRepository = paskaitaRepository;
        }

        public int CreateLectureAndAddToDepartment(string pavadinimas, int departamentas_id)
        {
            int paskaita_id = _paskaitaRepository.CreateLecture(pavadinimas);
            return _paskaitaRepository.AddLectureToDepartment(paskaita_id, departamentas_id);
        }

        public int AddLectureToDepartment(int paskaita_id,  int departamentas_id)
        {
            return _paskaitaRepository.AddLectureToDepartment(paskaita_id, departamentas_id);
        }

        public Paskaita GetLectureById(int paskaita_id)
        {
            return _paskaitaRepository.GetLectureById(paskaita_id);
        }
    }
}
