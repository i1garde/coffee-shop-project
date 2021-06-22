using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class IngredientsInCoffeeMachine
    {
        public static IngredientsInCoffeeMachineEntity toEntity(this IngredientsInCoffeeMachineModel model)
            {
                return new IngredientsInCoffeeMachineEntity
                {
                    Id = model.Id,
                    IngredientId = model.IngredientId,
                    Ingredient = model.Ingredient.toEntity(),
                    CoffeeMachineId = model.CoffeeMachineId,
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
                    IngredientId = entity.IngredientId,
                    Ingredient = entity.Ingredient.toModel(),
                    CoffeeMachineId = entity.CoffeeMachineId,
                    CoffeeMachine = entity.CoffeeMachine.toModel(),
                    IngredientAmount = entity.IngredientAmount,
                    IngredientCapacity = entity.IngredientCapacity
                };
            }
    }
}