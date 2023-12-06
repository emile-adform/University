namespace University.Interfaces
{
    public interface IDepartamentasRepository
    {
        public int CreateDepartamentas(string pavadinimas);
        public int GetDepartamentasById(int id);

    }
}
