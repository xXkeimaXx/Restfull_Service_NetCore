using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Validator")]
    [ApiController]
    public class Ah_ValidatorController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public Ah_ValidatorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ah_Validator ah_Validator)
        {
            var user = _unitOfWork.Ah_Validator.uspValidAdmin(ah_Validator.codigos);
            if (user == null || user.codigos == "")
            {
                throw new UnauthorizedAccessException();
            }
            return Ok(user);
        }
    }
}
