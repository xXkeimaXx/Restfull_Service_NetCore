namespace AmbuHelp.Models
{
    public class ListaPersonal: Ah_Usuarios
    {
        //public string IdUsuario { get; set; }
        public string IdPersonal { get; set; }
        //public string UserName { get; set; }
        //public string Nombres { get; set; }
        //public string ApPaterno { get; set; }
        //public string ApMaterno { get; set; }
        //public string DocId { get; set; }
        public string Direccion { get; set; }
        public string IdAmbulancia { get; set; }
        public string IdCentroSalud { get; set; }
        public string PlacaVehicular { get; set; }
    }
}
