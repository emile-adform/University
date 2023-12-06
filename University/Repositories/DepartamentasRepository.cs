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
    }
}
