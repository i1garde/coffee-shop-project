using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface ICoffeeMachineRepository : IGenericRepository<CoffeeMachineEntity, int>
    {
        
    }
}