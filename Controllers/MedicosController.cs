using Microsoft.AspNetCore.Mvc;
using Examen_preliminar.Models;
 
namespace Examen_preliminar.Controllers
{
    [ApiController]
    [Route("api/medicos")]
    public class MedicosController : ControllerBase
    {
        private static List<Medico> _medicos = new List<Medico>();
 
        [HttpGet]
        public IActionResult GetMedicos()
        {
            try
            {
                return Ok(_medicos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpGet("{id}")]
        public IActionResult GetMedico(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("El id debe ser mayor que 0");
 
                foreach (Medico m in _medicos)
                {
                    if (m.Id == id) return Ok(m);
                }
                return NotFound("Médico no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPost]
        public IActionResult AgregarMedico([FromBody] Medico nuevoMedico)
        {
            try
            {
                if (nuevoMedico == null) return BadRequest("Debe enviar los datos del médico");
                if (string.IsNullOrWhiteSpace(nuevoMedico.Nombre)) return BadRequest("El nombre es obligatorio");
 
                nuevoMedico.Id = _medicos.Count > 0 ? _medicos.Max(m => m.Id) + 1 : 1;
                _medicos.Add(nuevoMedico);
 
                return Created($"api/medicos/{nuevoMedico.Id}", nuevoMedico);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpPut("{id}")]
        public IActionResult ActualizarMedico(int id, [FromBody] Medico medicoEditado)
        {
            try
            {
                if (id <= 0 || medicoEditado == null) return BadRequest("Datos inválidos");
 
                foreach (Medico m in _medicos)
                {
                    if (m.Id == id)
                    {
                        m.Nombre = medicoEditado.Nombre;
                        m.Especialidad = medicoEditado.Especialidad;
                        m.Colegiatura = medicoEditado.Colegiatura;
                        return Ok(m);
                    }
                }
                return NotFound("Médico no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
 
        [HttpDelete("{id}")]
        public IActionResult EliminarMedico(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("El id debe ser mayor que 0");
 
                for (int i = 0; i < _medicos.Count; i++)
                {
                    if (_medicos[i].Id == id)
                    {
                        _medicos.RemoveAt(i);
                        return Ok("Médico eliminado correctamente");
                    }
                }
                return NotFound("Médico no encontrado");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}