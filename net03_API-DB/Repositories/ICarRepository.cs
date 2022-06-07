using net03_API_DB.Models;
using System;
using System.Collections.Generic;

namespace net03_API_DB.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars(); //[GET]

        IEnumerable<Car> GetCarsByColor(string color); //[GET]

        IEnumerable<Car> AddNewCar(CarDto carDto); //[POST}

        IEnumerable<Car> UpdateCar(Guid id, CarDto carDto); //[PUT}

        IEnumerable<Car> DeleteCar(Guid id); //[DELETE]
    }
}
