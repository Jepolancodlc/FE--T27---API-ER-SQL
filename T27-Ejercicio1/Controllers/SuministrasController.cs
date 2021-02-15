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
    public class SuministrasController : ControllerBase
    {
        private readonly APIcontext _context;

        public SuministrasController(APIcontext context)
        {
            _context = context;
        }

        // GET: api/Suministras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suministra>>> GetSuministra()
        {
            return await _context.Suministra.ToListAsync();
        }

        // GET: api/Suministras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Suministra>> GetSuministra(string id)
        {
            var suministra = await _context.Suministra.FindAsync(id);

            if (suministra == null)
            {
                return NotFound();
            }

            return suministra;
        }

        // PUT: api/Suministras/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuministra(string id, Suministra suministra)
        {
            if (id != suministra.IdProveedor)
            {
                return BadRequest();
            }

            _context.Entry(suministra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuministraExists(id))
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

        // POST: api/Suministras
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Suministra>> PostSuministra(Suministra suministra)
        {
            _context.Suministra.Add(suministra);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuministraExists(suministra.IdProveedor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuministra", new { id = suministra.IdProveedor }, suministra);
        }

        // DELETE: api/Suministras/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Suministra>> DeleteSuministra(string id)
        {
            var suministra = await _context.Suministra.FindAsync(id);
            if (suministra == null)
            {
                return NotFound();
            }

            _context.Suministra.Remove(suministra);
            await _context.SaveChangesAsync();

            return suministra;
        }

        private bool SuministraExists(string id)
        {
            return _context.Suministra.Any(e => e.IdProveedor == id);
        }
    }
}
