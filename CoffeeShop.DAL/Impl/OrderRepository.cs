using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class OrderRepository 
        : GenericRepository<OrderEntity, int>, IOrderRepository
    {
        public OrderRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}