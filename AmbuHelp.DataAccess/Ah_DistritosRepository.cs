using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    class Ah_DistritosRepository : Repository<Ah_Distritos>, IAh_DistritosRepository
    {
        public Ah_DistritosRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Ah_Distritos> uspGetUbicacion(string Option, int IdNum)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdNum", IdNum);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Ah_Distritos>(
                    "uspGetUbicacion", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
