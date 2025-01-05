using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using MusicReviewApp;
using MusicReviewApp.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server=localhost;Database=MusicReviewApp;Trusted_Connection=True;";

// Add services to the container.
builder.Services.AddControllers(); // Support for API controllers
builder.Services.AddEndpointsApiExplorer(); // Enable endpoint discovery for Swagger
builder.Services.AddSwaggerGen(); // Add Swagger services

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


// Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "YourIssuer", // Replace with your app's issuer
        ValidAudience = "YourAudience", // Replace with your app's audience
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSecretKey")) // Replace with a secure key
    };
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enable detailed error pages in development
    app.UseSwagger(); // Enable Swagger middleware
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MusicReviewApp API v1")); // Configure Swagger UI
}

app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseAuthorization(); // Add authorization middleware

app.MapControllers(); // Map attribute-routed controllers

app.Run(); // Run the application
