using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuHelp.Models
{
    public class InsertPacientes: Ah_Usuarios
    {
        public string NumCelular { get; set; }
        public string CorreoPer { get; set; }
        public string CoPariente { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
