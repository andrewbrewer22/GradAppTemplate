using System.Collections.Generic;
using App.Core.Models;

namespace App.Core.Services
{
    public interface ICarRepository
    {
        Car Add(Car vehicle);
        Car Get(int id);
        Car Update(Car vehicle);
        void Remove(Car vehicle);
        IEnumerable<Car> GetAll();
    }
}
