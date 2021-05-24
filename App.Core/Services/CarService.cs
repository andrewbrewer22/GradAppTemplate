using App.Core.Models;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _IcarRepository;

        public CarService(ICarRepository carRepository)
        {
            _IcarRepository = carRepository;
        }

        public Car Add(Car newCar)
        {
            return _IcarRepository.Add(newCar);
        }

        public Car Get(int id)
        {
            return _IcarRepository.Get(id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _IcarRepository.GetAll();
        }

        public void Remove(Car car)
        {
            _IcarRepository.Remove(car);
        }

        public Car Update(Car updatedCar)
        {
            return _IcarRepository.Update(updatedCar);
        }
    }
}
