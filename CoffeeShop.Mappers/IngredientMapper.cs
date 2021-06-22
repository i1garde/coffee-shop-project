using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.Mappers
{
    public static class IngredientMapper
    {
        public static IngredientEntity toEntity(this IngredientModel model)
        {
            return new IngredientEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static IngredientModel toModel(this IngredientEntity entity)
        {
            return new IngredientModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}