using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface ICoffeeMachineService
    {
        void Add(CoffeeMachineModel coffeeMachineModel);
        List<CoffeeMachineModel> GetAll();
        List<int> GetTimeToRefreshIngredients(CoffeeMachineModel coffeeMachine, DateTime start, DateTime end);
    }
}