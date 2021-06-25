using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class IngredientInRecipeMapper : IIngredientInRecipeMapper
    {
        private IRecipeMapper _recipeMapper;
        private IIngredientMapper _ingredientMapper;

        public IngredientInRecipeMapper(IRecipeMapper recipeMapper, IIngredientMapper ingredientMapper)
        {
            _recipeMapper = recipeMapper;
            _ingredientMapper = ingredientMapper;
        }
        public IngredientInRecipeModel ToModel(IngredientInRecipeEntity entity)
        {
            return new IngredientInRecipeModel
            {
                Id = entity.Id,
                Recipe = _recipeMapper.ToModel(entity.Recipe),
                Ingredient = _ingredientMapper.ToModel(entity.Ingredient),
                IngredientAmount = entity.IngredientAmount
            };
        }

        public IngredientInRecipeEntity ToEntity(IngredientInRecipeModel model)
        {
            return new IngredientInRecipeEntity
            {
                Id = model.Id,
                Recipe = _recipeMapper.ToEntity(model.Recipe),
                Ingredient = _ingredientMapper.ToEntity(model.Ingredient),
                IngredientAmount = model.IngredientAmount
            };
        }
    }
}