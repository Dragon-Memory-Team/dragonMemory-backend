using Backend.Data;
using Backend.Data.Entities;
using Backend.Data.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO request)
        {
            if(request == null || string.IsNullOrEmpty(request.Username))
            {
                return BadRequest();
            }

            var newUser = UserDtoToUser(request);

            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();
            

            return Ok(newUser);
        }

        private User UserDtoToUser(UserDTO request) {
            return new User 
            {
                Name = request.Username,
            };
        }

    }
}
