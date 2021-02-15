using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T27_Ejercicio2.Models;

namespace T27_Ejercicio2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoesController : ControllerBase
    {
        private readonly APIContext _context;

        public ProyectoesController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Proyectoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyecto>>> GetProyectos()
        {
            return await _context.Proyectos.ToListAsync();
        }

        // GET: api/Proyectoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto>> GetProyecto(string id)
        {
            var proyecto = await _context.Proyectos.FindAsync(id);

            if (proyecto == null)
            {
                return NotFound();
            }

            return proyecto;
        }

        // PUT: api/Proyectoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyecto(string id, Proyecto proyecto)
        {
            if (id != proyecto.Id)
            {
                return BadRequest();
            }

            _context.Entry(proyecto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProyectoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Proyectoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Proyecto>> PostProyecto(Proyecto proyecto)
        {
            _context.Proyectos.Add(proyecto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProyectoExists(proyecto.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProyecto", new { id = proyecto.Id }, proyecto);
        }

        // DELETE: api/Proyectoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proyecto>> DeleteProyecto(string id)
        {
            var proyecto = await _context.Proyectos.FindAsync(id);
            if (proyecto == null)
            {
                return NotFound();
            }

            _context.Proyectos.Remove(proyecto);
            await _context.SaveChangesAsync();

            return proyecto;
        }

        private bool ProyectoExists(string id)
        {
            return _context.Proyectos.Any(e => e.Id == id);
        }
    }
}
