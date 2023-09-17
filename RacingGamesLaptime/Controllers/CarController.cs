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
            return _rGLDbContext.Cars;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Car car)
        {
            await _rGLDbContext.Cars.AddAsync(car);
            await _rGLDbContext.SaveChangesAsync();
            return Ok();
        }

        /*
         {
    "Id":"34a0a422-f00c-464f-a522-09165ac46da2",
    "Model":"99998",
    "Brand":"PC",
    "OriginCountry":"dfdfdf",
    "Category":"5321",
    "Engine":"weoi",
    "Tyre":"Hard",
    "isMod":false
}
         */
    }
}
