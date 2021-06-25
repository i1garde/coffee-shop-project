using System.Collections.Generic;
using System.Linq;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Impl
{
    public class IngredientInRecipeRepository 
        : GenericRepository<IngredientInRecipeEntity, int>, IIngredientInRecipeRepository
    {
        public IngredientInRecipeRepository(CoffeeShopDBContext context) : base(context)
        {
        }
        
        public List<IngredientInRecipeEntity> GetAllByRecipeId(int id)
        {
            return _context.Set<IngredientInRecipeEntity>()
                .Where(c => c.RecipeId == id).ToList();
        }
    }
}