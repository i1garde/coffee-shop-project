using System.Collections.Generic;

namespace CoffeeShop.DAL.Entities
{
    public class RecipeEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual List<IngredientInRecipeEntity> RecipeIngredients { get; set; }
    }
}