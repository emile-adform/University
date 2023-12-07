using University.Interfaces;

namespace University.Services
{
    public class StudentasService : IStudentasService
    {
        private readonly IStudentasRepository _studentasRepository;
        
        public StudentasService(IStudentasRepository studentasRepository)
        {
            _studentasRepository = studentasRepository;
        }
        public int AddStudentToDepartment(int student_id, int department_id)
        {
            return _studentasRepository.AddStudentToDepartment(student_id, department_id);
        }
    }
}
