using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class ListaUbicacionRepository : Repository<Ah_Regiones>, IListaUbicacionRepository
    {
        public ListaUbicacionRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Ah_Regiones> uspGetUbicacion(string Option, int IdNum)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdNum", IdNum);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Ah_Regiones>(
                    "uspGetUbicacion", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
