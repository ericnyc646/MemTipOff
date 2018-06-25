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
    public class TechCategoriesController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public TechCategoriesController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/TechCategories
        [HttpGet]
        public IEnumerable<TechCategories> GetTechCategories()
        {
            return _context.TechCategories;
        }

        // GET: api/TechCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTechCategories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var techCategories = await _context.TechCategories.FindAsync(id);

            if (techCategories == null)
            {
                return NotFound();
            }

            return Ok(techCategories);
        }

        // PUT: api/TechCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechCategories([FromRoute] int id, [FromBody] TechCategories techCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != techCategories.Id)
            {
                return BadRequest();
            }

            _context.Entry(techCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechCategoriesExists(id))
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

        // POST: api/TechCategories
        [HttpPost]
        public async Task<IActionResult> PostTechCategories([FromBody] TechCategories techCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TechCategories.Add(techCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechCategories", new { id = techCategories.Id }, techCategories);
        }

        // DELETE: api/TechCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTechCategories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var techCategories = await _context.TechCategories.FindAsync(id);
            if (techCategories == null)
            {
                return NotFound();
            }

            _context.TechCategories.Remove(techCategories);
            await _context.SaveChangesAsync();

            return Ok(techCategories);
        }

        private bool TechCategoriesExists(int id)
        {
            return _context.TechCategories.Any(e => e.Id == id);
        }
    }
}