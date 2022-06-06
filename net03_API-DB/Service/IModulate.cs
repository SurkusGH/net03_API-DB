using net03_API_DB.Models;
using System.Collections.Generic;

namespace net03_API_DB.Service
{
    public interface IModulate
    {
        IEnumerable<Car> AddCar(Car car); //[POST}
        //IEnumerable<Car> UpdateCar(Car car); //[PUT}

        IEnumerable<Car> GetAllCars(); //[GET]
        //IEnumerable<Car> GetCarsByColor(Car car); //[GET]
    }
}
