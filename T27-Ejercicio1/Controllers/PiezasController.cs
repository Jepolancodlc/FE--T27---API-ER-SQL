using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T27_Ejercicio1.Models;

namespace T27_Ejercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiezasController : ControllerBase
    {
        private readonly APIcontext _context;

        public PiezasController(APIcontext context)
        {
            _context = context;
        }

        // GET: api/Piezas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pieza>>> GetPieza()
        {
            return await _context.Pieza.ToListAsync();
        }

        // GET: api/Piezas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pieza>> GetPieza(int id)
        {
            var pieza = await _context.Pieza.FindAsync(id);

            if (pieza == null)
            {
                return NotFound();
            }

            return pieza;
        }

        // PUT: api/Piezas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPieza(int id, Pieza pieza)
        {
            if (id != pieza.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(pieza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PiezaExists(id))
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

        // POST: api/Piezas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pieza>> PostPieza(Pieza pieza)
        {
            _context.Pieza.Add(pieza);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPieza", new { id = pieza.Codigo }, pieza);
        }

        // DELETE: api/Piezas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pieza>> DeletePieza(int id)
        {
            var pieza = await _context.Pieza.FindAsync(id);
            if (pieza == null)
            {
                return NotFound();
            }

            _context.Pieza.Remove(pieza);
            await _context.SaveChangesAsync();

            return pieza;
        }

        private bool PiezaExists(int id)
        {
            return _context.Pieza.Any(e => e.Codigo == id);
        }
    }
}
