using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Provincia")]
    [ApiController]
    public class Ah_ProvinciasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_ProvinciasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("Lista/{IdNum:int}")]
        public IActionResult GetListAh_Provincias(string Option, int IdNum)
        {
            Option = "002";
            return Ok(_unitOfWork.Ah_Provincias.uspGetUbicacion(Option, IdNum));
        }
    }
}
