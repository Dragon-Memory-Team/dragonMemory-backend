using Backend.Data.Entities;
using Backend.Data.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public ActionResult<User> Register(UserDTO request)
        {
            return Ok();
        }

    }
}
