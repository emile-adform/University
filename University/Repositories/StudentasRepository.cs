using Dapper;
using System.Data;
using University.Entities;
using University.Interfaces;

namespace University.Repositories
{
    public class StudentasRepository : IStudentasRepository
    {
        private readonly IDbConnection _connection;
        public StudentasRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int AddStudentToDepartment(int student_id, int department_id)
        {
            string sql = $"INSERT INTO studentas_departamentas VALUES (@student_id, @department_id)";
            var queryArguments = new
            {
                student_id = student_id,
                department_id = department_id
            };
            return _connection.Execute(sql, queryArguments);
        }

        public int CreateStudent(string vardas, string pavarde)
        {
            string sql = $"INSERT INTO studentas (vardas, pavarde) VALUES (@vardas, @pavarde) RETURNING id";
            var queryArguments = new
            {
                vardas = vardas,
                pavarde = pavarde
            };
            return _connection.QuerySingle<int>(sql, queryArguments);
        }

        public int DeleteStudent(int student_id)
        {
            string sql = $"DELETE FROM studentas WHERE id = @student_id";
            var queryArguments = new
            {
                student_id = student_id
            };
            return _connection.Execute(sql, queryArguments);
        }

        public int GetStudentsDepartmentId(int student_id)
        {
            string sql = $"SELECT departamentas_id FROM studentas_departamentas WHERE studentas_id = @student_id";
            var queryArguments = new
            {
                student_id = student_id
            };
            return _connection.QuerySingle<int>(sql, queryArguments);
        }

        public int UpdateStudentsDepartment(int student_id, int department_id)
        {
            string sql = $"UPDATE studentas_departamentas SET departamentas_id = @department_id WHERE studentas_id = @student_id";
            var queryArguments = new
            {
                student_id = student_id,
                department_id = department_id
            };
            return _connection.Execute(sql, queryArguments);
        }
        
    }
}
