using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Ah_CentroSaludRepository : Repository<Ah_CentroSalud>, IAh_CentroSaludRepository
    {
        public Ah_CentroSaludRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Ah_CentroSalud> uspGetList(string Option, string IdCent)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdCent", IdCent);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Ah_CentroSalud>(
                    "uspGetList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
