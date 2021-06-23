using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class OrderMapper
    {
        public static OrderEntity toEntity(this OrderModel model)
        {
            return new OrderEntity
            {
                Id = model.Id,
                Recipe = model.Recipe.toEntity(),
                OrderTime = model.OrderTime
            };
        }
    
        public static OrderModel toModel(this OrderEntity entity)
        {
            return new OrderModel
            {
                Id = entity.Id,
                Recipe = entity.Recipe.toModel(),
                OrderTime = entity.OrderTime
            };
        }
    }
}