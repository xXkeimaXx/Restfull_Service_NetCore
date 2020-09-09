using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/TipoEmergencia")]
    [ApiController]
    [Authorize]
    public class Ah_TipoEmergenciaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_TipoEmergenciaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.Ah_TipoEmergencia.GetById(id));
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult GetListAh_TipoEmergencia(string Option)
        {
            Option = "001";
            return Ok(_unitOfWork.Ah_TipoEmergencia.uspGetList(Option));
        }
        [HttpPost]
        public IActionResult Post([FromBody]Ah_TipoEmergencia ah_TipoEmergencia)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.Ah_TipoEmergencia.insert(ah_TipoEmergencia));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Ah_TipoEmergencia ah_TipoEmergencia)
        {
            if (ModelState.IsValid && _unitOfWork.Ah_TipoEmergencia.Update(ah_TipoEmergencia))
            {
                return Ok(new { Message = "El Tipo de Emergencia fue actualizado"});
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Ah_TipoEmergencia ah_TipoEmergencia)
        {
            if (ah_TipoEmergencia.IdTipoEmergencia != "")
            
                return Ok(_unitOfWork.Ah_TipoEmergencia.Delete(ah_TipoEmergencia));
            return BadRequest();
        }
    }
}
