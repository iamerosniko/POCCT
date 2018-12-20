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
    public class CallCategoriesController : ControllerBase
    {
        private readonly dbbtCalTContext _context;

        public CallCategoriesController(dbbtCalTContext context)
        {
            _context = context;
        }

        // GET: api/CallCategories
        [HttpGet]
        public IEnumerable<CtdCallCategories> GetCtdCallCategories()
        {
            return _context.CtdCallCategories;
        }

        // GET: api/CallCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCtdCallCategories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallCategories = await _context.CtdCallCategories.FindAsync(id);

            if (ctdCallCategories == null)
            {
                return NotFound();
            }

            return Ok(ctdCallCategories);
        }

        // PUT: api/CallCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCtdCallCategories([FromRoute] int id, [FromBody] CtdCallCategories ctdCallCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ctdCallCategories.CallCategoryID)
            {
                return BadRequest();
            }

            _context.Entry(ctdCallCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CtdCallCategoriesExists(id))
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

        // POST: api/CallCategories
        [HttpPost]
        public async Task<IActionResult> PostCtdCallCategories([FromBody] CtdCallCategories ctdCallCategories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CtdCallCategories.Add(ctdCallCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCtdCallCategories", new { id = ctdCallCategories.CallCategoryID }, ctdCallCategories);
        }

        // DELETE: api/CallCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCtdCallCategories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ctdCallCategories = await _context.CtdCallCategories.FindAsync(id);
            if (ctdCallCategories == null)
            {
                return NotFound();
            }

            _context.CtdCallCategories.Remove(ctdCallCategories);
            await _context.SaveChangesAsync();

            return Ok(ctdCallCategories);
        }

        private bool CtdCallCategoriesExists(int id)
        {
            return _context.CtdCallCategories.Any(e => e.CallCategoryID == id);
        }
    }
}