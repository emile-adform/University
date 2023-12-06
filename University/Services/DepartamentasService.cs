using University.Interfaces;

namespace University.Services
{
    public class DepartamentasService : IDepartamentasService
    {
        public readonly IDepartamentasRepository _departamentasRepository;
        public DepartamentasService(IDepartamentasRepository departamentasRepository)
        {
            _departamentasRepository = departamentasRepository;
        }

        public int CreateDepartamentas(string pavadinimas)
        {
            return _departamentasRepository.CreateDepartamentas(pavadinimas);
        }
    }
}
