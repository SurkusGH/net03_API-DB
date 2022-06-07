using net03_API_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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


        public IEnumerable<Car> GetCarsByColor(string color) //[GET]++
        {
            var selectorByColor = _carList.Where(car => car.Color == color);
            return selectorByColor;
        }

        public IEnumerable<Car> UpdateCar(Car car, Guid id) //[PUT}
        {
            var selectorUpdate = _carList.First(car => car.Id == id);
            selectorUpdate.Name = car.Name;
            selectorUpdate.Color = car.Color;
            return _carList;
        }

        public IEnumerable<Car> DeleteCar(Guid id) //[PUT}
        {
            var selectorDelete = _carList.First(car => car.Id == id);
            _carList.Remove(selectorDelete);
            return _carList;
        }

    }
}
