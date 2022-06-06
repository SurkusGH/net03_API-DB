using net03_API_DB.Models;
using System.Collections.Generic;

namespace net03_API_DB.Service
{
    public class Modulate : IModulate
    {
        private static readonly List<Car> _carList = new();
        public IEnumerable<Car> AddCar(Car car) //[POST}
        {
            _carList.Add(car);
            return _carList;
        }
        public IEnumerable<Car> GetAllCars() //[GET]
        {
            return _carList;
        }



        public IEnumerable<Car> UpdateCar(Car car) //[PUT}
        {
            return _carList; // XX
        }

        public IEnumerable<Car> GetCarsByColor(Car car) //[GET]
        {
            return _carList; // XX
        }

    }
}
