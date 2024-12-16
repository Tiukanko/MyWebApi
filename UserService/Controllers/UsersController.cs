using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new[] { "User1", "User2", "User3" });
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok($"User {id}");
        }
    }
}
