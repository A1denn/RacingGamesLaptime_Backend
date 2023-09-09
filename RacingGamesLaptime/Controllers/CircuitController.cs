using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Data;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CircuitController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {
            RacingGamesLaptimeDbContext racingGamesLaptimeDbContext = new RacingGamesLaptimeDbContext();
            var circuitData = racingGamesLaptimeDbContext.Circuits.ToList();
            return Ok(circuitData);
        }           
    }
}
