using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class CoffeeMachineMapper
    {
        static Random random = new Random();
        public static CoffeeMachineEntity toEntity(this CoffeeMachineModel model)
        {
            return new CoffeeMachineEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static CoffeeMachineModel toModel(this CoffeeMachineEntity entity)
        {
            return new CoffeeMachineModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                PlaceCoef = Convert.ToSingle(random.Next(50, 150)) / 100,
                PopularityCoef = Convert.ToSingle(random.Next(50, 150)) / 100
            };
        }
    }
}