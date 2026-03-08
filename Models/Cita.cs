using System.ComponentModel.DataAnnotations;

public class Cita
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del paciente es obligatorio")]
    [StringLength(100)]
    public string Paciente { get; set; } = "";

    [Required(ErrorMessage = "El médico es obligatorio")]
    public string Medico { get; set; } = "";

    [Required]
    public string Especialidad { get; set; } = "";

    [Required]
    public DateTime Fecha { get; set; }

    public string Estado { get; set; } = "Programada"; // Pendiente, Atendida, Cancelada
}