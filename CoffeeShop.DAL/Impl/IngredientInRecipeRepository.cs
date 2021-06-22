using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class IngredientInRecipeRepository 
        : GenericRepository<IngredientsInRecipeEntity, int>, IIngredientInRecipeRepository
    {
        public IngredientInRecipeRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}