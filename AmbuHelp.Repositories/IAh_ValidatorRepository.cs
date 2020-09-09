using AmbuHelp.Models;

namespace AmbuHelp.Repositories
{
    public interface IAh_ValidatorRepository: IRepository<Ah_Validator>
    {
        Ah_Validator uspValidAdmin(string codigo);
    }
}
