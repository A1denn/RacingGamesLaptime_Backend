using Microsoft.AspNetCore.Http;
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
            return _rGLDbContext.Laptime;
        }
    }
}
