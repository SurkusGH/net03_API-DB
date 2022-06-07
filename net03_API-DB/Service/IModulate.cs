using net03_API_DB.Models;
using System;
using System.Collections.Generic;

namespace net03_API_DB.Service
{
    public interface IModulate
    {
        IEnumerable<Car> AddCar(Car car); //[POST}
        IEnumerable<Car> UpdateCar(Car car, Guid id); //[PUT}

        IEnumerable<Car> GetAllCars(); //[GET]
        IEnumerable<Car> GetCarsByColor(string color); //[GET]

        IEnumerable<Car> DeleteCar(Guid id); //[GET]
    }
}
