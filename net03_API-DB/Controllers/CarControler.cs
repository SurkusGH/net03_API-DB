using Microsoft.AspNetCore.Mvc;
using net03_API_DB.Models;
using net03_API_DB.Service;
using System;
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

        [HttpGet("GetCarsByColor")]
        public IEnumerable<Car> GetCarsByColor(string color) //[GET]
        {
            return _modulator.GetCarsByColor(color);
        }

        [HttpPut("UpdateCar")]
        public IEnumerable<Car> UpdateCar(Car car, Guid id)
        {
            return _modulator.UpdateCar(car, id);
        }

        [HttpDelete("DeleteCar")]
        public IEnumerable<Car> DeleteCar(Guid id) //[Delete]
        {
            return _modulator.DeleteCar(id);
        }
    }

}
