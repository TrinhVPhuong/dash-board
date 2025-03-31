using Microsoft.AspNetCore.Mvc;
using CalendarService.Data;
using CalendarService.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CalendarService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LunarEventsController : ControllerBase
    {
        private readonly CalendarDbContext _context;

        public LunarEventsController(CalendarDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LunarEvent>>> GetLunarEvents()
        {
            return await _context.LunarEvents.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LunarEvent>> GetLunarEvent(int id)
        {
            var lunarEvent = await _context.LunarEvents.FindAsync(id);

            if (lunarEvent == null)
            {
                return NotFound();
            }

            return lunarEvent;
        }

        [HttpPost]
        public async Task<ActionResult<LunarEvent>> CreateLunarEvent(LunarEvent lunarEvent)
        {
            _context.LunarEvents.Add(lunarEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLunarEvent), new { id = lunarEvent.Id }, lunarEvent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLunarEvent(int id, LunarEvent lunarEvent)
        {
            if (id != lunarEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(lunarEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LunarEventExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLunarEvent(int id)
        {
            var lunarEvent = await _context.LunarEvents.FindAsync(id);
            if (lunarEvent == null)
            {
                return NotFound();
            }

            _context.LunarEvents.Remove(lunarEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LunarEventExists(int id)
        {
            return _context.LunarEvents.Any(e => e.Id == id);
        }
    }
}
