using System.ComponentModel.DataAnnotations;
 
namespace Examen_preliminar.Models
{
    public class Medico
    {
        public int Id { get; set; }
 
        [Required]
        public string Nombre { get; set; } = "";
 
        [Required]
        public string Especialidad { get; set; } = "";
 
        [Required]
        public string Colegiatura { get; set; } = "";
    }
}
