using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefericoWebApp.Data;
using TelefericoWebApp.Models;

namespace TelefericoWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValoresController : ControllerBase
    {
        private readonly TelefericoWebAppContext _context;

        public ValoresController(TelefericoWebAppContext context)
        {
            _context = context;
        }

        // GET: api/Valores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Valor>>> GetValor()
        {
            return await _context.Valor.ToListAsync();
        }

        // GET: api/Valores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Valor>> GetValor(int id)
        {
            var valor = await _context.Valor.FindAsync(id);

            if (valor == null)
            {
                return NotFound();
            }

            return valor;
        }

        // PUT: api/Valores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutValor(int id, Valor valor)
        {
            if (id != valor.ValorId)
            {
                return BadRequest();
            }

            _context.Entry(valor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValorExists(id))
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

        // POST: api/Valores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Valor>> PostValor(Valor valor)
        {
            _context.Valor.Add(valor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetValor", new { id = valor.ValorId }, valor);
        }

        // DELETE: api/Valores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteValor(int id)
        {
            var valor = await _context.Valor.FindAsync(id);
            if (valor == null)
            {
                return NotFound();
            }

            _context.Valor.Remove(valor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ValorExists(int id)
        {
            return _context.Valor.Any(e => e.ValorId == id);
        }
    }
}
