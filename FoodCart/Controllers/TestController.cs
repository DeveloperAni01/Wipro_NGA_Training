using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FoodCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet("public")]

        public IActionResult Public()
        {
            return Ok("Anyone Can Access");
        }


        [Authorize]

        [HttpGet("loggedin")]

        public IActionResult LoggedIn()
        {
            return Ok("Only Logged User");
        }


        [Authorize(Roles = "Admin")]

        [HttpGet("admin")]

        public IActionResult AdminOnly()
        {
            return Ok("Admin Only Access");
        }

    }
}