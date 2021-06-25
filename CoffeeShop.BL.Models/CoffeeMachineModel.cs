using System;
using System.Collections.Generic;

namespace CoffeeShop.BL.Models
{
    public class CoffeeMachineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float PlaceCoef { get; set; }
        public float PopularityCoef { get; set; }
    }
}