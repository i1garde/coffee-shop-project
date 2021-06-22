using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class RecipeRepository 
        : GenericRepository<RecipeEntity, int>, IRecipeRepository
    {
        public RecipeRepository(CoffeeShopDBContext context) : base(context)
        {
        }
    }
}