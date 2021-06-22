namespace CoffeeShop.BL.Models
{
    public class IngredientsInRecipeModel
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public RecipeModel Recipe { get; set; }
        public int IngredientId { get; set; }
        public IngredientModel Ingredient { get; set; }
        public float IngredientAmount { get; set; }
    }
}