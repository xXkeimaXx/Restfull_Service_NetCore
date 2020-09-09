using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class ListaSolicitudesRepository : Repository<ListaSolicitudes>, IListaSolicitudesRepository
    {
        public ListaSolicitudesRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<ListaSolicitudes> uspGetList(string Option, string IdCent)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdCent", IdCent);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<ListaSolicitudes>(
                    "uspGetList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
