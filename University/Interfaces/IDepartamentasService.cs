using University.Models.DTOs;
using University.Models.Entities;

namespace University.Interfaces
{
    public interface IDepartamentasService
    {
        public int CreateDepartamentas(string pavadinimas);
        public int DeleteDepartamentas(int id);
        public IEnumerable<Studentas> GetAllStudentsFromDepartment(int departamentas_id);
        public IEnumerable<Paskaita> GetAllLecturesFromDepartment(int departamentas_id);

        public int CreateDepartmentWithStudentsAndLectures(CreateDepartmentRequest request);

    }
}
