using Microsoft.EntityFrameworkCore;
using RacingGamesLaptime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/*
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/

/* =========== Database Cotext Dependency Injection =========== */

var connectionString = "Server=localhost;Port=3306;Database=racing_games_laptime_db;User=root;Password=wLgg4Da-AqBjtJ@4;";
builder.Services.AddDbContext<RacingGamesLaptimeDbContext>(o => o.UseMySQL(connectionString));
/* ========================================================================================================= */

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
