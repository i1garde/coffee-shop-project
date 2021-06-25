using System.Collections.Generic;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface IIngredientInRecipeRepository 
        : IGenericRepository<IngredientInRecipeEntity, int>
    {
        List<IngredientInRecipeEntity> GetAllByRecipeId(int id);
    }
}