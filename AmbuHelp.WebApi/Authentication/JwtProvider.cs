using AmbuHelp.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace AmbuHelp.WebApi.Authentication
{
    public class JwtProvider : ITokenProvider
    {
        private RsaSecurityKey _key;
        private string _algoritm;
        private string _issuer;
        private string _audience;

        public JwtProvider(string issuer, string audience, string keyName)
        {
            var parameters = new CspParameters
            { 
                KeyContainerName = keyName,
                Flags = CspProviderFlags.UseMachineKeyStore
            };
            var provider = new RSACryptoServiceProvider(2048, parameters);
            _key = new RsaSecurityKey(provider);
            _algoritm = SecurityAlgorithms.RsaSha256Signature;
            _issuer = issuer;
            _audience = audience;
        }
        public string CreateToken(Ah_Usuarios user, DateTime expiry)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var identity = new ClaimsIdentity(new List<Claim>()
                                {
                                    new Claim(ClaimTypes.Name,$"{user.Nombres}"),
                                    new Claim(ClaimTypes.NameIdentifier,$"{user.ApPaterno} {user.ApMaterno}"),
                                    new Claim(ClaimTypes.GivenName,$"{user.IdCentroSalud}"),
                                    new Claim(ClaimTypes.Role, user.IdTipoUsu),
                                    new Claim(ClaimTypes.Surname, user.IdAmbulancia),
                                    new Claim(ClaimTypes.PrimarySid, user.IdUsuario.ToString())
                                }, "Custom");
            SecurityToken token = tokenHandler.CreateJwtSecurityToken(new SecurityTokenDescriptor
            {
                Audience = _audience,
                Issuer = _issuer,
                SigningCredentials = new SigningCredentials(_key, _algoritm),
                Expires = expiry.ToUniversalTime(),
                Subject = identity
            }) ;
            return tokenHandler.WriteToken(token);
        }

        public TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters
            {
                IssuerSigningKey = _key,
                ValidAudience = _audience,
                ValidIssuer = _issuer,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromSeconds(0)
            };
        }
    }
}
