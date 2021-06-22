using System.Collections.Generic;

namespace CoffeeShop.BL.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IngredientsInRecipeModel> RecipeIngredients { get; set; }
    }
}