using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using AmbuHelp.WebApi.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private ITokenProvider _tokenProvider;
        private IUnitOfWork _unitOfWork;

        public TokenController(ITokenProvider tokenProvider,IUnitOfWork unitOfWork)
        {
            _tokenProvider = tokenProvider;
            _unitOfWork = unitOfWork; 
        }

        [HttpPost]
        public JsonWebToken Post([FromBody]Ah_Usuarios userLogin)
        {
            

            var user = _unitOfWork.Ah_Usuarios.uspValidateUser(userLogin.UserName, userLogin.Password);
            if (user == null || user.IdUsuario == "" )
            {
                throw new UnauthorizedAccessException();
            }

            var token = new JsonWebToken
            {
                Access_Token = _tokenProvider.CreateToken(user, DateTime.UtcNow.AddHours(3)),
                Expires_in = 180 //minutes
            };

            return token;
        }
    }
}
