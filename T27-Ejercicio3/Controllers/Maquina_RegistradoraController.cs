using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T27_Ejercicio3;

namespace T27_Ejercicio3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Maquina_RegistradoraController : ControllerBase
    {
        private readonly APIContext _context;

        public Maquina_RegistradoraController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Maquina_Registradora
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maquina_Registradora>>> GetMaquina()
        {
            return await _context.Maquina.ToListAsync();
        }

        // GET: api/Maquina_Registradora/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Maquina_Registradora>> GetMaquina_Registradora(int id)
        {
            var maquina_Registradora = await _context.Maquina.FindAsync(id);

            if (maquina_Registradora == null)
            {
                return NotFound();
            }

            return maquina_Registradora;
        }

        // PUT: api/Maquina_Registradora/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaquina_Registradora(int id, Maquina_Registradora maquina_Registradora)
        {
            if (id != maquina_Registradora.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(maquina_Registradora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Maquina_RegistradoraExists(id))
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

        // POST: api/Maquina_Registradora
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Maquina_Registradora>> PostMaquina_Registradora(Maquina_Registradora maquina_Registradora)
        {
            _context.Maquina.Add(maquina_Registradora);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaquina_Registradora", new { id = maquina_Registradora.Codigo }, maquina_Registradora);
        }

        // DELETE: api/Maquina_Registradora/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Maquina_Registradora>> DeleteMaquina_Registradora(int id)
        {
            var maquina_Registradora = await _context.Maquina.FindAsync(id);
            if (maquina_Registradora == null)
            {
                return NotFound();
            }

            _context.Maquina.Remove(maquina_Registradora);
            await _context.SaveChangesAsync();

            return maquina_Registradora;
        }

        private bool Maquina_RegistradoraExists(int id)
        {
            return _context.Maquina.Any(e => e.Codigo == id);
        }
    }
}
