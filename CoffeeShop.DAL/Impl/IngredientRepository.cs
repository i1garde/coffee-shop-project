using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class IngredientRepository 
        : GenericRepository<IngredientEntity, int>, IIngredientRepository
    {
        public IngredientRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}