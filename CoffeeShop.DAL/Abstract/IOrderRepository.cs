using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface IOrderRepository : IGenericRepository<OrderEntity, int>
    {
        
    }
}