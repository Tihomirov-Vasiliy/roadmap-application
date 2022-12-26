using Dapper;
using Npgsql;
using System.Data;

namespace DataAccess.Repositories
{
    public class BaseAdoCrudRepository<T> where T : class
    {
        string _connectionString;

        public BaseAdoCrudRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task ExecuteDbCommandScalarAsync(IDbCommand command)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
                await connection.ExecuteAsync(command.CommandText);
        }

        public async Task<T> GetEntityByQueryAsync(IDbCommand command)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
                return await connection.QuerySingleOrDefaultAsync<T>(command.CommandText);
        }
        public async Task<IEnumerable<T>> GetEntitiesByQueryAsync(IDbCommand command)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
                return await connection.QueryAsync<T>(command.CommandText);
        }

    }
}
