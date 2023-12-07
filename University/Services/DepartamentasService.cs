using University.Entities;
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

        public int DeleteDepartamentas(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paskaita> GetAllLecturesFromDepartment(int departamentas_id)
        {
            return _departamentasRepository.GetAllLecturesFromDepartment(departamentas_id);
        }

        public IEnumerable<Studentas> GetAllStudentsFromDepartment(int departamentas_id)
        {
            return _departamentasRepository.GetAllStudentsOfDepartment(departamentas_id);
        }
    }
}
