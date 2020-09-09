using System;

namespace AmbuHelp.Models
{
    public class ListaSolicitudes : Ah_Usuarios
    {
		public string Direccion { get; set; }
		public string NumCelular { get; set; }
		public string FechaNac { get; set; }
		public string TipoSol { get; set; }
		public string DesTipo { get; set; }
		public string Descripcion { get; set; }
		public string Fecha { get; set; }
		public string Hora { get; set; }
		public string GeoLat { get; set; }
		public string GeoLong { get; set; }
	}
}
