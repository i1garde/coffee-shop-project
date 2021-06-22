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
                RecipeId = model.RecipeId,
                Recipe = model.Recipe.toEntity(),
            };
        }
    
        public static OrderModel toModel(this OrderEntity entity)
        {
            return new OrderModel
            {
                Id = entity.Id,
                RecipeId = entity.RecipeId,
                Recipe = entity.Recipe.toModel(),
            };
        }
    }
}