using AmbuHelp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuHelp.Repositories
{
    public interface IAh_UsuariosRepository : IRepository<Ah_Usuarios>
    {
        Ah_Usuarios uspValidateUser(string userName, string password);
    }
}
