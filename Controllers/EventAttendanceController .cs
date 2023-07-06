using System;
using System.Linq;
using System.Threading.Tasks;
using Eventify.Data;
using Eventify.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Eventify.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EventAttendanceController : ControllerBase
    {
        private readonly EventifyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventAttendanceController(EventifyContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost("{eventId}")]
        public async Task<IActionResult> AttendEvent(int eventId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return BadRequest(new { message = "User not found." });
            }

            var eventItem = await _context.Events.FindAsync(eventId);
            if (eventItem == null)
            {
                return BadRequest(new { message = "Event not found." });
            }

            // Check if the user has already attended the event
            var attendance = await _context.EventAttendances
                                           .FirstOrDefaultAsync(ea => ea.UserId == user.Id && ea.EventId == eventId);
            if (attendance != null)
            {
                return BadRequest(new { message = "User already attended this event." });
            }

            // Create a new attendance
            var newAttendance = new EventAttendance
            {
                UserId = user.Id,
                EventId = eventId,
                RegistrationTimestamp = DateTime.UtcNow
            };

            _context.EventAttendances.Add(newAttendance);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Event successfully attended." });
        }

    }
}
