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
        private readonly ICarRepository _carRepo;

        public CarController(ICarRepository list)
        {
            _carRepo = list;
        }

        #region GetAllCars – [GET]

        [HttpGet("GetAllCars")]
        public IEnumerable<Car> GetAllCars()
        {
            return _carRepo.GetAllCars();
        }

        #endregion


        #region GetCarsByColor - [GET]

        [HttpGet("GetCarsByColor")]
        public IEnumerable<Car> GetCarsByColor([FromQueryAttribute] string color)
        {
            return _carRepo.GetCarsByColor(color);
        }

        #endregion

        #region AddNewCar – [POST]

        [HttpPost("AddNewCar")]
        public IEnumerable<Car> AddNewCar(CarDto carDto)
        {
            return _carRepo.AddNewCar(carDto);
        }

        #endregion

        #region UpdateCar – [PUT]

        [HttpPut("UpdateCar")]
        public IEnumerable<Car> UpdateCar([FromQueryAttribute]Guid id, CarDto carDto)
        {
            return _carRepo.UpdateCar(id, carDto);
        }

        #endregion

        #region DeleteCar – [DELETE]

        [HttpDelete("DeleteCar")]
        public IEnumerable<Car> DeleteCar(Guid id)
        {
            return _carRepo.DeleteCar(id);
        }

        #endregion
    }
}
