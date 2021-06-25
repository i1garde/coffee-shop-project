using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface IIngredientInCoffeeMachineService
    {
        List<IngredientInCoffeeMachineModel> GetIngredients(int id);
        bool EjectIngredient(CoffeeMachineModel coffeeMachineModel, RecipeInCoffeeMachineModel recipeInCoffeeMachine);
    }
}