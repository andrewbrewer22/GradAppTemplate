using App.Core.Models;
using App.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerable<Car> GetAll()
        {
            //return _dbContext.Cars.ToList();
            throw new NotImplementedException();
        }

        public void Remove(Car vehicle)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
