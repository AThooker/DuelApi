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
    public class VilliansController : ControllerBase
    {
        private readonly DuelDbContext _context;

        public VilliansController(DuelDbContext context)
        {
            _context = context;
        }

        // GET: api/Villians
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Villian>>> GetVillians()
        {
            return await _context.Villians.ToListAsync();
        }

        // GET: api/Villians/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Villian>> GetVillian(int id)
        {
            var villian = await _context.Villians.FindAsync(id);

            if (villian == null)
            {
                return NotFound();
            }

            return villian;
        }

        // PUT: api/Villians/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVillian(int id, Villian villian)
        {
            if (id != villian.Id)
            {
                return BadRequest();
            }

            _context.Entry(villian).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VillianExists(id))
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

        // POST: api/Villians
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Villian>> PostVillian(Villian villian)
        {
            _context.Villians.Add(villian);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVillian", new { id = villian.Id }, villian);
        }

        // DELETE: api/Villians/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillian(int id)
        {
            var villian = await _context.Villians.FindAsync(id);
            if (villian == null)
            {
                return NotFound();
            }

            _context.Villians.Remove(villian);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VillianExists(int id)
        {
            return _context.Villians.Any(e => e.Id == id);
        }
    }
}
