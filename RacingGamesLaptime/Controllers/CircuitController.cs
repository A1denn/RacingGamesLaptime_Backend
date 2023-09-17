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
            return _rGLDbContext.Circuits;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Circuit circuit)
        {
            await _rGLDbContext.Circuits.AddAsync(circuit);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }
        /*
        {
    "Id":"34a0a422-f00c-464f-a522-09165ac46da2",
    "Name":"99998",
    "Country":"PC",
    "Layout":"dfdfdf",
    "Length":5321,
    "isMod":false
}
        */
    }
}
