using BookByIdApi.Businness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]

    public class UserController : ControllerBase
    {
        

        private readonly ILogger<UserController> _logger;
        private IUserBusinness UserBusinness;

        public UserController(ILogger<UserController> logger, IUserBusinness userBusinness)
        {
            _logger = logger;
            UserBusinness = userBusinness;
        }
        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(UserBusinness.FindAllUsers());
        }

        [HttpGet("detail/{email}")]
        public IActionResult FindDetailUser(string email)
        {
            var detail = UserBusinness.FindDetailUser(email);
            if (detail == null) return NotFound();
            
            return Ok(detail);
        }
        [HttpGet("{id}")]
        public IActionResult FindByID(int id)
        {
            var result = UserBusinness.FindByID(id);
            if (result == null) return NoContent();
            return Ok(result);
        }

    }
}
