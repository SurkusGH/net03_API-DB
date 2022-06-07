using net03_API_DB.DataAccess;
using net03_API_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace net03_API_DB.Repositories
{
    public class CarRepository : ICarRepository
    {
        private static readonly List<Car> _carList = new();
        private readonly Context _db;

        public CarRepository(Context context)
        {
            _db = context;
        }

        public IEnumerable<Car> GetAllCars() //[GET]
        {
            return _db.Cars.ToList();
        }

        public IEnumerable<Car> GetCarsByColor(string color) //[GET] + Modifier[FromBodyAttribute]
        {
            var selectorByColor = _db.Cars.Where(car => car.Color == color);
            return selectorByColor;
        }

        public IEnumerable<Car> AddNewCar(CarDto carDto) //[POST]
        {

            var car = new Car
            {
                Id = Guid.NewGuid(),
                Model = carDto.Name,
                Color = carDto.Color
            };

            _db.Add(car);
            _db.SaveChanges();
            
            return _db.Cars.ToList();
        }

        public IEnumerable<Car> UpdateCar(Guid id, CarDto carDto) //[PUT]
        {
            var carSelectorToUpdate = _db.Cars.Single(car => car.Id == id);
            carSelectorToUpdate.Model = carDto.Name;
            carSelectorToUpdate.Color = carDto.Color;
            _db.Cars.Update(carSelectorToUpdate);
            _db.SaveChanges();
            return _db.Cars.ToList();
        }

        public IEnumerable<Car> DeleteCar(Guid id) //[DELETE]
        {
            var selectorDelete = _db.Cars.First(car => car.Id == id);
            _db.Cars.Remove(selectorDelete);
            _db.SaveChanges();
            return _db.Cars.ToList();
        }

    }
}
