using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.ApiModels
{
    public class CarModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }

        //Truck, SUV, Sedan, 
        [Required]
        public string Type { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
