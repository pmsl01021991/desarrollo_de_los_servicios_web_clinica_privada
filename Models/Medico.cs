using System.ComponentModel.DataAnnotations;
 
namespace Examen_preliminar.Models
{
    public class Medico
    {
        public int Id { get; set; }
 
        [Required(ErrorMessage = "El nombre del médico no debe ir vacío")]
        [StringLength(30)]
        public string Nombre { get; set; } = "";
 
        [Required(ErrorMessage = "El nombre de la especialidad no debe ir vacía")]
        [StringLength(30)]
        public string Especialidad { get; set; } = "";
 
        [Required(ErrorMessage = "El nombre de la colegiatura no debe ir vacía")]
        [StringLength(30)]
        public string Colegiatura { get; set; } = "";
    }
}
