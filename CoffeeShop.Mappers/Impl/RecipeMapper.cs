using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class RecipeMapper : IRecipeMapper
    {
        public RecipeModel ToModel(RecipeEntity entity)
        {
            return new RecipeModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public RecipeEntity ToEntity(RecipeModel model)
        {
            return new RecipeEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}