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
    public class DetalheProdutosController : ControllerBase
    {
        private readonly TelefericoWebAppContext _context;

        public DetalheProdutosController(TelefericoWebAppContext context)
        {
            _context = context;
        }

        // GET: api/DetalheProdutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalheProduto>>> GetDetalheProdutos()
        {
            return await _context.DetalheProdutos.ToListAsync();
        }

        // GET: api/DetalheProdutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalheProduto>> GetDetalheProduto(int id)
        {
            var detalheProduto = await _context.DetalheProdutos.FindAsync(id);

            if (detalheProduto == null)
            {
                return NotFound();
            }

            return detalheProduto;
        }

        // PUT: api/DetalheProdutos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalheProduto(int id, DetalheProduto detalheProduto)
        {
            if (id != detalheProduto.DetalheProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(detalheProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalheProdutoExists(id))
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

        // POST: api/DetalheProdutos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalheProduto>> PostDetalheProduto(DetalheProduto detalheProduto)
        {
            _context.DetalheProdutos.Add(detalheProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalheProduto", new { id = detalheProduto.DetalheProdutoId }, detalheProduto);
        }

        // DELETE: api/DetalheProdutos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalheProduto(int id)
        {
            var detalheProduto = await _context.DetalheProdutos.FindAsync(id);
            if (detalheProduto == null)
            {
                return NotFound();
            }

            _context.DetalheProdutos.Remove(detalheProduto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalheProdutoExists(int id)
        {
            return _context.DetalheProdutos.Any(e => e.DetalheProdutoId == id);
        }
    }
}
