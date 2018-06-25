using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MemTipOff.Web.Models;

namespace MemTipOff.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologiesController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public TechnologiesController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/Technologies
        [HttpGet]
        public IEnumerable<Technologies> GetTechnologies()
        {
            return _context.Technologies;
        }

        // GET: api/Technologies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTechnologies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var technologies = await _context.Technologies.FindAsync(id);

            if (technologies == null)
            {
                return NotFound();
            }

            return Ok(technologies);
        }

        // PUT: api/Technologies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechnologies([FromRoute] int id, [FromBody] Technologies technologies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != technologies.Id)
            {
                return BadRequest();
            }

            _context.Entry(technologies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechnologiesExists(id))
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

        // POST: api/Technologies
        [HttpPost]
        public async Task<IActionResult> PostTechnologies([FromBody] Technologies technologies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Technologies.Add(technologies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechnologies", new { id = technologies.Id }, technologies);
        }

        // DELETE: api/Technologies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTechnologies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var technologies = await _context.Technologies.FindAsync(id);
            if (technologies == null)
            {
                return NotFound();
            }

            _context.Technologies.Remove(technologies);
            await _context.SaveChangesAsync();

            return Ok(technologies);
        }

        private bool TechnologiesExists(int id)
        {
            return _context.Technologies.Any(e => e.Id == id);
        }
    }
}