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
    public class UserRoleDefinitionsController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public UserRoleDefinitionsController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/UserRoleDefinitions
        [HttpGet]
        public IEnumerable<UserRoleDefinition> GetUserRoleDefinition()
        {
            return _context.UserRoleDefinition;
        }

        // GET: api/UserRoleDefinitions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRoleDefinition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRoleDefinition = await _context.UserRoleDefinition.FindAsync(id);

            if (userRoleDefinition == null)
            {
                return NotFound();
            }

            return Ok(userRoleDefinition);
        }

        // PUT: api/UserRoleDefinitions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRoleDefinition([FromRoute] int id, [FromBody] UserRoleDefinition userRoleDefinition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userRoleDefinition.Id)
            {
                return BadRequest();
            }

            _context.Entry(userRoleDefinition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRoleDefinitionExists(id))
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

        // POST: api/UserRoleDefinitions
        [HttpPost]
        public async Task<IActionResult> PostUserRoleDefinition([FromBody] UserRoleDefinition userRoleDefinition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserRoleDefinition.Add(userRoleDefinition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserRoleDefinition", new { id = userRoleDefinition.Id }, userRoleDefinition);
        }

        // DELETE: api/UserRoleDefinitions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoleDefinition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRoleDefinition = await _context.UserRoleDefinition.FindAsync(id);
            if (userRoleDefinition == null)
            {
                return NotFound();
            }

            _context.UserRoleDefinition.Remove(userRoleDefinition);
            await _context.SaveChangesAsync();

            return Ok(userRoleDefinition);
        }

        private bool UserRoleDefinitionExists(int id)
        {
            return _context.UserRoleDefinition.Any(e => e.Id == id);
        }
    }
}