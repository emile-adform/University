﻿using University.Models.Entities;

namespace University.Interfaces
{
    public interface IPaskaitaService
    {
        public int CreateLectureAndAddToDepartment(string pavadinimas, int departamentas_id);
        public int AddLectureToDepartment(int paskaita_id, int departamentas_id);
        public Paskaita GetLectureById(int paskaita_id);
    }
}
