using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface IIngredientInRecipeService
    {
        List<IngredientInRecipeModel> GetIngredients(int id);
    }
}