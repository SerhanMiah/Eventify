using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eventify.Data;
using Eventify.Models;
using Microsoft.AspNetCore.Authorization;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly EventifyContext _context;

    public EventsController(EventifyContext context)
    {
        _context = context;
    }

    // GET: api/Events
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
    {
        return await _context.Events.ToListAsync();
    }

    // GET: api/Events/:id
    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEvent(int id)
    {
        var eventItem = await _context.Events.FindAsync(id);

        if (eventItem == null)
        {
            return NotFound();
        }

        return eventItem;
    }

    // POST: api/Events
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Event>> PostEvent(Event newEvent)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        _context.Events.Add(newEvent);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEvent), new { id = newEvent.Id }, newEvent);
    }
}

