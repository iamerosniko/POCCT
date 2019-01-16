using CTAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        private readonly dbbtCalTContext _context;

        public CallsController(dbbtCalTContext context)
        {
            _context = context;
        }

        // GET: api/CtdCalls
        [HttpGet]
        public IEnumerable<CtdCalls> GetCtdCalls()
        {
            return _context.CtdCalls;
        }

        // GET: api/CtdCalls/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCtdCalls([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCalls = await _context.CtdCalls.FindAsync(id);

            if (ctdCalls == null)
            {
                return NotFound();
            }

            return Ok(ctdCalls);
        }

        // PUT: api/CtdCalls/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCtdCalls([FromRoute] int id, [FromBody] CtdCalls ctdCalls)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ctdCalls.CallID)
            {
                return BadRequest();
            }

            _context.Entry(ctdCalls).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CtdCallsExists(id))
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

        // POST: api/CtdCalls
        [HttpPost]
        public async Task<IActionResult> PostCtdCalls([FromBody] CtdCalls ctdCalls)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _context.CtdCalls.Add(ctdCalls);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { }

            return CreatedAtAction("GetCtdCalls", new { id = ctdCalls.CallID }, ctdCalls);
        }

        // DELETE: api/CtdCalls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCtdCalls([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCalls = await _context.CtdCalls.FindAsync(id);
            if (ctdCalls == null)
            {
                return NotFound();
            }

            _context.CtdCalls.Remove(ctdCalls);
            await _context.SaveChangesAsync();

            return Ok(ctdCalls);
        }

        private bool CtdCallsExists(int id)
        {
            return _context.CtdCalls.Any(e => e.CallID == id);
        }
    }
}