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
    public class UserPurchaseHistoriesController : ControllerBase
    {
        private readonly memorytipoffdbContext _context;

        public UserPurchaseHistoriesController(memorytipoffdbContext context)
        {
            _context = context;
        }

        // GET: api/UserPurchaseHistories
        [HttpGet]
        public IEnumerable<UserPurchaseHistory> GetUserPurchaseHistory()
        {
            return _context.UserPurchaseHistory;
        }

        // GET: api/UserPurchaseHistories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserPurchaseHistory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userPurchaseHistory = await _context.UserPurchaseHistory.FindAsync(id);

            if (userPurchaseHistory == null)
            {
                return NotFound();
            }

            return Ok(userPurchaseHistory);
        }

        // PUT: api/UserPurchaseHistories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPurchaseHistory([FromRoute] int id, [FromBody] UserPurchaseHistory userPurchaseHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userPurchaseHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(userPurchaseHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPurchaseHistoryExists(id))
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

        // POST: api/UserPurchaseHistories
        [HttpPost]
        public async Task<IActionResult> PostUserPurchaseHistory([FromBody] UserPurchaseHistory userPurchaseHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserPurchaseHistory.Add(userPurchaseHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserPurchaseHistory", new { id = userPurchaseHistory.Id }, userPurchaseHistory);
        }

        // DELETE: api/UserPurchaseHistories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserPurchaseHistory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userPurchaseHistory = await _context.UserPurchaseHistory.FindAsync(id);
            if (userPurchaseHistory == null)
            {
                return NotFound();
            }

            _context.UserPurchaseHistory.Remove(userPurchaseHistory);
            await _context.SaveChangesAsync();

            return Ok(userPurchaseHistory);
        }

        private bool UserPurchaseHistoryExists(int id)
        {
            return _context.UserPurchaseHistory.Any(e => e.Id == id);
        }
    }
}