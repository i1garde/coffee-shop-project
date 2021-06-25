using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class CoffeeMachineMapper : ICoffeeMachineMapper
    {
        Random random = new Random();
        public CoffeeMachineModel ToModel(CoffeeMachineEntity entity)
        {
            return new CoffeeMachineModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                PlaceCoef = Convert.ToSingle(random.Next(50, 150)) / 100,
                PopularityCoef = Convert.ToSingle(random.Next(50, 150)) / 100
            };
        }
        public CoffeeMachineEntity ToEntity(CoffeeMachineModel model)
        {
            return new CoffeeMachineEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}