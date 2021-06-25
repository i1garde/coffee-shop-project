using System.Collections.Generic;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface IRecipeInCoffeeMachineRepository : IGenericRepository<RecipeInCoffeeMachineEntity, int>
    {
        List<RecipeInCoffeeMachineEntity> GetAllByCoffeeMachineId(int id);
    }
}