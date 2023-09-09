using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Data;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            RacingGamesLaptimeDbContext racingGamesLaptimeDbContext = new RacingGamesLaptimeDbContext();
            var carData = racingGamesLaptimeDbContext.Cars.ToList();
            return Ok(carData);
        }
    }
}
