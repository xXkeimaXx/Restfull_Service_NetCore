using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Ambulancias")]
    [ApiController]
    [Authorize]
    public class Ah_AmbulanciasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Ah_AmbulanciasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.ListaAmbulancia.GetById(id));
        }

        [HttpGet]
        [Route("Lista/{IdCent}")]
        public IActionResult GetListListaAmbulancia(string Option, string IdCent)
        {
            Option = "004";
            return Ok(_unitOfWork.ListaAmbulancia.uspGetList(Option, IdCent));
        }

        [HttpGet]
        [Route("FueraServicio/{IdCent}")]
        public IActionResult GetListAmbulanciaFServicio(string Option, string IdCent)
        {
            Option = "005";
            return Ok(_unitOfWork.ListaAmbulancia.uspGetList(Option, IdCent));
        }
        [HttpPost]
        [Route("registro/{IdCent}")]
        public IActionResult Post([FromBody] ListaAmbulancia listaAmbulancia, string IdCent)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.ListaAmbulancia.uspInsertAmbulancia(IdCent, listaAmbulancia.PlacaVehicular, listaAmbulancia.TipoAmbulancia));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] ListaAmbulancia listaAmbulancia)
        {
            if (listaAmbulancia.IdAmbulancia != null)
                return Ok(_unitOfWork.ListaAmbulancia.Delete(listaAmbulancia));
            return BadRequest();
        }
    }
}
