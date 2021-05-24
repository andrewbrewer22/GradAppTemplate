using System;
using System.Collections.Generic;
using System.Linq;
using App.ApiModels;
using App.Core.Models;

namespace App.ApiModels
{
    public static class CarMappingExtensions
    {
        public static CarModel ToApiModel(this Car item)
        {
            return new CarModel
            {
                //This allows us to return a proper model to our
                //controller

                Id = item.Id,
                Make = item.Make,
                Model = item.Model,
                Type = item.Type,
                Year = item.Year,
                Color = item.Color,
                UserId = item.UserId
            };
        }

        public static Car ToDomainModel(this CarModel item)
        {
            return new Car
            {
                Id = item.Id,
                Color = item.Color,
                Make = item.Make,
                Model = item.Model,
                Type = item.Type,
                Year = item.Year,
                UserId = item.UserId
            };
        }

        public static IEnumerable<CarModel> ToApiModels(this IEnumerable<Car> items)
        {
            return items.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Car> ToDomainModels(this IEnumerable<CarModel> items)
        {
            return items.Select(a => a.ToDomainModel());
        }
    }
}
