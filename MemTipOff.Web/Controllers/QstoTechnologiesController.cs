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
    public class QstoTechnologiesController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public QstoTechnologiesController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/QstoTechnologies
        [HttpGet]
        public IEnumerable<QstoTechnologies> GetQstoTechnologies()
        {
            return _context.QstoTechnologies;
        }

        // GET: api/QstoTechnologies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQstoTechnologies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var qstoTechnologies = await _context.QstoTechnologies.FindAsync(id);

            if (qstoTechnologies == null)
            {
                return NotFound();
            }

            return Ok(qstoTechnologies);
        }

        // PUT: api/QstoTechnologies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQstoTechnologies([FromRoute] int id, [FromBody] QstoTechnologies qstoTechnologies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != qstoTechnologies.Id)
            {
                return BadRequest();
            }

            _context.Entry(qstoTechnologies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QstoTechnologiesExists(id))
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

        // POST: api/QstoTechnologies
        [HttpPost]
        public async Task<IActionResult> PostQstoTechnologies([FromBody] QstoTechnologies qstoTechnologies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.QstoTechnologies.Add(qstoTechnologies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQstoTechnologies", new { id = qstoTechnologies.Id }, qstoTechnologies);
        }

        // DELETE: api/QstoTechnologies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQstoTechnologies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var qstoTechnologies = await _context.QstoTechnologies.FindAsync(id);
            if (qstoTechnologies == null)
            {
                return NotFound();
            }

            _context.QstoTechnologies.Remove(qstoTechnologies);
            await _context.SaveChangesAsync();

            return Ok(qstoTechnologies);
        }

        private bool QstoTechnologiesExists(int id)
        {
            return _context.QstoTechnologies.Any(e => e.Id == id);
        }
    }
}