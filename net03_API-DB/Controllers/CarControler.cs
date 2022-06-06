using Microsoft.AspNetCore.Mvc;
using net03_API_DB.Models;
using net03_API_DB.Service;
using System.Collections.Generic;

namespace net03_API_DB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IModulate _modulator;

        public CarController(IModulate list)
        {
            _modulator = list;
        }

        [HttpPost("AddCar")] //[POST}
        public IEnumerable<Car> AddCar([FromBody] Car car)
        {
            return _modulator.AddCar(car);
        }


        [HttpGet("GetAllCars")]
        public IEnumerable<Car> GetAllCars() //[GET]
        {
            return _modulator.GetAllCars();
        }
    }

}
