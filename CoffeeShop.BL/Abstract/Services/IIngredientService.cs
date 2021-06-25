using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface IIngredientService
    {
        void Add(IngredientModel ingredientModel);
        List<IngredientModel> GetAll();
    }
}