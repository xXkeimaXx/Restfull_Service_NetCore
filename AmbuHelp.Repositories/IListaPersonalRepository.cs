using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IListaPersonalRepository : IRepository<ListaPersonal>
    {
        IEnumerable<ListaPersonal> uspGetList(string Option, string IdCent);
        ListaPersonal uspInsertPersonal(string Option, 
                                        string userName, 
                                        string password, 
                                        string nombres, 
                                        string apPaterno,
                                        string apMaterno,
                                        string docId,
                                        int ubigeo,
                                        string validacion,
                                        string direccion,
                                        string idAmbulancia,
                                        string idCentroSalud);
    }
}
