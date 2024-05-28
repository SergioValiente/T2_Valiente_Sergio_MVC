using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T2_Valiente_Sergio.Models
{
    public class Distribuidor
    {
        [Key]
        
        [Required(ErrorMessage = "El campo Id es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo NombreDistribuidor es obligatorio.")]
        public string NombreDistribuidor { get; set; }
       
        [Required(ErrorMessage = "El campo RazonSocial es obligatorio.")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [Phone(ErrorMessage = "El campo Telefono no es un número de teléfono válido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo AnioInicioOperacion es obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El campo AnioInicioOperacion debe estar entre 1900 y 3000.")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El campo Contacto es obligatorio.")]
        public string Contacto { get; set; }
    }
}