using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoBra.Data;
using BoBra.Models;
using server.API.Attributes;

namespace BoBra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : Controller
    {
        private readonly BoBraContext _context;

        public PropertiesController(BoBraContext context)
        {
            _context = context;
        }

        // GET: api/Properties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
        {
            return await _context.Properties.ToListAsync();
        }

        // GET: api/Properties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(int id)
        {
            var @property = await _context.Properties.FindAsync(id);

            if (@property == null)
            {
                return NotFound();
            }

            return @property;
        }

        // PUT: api/Properties/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[GoogleAuthorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProperty(int id, Property @property)
        {
            var exists = _context.Properties.FirstOrDefault(e => e.PropertyID == id);

            if (exists == null)
            {
                return NotFound();
            }

            exists.Adress = property.Adress;
            exists.BuildYear = property.BuildYear;
            exists.LivingArea = property.LivingArea;
            exists.Rooms = property.Rooms;
            exists.HouseType = property.HouseType;
            exists.PlotArea = property.PlotArea;
            exists.BiArea = property.BiArea;
            exists.ViewingDate = property.ViewingDate;

            _context.Properties.Update(exists);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception exceptionex)
            {
                return BadRequest(exceptionex);
            }

            return Ok();
        }

        // POST: api/Properties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[GoogleAuthorize]
        [HttpPost]
        public async Task<ActionResult<Property>> PostProperty(Property @property)
        {
            _context.Properties.Add(@property);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProperty", new { id = @property.PropertyID }, @property);
        }

        // DELETE: api/Properties/5
        [HttpDelete("{id}")]
        //[GoogleAuthorize]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }

            _context.Properties.Remove(@property);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
    }
}
