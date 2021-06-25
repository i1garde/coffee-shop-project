using System.Collections.Generic;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface IIngredientInCoffeeMachineRepository 
        : IGenericRepository<IngredientInCoffeeMachineEntity, int>
    {
        List<IngredientInCoffeeMachineEntity> GetAllByCoffeeMachineId(int id);
    }
}