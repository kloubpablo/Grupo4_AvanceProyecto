using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("COMERCIO_G4")]
    public class Comercio
    {
        [Key]
        public int IdComercio { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        public int TipoIdentificacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        public int TipoDeComercio { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(150)]
        public string? CorreoElectronico { get; set; }

        [StringLength(250)]
        public string? Direccion { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public DateTime? FechaDeModificacion { get; set; }

        public bool Estado { get; set; } = true;
    }
}
