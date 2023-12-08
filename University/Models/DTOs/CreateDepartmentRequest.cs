using University.Models.Entities;

namespace University.Models.DTOs
{
    public class CreateDepartmentRequest
    {
        public string DepartmentName { get; set; }
        public List<CreateStudentDto> Studentai { get; set; }
        public List<PaskaitaDto> Paskaitos { get; set;}
    }
}
