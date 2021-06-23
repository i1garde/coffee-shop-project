using System.Collections.Generic;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class RecipeInCoffeeMachineRepository
        : GenericRepository<RecipeInCoffeeMachineEntity, int>, IRecipeInCoffeeMachineRepository
    {
        public RecipeInCoffeeMachineRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}