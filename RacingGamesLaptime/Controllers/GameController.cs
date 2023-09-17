using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Models;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly RacingGamesLaptimeDbContext _rGLDbContext;

        public GameController(RacingGamesLaptimeDbContext racingGaGamesLaptimeDbContext)
        {
            _rGLDbContext = racingGaGamesLaptimeDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAllGames()
        {
            return _rGLDbContext.Games;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Game game)
        {
            await _rGLDbContext.Games.AddAsync(game);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }

        /*
         {
    "Id":"34a0a422-f00c-464f-a522-09165ac46da2",
    "Name":"99998",
    "Platform":"PC",
    "ReleaseYear":2022
}
         */
    }
}
