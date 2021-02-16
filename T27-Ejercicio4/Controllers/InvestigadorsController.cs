using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T27_Ejercicio4.Modelos;

namespace T27_Ejercicio4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestigadorsController : ControllerBase
    {
        private readonly APIContext _context;

        public InvestigadorsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Investigadors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Investigador>>> GetInvestigadores()
        {
            return await _context.Investigadores.ToListAsync();
        }

        // GET: api/Investigadors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Investigador>> GetInvestigador(string id)
        {
            var investigador = await _context.Investigadores.FindAsync(id);

            if (investigador == null)
            {
                return NotFound();
            }

            return investigador;
        }

        // PUT: api/Investigadors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvestigador(string id, Investigador investigador)
        {
            if (id != investigador.DNI)
            {
                return BadRequest();
            }

            _context.Entry(investigador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvestigadorExists(id))
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

        // POST: api/Investigadors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Investigador>> PostInvestigador(Investigador investigador)
        {
            _context.Investigadores.Add(investigador);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InvestigadorExists(investigador.DNI))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInvestigador", new { id = investigador.DNI }, investigador);
        }

        // DELETE: api/Investigadors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Investigador>> DeleteInvestigador(string id)
        {
            var investigador = await _context.Investigadores.FindAsync(id);
            if (investigador == null)
            {
                return NotFound();
            }

            _context.Investigadores.Remove(investigador);
            await _context.SaveChangesAsync();

            return investigador;
        }

        private bool InvestigadorExists(string id)
        {
            return _context.Investigadores.Any(e => e.DNI == id);
        }
    }
}
