using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IListaUbicacionRepository : IRepository<Ah_Regiones>
    {
        IEnumerable<Ah_Regiones> uspGetUbicacion(string Option, int IdNum);
    }
}
