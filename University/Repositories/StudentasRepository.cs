using System.Data;
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
    }
}
