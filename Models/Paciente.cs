using System.ComponentModel.DataAnnotations;
 
namespace Examen_preliminar.Models
{
    public class Paciente
    {
        public int Id { get; set; }
 
        [Required(ErrorMessage = "Este campo del nombre no debe ir vacío")]
        public string Nombre { get; set; } = "";
 
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI debe tener 8 caracteres")]
        public string Dni { get; set; } = "";
 
        [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120")]
        public int Edad { get; set; }

        
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El teléfono debe tener 9 dígitos")]
        public string Telefono { get; set; } = "";
    }
}