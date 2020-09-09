using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;

namespace AmbuHelp.DataAccess
{
    public class EstadoAmbulanciaRepository : Repository<Ah_Ambulancias>, IEstadoAmbulanciaRepository
    {
        public EstadoAmbulanciaRepository(string connectionString) : base(connectionString)
        {
        }

        public Ah_Ambulancias uspUpdateEstado(string Option, string IdAmbulancia)
        {
                var parameters = new DynamicParameters();

                parameters.Add("_Option", Option);
                parameters.Add("_IdAmbulancia", IdAmbulancia);

                using (var connection = new MySqlConnection(_connectionString))
                {
                    return connection.QueryFirstOrDefault<Ah_Ambulancias>(
                        "uspUpdateEstado", parameters,
                        commandType: System.Data.CommandType.StoredProcedure);
                }
            
        }
    }
}
