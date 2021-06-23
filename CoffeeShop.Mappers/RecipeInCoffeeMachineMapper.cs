using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class RecipeInCoffeeMachineMapper
    {
        public static RecipeInCoffeeMachineEntity toEntity(this RecipeInCoffeeMachineModel model)
        {
            return new RecipeInCoffeeMachineEntity
            {
                Id = model.Id,
                Recipe = model.Recipe.toEntity(),
                CoffeeMachine = model.CoffeeMachine.toEntity()
            };
        }

        public static RecipeInCoffeeMachineModel toModel(this RecipeInCoffeeMachineEntity entity)
        {
            return new RecipeInCoffeeMachineModel
            {
                Id = entity.Id,
                Recipe = entity.Recipe.toModel(),
                CoffeeMachine = entity.CoffeeMachine.toModel()
            };
        }
    }
}