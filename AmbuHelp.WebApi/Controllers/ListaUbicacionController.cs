using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Ubicacion")]
    [ApiController]
    public class ListaUbicacionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ListaUbicacionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("Lista/{IdNum:int}")]
        public IActionResult GetListListaUbicacion(string Option, int IdNum)
        {
            Option = "001";
            return Ok(_unitOfWork.Ah_Regiones.uspGetUbicacion(Option,IdNum));
        }
    }
}
