using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using App.ApiModels;
using App.Core.Services;


namespace App.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAll().ToList();
            return Ok(cars.ToApiModels());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var car = _carService.Get(id);
            return Ok(car.ToApiModel());
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromBody] CarModel carModel)
        {
            try
            {
                var savedCarData = _carService.Add(carModel.ToDomainModel());

                return CreatedAtAction("Get", new { Id = savedCarData.Id }, savedCarData.ToApiModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddCar", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CarModel carModel)
        {
            var updatedCar = _carService.Update(carModel.ToDomainModel());
            return Ok(updatedCar.ToApiModel());
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _carService.Remove(id);
            return Ok();
        }
    }
}
