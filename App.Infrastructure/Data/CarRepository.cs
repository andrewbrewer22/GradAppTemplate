using App.Core.Models;
using App.Core.Services;
using System.Linq;
using System.Collections.Generic;

namespace App.Infrastructure.Data
{
    class CarRepository : ICarRepository
    {
        private readonly AppDbContext _dbContext;

        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Car Add(Car vehicle)
        {
            _dbContext.Cars.Add(vehicle);
            _dbContext.SaveChanges();

            return vehicle;
        }

        public Car Get(int id)
        {
            return _dbContext.Cars.Find(id);
        }

        public void Remove(Car vehicle)
        {
            _dbContext.Cars.Remove(vehicle);
            _dbContext.SaveChanges();
        }

        public Car Update(Car vehicle)
        {
            var current = _dbContext.Cars.Find(vehicle.Id);

            if (current == null)
                return null;

            _dbContext.Entry(current)
                .CurrentValues
                .SetValues(vehicle);

            _dbContext.SaveChanges();

            return current;
        }
        public IEnumerable<Car> GetAll()
        {
            return _dbContext.Cars.ToList();
        }
    }
}
