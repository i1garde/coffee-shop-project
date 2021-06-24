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
        public CoffeeShopDBContext() : base(NpgSqlConfiguration.GetDatabaseConnection(), true)
        {
            Database.SetInitializer(new NullDatabaseInitializer<CoffeeShopDBContext>());
        }
        
        public DbSet<CoffeeMachineEntity> CoffeeMachine { get; set; }
        public DbSet<RecipeInCoffeeMachineEntity> RecipeInCoffeeMachine { get; set; }
        public DbSet<IngredientEntity> Ingredient { get; set; }
        public DbSet<IngredientsInRecipeEntity> IngredientsInRecipe { get; set; }
        public DbSet<IngredientsInCoffeeMachineEntity> IngredientsInCoffeeMachine { get; set; }
        public DbSet<RecipeEntity> Recipe { get; set; }
        public DbSet<OrderEntity> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}