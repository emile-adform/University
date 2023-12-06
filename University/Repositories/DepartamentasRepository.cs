using Dapper;
using System.Data;
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
            string sql = $"INSERT INTO departamentas (pavadinimas) VALUES (@pavadinimas)";
            var queryArguments = new
            {
                pavadinimas = pavadinimas
            };
            return _connection.Execute(sql, queryArguments);
        }

        public int GetDepartamentasById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
