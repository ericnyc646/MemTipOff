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
    public class QuickSheetsController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public QuickSheetsController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/QuickSheets
        [HttpGet]
        public IEnumerable<QuickSheets> GetQuickSheets()
        {
            return _context.QuickSheets;
        }

        // GET: api/QuickSheets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuickSheets([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheets = await _context.QuickSheets.FindAsync(id);

            if (quickSheets == null)
            {
                return NotFound();
            }

            return Ok(quickSheets);
        }

        // PUT: api/QuickSheets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuickSheets([FromRoute] int id, [FromBody] QuickSheets quickSheets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quickSheets.Id)
            {
                return BadRequest();
            }

            _context.Entry(quickSheets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuickSheetsExists(id))
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

        // POST: api/QuickSheets
        [HttpPost]
        public async Task<IActionResult> PostQuickSheets([FromBody] QuickSheets quickSheets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.QuickSheets.Add(quickSheets);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuickSheets", new { id = quickSheets.Id }, quickSheets);
        }

        // DELETE: api/QuickSheets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuickSheets([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheets = await _context.QuickSheets.FindAsync(id);
            if (quickSheets == null)
            {
                return NotFound();
            }

            _context.QuickSheets.Remove(quickSheets);
            await _context.SaveChangesAsync();

            return Ok(quickSheets);
        }

        private bool QuickSheetsExists(int id)
        {
            return _context.QuickSheets.Any(e => e.Id == id);
        }
    }
}