
using System;


namespace WebApplication.Models
{
    public class BitacoraEvento
    {
        public int IdEvento{ get; set; }
        
        public string TablaDeEvento { get; set; } = string.Empty;

        public string TipoDeEvento { get; set; } = string.Empty; 
        
        public DateTime FechaDeEvento { get; set; }

        public string DescripcionDeEvento { get; set; }

        public string StrackTrace { get; set; } = string.Empty;

        public string DatosAnteriores { get; set; }

        public string DatosPosteriores{ get; set; }

    }
}
