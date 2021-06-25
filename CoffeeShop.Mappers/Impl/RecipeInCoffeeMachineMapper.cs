using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class RecipeInCoffeeMachineMapper : IRecipeInCoffeeMachineMapper
    {
        private IRecipeMapper _recipeMapper;
        private ICoffeeMachineMapper _coffeeMachineMapper;
        public RecipeInCoffeeMachineMapper
            (IRecipeMapper recipeMapper, ICoffeeMachineMapper coffeeMachineMapper)
        {
            _recipeMapper = recipeMapper;
            _coffeeMachineMapper = coffeeMachineMapper;
        }
        public RecipeInCoffeeMachineModel ToModel(RecipeInCoffeeMachineEntity entity)
        {
            return new RecipeInCoffeeMachineModel
            {
                Id = entity.Id,
                Recipe = _recipeMapper.ToModel(entity.Recipe),
                CoffeeMachine = _coffeeMachineMapper.ToModel(entity.CoffeeMachine)
            };
        }

        public RecipeInCoffeeMachineEntity ToEntity(RecipeInCoffeeMachineModel model)
        {
            return new RecipeInCoffeeMachineEntity
            {
                Id = model.Id,
                Recipe = _recipeMapper.ToEntity(model.Recipe),
                CoffeeMachine = _coffeeMachineMapper.ToEntity(model.CoffeeMachine)
            };
        }
    }
}