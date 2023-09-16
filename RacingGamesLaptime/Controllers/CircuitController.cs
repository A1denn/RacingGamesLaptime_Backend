using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Models;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CircuitController : ControllerBase
    {
        private readonly RacingGamesLaptimeDbContext _rGLDbContext;

        public CircuitController(RacingGamesLaptimeDbContext racingGaGamesLaptimeDbContext) 
        { 
            _rGLDbContext = racingGaGamesLaptimeDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Circuit>> GetAllCircuits() 
        {
            return _rGLDbContext.Circuit;
        }
    }
}
