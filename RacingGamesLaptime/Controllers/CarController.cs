using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RacingGamesLaptime.Models;

namespace RacingGamesLaptime.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly RacingGamesLaptimeDbContext _rGLDbContext;

        public CarController(RacingGamesLaptimeDbContext racingGaGamesLaptimeDbContext)
        {
            _rGLDbContext = racingGaGamesLaptimeDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            return _rGLDbContext.Car;
        }
    }
}
