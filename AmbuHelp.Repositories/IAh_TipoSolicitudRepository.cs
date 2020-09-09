using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_TipoSolicitudRepository : IRepository<Ah_TipoSolicitud>
    {
        IEnumerable<Ah_TipoSolicitud> uspGetList(string Option);
    }
}
