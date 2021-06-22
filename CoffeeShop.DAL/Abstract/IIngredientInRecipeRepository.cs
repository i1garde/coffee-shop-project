using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL.Abstract
{
    public interface IIngredientInRecipeRepository 
        : IGenericRepository<IngredientsInRecipeEntity, int>
    {
        
    }
}