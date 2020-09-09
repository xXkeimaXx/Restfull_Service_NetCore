using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Personal")]
    [ApiController]
    [Authorize]
    public class ListaPersonalController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ListaPersonalController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.ListaPersonal.GetById(id));
        }

        [HttpGet]
        [Route("Lista/{IdCent}")]
        public IActionResult GetListListaPersonal(string Option, string IdCent)
        {
            Option = "003";
            return Ok(_unitOfWork.ListaPersonal.uspGetList(Option, IdCent));
        }
        [HttpPost]
        [Route("{Option}")]
        public IActionResult Post([FromBody] ListaPersonal listaPersonal, string Option)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.ListaPersonal.uspInsertPersonal(Option,listaPersonal.UserName,listaPersonal.Password,listaPersonal.Nombres,
                                                                  listaPersonal.ApPaterno,listaPersonal.ApMaterno,listaPersonal.DocId,
                                                                  listaPersonal.Ubigeo,listaPersonal.Validacion,listaPersonal.Direccion,
                                                                  listaPersonal.IdAmbulancia, listaPersonal.IdCentroSalud));
        }

        [HttpPost]
        [Route("Eliminar")]
        public IActionResult Post([FromBody] Ah_Personal ah_personal, string Option)
        {
            Option = "001";
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.Ah_Personal.uspDeleteEntidad(Option, ah_personal.IdPersonal));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] ListaPersonal listaPersonal)
        {
            if (listaPersonal.IdPersonal != null)
                return Ok(_unitOfWork.ListaPersonal.Delete(listaPersonal));
            return BadRequest();
        }
    }
}
