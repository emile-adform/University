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
    }
}
