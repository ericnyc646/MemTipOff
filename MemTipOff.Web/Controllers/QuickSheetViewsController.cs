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
    public class QuickSheetViewsController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public QuickSheetViewsController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/QuickSheetViews
        [HttpGet]
        public IEnumerable<QuickSheetViews> GetQuickSheetViews()
        {
            return _context.QuickSheetViews;
        }

        // GET: api/QuickSheetViews/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuickSheetViews([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheetViews = await _context.QuickSheetViews.FindAsync(id);

            if (quickSheetViews == null)
            {
                return NotFound();
            }

            return Ok(quickSheetViews);
        }

        // PUT: api/QuickSheetViews/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuickSheetViews([FromRoute] int id, [FromBody] QuickSheetViews quickSheetViews)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quickSheetViews.Id)
            {
                return BadRequest();
            }

            _context.Entry(quickSheetViews).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuickSheetViewsExists(id))
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

        // POST: api/QuickSheetViews
        [HttpPost]
        public async Task<IActionResult> PostQuickSheetViews([FromBody] QuickSheetViews quickSheetViews)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.QuickSheetViews.Add(quickSheetViews);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuickSheetViews", new { id = quickSheetViews.Id }, quickSheetViews);
        }

        // DELETE: api/QuickSheetViews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuickSheetViews([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quickSheetViews = await _context.QuickSheetViews.FindAsync(id);
            if (quickSheetViews == null)
            {
                return NotFound();
            }

            _context.QuickSheetViews.Remove(quickSheetViews);
            await _context.SaveChangesAsync();

            return Ok(quickSheetViews);
        }

        private bool QuickSheetViewsExists(int id)
        {
            return _context.QuickSheetViews.Any(e => e.Id == id);
        }
    }
}