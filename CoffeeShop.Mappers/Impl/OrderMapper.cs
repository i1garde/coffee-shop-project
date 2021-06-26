using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class OrderMapper : IOrderMapper
    {
        private IRecipeMapper _recipeMapper;

        public OrderMapper(IRecipeMapper recipeMapper)
        {
            _recipeMapper = recipeMapper;
        }
        public OrderModel ToModel(OrderEntity entity)
        {
            return new OrderModel
            {
                Id = entity.Id,
                Recipe = _recipeMapper.ToModel(entity.Recipe),
                OrderTime = entity.OrderTime
            };
        }

        public OrderEntity ToEntity(OrderModel model)
        {
            return new OrderEntity
            {
                Id = model.Id,
                Recipe = _recipeMapper.ToEntity(model.Recipe),
                OrderTime = model.OrderTime
            };
        }
    }
}