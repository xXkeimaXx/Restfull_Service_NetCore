using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;

namespace AmbuHelp.DataAccess
{
    public class Ah_ValidatorRepository : Repository<Ah_Validator>, IAh_ValidatorRepository
    {
        public Ah_ValidatorRepository(string connectionString) : base(connectionString)
        {
        }

        public Ah_Validator uspValidAdmin(string codigo)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_codigo", codigo);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Ah_Validator>(
                    "uspValidAdmin", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
