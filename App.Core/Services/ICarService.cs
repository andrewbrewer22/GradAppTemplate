using System;
using System.Collections.Generic;
using App.Core.Models;

namespace App.Core.Services
{
    public interface ICarService
    {
        Car Get(int id);
        IEnumerable<Car> GetAll();
        Car Add(Car newCar);
        Car Update(Car updatedCar);
        void Remove(int id);
    }
}
