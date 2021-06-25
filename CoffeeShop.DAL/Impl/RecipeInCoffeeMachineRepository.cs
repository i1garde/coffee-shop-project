using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        
        public List<RecipeInCoffeeMachineEntity> GetAllByCoffeeMachineId(int id)
        {
            return _context.Set<RecipeInCoffeeMachineEntity>()
                .Where(c => c.CoffeeMachineId == id).ToList();
        }
    }
}