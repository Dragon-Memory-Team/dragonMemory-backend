using Backend.Data;
using Backend.Data.Entities;
using Backend.Data.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
                _context = context;
        }

        [HttpPost("register")]
        public ActionResult<User> CreateUser(UserDTO request)
        {
            return Ok();
        }
    }
}
