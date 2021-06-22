using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class IngredientsInRecipe
    {
        public static IngredientsInRecipeEntity toEntity(this IngredientsInRecipeModel model)
        {
            return new IngredientsInRecipeEntity
            {
                Id = model.Id,
                RecipeId = model.RecipeId,
                Recipe = model.Recipe.toEntity(),
                IngredientId = model.IngredientId,
                Ingredient = model.Ingredient.toEntity(),
                IngredientAmount = model.IngredientAmount
            };
        }
    
        public static IngredientsInRecipeModel toModel(this IngredientsInRecipeEntity entity)
        {
            return new IngredientsInRecipeModel
            {
                Id = entity.Id,
                RecipeId = entity.RecipeId,
                Recipe = entity.Recipe.toModel(),
                IngredientId = entity.IngredientId,
                Ingredient = entity.Ingredient.toModel(),
                IngredientAmount = entity.IngredientAmount
            };
        }
    }
}