using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/EstadoAmbulancia")]
    [ApiController]
    [Authorize]
    public class EstAmbulanciaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstAmbulanciaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("Estado/{Option}")]
        public IActionResult Post([FromBody] Ah_Ambulancias ah_Ambulancias, string Option)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.Ah_Ambulancias.uspUpdateEstado(Option, ah_Ambulancias.IdAmbulancia));
        }


        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Post([FromBody] ListaAmbulancia listaAmbulancia, string Option)
        {
            Option = "002";
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.ListaAmbulancia.uspDeleteEntidad(Option, listaAmbulancia.IdAmbulancia));
        }

    }
}
