using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Centrosalud")]
    [ApiController]
    public class Ah_CentroSaludController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_CentroSaludController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        [Route("Lista")]
        public IActionResult GetListListaCentroSalud(string Option)
        {
            Option = "006";
            return Ok(_unitOfWork.Ah_CentroSalud.uspGetList(Option, ""));
        }

    }

}
