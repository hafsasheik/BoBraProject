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
    public class BrokersController : ControllerBase
    {
        private readonly BoBraContext _context;

        public BrokersController(BoBraContext context)
        {
            _context = context;
        }

        // GET: api/Brokers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Broker>>> GetBrokers()
        {
            return await _context.Brokers.ToListAsync();
        }

        // GET: api/Brokers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Broker>> GetBroker(int id)
        {
            var broker = await _context.Brokers.FindAsync(id);

            if (broker == null)
            {
                return NotFound();
            }

            return broker;
        }

        // PUT: api/Brokers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBroker(int id, Broker broker)
        {
            if (id != broker.BrokerID)
            {
                return BadRequest();
            }

            _context.Entry(broker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrokerExists(id))
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

        // POST: api/Brokers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Broker>> PostBroker(Broker broker)
        {
            _context.Brokers.Add(broker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBroker", new { id = broker.BrokerID }, broker);
        }

        // DELETE: api/Brokers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBroker(int id)
        {
            var broker = await _context.Brokers.FindAsync(id);
            if (broker == null)
            {
                return NotFound();
            }

            _context.Brokers.Remove(broker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BrokerExists(int id)
        {
            return _context.Brokers.Any(e => e.BrokerID == id);
        }
    }
}
