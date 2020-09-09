using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class Ah_AmbulanciasRepository : Repository<ListaAmbulancia>, IAh_AmbulanciasRepository
    {
        public Ah_AmbulanciasRepository(string connectionString) : base(connectionString)
        {

        }

        public ListaAmbulancia uspDeleteEntidad(string Option, string IdAmbulancia)
        {
            var parameters = new DynamicParameters();

            parameters.Add("_Option", Option);
            parameters.Add("_Id", IdAmbulancia);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<ListaAmbulancia>(
                    "uspDeleteEntidad", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ListaAmbulancia> uspGetList(string Option, string IdCent)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdCent", IdCent);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<ListaAmbulancia>(
                    "uspGetList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public ListaAmbulancia uspInsertAmbulancia(string IdCent, string PlacaVehicular, string TipoAmbulancia)
        {
            var parameters = new DynamicParameters();
            
            parameters.Add("_PlacaVehicular", PlacaVehicular);
            parameters.Add("_TipoAmbulancia", TipoAmbulancia);
            parameters.Add("_IdCent", IdCent);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<ListaAmbulancia>(
                    "uspInsertAmbulancia", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
