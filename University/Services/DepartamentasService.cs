using Microsoft.AspNetCore.Http.HttpResults;
using University.Interfaces;
using University.Models.DTOs;
using University.Models.Entities;

namespace University.Services
{
    public class DepartamentasService : IDepartamentasService
    {
        public readonly IDepartamentasRepository _departamentasRepository;
        public readonly IStudentasRepository _studentasRepository;
        public readonly IPaskaitaRepository _paskaitaRepository;
        public DepartamentasService(IDepartamentasRepository departamentasRepository, IStudentasRepository studentasRepository, IPaskaitaRepository paskaitaRepository)
        {
            _departamentasRepository = departamentasRepository;
            _studentasRepository = studentasRepository;
            _paskaitaRepository = paskaitaRepository;
        }

        public int CreateDepartamentas(string pavadinimas)
        {
            return _departamentasRepository.CreateDepartamentas(pavadinimas);
        }

        public int CreateDepartmentWithStudentsAndLectures(CreateDepartmentRequest request)
        {
            var departmentId = _departamentasRepository.CreateDepartamentas(request.DepartmentName);
            List<int> student_ids = new List<int>();        
            List<int> paskaita_ids = new List<int>();        
            foreach(var studentas in request.Studentai)
            {
                int studentas_id = _studentasRepository.CreateStudent(studentas.Vardas, studentas.Pavarde);
                student_ids.Add(studentas_id);
                _studentasRepository.AddStudentToDepartment(studentas_id, departmentId);
            }
            foreach (var paskaita in request.Paskaitos)
            {
                int paskaita_id = _paskaitaRepository.CreateLecture(paskaita.Pavadinimas);
                paskaita_ids.Add(paskaita_id);
                _paskaitaRepository.AddLectureToDepartment(paskaita_id, departmentId);
            }
            
            return departmentId;

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
