using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CTAPI.Models;

namespace CTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallStatusesController : ControllerBase
    {
        private readonly dbbtCalTContext _context;

        public CallStatusesController(dbbtCalTContext context)
        {
            _context = context;
        }

        // GET: api/CallStatuses
        [HttpGet]
        public IEnumerable<CtdCallStatuses> GetCtdCallStatuses()
        {
            return _context.CtdCallStatuses;
        }

        // GET: api/CallStatuses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCtdCallStatuses([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallStatuses = await _context.CtdCallStatuses.FindAsync(id);

            if (ctdCallStatuses == null)
            {
                return NotFound();
            }

            return Ok(ctdCallStatuses);
        }

        // PUT: api/CallStatuses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCtdCallStatuses([FromRoute] int id, [FromBody] CtdCallStatuses ctdCallStatuses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ctdCallStatuses.CallStatusID)
            {
                return BadRequest();
            }

            _context.Entry(ctdCallStatuses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CtdCallStatusesExists(id))
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

        // POST: api/CallStatuses
        [HttpPost]
        public async Task<IActionResult> PostCtdCallStatuses([FromBody] CtdCallStatuses ctdCallStatuses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CtdCallStatuses.Add(ctdCallStatuses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCtdCallStatuses", new { id = ctdCallStatuses.CallStatusID }, ctdCallStatuses);
        }

        // DELETE: api/CallStatuses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCtdCallStatuses([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallStatuses = await _context.CtdCallStatuses.FindAsync(id);
            if (ctdCallStatuses == null)
            {
                return NotFound();
            }

            _context.CtdCallStatuses.Remove(ctdCallStatuses);
            await _context.SaveChangesAsync();

            return Ok(ctdCallStatuses);
        }

        private bool CtdCallStatusesExists(int id)
        {
            return _context.CtdCallStatuses.Any(e => e.CallStatusID == id);
        }
    }
}