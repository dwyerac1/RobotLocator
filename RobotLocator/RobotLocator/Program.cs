using RobotLocator.Interfaces;
using RobotLocator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IDistanceCalculatorService, DistanceCalculatorService>();
builder.Services.AddScoped<IRobotDistanceService, RobotDistanceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
