using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface IRecipeInCoffeeMachineService
    {
        List<RecipeInCoffeeMachineModel> GetRecipes(int id);
    }
}