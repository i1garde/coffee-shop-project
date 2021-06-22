using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class CoffeeMachineRepository
        : GenericRepository<CoffeeMachineEntity, int>, ICoffeeMachineRepository
    {
        public CoffeeMachineRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}