using System.Collections.Generic;
using System.Linq;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class IngredientInCoffeeMachineRepository
        : GenericRepository<IngredientInCoffeeMachineEntity, int>, IIngredientInCoffeeMachineRepository
    {
        public IngredientInCoffeeMachineRepository(CoffeeShopDBContext context) : base(context)
        {
        }
        
        public List<IngredientInCoffeeMachineEntity> GetAllByCoffeeMachineId(int id)
        {
            return _context.Set<IngredientInCoffeeMachineEntity>()
                .Where(c => c.CoffeeMachineId == id).ToList();
        }
    }
}