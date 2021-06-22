using System.Collections.Generic;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class CoffeeMachineMapper
    {
        public static CoffeeMachineEntity toEntity(this CoffeeMachineModel model)
        {
            List<RecipeEntity> recipeEntities = new List<RecipeEntity>();
            model.Recipes.ForEach(i => recipeEntities.Add(i.toEntity()));
            List<OrderEntity> orderEntities = new List<OrderEntity>();
            model.Orders.ForEach(i => orderEntities.Add(i.toEntity()));
            List<IngredientsInCoffeeMachineEntity> ingredientsInCoffeeMachine = new List<IngredientsInCoffeeMachineEntity>();
            model.Ingredients.ForEach(i => ingredientsInCoffeeMachine.Add(i.toEntity()));
            return new CoffeeMachineEntity
            {
                Id = model.Id,
                Name = model.Name,
                Recipes = recipeEntities,
                Orders = orderEntities,
                Ingredients = ingredientsInCoffeeMachine
            };
        }

        public static CoffeeMachineModel toModel(this CoffeeMachineEntity entity)
        {
            List<RecipeModel> recipeModels = new List<RecipeModel>();
            entity.Recipes.ForEach(i => recipeModels.Add(i.toModel()));
            List<OrderModel> orderModels = new List<OrderModel>();
            entity.Orders.ForEach(i => orderModels.Add(i.toModel()));
            List<IngredientsInCoffeeMachineModel> ingredientsInCoffeeMachine = new List<IngredientsInCoffeeMachineModel>();
            entity.Ingredients.ForEach(i => ingredientsInCoffeeMachine.Add(i.toModel()));
            return new CoffeeMachineModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Recipes = recipeModels,
                Orders = orderModels,
                Ingredients = ingredientsInCoffeeMachine
            };
        }
    }
}