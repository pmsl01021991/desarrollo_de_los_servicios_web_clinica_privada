using System.ComponentModel.DataAnnotations;
 
namespace Examen_preliminar.Models
{
    public class Paciente
    {
        public int Id { get; set; }
 
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = "";
 
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI debe tener 8 caracteres")]
        public string Dni { get; set; } = "";
 
        public int Edad { get; set; }
        public string Telefono { get; set; } = "";
    }
}