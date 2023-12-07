using University.Entities;

namespace University.Interfaces
{
    public interface IStudentasService
    {
        public int AddStudentToDepartment(int student_id, int department_id);

        public int CreateStudentAndReferItToDepartment(string vardas, string pavarde, int departamentas_id);
        public int UpdateStudentsDepartment(int student_id, int department_);
        public IEnumerable<Paskaita> GetAllLecturesFromStudent(int student_id);
        public int GetStudentsDepartment(int studentas_id);
    }
}
