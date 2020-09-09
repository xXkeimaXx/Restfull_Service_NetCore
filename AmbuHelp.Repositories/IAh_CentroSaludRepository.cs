using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IAh_CentroSaludRepository: IRepository<Ah_CentroSalud>
    {
        IEnumerable<Ah_CentroSalud> uspGetList(string Option, string IdCent);
    }
}
