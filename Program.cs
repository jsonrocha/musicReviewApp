using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Support for API controllers
builder.Services.AddEndpointsApiExplorer(); // Enable endpoint discovery for Swagger
builder.Services.AddSwaggerGen(); // Add Swagger services

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
