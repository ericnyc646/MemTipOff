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
    public class UserRolesController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public UserRolesController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/UserRoles
        [HttpGet]
        public IEnumerable<UserRoles> GetUserRoles()
        {
            return _context.UserRoles;
        }

        // GET: api/UserRoles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRoles([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRoles = await _context.UserRoles.FindAsync(id);

            if (userRoles == null)
            {
                return NotFound();
            }

            return Ok(userRoles);
        }

        // PUT: api/UserRoles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRoles([FromRoute] int id, [FromBody] UserRoles userRoles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userRoles.Id)
            {
                return BadRequest();
            }

            _context.Entry(userRoles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRolesExists(id))
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

        // POST: api/UserRoles
        [HttpPost]
        public async Task<IActionResult> PostUserRoles([FromBody] UserRoles userRoles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserRoles.Add(userRoles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserRoles", new { id = userRoles.Id }, userRoles);
        }

        // DELETE: api/UserRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoles([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRoles = await _context.UserRoles.FindAsync(id);
            if (userRoles == null)
            {
                return NotFound();
            }

            _context.UserRoles.Remove(userRoles);
            await _context.SaveChangesAsync();

            return Ok(userRoles);
        }

        private bool UserRolesExists(int id)
        {
            return _context.UserRoles.Any(e => e.Id == id);
        }
    }
}