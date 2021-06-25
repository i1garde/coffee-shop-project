using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.Mappers.Impl
{
    public class IngredientMapper : IIngredientMapper
    {
        public IngredientModel ToModel(IngredientEntity entity)
        {
            return new IngredientModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
        public IngredientEntity ToEntity(IngredientModel model)
        {
            return new IngredientEntity
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}