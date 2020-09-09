using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/TipoSolicitud")]
    [ApiController]
    [Authorize]
    public class Ah_TipoSolicitudController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_TipoSolicitudController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.Ah_TipoSolicitud.GetById(id));
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult GetListAh_TipoSolicitud(string Option)
        {
            Option = "002";
            return Ok(_unitOfWork.Ah_TipoSolicitud.uspGetList(Option));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Ah_TipoSolicitud ah_TipoSolicitud)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.Ah_TipoSolicitud.insert(ah_TipoSolicitud));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ah_TipoSolicitud ah_TipoSolicitud)
        {
            if (ModelState.IsValid && _unitOfWork.Ah_TipoSolicitud.Update(ah_TipoSolicitud))
            {
                return Ok(new { Message = "El Tipo de Solicitud fue actualizado" });
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Ah_TipoSolicitud ah_TipoSolicitud)
        {
            if (ah_TipoSolicitud.IdTipoSolicitud > 0)
                return Ok(_unitOfWork.Ah_TipoSolicitud.Delete(ah_TipoSolicitud));
            return BadRequest();
        }
    }
}
