using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AmbuHelp.DataAccess
{
    public class ListaPersonalRepository : Repository<ListaPersonal>, IListaPersonalRepository
    {
        public ListaPersonalRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<ListaPersonal> uspGetList(string Option, string IdCent)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdCent", IdCent);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<ListaPersonal>(
                    "uspGetList", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public ListaPersonal uspInsertPersonal( string Option, string userName, string password, 
                                                string nombres, string apPaterno, string apMaterno, 
                                                string docId, int ubigeo, string validacion, string direccion, 
                                                string idAmbulancia, string idCentroSalud)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_UserName", userName);
            parameters.Add("_Password", password);
            parameters.Add("_Nombres", nombres);
            parameters.Add("_ApPaterno", apPaterno);
            parameters.Add("_ApMaterno", apMaterno);
            parameters.Add("_DocId", docId);
            parameters.Add("_Ubigeo", ubigeo);
            parameters.Add("_Validacion", validacion);
            parameters.Add("_Direccion", direccion);
            parameters.Add("_IdAmbulancia", idAmbulancia);
            parameters.Add("_IdCentroSalud", idCentroSalud);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<ListaPersonal>(
                    "uspInsertPersonal", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
