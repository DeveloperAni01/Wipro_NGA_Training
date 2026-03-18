using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using FoodCart.Models;
using FoodCart.DTOs;


namespace FoodCart.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;

            _signInManager = signInManager;

            _roleManager = roleManager;
        }

    [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            var user = new ApplicationUser
            {
                UserName = dto.Email,
                Email = dto.Email
            };

            var result =
                await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User Created");
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var result =
                await _signInManager.PasswordSignInAsync(
                    dto.Email,
                    dto.Password,
                    false,
                    false);

            if (!result.Succeeded)
                return Unauthorized("Login Failed");

            return Ok("Logged In");
        }

        [HttpPost("createRole")]

        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (await _roleManager.RoleExistsAsync(roleName))
                return Ok("Role Exists");

            await _roleManager.CreateAsync(
                new IdentityRole(roleName));

            return Ok("Role Created");
        }

        [HttpPost("assignRole")]

        public async Task<IActionResult> AssignRole(
string email,
string role)
        {
            var user =
                await _userManager.FindByEmailAsync(email);

            if (user == null)
                return NotFound();

            await _userManager.AddToRoleAsync(user, role);

            return Ok("Role Assigned");
        }

    }

}
