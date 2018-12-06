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
    public class CtdCallerAssocsController : ControllerBase
    {
        private readonly dbbtCalTContext _context;

        public CtdCallerAssocsController(dbbtCalTContext context)
        {
            _context = context;
        }

        // GET: api/CtdCallerAssocs
        [HttpGet]
        public IEnumerable<CtdCallerAssocs> GetCtdCallerAssocs()
        {
            return _context.CtdCallerAssocs;
        }

        // GET: api/CtdCallerAssocs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCtdCallerAssocs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallerAssocs = await _context.CtdCallerAssocs.FindAsync(id);

            if (ctdCallerAssocs == null)
            {
                return NotFound();
            }

            return Ok(ctdCallerAssocs);
        }

        // PUT: api/CtdCallerAssocs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCtdCallerAssocs([FromRoute] int id, [FromBody] CtdCallerAssocs ctdCallerAssocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ctdCallerAssocs.CallerAssocId)
            {
                return BadRequest();
            }

            _context.Entry(ctdCallerAssocs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CtdCallerAssocsExists(id))
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

        // POST: api/CtdCallerAssocs
        [HttpPost]
        public async Task<IActionResult> PostCtdCallerAssocs([FromBody] CtdCallerAssocs ctdCallerAssocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CtdCallerAssocs.Add(ctdCallerAssocs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCtdCallerAssocs", new { id = ctdCallerAssocs.CallerAssocId }, ctdCallerAssocs);
        }

        // DELETE: api/CtdCallerAssocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCtdCallerAssocs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallerAssocs = await _context.CtdCallerAssocs.FindAsync(id);
            if (ctdCallerAssocs == null)
            {
                return NotFound();
            }

            _context.CtdCallerAssocs.Remove(ctdCallerAssocs);
            await _context.SaveChangesAsync();

            return Ok(ctdCallerAssocs);
        }

        private bool CtdCallerAssocsExists(int id)
        {
            return _context.CtdCallerAssocs.Any(e => e.CallerAssocId == id);
        }
    }
}