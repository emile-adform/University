﻿using University.Entities;

namespace University.Interfaces
{
    public interface IDepartamentasRepository
    {
        public int CreateDepartamentas(string pavadinimas);
        public IEnumerable<Studentas> GetAllStudentsOfDepartment(int departamentas_id);
        public IEnumerable<Paskaita> GetAllLecturesFromDepartment(int departamentas_id);

    }
}
