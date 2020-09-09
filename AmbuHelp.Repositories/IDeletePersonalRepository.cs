using AmbuHelp.Models;

namespace AmbuHelp.Repositories
{
    public interface IDeletePersonalRepository : IRepository<Ah_Personal>
    {
        Ah_Personal uspDeleteEntidad(string Option, string IdPersonal);
    }
}
