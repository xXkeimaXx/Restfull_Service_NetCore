using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_AmbulanciasRepository : IRepository<ListaAmbulancia>
    {
        IEnumerable<ListaAmbulancia> uspGetList(string Option, string IdCent);
        ListaAmbulancia uspInsertAmbulancia(string IdCent, string PlacaVehicular, string TipoAmbulancia);
        ListaAmbulancia uspDeleteEntidad(string Option, string IdAmbulancia);
    }
}
