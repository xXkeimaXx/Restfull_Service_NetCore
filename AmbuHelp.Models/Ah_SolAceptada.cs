using System;

namespace AmbuHelp.Models
{
    public class Ah_SolAceptada
    {
        public string IdSolAceptada { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraAcep { get; set; }
        public DateTime HoraAtnd { get; set; }
        public string IdCentroSalud { get; set; }
        public string IdSolicitud { get; set; }
        public string IdAmbulancia { get; set; }
    }
}
