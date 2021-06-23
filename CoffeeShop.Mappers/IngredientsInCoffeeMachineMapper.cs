using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class IngredientsInCoffeeMachineMapper
    {
        public static IngredientsInCoffeeMachineEntity toEntity(this IngredientsInCoffeeMachineModel model)
        {
            return new IngredientsInCoffeeMachineEntity
            {
                Id = model.Id,
                Ingredient = model.Ingredient.toEntity(),
                CoffeeMachine = model.CoffeeMachine.toEntity(),
                IngredientAmount = model.IngredientAmount,
                IngredientCapacity = model.IngredientCapacity
            };
        }

        public static IngredientsInCoffeeMachineModel toModel(this IngredientsInCoffeeMachineEntity entity)
        {
            return new IngredientsInCoffeeMachineModel
            {
                Id = entity.Id,
                Ingredient = entity.Ingredient.toModel(),
                CoffeeMachine = entity.CoffeeMachine.toModel(),
                IngredientAmount = entity.IngredientAmount,
                IngredientCapacity = entity.IngredientCapacity
            };
        }
    }
}