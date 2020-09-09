using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Solicitud")]
    [ApiController]
    [Authorize]
    public class Ah_SolicitudesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_SolicitudesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("Lista/{IdCent}")]
        public IActionResult GetListListaSolicitudes(string Option, string IdCent)
        {
            Option = "007";
            return Ok(_unitOfWork.ListaSolicitudes.uspGetList(Option, IdCent));
        }

        [HttpPost]
        [Route("registro/{Option}")]
        public IActionResult Post([FromBody] Ah_Solicitudes ah_Solicitudes, string Option)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.Ah_Solicitudes.uspInsertSolicitud(  Option, ah_Solicitudes.IdPaciente, 
                                                                      ah_Solicitudes.IdTipoEmergencia, 
                                                                      ah_Solicitudes.IdTipoSolicitud, 
                                                                      ah_Solicitudes.Descripcion,
                                                                      ah_Solicitudes.GeoLat,
                                                                      ah_Solicitudes.GeoLong));
        }
    }
}
