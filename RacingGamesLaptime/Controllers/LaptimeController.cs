using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Data;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            RacingGamesLaptimeDbContext racingGamesLaptimeDbContext = new RacingGamesLaptimeDbContext();
            var laptimeData = racingGamesLaptimeDbContext.Laptimes.ToList();
            return Ok(laptimeData);
        }
    }
}
