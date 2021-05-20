using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Core.Services
{
    public class CarService : ICarService
    {

        private readonly ICarService _carService;

        public CarService(ICarService carService)
        {
            _carService = carService;
        }

        public Car Add(Car newCar)
        {

            return _carService.Add(newCar);
        }

        public Car Get(int id)
        {
            return _carService.Get(id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public void Remove(int id)
        {
            _carService.Remove(id);
        }

        public Car Update(Car updatedCar)
        {
            return _carService.Update(updatedCar);
        }
    }
}
