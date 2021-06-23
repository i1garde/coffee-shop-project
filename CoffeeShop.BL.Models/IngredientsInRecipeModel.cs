namespace CoffeeShop.BL.Models
{
    public class IngredientsInRecipeModel
    {
        public int Id { get; set; }
        public RecipeModel Recipe { get; set; }
        public IngredientModel Ingredient { get; set; }
        public float IngredientAmount { get; set; }
    }
}