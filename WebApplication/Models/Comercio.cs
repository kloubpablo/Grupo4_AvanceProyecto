using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("Comercio")]
    public class Comercio
    {
        [Key]
        public int IdComercio { get; set; }

        [Required]
        public string Identificacion { get; set; }

        public int TipoIdentificacion { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int TipoDeComercio { get; set; }

        public string Telefono { get; set; }

        public string CorreoElectronico { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public DateTime? FechaDeModificacion { get; set; }

        public bool Estado { get; set; }
    }
}
