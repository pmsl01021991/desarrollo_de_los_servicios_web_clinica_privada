using Microsoft.AspNetCore.Mvc;
using Examen_preliminar.Models;
 
namespace Examen_preliminar.Controllers
{
    [ApiController]
    [Route("api/citas")]
    public class CitasController : ControllerBase
    {
        private static List<Cita> _citas = new List<Cita>();
 
        [HttpGet]
        public IActionResult GetCitas()
        {
            try
            {
                return Ok(_citas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpGet("{id}")]
        public IActionResult GetCita(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("El id debe ser mayor que 0");
                }
 
                foreach (Cita c in _citas)
                {
                    if (c.Id == id)
                    {
                        return Ok(c);
                    }
                }
                return NotFound("Cita no encontrada");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPost]
        public IActionResult AgregarCita([FromBody] Cita nuevaCita)
        {
            try
            {
                if (nuevaCita == null)
                {
                    return BadRequest("Debe enviar los datos de la cita indicada");
                }
 
                if (string.IsNullOrWhiteSpace(nuevaCita.Paciente) || string.IsNullOrWhiteSpace(nuevaCita.Medico))
                {
                    return BadRequest("El paciente y el médico son obligatorios");
                }
 
                nuevaCita.Id = _citas.Count > 0 ? _citas.Max(c => c.Id) + 1 : 1;
                _citas.Add(nuevaCita);
 
                return Created($"api/citas/{nuevaCita.Id}", nuevaCita);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPut("{id}")]
        public IActionResult ActualizarCita(int id, [FromBody] Cita citaEditada)
        {
            try
            {
                if (id <= 0 || citaEditada == null)
                {
                    return BadRequest("Datos inválidos");
                }
 
                foreach (Cita c in _citas)
                {
                    if (c.Id == id)
                    {
                        c.Paciente = citaEditada.Paciente;
                        c.Medico = citaEditada.Medico;
                        c.Especialidad = citaEditada.Especialidad;
                        c.Fecha = citaEditada.Fecha;
                        c.Estado = citaEditada.Estado;
                        return Ok(c);
                    }
                }
                return NotFound("Cita no encontrada");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpDelete("{id}")]
        public IActionResult EliminarCita(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("El id debe ser mayor que 0");
 
                for (int i = 0; i < _citas.Count; i++)
                {
                    if (_citas[i].Id == id)
                    {
                        _citas.RemoveAt(i);
                        return Ok("Cita eliminada correctamente");
                    }
                }
                return NotFound("Cita no encontrada");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}