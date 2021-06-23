using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.DAL
{
    public static class DALDependencyInstaller
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<CoffeeShopDBContext>();
            serviceCollection.AddScoped<ICoffeeMachineRepository, CoffeeMachineRepository>();
            serviceCollection.AddScoped<IIngredientInCoffeeMachineRepository, IngredientInCoffeeMachineRepository>();
            serviceCollection.AddScoped<IIngredientInRecipeRepository, IngredientInRecipeRepository>();
            serviceCollection.AddScoped<IIngredientRepository, IngredientRepository>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddScoped<IRecipeInCoffeeMachineRepository, RecipeInCoffeeMachineRepository>();
            serviceCollection.AddScoped<IRecipeRepository, RecipeRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}