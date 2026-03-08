using Microsoft.AspNetCore.Mvc;
using Examen_preliminar.Models;
 
namespace Examen_preliminar.Controllers
{
    [ApiController]
    [Route("api/pacientes")]
    public class PacientesController : ControllerBase
    {
        private static List<Paciente> _pacientes = new List<Paciente>();
 
        [HttpGet]
        public IActionResult GetPacientes()
        {
            try
            {
                return Ok(_pacientes);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpGet("{id}")]
        public IActionResult GetPaciente(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("El id debe ser mayor que 0");
 
                foreach (Paciente p in _pacientes)
                {
                    if (p.Id == id) return Ok(p);
                }
                return NotFound("Paciente no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPost]
        public IActionResult AgregarPaciente([FromBody] Paciente nuevoPaciente)
        {
            try
            {
                if (nuevoPaciente == null) return BadRequest("Debe enviar los datos del paciente");
                if (string.IsNullOrWhiteSpace(nuevoPaciente.Nombre)) return BadRequest("El nombre es obligatorio");
 
                nuevoPaciente.Id = _pacientes.Count > 0 ? _pacientes.Max(p => p.Id) + 1 : 1;
                _pacientes.Add(nuevoPaciente);
 
                return Created($"api/pacientes/{nuevoPaciente.Id}", nuevoPaciente);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPut("{id}")]
        public IActionResult ActualizarPaciente(int id, [FromBody] Paciente pacienteEditado)
        {
            try
            {
                if (id <= 0 || pacienteEditado == null) return BadRequest("Datos inválidos");
 
                foreach (Paciente p in _pacientes)
                {
                    if (p.Id == id)
                    {
                        p.Nombre = pacienteEditado.Nombre;
                        p.Dni = pacienteEditado.Dni;
                        p.Edad = pacienteEditado.Edad;
                        p.Telefono = pacienteEditado.Telefono;
                        return Ok(p);
                    }
                }
                return NotFound("Paciente no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpDelete("{id}")]
        public IActionResult EliminarPaciente(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("El id debe ser mayor que 0");
 
                for (int i = 0; i < _pacientes.Count; i++)
                {
                    if (_pacientes[i].Id == id)
                    {
                        _pacientes.RemoveAt(i);
                        return Ok("Paciente eliminado correctamente");
                    }
                }
                return NotFound("Paciente no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}