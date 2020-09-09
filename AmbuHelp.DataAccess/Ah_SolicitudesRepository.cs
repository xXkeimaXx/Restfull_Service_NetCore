using AmbuHelp.Models;
using AmbuHelp.Repositories;
using Dapper;
using MySql.Data.MySqlClient;

namespace AmbuHelp.DataAccess
{
    class Ah_SolicitudesRepository : Repository<Ah_Solicitudes>, IAh_SolicitudesRepository
    {
        public Ah_SolicitudesRepository(string connectionString) : base(connectionString)
        {
        }

        public Ah_Solicitudes uspInsertSolicitud(string Option, string IdPaciente, 
                                                 string IdTipoEmergencia, int IdTipoSolicitud, 
                                                 string Descripcion, string GeoLat, string GeoLong)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_Option", Option);
            parameters.Add("_IdPaciente", IdPaciente);
            parameters.Add("_IdTipoEmergencia", IdTipoEmergencia);
            parameters.Add("_IdTipoSolicitud", IdTipoSolicitud);
            parameters.Add("_Descripcion", Descripcion);
            parameters.Add("_GeoLat", GeoLat);
            parameters.Add("_GeoLong", GeoLong);

            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Ah_Solicitudes>(
                    "uspInsertSolicitud", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
