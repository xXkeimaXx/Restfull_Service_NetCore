using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_DistritosRepository: IRepository<Ah_Distritos>
    {
        IEnumerable<Ah_Distritos> uspGetUbicacion(string Option, int IdNum);
    }
}
