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
    public class BrokerLoginsController : ControllerBase
    {
        private readonly BoBraContext _context;

        public BrokerLoginsController(BoBraContext context)
        {
            _context = context;
        }

        // GET: api/BrokerLogins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrokerLogin>>> GetBrokerLogins()
        {
            return await _context.BrokerLogins.ToListAsync();
        }

        // GET: api/BrokerLogins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BrokerLogin>> GetBrokerLogin(int id)
        {
            var brokerLogin = await _context.BrokerLogins.FindAsync(id);

            if (brokerLogin == null)
            {
                return NotFound();
            }

            return brokerLogin;
        }

        // PUT: api/BrokerLogins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrokerLogin(int id, BrokerLogin brokerLogin)
        {
            if (id != brokerLogin.MKID)
            {
                return BadRequest();
            }

            _context.Entry(brokerLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrokerLoginExists(id))
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

        // POST: api/BrokerLogins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BrokerLogin>> PostBrokerLogin(BrokerLogin brokerLogin)
        {
            _context.BrokerLogins.Add(brokerLogin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrokerLogin", new { id = brokerLogin.MKID }, brokerLogin);
        }

        // DELETE: api/BrokerLogins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrokerLogin(int id)
        {
            var brokerLogin = await _context.BrokerLogins.FindAsync(id);
            if (brokerLogin == null)
            {
                return NotFound();
            }

            _context.BrokerLogins.Remove(brokerLogin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BrokerLoginExists(int id)
        {
            return _context.BrokerLogins.Any(e => e.MKID == id);
        }
    }
}
