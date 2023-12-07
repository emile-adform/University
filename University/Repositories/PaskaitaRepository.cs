using Dapper;
using System.Data;
using University.Interfaces;

namespace University.Repositories
{
    public class PaskaitaRepository : IPaskaitaRepository
    {
        private readonly IDbConnection _connection;
        public PaskaitaRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int AddLectureToDepartment(int paskaita_id, int departamentas_id)
        {
            string sql = $"INSERT INTO departamentas_paskaita VALUES (@departamentas_id, @paskaita_id)";
            var queryArguments = new
            {
                departamentas_id = departamentas_id,
                paskaita_id = paskaita_id
            };
            return _connection.Execute(sql, queryArguments);
        }

        public int CreateLecture(string pavadinimas)
        {
            string sql = $"INSERT INTO paskaita (pavadinimas) VALUES (@pavadinimas) RETURNING id";
            var queryArguments = new
            {
                pavadinimas = pavadinimas
            };
            return _connection.QuerySingle<int>(sql, queryArguments);
        }

        public int DeleteLecture(int paskaita_id)
        {
            string sql = $"DELETE FROM paskaita WHERE id = @paskaita_id";
            var queryArguments = new
            {
                 paskaita_id = paskaita_id
            };
            return _connection.Execute(sql, queryArguments);
        }
    }
}
