using AmbuHelp.Models;
using System.Collections.Generic;

namespace AmbuHelp.Repositories
{
    public interface IListaSolicitudesRepository: IRepository<ListaSolicitudes>
    {
        IEnumerable<ListaSolicitudes> uspGetList(string Option, string IdCent);
    }
}
