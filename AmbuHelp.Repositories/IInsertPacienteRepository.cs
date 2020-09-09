using AmbuHelp.Models;
using System;

namespace AmbuHelp.Repositories
{
    public interface IInsertPacienteRepository: IRepository<InsertPacientes>
    {
        InsertPacientes uspInsertPaciente(  string userName,
                                            string password,
                                            string nombres,
                                            string apPaterno,
                                            string apMaterno,
                                            string docId,
                                            int ubigeo,
                                            string direccion,
                                            string numCelular,
                                            string correoPer,
                                            string coPariente,
                                            DateTime fechaNac);

    }
}
