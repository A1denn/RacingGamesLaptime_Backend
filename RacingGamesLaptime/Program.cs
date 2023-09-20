using Microsoft.EntityFrameworkCore;
using RacingGamesLaptime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// CORS Policies
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost" || new Uri(origin).Host == "myweb.local");
    });
});

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
// reference https://www.youtube.com/watch?v=b1BSu0Wb2Rw&t=224s

var connectionString = "Server=localhost;Port=3306;Database=racing_games_laptime_db;User=root;Password=wLgg4Da-AqBjtJ@4;";
builder.Services.AddDbContext<RacingGamesLaptimeDbContext>(o => o.UseMySQL(connectionString));
/* ========================================================================================================= */

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Enable Cors
app.UseCors();

app.Run();
