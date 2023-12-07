using University.Entities;

namespace University.Interfaces
{
    public interface IStudentasRepository
    {
        public int AddStudentToDepartment(int student_id, int department_id);
        public int CreateStudent(string vardas, string pavarde);
        public int DeleteStudent(int student_id);
        public int UpdateStudentsDepartment(int student_id, int department_);
        public int GetStudentsDepartmentId(int student_id);
    }
}
