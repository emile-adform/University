using Dapper;
using System.Data;
using University.Entities;
using University.Interfaces;

namespace University.Repositories
{
    public class DepartamentasRepository : IDepartamentasRepository
    {
        private readonly IDbConnection _connection;
        public DepartamentasRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int CreateDepartamentas(string pavadinimas)
        {
            string sql = $"INSERT INTO departamentas (pavadinimas) VALUES (@pavadinimas) RETURNING id";
            var queryArguments = new
            {
                pavadinimas = pavadinimas
            };
            return _connection.QuerySingle<int>(sql, queryArguments);
        }

        public IEnumerable<Paskaita> GetAllLecturesFromDepartment(int departamentas_id)
        {
            string sql = $"SELECT pavadinimas FROM paskaita as p JOIN departamentas_paskaita as dp " +
                $"ON p.id = dp.paskaita_id WHERE dp.departamentas_id = @departamentas_id";
            var queryArguments = new
            {
                departamentas_id = departamentas_id
            };
            return _connection.Query<Paskaita>(sql, queryArguments);
        }

        public IEnumerable<Studentas> GetAllStudentsOfDepartment(int departamentas_id)
        {
            string sql = $"SELECT id, vardas, pavarde FROM studentas as s JOIN studentas_departamentas as sd " +
                $"ON s.id = sd.studentas_id WHERE sd.departamentas_id = @departamentas_id";
            var queryArguments = new
            {
                departamentas_id = departamentas_id
            };
            return _connection.Query<Studentas>(sql, queryArguments);
        }
    }
}
