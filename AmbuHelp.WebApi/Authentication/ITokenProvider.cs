using AmbuHelp.Models;
using Microsoft.IdentityModel.Tokens;
using System;

namespace AmbuHelp.WebApi.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(Ah_Usuarios user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();
    }
}
