using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoBra.Data;
using BoBra.Models;

namespace BoBra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Interest_RegController : ControllerBase
    {
        private readonly BoBraContext _context;

        public Interest_RegController(BoBraContext context)
        {
            _context = context;
        }

        // GET: api/Interest_Reg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interest_Reg>>> GetInterest_Regs()
        {
            return await _context.Interest_Regs.ToListAsync();
        }

        // GET: api/Interest_Reg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interest_Reg>> GetInterest_Reg(int id)
        {
            var interest_Reg = await _context.Interest_Regs.FindAsync(id);

            if (interest_Reg == null)
            {
                return NotFound();
            }

            return interest_Reg;
        }

        // PUT: api/Interest_Reg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInterest_Reg(int id, Interest_Reg interest_Reg)
        {
            if (id != interest_Reg.PropertyID)
            {
                return BadRequest();
            }

            _context.Entry(interest_Reg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Interest_RegExists(id))
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

        // POST: api/Interest_Reg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Interest_Reg>> PostInterest_Reg(Interest_Reg interest_Reg)
        {
            _context.Interest_Regs.Add(interest_Reg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Interest_RegExists(interest_Reg.PropertyID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInterest_Reg", new { id = interest_Reg.PropertyID }, interest_Reg);
        }

        // DELETE: api/Interest_Reg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterest_Reg(int id)
        {
            var interest_Reg = await _context.Interest_Regs.FindAsync(id);
            if (interest_Reg == null)
            {
                return NotFound();
            }

            _context.Interest_Regs.Remove(interest_Reg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Interest_RegExists(int id)
        {
            return _context.Interest_Regs.Any(e => e.PropertyID == id);
        }
    }
}
