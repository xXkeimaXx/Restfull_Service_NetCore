using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;

namespace AmbuHelp.DataAccess
{
    public class DeletePersonalRepository : Repository<Ah_Personal>, IDeletePersonalRepository
    {
        public DeletePersonalRepository(string connectionString) : base(connectionString)
        {
        }

        public Ah_Personal uspDeleteEntidad(string Option, string IdPersonal)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_Id", IdPersonal);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Ah_Personal>(
                    "uspDeleteEntidad", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
