namespace University.Models.Entities
{
    public class Departamentas
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public List<Studentas> Studentai { get; set; }
        public List<Paskaita> Paskaitos { get; set;}
    }
}
