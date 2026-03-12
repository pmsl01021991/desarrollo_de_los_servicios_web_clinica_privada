using System.ComponentModel.DataAnnotations;

public class Cita
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del paciente es obligatorio")]
    [StringLength(30)]
    public string Paciente { get; set; } = "";

    [Required(ErrorMessage = "El nombre del médico es obligatorio")]
    [StringLength(30)]
    public string Medico { get; set; } = "";

    [Required(ErrorMessage = "El nombre de la especialidad es obligatorio")]
    [StringLength(30)]
    public string Especialidad { get; set; } = "";

    [Required(ErrorMessage = "La fecha es obligatoria")]
    [DataType(DataType.DateTime)]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El estado de la cita es obligatorio")]
    [StringLength(30)]
    public string Estado { get; set; } = "Programada"; // Pendiente, Atendida, Cancelada
}