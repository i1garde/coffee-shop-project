using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class RecipeMapper
    {
        public static RecipeEntity toEntity(this RecipeModel model)
        {
            return new RecipeEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static RecipeModel toModel(this RecipeEntity entity)
        {
            return new RecipeModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}