using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Reflection.Emit;
using CoffeeShop.DAL.Entities;

namespace CoffeeShop.DAL
{
    public class CoffeeShopDBContext : DbContext
    {
        public CoffeeShopDBContext() : base("name=CoffeeShopDBConnectionString")
        {
            
        }
        
        public DbSet<CoffeeMachineEntity> CoffeeMachine { get; set; }
        public DbSet<RecipeInCoffeeMachineEntity> RecipeInCoffeeMachine { get; set; }
        public DbSet<IngredientEntity> Ingredient { get; set; }
        public DbSet<IngredientInRecipeEntity> IngredientsInRecipe { get; set; }
        public DbSet<IngredientInCoffeeMachineEntity> IngredientsInCoffeeMachine { get; set; }
        public DbSet<RecipeEntity> Recipe { get; set; }
        public DbSet<OrderEntity> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}