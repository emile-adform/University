using University.Interfaces;
using University.Models.Entities;
using University.Repositories;

namespace University.Services
{
    public class StudentasService : IStudentasService
    {
        private readonly IStudentasRepository _studentasRepository;
        private readonly IDepartamentasRepository _departamentasRepository;
        
        public StudentasService(IStudentasRepository studentasRepository, IDepartamentasRepository departamentasRepository)
        {
            _studentasRepository = studentasRepository;
            _departamentasRepository = departamentasRepository;
        }
        public int AddStudentToDepartment(int student_id, int department_id)
        {
            return _studentasRepository.AddStudentToDepartment(student_id, department_id);
        }

        public int CreateStudentAndReferItToDepartment(string vardas, string pavarde, int departamentas_id)
        {
            int studentas = _studentasRepository.CreateStudent(vardas, pavarde);
            return _studentasRepository.AddStudentToDepartment(studentas, departamentas_id);
        }

        public IEnumerable<Paskaita> GetAllLecturesFromStudent(int student_id)
        {
            int departamentas_id = _studentasRepository.GetStudentsDepartmentId(student_id);
            return _departamentasRepository.GetAllLecturesFromDepartment(departamentas_id);
        }

        public int GetStudentsDepartment(int studentas_id)
        {
            return _studentasRepository.GetStudentsDepartmentId(studentas_id);
        }

        public int UpdateStudentsDepartment(int student_id, int department_)
        {
            return _studentasRepository.UpdateStudentsDepartment(student_id, department_);
        }
    }
}
