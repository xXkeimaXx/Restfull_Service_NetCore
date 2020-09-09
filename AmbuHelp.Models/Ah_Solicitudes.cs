using System;

namespace AmbuHelp.Models
{
    public class Ah_Solicitudes
    {
        public string IdSolicitud { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public bool EstadoSo { get; set; }
        public string Descripcion { get; set; }
        public string IdTipoEmergencia { get; set; }
        public string IdPaciente { get; set; }
        public int IdTipoSolicitud { get; set; }
        public string GeoLat { get; set; }
        public string GeoLong { get; set; }
    }
}
