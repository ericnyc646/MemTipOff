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
    public class QuickSheetRatingsController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public QuickSheetRatingsController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/QuickSheetRatings
        [HttpGet]
        public IEnumerable<QuickSheetRatings> GetQuickSheetRatings()
        {
            return _context.QuickSheetRatings;
        }

        // GET: api/QuickSheetRatings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuickSheetRatings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheetRatings = await _context.QuickSheetRatings.FindAsync(id);

            if (quickSheetRatings == null)
            {
                return NotFound();
            }

            return Ok(quickSheetRatings);
        }

        // PUT: api/QuickSheetRatings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuickSheetRatings([FromRoute] int id, [FromBody] QuickSheetRatings quickSheetRatings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quickSheetRatings.Id)
            {
                return BadRequest();
            }

            _context.Entry(quickSheetRatings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuickSheetRatingsExists(id))
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

        // POST: api/QuickSheetRatings
        [HttpPost]
        public async Task<IActionResult> PostQuickSheetRatings([FromBody] QuickSheetRatings quickSheetRatings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.QuickSheetRatings.Add(quickSheetRatings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuickSheetRatings", new { id = quickSheetRatings.Id }, quickSheetRatings);
        }

        // DELETE: api/QuickSheetRatings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuickSheetRatings([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheetRatings = await _context.QuickSheetRatings.FindAsync(id);
            if (quickSheetRatings == null)
            {
                return NotFound();
            }

            _context.QuickSheetRatings.Remove(quickSheetRatings);
            await _context.SaveChangesAsync();

            return Ok(quickSheetRatings);
        }

        private bool QuickSheetRatingsExists(int id)
        {
            return _context.QuickSheetRatings.Any(e => e.Id == id);
        }
    }
}