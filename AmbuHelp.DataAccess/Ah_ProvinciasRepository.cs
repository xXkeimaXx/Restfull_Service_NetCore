using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Ah_ProvinciasRepository : Repository<Ah_Provincias>, IAh_ProvinciasRepository
    {
        public Ah_ProvinciasRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Ah_Provincias> uspGetUbicacion(string Option, int IdNum)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdNum", IdNum);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Ah_Provincias>(
                    "uspGetUbicacion", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
