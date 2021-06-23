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
                Recipe = model.Recipe.toEntity(),
                Ingredient = model.Ingredient.toEntity(),
                IngredientAmount = model.IngredientAmount
            };
        }
    
        public static IngredientsInRecipeModel toModel(this IngredientsInRecipeEntity entity)
        {
            return new IngredientsInRecipeModel
            {
                Id = entity.Id,
                Recipe = entity.Recipe.toModel(),
                Ingredient = entity.Ingredient.toModel(),
                IngredientAmount = entity.IngredientAmount
            };
        }
    }
}