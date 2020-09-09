using AmbuHelp.Models;

namespace AmbuHelp.Repositories
{
    public interface IEstadoAmbulanciaRepository : IRepository<Ah_Ambulancias>
    {
        Ah_Ambulancias uspUpdateEstado(string Option, string IdAmbulancia);
    }
}
