using FoodCart.Data;
using FoodCart.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



// ================= SERVICES =================

// Controllers
builder.Services.AddControllers();


// Swagger / OpenAPI
builder.Services.AddOpenApi();


// Database Connection
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnectionString")
));


// Identity (Users + Roles)
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();




// Authorization
builder.Services.AddAuthorization();


// Cookie Settings
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/api/auth/login";

    // Important for APIs
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };

    options.Events.OnRedirectToAccessDenied = context =>
    {
        context.Response.StatusCode = 403;
        return Task.CompletedTask;
    };
});



var app = builder.Build();



// ================= PIPELINE =================

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


// HTTPS
app.UseHttpsRedirection();


// ⭐ ORDER MATTERS ⭐
app.UseAuthentication();

app.UseAuthorization();


// Controllers
app.MapControllers();

app.Run();