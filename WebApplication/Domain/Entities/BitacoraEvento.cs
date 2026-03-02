using System


namespace WebApplication.Domain.Entities
{
    public class BitacoraEvento
    {
        public int Id { get; set; }
        
        public string Modulo { get; set; }

        public string Accion { get; set; }

        public string DatosAntes { get; set; }

        public string DatosDespues { get; set; }

        public DateTime Fecha { get; set; }

        public string Usuario { get; set; }

    }
}
