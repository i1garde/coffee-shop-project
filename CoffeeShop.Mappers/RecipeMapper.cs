using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class RecipeMapper
    {
        public static RecipeEntity toEntity(this RecipeModel model)
        {
            List<IngredientsInRecipeEntity> ingredientsInRecipe = new List<IngredientsInRecipeEntity>();
            model.RecipeIngredients.ForEach(i => ingredientsInRecipe.Add(i.toEntity()));
            return new RecipeEntity
            {
                Id = model.Id,
                Name = model.Name,
                RecipeIngredients = ingredientsInRecipe
            };
        }

        public static RecipeModel toModel(this RecipeEntity entity)
        {
            List<IngredientsInRecipeModel> ingredientsInRecipe = new List<IngredientsInRecipeModel>();
            entity.RecipeIngredients.ForEach(i => ingredientsInRecipe.Add(i.toModel()));
            return new RecipeModel
            {
                Id = entity.Id,
                Name = entity.Name,
                RecipeIngredients = ingredientsInRecipe
            };
        }
    }
}