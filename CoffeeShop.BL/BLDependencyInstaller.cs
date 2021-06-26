using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Impl.Services;
using CoffeeShop.Mappers.Impl;
using CoffeeShop.Mappers.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.BL
{
    public static class BLDependencyInstaller
    {
        public static IServiceCollection RegisterBL(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICoffeeMachineService, CoffeeMachineService>();
            serviceCollection.AddScoped<IIngredientInCoffeeMachineService, IngredientInCoffeeMachineService>();
            serviceCollection.AddScoped<IIngredientInRecipeService, IngredientInRecipeService>();
            serviceCollection.AddScoped<IIngredientService, IngredientService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            serviceCollection.AddScoped<IRecipeInCoffeeMachineService, RecipeInCoffeeMachineService>();
            
            serviceCollection.AddScoped<ICoffeeMachineMapper, CoffeeMachineMapper>();
            serviceCollection.AddScoped<IIngredientInCoffeeMachineMapper, IngredientInCoffeeMachineMapper>();
            serviceCollection.AddScoped<IIngredientInRecipeMapper, IngredientInRecipeMapper>();
            serviceCollection.AddScoped<IIngredientMapper, IngredientMapper>();
            serviceCollection.AddScoped<IOrderMapper, OrderMapper>();
            serviceCollection.AddScoped<IRecipeInCoffeeMachineMapper, RecipeInCoffeeMachineMapper>();
            serviceCollection.AddScoped<IRecipeMapper, RecipeMapper>();
            return serviceCollection;
        }
    }
}