using University.Models.Entities;

namespace University.Interfaces
{
    public interface IPaskaitaRepository
    {
        public int CreateLecture(string pavadinimas);
        public int AddLectureToDepartment(int paskaita_id, int departamentas_id);
        public Paskaita GetLectureById(int paskaita_id);

    }
}
