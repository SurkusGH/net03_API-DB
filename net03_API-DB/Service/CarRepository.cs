using net03_API_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace net03_API_DB.Service
{
    public class CarRepository : ICarRepository
    {
        private static readonly List<Car> _carList = new();

        public IEnumerable<Car> GetAllCars() //[GET]
        {
            return _carList;
        }

        public IEnumerable<Car> GetCarsByColor(string color) //[GET] + Modifier[FromBodyAttribute]
        {
            var selectorByColor = _carList.Where(car => car.Color == color);
            return selectorByColor;
        }

        public IEnumerable<Car> AddNewCar(CarDto carDto) //[POST]
        {

            var car = new Car
            {
                Id = Guid.NewGuid(),
                Name = carDto.Name,
                Color = carDto.Color
            };

            _carList.Add(car);
            return _carList;
        }

        public IEnumerable<Car> UpdateCar(Guid id, CarDto carDto) //[PUT]
        {
            var carSelectorToUpdate = _carList.Single(car => car.Id == id);
            carSelectorToUpdate.Name = carDto.Name;
            carSelectorToUpdate.Color = carDto.Color;
            return _carList;
        }

        public IEnumerable<Car> DeleteCar(Guid id) //[DELETE]
        {
            var selectorDelete = _carList.First(car => car.Id == id);
            _carList.Remove(selectorDelete);
            return _carList;
        }

    }
}
