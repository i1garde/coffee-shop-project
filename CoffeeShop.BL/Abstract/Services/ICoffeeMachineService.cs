using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface ICoffeeMachineService
    {
        List<CoffeeMachineModel> GetAll();
        TimeSpan GetTimeToRefreshIngredients(int id, DateTime firstDate, DateTime lastDate);
    }
}