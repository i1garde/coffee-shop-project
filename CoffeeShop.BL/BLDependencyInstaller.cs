using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Impl.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.BL
{
    public static class BLDependencyInstaller
    {
        public static IServiceCollection RegisterBL(this IServiceCollection serviceCollection)
                {
                    serviceCollection.AddScoped<ICoffeeMachineService, CoffeeMachineService>();
                    return serviceCollection;
                }
    }
}