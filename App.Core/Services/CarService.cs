using App.Core.Models;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class CarService : ICarService
    {
        //private readonly ICarService _carService;
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car Add(Car newCar)
        {
            var vehicle = _carRepository.Get(newCar.Id);

            if (vehicle == null)
                throw new Exception("Invalid Vehicle");

            return _carRepository.Add(newCar);
        }

        public Car Get(int id)
        {
            return _carRepository.Get(id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public void Remove(Car car)
        {
            _carRepository.Remove(car);
        }

        public Car Update(Car updatedCar)
        {
            return _carRepository.Update(updatedCar);
        }
    }
}
