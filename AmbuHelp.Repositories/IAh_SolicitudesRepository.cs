using AmbuHelp.Models;

namespace AmbuHelp.Repositories
{
    public interface IAh_SolicitudesRepository : IRepository<Ah_Solicitudes>
    {
        Ah_Solicitudes uspInsertSolicitud(string Option, string IdPaciente, 
                                          string IdTipoEmergencia, int IdTipoSolicitud, 
                                          string Descripcion, string Geolat, string GeoLong);
    }
}
