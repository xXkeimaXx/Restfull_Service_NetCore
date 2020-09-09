using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_ProvinciasRepository : IRepository<Ah_Provincias>
    {
        IEnumerable<Ah_Provincias> uspGetUbicacion(string Option, int IdNum);
    }
}
