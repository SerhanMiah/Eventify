using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Eventify.Models;
using Eventify.Data;

namespace Eventify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/ApplicationUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetApplicationUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        // GET: api/ApplicationUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetApplicationUser(string id)
        {
            var applicationUser = await _userManager.FindByIdAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            return applicationUser;
        }

        // PUT: api/ApplicationUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationUser(string id, ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return BadRequest();
            }

            user.FirstName = applicationUser.FirstName;
            user.LastName = applicationUser.LastName;
            // update other properties as needed

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return NoContent();
        }

        // POST: api/ApplicationUsers
        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> PostApplicationUser(ApplicationUser applicationUser)
        {
            var result = await _userManager.CreateAsync(applicationUser);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return CreatedAtAction(nameof(GetApplicationUser), new { id = applicationUser.Id }, applicationUser);
        }

        // DELETE: api/ApplicationUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApplicationUser>> DeleteApplicationUser(string id)
        {
            var applicationUser = await _userManager.FindByIdAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(applicationUser);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return applicationUser;
        }
    }
}
