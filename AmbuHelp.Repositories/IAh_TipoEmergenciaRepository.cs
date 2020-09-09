using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_TipoEmergenciaRepository : IRepository<Ah_TipoEmergencia>
    {
        IEnumerable<Ah_TipoEmergencia> uspGetList(string Option);
    }
}
