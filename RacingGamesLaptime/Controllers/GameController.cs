using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Data;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            RacingGamesLaptimeDbContext racingGamesLaptimeDbContext = new RacingGamesLaptimeDbContext();
            var gameData = racingGamesLaptimeDbContext.Games.ToList();
            return Ok(gameData);
        }
    }
}
