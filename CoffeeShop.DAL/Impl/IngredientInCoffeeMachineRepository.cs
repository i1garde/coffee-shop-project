using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class IngredientInCoffeeMachineRepository
        : GenericRepository<IngredientsInCoffeeMachineEntity, int>, IIngredientInCoffeeMachineRepository
    {
        public IngredientInCoffeeMachineRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}