using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class IngredientInCoffeeMachineMapper : IIngredientInCoffeeMachineMapper
    {
        private IIngredientMapper _ingredientMapper;
        private ICoffeeMachineMapper _coffeeMachineMapper;
        public IngredientInCoffeeMachineMapper
            (IIngredientMapper ingredientMapper, ICoffeeMachineMapper coffeeMachineMapper)
        {
            _ingredientMapper = ingredientMapper;
            _coffeeMachineMapper = coffeeMachineMapper;
        }
        public IngredientInCoffeeMachineModel ToModel(IngredientInCoffeeMachineEntity entity)
        {
            return new IngredientInCoffeeMachineModel
            {
                Id = entity.Id,
                Ingredient = _ingredientMapper.ToModel(entity.Ingredient),
                CoffeeMachine = _coffeeMachineMapper.ToModel(entity.CoffeeMachine),
                IngredientAmount = entity.IngredientAmount,
                IngredientCapacity = entity.IngredientCapacity
            };
        }

        public IngredientInCoffeeMachineEntity ToEntity(IngredientInCoffeeMachineModel model)
        {
            return new IngredientInCoffeeMachineEntity
            {
                Id = model.Id,
                Ingredient = _ingredientMapper.ToEntity(model.Ingredient),
                CoffeeMachine = _coffeeMachineMapper.ToEntity(model.CoffeeMachine),
                IngredientAmount = model.IngredientAmount,
                IngredientCapacity = model.IngredientCapacity
            };
        }
    }
}