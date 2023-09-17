using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Models;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LaptimeController : ControllerBase
    {
        private readonly RacingGamesLaptimeDbContext _rGLDbContext;

        public LaptimeController(RacingGamesLaptimeDbContext racingGaGamesLaptimeDbContext)
        {
            _rGLDbContext = racingGaGamesLaptimeDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Laptime>> GetAllLaptimes()
        {
            return _rGLDbContext.Laptimes;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Laptime laptime)
        {
            await _rGLDbContext.Laptimes.AddAsync(laptime);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }

        /* Test Data
         {
    "Id":"34a0a422-f00c-464f-a522-09165ac46da1",
    "Time":99998,
    "Car":"F91",
    "GameName":"Road Rash",
    "Circuit":"Melbourne Cup",
    "CarCategory":"Motorcycle",
    "CircuitLayout":"Series",
    "CircuitCountry":"Australia",
    "CarCountry":"Meng De",
    "isCarMod":true,
    "isCircuitMod":false
}
         */

        [HttpPut]
        public async Task<ActionResult> Update(Laptime laptime)
        {
            _rGLDbContext.Laptimes.Update(laptime);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> Delete(Guid id) 
        { 
            var laptime = await _rGLDbContext.Laptimes.FindAsync(id);
            _rGLDbContext.Laptimes.Remove(laptime);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
