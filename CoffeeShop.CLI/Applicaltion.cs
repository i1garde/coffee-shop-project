using System;
using System.Collections.Generic;
using System.Transactions.Configuration;
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

        public void ShowMenu()
        {
            Console.WriteLine("Choose one option:");
            Console.WriteLine("1) Ingredients usage");
        }

        public void AddCoffeeMachine(CoffeeMachineModel coffeeMachineModel)
        {
            ICoffeeMachineService coffeeMachineService = 
                serviceProvider.GetRequiredService<ICoffeeMachineService>();
            coffeeMachineService.Add(coffeeMachineModel);
        }

        public CoffeeMachineModel ChooseCoffeeMachine()
        {
            ICoffeeMachineService coffeeMachineService = 
                serviceProvider.GetRequiredService<ICoffeeMachineService>();
            List<CoffeeMachineModel> coffeeMachineModels =
                coffeeMachineService.GetAll();
            int i = 0;
            
            foreach (var coffeeMachine in coffeeMachineModels)
            {
                i++;
                Console.WriteLine($"{i} - Name: {coffeeMachine.Name}");
            }
            Console.Write("Choose Coffee Machine: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            
            return coffeeMachineModels[num - 1];
        }

        public void IngredientUsage()
        {
            ICoffeeMachineService coffeeMachineService = 
                serviceProvider.GetRequiredService<ICoffeeMachineService>();
            List<int> result = 
                coffeeMachineService.GetTimeToRefreshIngredients
                    (ChooseCoffeeMachine(), Convert.ToDateTime("15.04.2002"), Convert.ToDateTime("21.04.2002"));
        }
    }
}