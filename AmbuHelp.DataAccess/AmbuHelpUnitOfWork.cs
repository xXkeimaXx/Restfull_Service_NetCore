using AmbuHelp.Repositories;
using AmbuHelp.UnitOfWork;

namespace AmbuHelp.DataAccess
{
    public class AmbuHelpUnitOfWork : IUnitOfWork
    {
        public AmbuHelpUnitOfWork(string connectionString)
        {
            Ah_TipoEmergencia = new Ah_TipoEmergenciaRepository(connectionString);

            Ah_TipoSolicitud = new Ah_TipoSolicitudRepository(connectionString);

            ListaAmbulancia = new Ah_AmbulanciasRepository(connectionString);

            Ah_Usuarios = new Ah_UsuariosRepository(connectionString);

            ListaPersonal = new ListaPersonalRepository(connectionString);

            Ah_Regiones = new ListaUbicacionRepository(connectionString);

            Ah_Provincias = new Ah_ProvinciasRepository(connectionString);

            Ah_Distritos = new Ah_DistritosRepository(connectionString);

            Ah_Ambulancias = new EstadoAmbulanciaRepository(connectionString);

            Ah_Personal = new DeletePersonalRepository(connectionString);

            InsertPaciente = new InsertPacienteRepository(connectionString);

            Ah_Validator = new Ah_ValidatorRepository(connectionString);

            Ah_CentroSalud = new Ah_CentroSaludRepository(connectionString);

            Ah_Solicitudes = new Ah_SolicitudesRepository(connectionString);

            ListaSolicitudes = new ListaSolicitudesRepository(connectionString);

        }
        public IAh_TipoEmergenciaRepository Ah_TipoEmergencia { get; private set; }

        public IAh_TipoSolicitudRepository Ah_TipoSolicitud { get; private set; }

        public IAh_UsuariosRepository Ah_Usuarios { get; private set; }

        public IAh_AmbulanciasRepository ListaAmbulancia { get; private set; }

        public IListaPersonalRepository ListaPersonal { get; private set; }

        public IListaUbicacionRepository Ah_Regiones { get; private set; }

        public IAh_ProvinciasRepository Ah_Provincias { get; private set; }

        public IAh_DistritosRepository Ah_Distritos { get; private set; }

        public IEstadoAmbulanciaRepository Ah_Ambulancias { get; private set; }

        public IDeletePersonalRepository Ah_Personal { get; private set; }

        public IInsertPacienteRepository InsertPaciente { get; private set; }

        public IAh_ValidatorRepository Ah_Validator { get; private set; }

        public IAh_CentroSaludRepository Ah_CentroSalud { get; private set; }

        public IAh_SolicitudesRepository Ah_Solicitudes { get; private set; }

        public IListaSolicitudesRepository ListaSolicitudes { get; private set; }
    }
}
