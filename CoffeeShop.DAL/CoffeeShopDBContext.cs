using System.Data.Entity;

namespace CoffeeShop.DAL
{
    public class CoffeeShopDBContext : DbContext
    {
        public CoffeeShopDBContext() : base("CoffeeShopDB") { }
        
        public DbSet<CoffeeMachineEntity> CoffeeMachine { get; set; }
        public DbSet<IngredientEntity> Ingredient { get; set; }
        public DbSet<IngredientsInRecipeEntity> IngredientsInRecipe { get; set; }
        public DbSet<IngredientsInCoffeeMachineEntity> IngredientsInCoffeeMachine { get; set; }
        public DbSet<RecipeEntity> Recipe { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
    }
}