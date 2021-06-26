namespace CoffeeShop.DAL.Entities
{
    public class IngredientInRecipeEntity : BaseEntity<int>
    {
        public int RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
        public int IngredientId { get; set; }
        public IngredientEntity Ingredient { get; set; }
        public float IngredientAmount { get; set; }
    }
}