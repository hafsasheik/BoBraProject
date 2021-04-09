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
    public class Broker_PropertyController : ControllerBase
    {
        private readonly BoBraContext _context;

        public Broker_PropertyController(BoBraContext context)
        {
            _context = context;
        }

        // GET: api/Broker_Property
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Broker_Property>>> GetBroker_Properties()
        {
            return await _context.Broker_Properties.ToListAsync();
        }

        // GET: api/Broker_Property/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Broker_Property>> GetBroker_Property(int id)
        {
            var broker_Property = await _context.Broker_Properties.FindAsync(id);

            if (broker_Property == null)
            {
                return NotFound();
            }

            return broker_Property;
        }

        // PUT: api/Broker_Property/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBroker_Property(int id, Broker_Property broker_Property)
        {
            if (id != broker_Property.BrokerID)
            {
                return BadRequest();
            }

            _context.Entry(broker_Property).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Broker_PropertyExists(id))
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

        // POST: api/Broker_Property
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Broker_Property>> PostBroker_Property(Broker_Property broker_Property)
        {
            _context.Broker_Properties.Add(broker_Property);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Broker_PropertyExists(broker_Property.BrokerID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBroker_Property", new { id = broker_Property.BrokerID }, broker_Property);
        }

        // DELETE: api/Broker_Property/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBroker_Property(int id)
        {
            var broker_Property = await _context.Broker_Properties.FindAsync(id);
            if (broker_Property == null)
            {
                return NotFound();
            }

            _context.Broker_Properties.Remove(broker_Property);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Broker_PropertyExists(int id)
        {
            return _context.Broker_Properties.Any(e => e.BrokerID == id);
        }
    }
}
