using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;

namespace AmbuHelp.DataAccess
{
    public class Ah_UsuariosRepository : Repository<Ah_Usuarios>, IAh_UsuariosRepository
    {
        public Ah_UsuariosRepository(string connectionString) : base(connectionString)
        {
        }

        public Ah_Usuarios uspValidateUser(string userName, string password)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_UserName", userName);
            parameters.Add("_Password", password);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Ah_Usuarios>(
                    "uspValidateUser", parameters, 
                    commandType: System.Data.CommandType.StoredProcedure);
            }

        }
    }
}
