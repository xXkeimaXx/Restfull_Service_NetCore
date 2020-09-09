using AmbuHelp.Repositories;

namespace AmbuHelp.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAh_TipoEmergenciaRepository Ah_TipoEmergencia { get; }
        IAh_TipoSolicitudRepository Ah_TipoSolicitud { get; }
        IAh_UsuariosRepository Ah_Usuarios { get; }
        IAh_AmbulanciasRepository ListaAmbulancia { get; }
        IListaPersonalRepository ListaPersonal { get; }
        IListaUbicacionRepository Ah_Regiones { get; }
        IAh_ProvinciasRepository Ah_Provincias { get; }
        IAh_DistritosRepository Ah_Distritos { get; }
        IEstadoAmbulanciaRepository Ah_Ambulancias { get; }
        IDeletePersonalRepository Ah_Personal { get; }
        IInsertPacienteRepository InsertPaciente { get; }
        IAh_ValidatorRepository Ah_Validator { get; }
        IAh_CentroSaludRepository Ah_CentroSalud { get; }
        IAh_SolicitudesRepository Ah_Solicitudes { get; }
        IListaSolicitudesRepository ListaSolicitudes { get; }
    }
}
