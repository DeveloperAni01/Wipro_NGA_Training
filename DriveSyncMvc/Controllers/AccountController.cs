using DriveSyncMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Text.Json;

namespace DriveSyncMvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7222/"); // your API port

                var response = await client.PostAsJsonAsync(
      "api/auth/register-customer", model);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Login");
                }

                return Content("Registration Failed");
            }
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress =
                new Uri("https://localhost:7222/");

                var response =
                await client.PostAsJsonAsync(
                "api/auth/login", model);

                if (!response.IsSuccessStatusCode)
                {
                    return Content("Login Failed");
                }

                var json =
                await response.Content.ReadAsStringAsync();

                // Convert JSON → Object
                var loginResponse =
                JsonSerializer.Deserialize<LoginApiResponse>(
                    json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                // store JWT cookie
                Response.Cookies.Append(
                    "jwt",
                    loginResponse.Token,
                    new CookieOptions
                    {
                        HttpOnly = true,
                        Secure = true,
                        SameSite = SameSiteMode.Strict,
                        Expires =
                        DateTimeOffset.Now.AddHours(3)
                    });

                return RedirectToAction("Index");
            }
        }



    }

}
