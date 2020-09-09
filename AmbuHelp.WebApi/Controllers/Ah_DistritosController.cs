using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Distrito")]
    [ApiController]
    public class Ah_DistritosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_DistritosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("Lista/{IdNum:int}")]
        public IActionResult GetListAh_Distritos(string Option, int IdNum)
        {
            Option = "003";
            return Ok(_unitOfWork.Ah_Distritos.uspGetUbicacion(Option, IdNum));
        }
    }
}
