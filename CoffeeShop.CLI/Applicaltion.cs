using System;
using System.Collections.Generic;
using CoffeeShop.BL;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL;
using CoffeeShop.DAL.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.CLI
{
    public class Applicaltion
    {
        private readonly ServiceProvider serviceProvider;

        public Applicaltion()
        {
            var services = new ServiceCollection();
            services.RegisterBL();
            services.RegisterDAL();
            serviceProvider = services.BuildServiceProvider();
        }

        public void Run()
        {
            Console.WriteLine("Run-run-run!!!");
            ICoffeeMachineService coffeeMachineService = 
                serviceProvider.GetRequiredService<ICoffeeMachineService>();
            List<CoffeeMachineModel> coffeeMachineModels =
                coffeeMachineService.GetAll();
            Place a;
            foreach (var coffeeMachine in coffeeMachineModels)
            {
                Console.WriteLine($"Name: {coffeeMachine.Name} " +
                                  $"Place: {coffeeMachine.PlaceCoef} " +
                                  $"Popularity: {coffeeMachine.PopularityCoef} ");
            }
        }
    }
}