using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleDuelApi.Data;

namespace SimpleDuelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaknessesController : ControllerBase
    {
        private readonly DuelDbContext _context;

        public WeaknessesController(DuelDbContext context)
        {
            _context = context;
        }

        // GET: api/Weaknesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weakness>>> GetWeaknesses()
        {
            return await _context.Weaknesses.ToListAsync();
        }

        // GET: api/Weaknesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weakness>> GetWeakness(int id)
        {
            var weakness = await _context.Weaknesses.FindAsync(id);

            if (weakness == null)
            {
                return NotFound();
            }

            return weakness;
        }

        // PUT: api/Weaknesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeakness(int id, Weakness weakness)
        {
            if (id != weakness.Id)
            {
                return BadRequest();
            }

            _context.Entry(weakness).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaknessExists(id))
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

        // POST: api/Weaknesses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weakness>> PostWeakness(Weakness weakness)
        {
            _context.Weaknesses.Add(weakness);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeakness", new { id = weakness.Id }, weakness);
        }

        // DELETE: api/Weaknesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeakness(int id)
        {
            var weakness = await _context.Weaknesses.FindAsync(id);
            if (weakness == null)
            {
                return NotFound();
            }

            _context.Weaknesses.Remove(weakness);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaknessExists(int id)
        {
            return _context.Weaknesses.Any(e => e.Id == id);
        }
    }
}
