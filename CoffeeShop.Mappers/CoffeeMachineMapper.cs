using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class CoffeeMachineMapper
    {
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
            return new CoffeeMachineModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}