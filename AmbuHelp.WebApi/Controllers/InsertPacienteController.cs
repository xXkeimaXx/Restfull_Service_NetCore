using AmbuHelp.Models;
using AmbuHelp.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmbuHelp.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/InsertPac")]
    [ApiController]
    public class InsertPacienteController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InsertPacienteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("Insert")]
        public IActionResult Post([FromBody] InsertPacientes insertPaciente)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.InsertPaciente.uspInsertPaciente(insertPaciente.UserName,
                                                                    insertPaciente.Password,
                                                                    insertPaciente.Nombres,
                                                                    insertPaciente.ApPaterno,
                                                                    insertPaciente.ApMaterno,
                                                                    insertPaciente.DocId,
                                                                    insertPaciente.Ubigeo,
                                                                    insertPaciente.Direccion,
                                                                    insertPaciente.NumCelular,
                                                                    insertPaciente.CorreoPer,
                                                                    insertPaciente.CoPariente,
                                                                    insertPaciente.FechaNac));
        }

        [HttpPost]
        [Route("Admin")]
        public IActionResult Post([FromBody] ListaPersonal listaPersonal, string Option)
        {
            Option = "002";
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_unitOfWork.ListaPersonal.uspInsertPersonal(  Option, 
                                                                    listaPersonal.UserName, 
                                                                    listaPersonal.Password, 
                                                                    listaPersonal.Nombres,
                                                                    listaPersonal.ApPaterno, 
                                                                    listaPersonal.ApMaterno, 
                                                                    listaPersonal.DocId,
                                                                    listaPersonal.Ubigeo, 
                                                                    listaPersonal.Validacion, 
                                                                    listaPersonal.Direccion,
                                                                    listaPersonal.IdAmbulancia, 
                                                                    listaPersonal.IdCentroSalud));
        }

    }
}
